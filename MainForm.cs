using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GoodsOrdering
{
    public partial class MainForm : Form
    {
        private Form _parentForm;
        private EMPLOYEE _currentEmployee;
        private RailwayEntities _railwayEntities;
        private List<STATION> _stations;
        private List<STATIONS_CONNECTIONS> _stationConnections;

        public MainForm(Form parentForm, RailwayEntities railwayEntities)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _railwayEntities = railwayEntities;
            _stationConnections = _railwayEntities.STATIONS_CONNECTIONS.ToList();
            _stations = _railwayEntities.STATIONS.ToList();
        }

        public EMPLOYEE CurrentEmployee 
        {
            get => _currentEmployee;
            set
            {
                _currentEmployee = value;
                if (_currentEmployee != null)
                    UpdateAllInfo();
            }
        }

        void UpdateAllInfo()
        {
            List<ORDER> orders = _railwayEntities.ORDERS
                .Include(order => order.STATION)
                .Include(order => order.STATION1)
                .Include(order => order.CLIENT)
                .Where(order => CurrentEmployee.position_id == 1 || order.departure_station_id == _currentEmployee.station_id)
                .ToList();
            List<WAGON> wagons = _railwayEntities.WAGONS
                .Where(wagon => CurrentEmployee.position_id == 1 || wagon.station_id == _currentEmployee.station_id)
                .ToList();
            List<REPAIR> repairs = _railwayEntities.REPAIRS
                .Where(repair => CurrentEmployee.position_id == 1 || repair.WAGON.station_id == _currentEmployee.station_id)
                .ToList();
            List<EMPLOYEE> employees = _railwayEntities.EMPLOYEES
                .Where(employee => CurrentEmployee.position_id == 1 || employee.station_id == _currentEmployee.station_id)
                .ToList();

            //Очистка таблиць
            ordersDataGridView.Rows.Clear();
            wagonsDataGridView.Rows.Clear();
            repairsDataGridView.Rows.Clear();
            employeesDataGridView.Rows.Clear();

            // Замовлення
            foreach (var order in orders)
            {
                int id = order.order_id;
                string description = order.description;
                string customer = order.CLIENT.company_name == null
                    ? order.CLIENT.first_name + " " + order.CLIENT.last_name
                    : order.CLIENT.company_name;
                int weight = order.weight;
                int volume = order.volume;
                string departure_station = order.STATION.station_name;
                string arrival_station = order.STATION1.station_name;
                bool status = order.is_fulfilled;
                DateTime creationDate = order.creation_date;
                DateTime? executionDate = order.execution_date;

                ordersDataGridView.Rows.Add(id, description, customer, weight, volume, departure_station,
                                            arrival_station, status, creationDate, executionDate);
            }

            // Вагони
            foreach (var wagon in wagons)
            {
                int number = wagon.wagon_number;
                string station = wagon.STATION.station_name;
                bool isLocomotive = wagon.is_locomotive;

                wagonsDataGridView.Rows.Add(number, station, isLocomotive);
            }

            //  Ремонти
            foreach (var repair in repairs)
            {
                int id = repair.repair_id;
                string station = repair.STATION.station_name;
                int wagon_number = repair.wagon_number;
                bool isLocomotive = repair.WAGON.is_locomotive;
                DateTime date = repair.repair_date; 
                    
                repairsDataGridView.Rows.Add(id, station, wagon_number, isLocomotive, date);
            }

            // Працівники
            foreach (var employee in employees)
            {
                int idNumber = employee.employee_id_number;
                string first_name = employee.first_name;
                string last_name = employee.last_name;
                DateTime birthDate = employee.birth_date;
                string telephoneNumber = employee.telephone_number;
                string position = employee.POSITION.position_name;
                string station = employee.STATION.station_name;
                DateTime appointmentDate = employee.appointment_date;
                string employerName = employee.EMPLOYEE1?.first_name + " " + employee.EMPLOYEE1?.last_name;
                    
                employeesDataGridView.Rows.Add(idNumber, first_name, last_name, birthDate, telephoneNumber, position, station, appointmentDate, employerName);
            }

            //Статус користувача
            currentUserIDNumberTextBox.Text = _currentEmployee.employee_id_number.ToString();
            currentUserSurnameTextBox.Text = _currentEmployee.last_name;
            currentUserNameTextBox.Text = _currentEmployee.first_name;
            currentUserBirthDateTextBox.Text = _currentEmployee.birth_date.ToShortDateString();
            currentUserTelephoneNumberTextBox.Text = _currentEmployee.telephone_number;
            currentUserStationTextBox.Text = _currentEmployee.STATION.station_name;
            currentUserPositionTextBox.Text = _currentEmployee.POSITION.position_name;
            currentUserAppointmentDateTextBox.Text = _currentEmployee.appointment_date.ToShortDateString();
            currentUserEmployerTextBox.Text = _currentEmployee.EMPLOYEE1?.first_name + " " + _currentEmployee.EMPLOYEE1?.last_name;

            // Оновлення сторінки статистики
            UpdateStatisticsPage(_currentEmployee.station_id, beginDateDateTimePicker.Value, endDateDateTimePicker.Value);
        }     
        
        int CountDistance(STATION departureStation, STATION arrivalStation)
        {
            List<StationClass> stationsStructures = new List<StationClass>(_stations.Select(station => new StationClass(station)));
            StationClass startStation = stationsStructures.Find(station => station.Station.station_id == departureStation.station_id);
            startStation.MinimalDistance = 0;

            for (int i = 0; i < stationsStructures.Count; i++)
            {
                // Пошук станції з мінімальною поточною відстанню
                StationClass currentStation = stationsStructures.First();
                int minimalDistance = int.MaxValue;
                foreach (var station in stationsStructures)
                {
                    if (!station.IsVisited && station.MinimalDistance < minimalDistance)
                    {
                        minimalDistance = station.MinimalDistance;
                        currentStation = station;
                    }
                }

                // Список пов'язаних з поточною станцією станцій
                List<STATIONS_CONNECTIONS> connections = _stationConnections
                    .Where(stationConnection => stationConnection.first_station_id == currentStation.Station.station_id
                                                || stationConnection.second_station_id == currentStation.Station.station_id)
                    .ToList();

                // Переобчислення найкоротших відстаней
                foreach (var connection in connections)
                {
                    // Виділяємо зі з'єднання іншу, зв'язану з поточною, станцію
                    StationClass otherStation;
                    if (connection.first_station_id != currentStation.Station.station_id)
                    {
                        otherStation = stationsStructures
                            .Find(station => connection.first_station_id == station.Station.station_id);                        
                    }
                    else
                    {
                        otherStation = stationsStructures
                            .Find(station => connection.second_station_id == station.Station.station_id);
                    }

                    // Перевірка "напряму чи в обхід"
                    otherStation.MinimalDistance = Math.Min(otherStation.MinimalDistance,
                                                            currentStation.MinimalDistance + connection.distance);
                }
                // Позначаємо поточну станцію як відвідану
                currentStation.IsVisited = true;
            }
            //Виводимо знайдену відстань для станції прибуття
            return stationsStructures
                .Find(station => station.Station.station_id == arrivalStation.station_id)
                .MinimalDistance;
        }

        void UpdateStatisticsPage(int stationID, DateTime beginDate, DateTime endDate)
        {
            List<ORDER> validOrders = _railwayEntities.ORDERS
                .AsEnumerable()
                .Where(order => (CurrentEmployee.position_id == 1 || order.departure_station_id == stationID) && order.is_fulfilled == true
                                && beginDate <= order.execution_date && order.execution_date <= endDate)
                .ToList();

            List<CLIENT> clients = _railwayEntities.CLIENTS
                .AsEnumerable()
                .Where(client => client.ORDERS
                    .Any(order => validOrders.Contains(order)))
                .ToList();
            List<WAGON> wagons = _railwayEntities.WAGONS
                .AsEnumerable()
                .Where(wagon => wagon.TRAINS_WAGONS
                    .Any(trainWagon => validOrders.Contains(trainWagon.TRAIN.ORDER)))
                .ToList();

            List<STATION> stations = _railwayEntities.STATIONS
                .ToList();

            // Очистка таблиць
            clientsDataGridView.Rows.Clear();
            stationsDataGridView.Rows.Clear();
            wagonsStatsDataGridView.Rows.Clear();

            // Статистика по замовниках
            foreach (var client in clients)
            {
                int id = client.client_id;
                string name = client.first_name + " " + client.last_name;
                List<ORDER> orders = client.ORDERS
                    .Where(order => validOrders.Contains(order))
                    .ToList();
                int orderCount = orders.Count;
                int weight = orders.Sum(order => order.weight);
                int volume = orders.Sum(order => order.volume);

                clientsDataGridView.Rows.Add(id, name, orderCount, weight, volume);
            }

            // Статистика по станціях
            foreach (var station in stations)
            {
                int id = station.station_id;
                string name = station.station_name;
                int asDepartureStationCount = station.ORDERS
                    .Where(order => validOrders.Contains(order))
                    .Count();
                int asArrivalStationCount = station.ORDERS1
                    .Where(order => validOrders.Contains(order))
                    .Count();

                stationsDataGridView.Rows.Add(id, name, asDepartureStationCount, asArrivalStationCount);
            }

            // Статистика по вагонах
            foreach (var wagon in wagons)
            {
                int number = wagon.wagon_number;
                bool isLocomotive = wagon.is_locomotive;
                List<ORDER> ordersInDateRange = wagon.TRAINS_WAGONS
                    .Select(trainWagon => trainWagon.TRAIN.ORDER)
                    .Where(order => validOrders.Contains(order))
                    .ToList();
                int distance = wagon.TRAINS_WAGONS
                    .Select(trainWagon => trainWagon.TRAIN.ORDER)
                    .Sum(order => CountDistance(order.STATION, order.STATION1));
                int asPartOfTrainsCount = wagon.TRAINS_WAGONS.Count;
                int repairsCount = wagon.REPAIRS
                    .Where(repair => beginDate <= repair.repair_date && repair.repair_date <= endDate)
                    .Count();

                wagonsStatsDataGridView.Rows.Add(number, isLocomotive, distance, asPartOfTrainsCount, repairsCount);
            }
            // Кількісна статистика
            totalOrdersFulfilledTextBox.Text = validOrders
                .Count().ToString();
            totalGoodsWeightTransportedTextBox.Text = validOrders
                .Sum(order => order.weight).ToString();
            totalGoodsVolumeTransportedTextBox.Text = validOrders
                .Sum(order => order.volume).ToString();
        }

        private void OrderingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonToMain_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void beginDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatisticsPage(CurrentEmployee.station_id, beginDateDateTimePicker.Value, endDateDateTimePicker.Value);
        }

        private void endDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatisticsPage(CurrentEmployee.station_id, beginDateDateTimePicker.Value, endDateDateTimePicker.Value);
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            Form addOrderForm = new NewOrderForm(_railwayEntities, CurrentEmployee);
            addOrderForm.ShowDialog();
            UpdateAllInfo();
        }

        private void changeOrderButton_Click(object sender, EventArgs e)
        {
            int orderToChangeID = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
            ORDER orderToChange = _railwayEntities.ORDERS.Find(orderToChangeID);
            Form addOrderForm = new NewOrderForm(_railwayEntities, CurrentEmployee, orderToChange);
            addOrderForm.ShowDialog();
            UpdateAllInfo();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {            
            ORDER orderToMake = _railwayEntities.ORDERS.Find((int)ordersDataGridView.SelectedRows[0].Cells[0].Value);
            if (orderToMake.is_fulfilled)
            {
                Program.ShowMessage("Замовлення уже виконано");
                return;
            }
            Form makeOrderForm = new MakeOrderForm(_railwayEntities, orderToMake);
            makeOrderForm.ShowDialog();
            UpdateAllInfo();
        }

        private void addWagonButton_Click(object sender, EventArgs e)
        {
            Form addWagonForm = new AddWagonForm(_railwayEntities, CurrentEmployee);
            addWagonForm.ShowDialog();
            UpdateAllInfo();
        }

        private void removeWagonButton_Click(object sender, EventArgs e)
        {
            int wagonNumber = (int)wagonsDataGridView.SelectedRows[0].Cells[0].Value;
            _railwayEntities.TRAINS_WAGONS
                .RemoveRange(_railwayEntities.TRAINS_WAGONS
                    .Where(trainWagon => trainWagon.wagon_number == wagonNumber));
            _railwayEntities.REPAIRS
                .RemoveRange(_railwayEntities.REPAIRS
                    .Where(repair => repair.wagon_number == wagonNumber));
            _railwayEntities.WAGONS.Remove(_railwayEntities.WAGONS.Find(wagonNumber));

            _railwayEntities.SaveChanges();
            MessageBox.Show("Вагон списано");
            UpdateAllInfo();
        }

        private void repairButton_Click(object sender, EventArgs e)
        {
            REPAIR newRepair = new REPAIR
            {
                wagon_number = (int)wagonsDataGridView.SelectedRows[0].Cells[0].Value,
                station_id = CurrentEmployee.station_id,
                repair_date = DateTime.Now
            };
            _railwayEntities.REPAIRS.Add(newRepair);
            _railwayEntities.SaveChanges();
            MessageBox.Show("Ремонт виконано");
            UpdateAllInfo();
        }

        private void appointButton_Click(object sender, EventArgs e)
        {
            Form addNewEmployeeForm = new AddNewEmployeeForm(_railwayEntities, CurrentEmployee);
            addNewEmployeeForm.ShowDialog();
            UpdateAllInfo();
        }

        private void changeEmployeeInfoButton_Click(object sender, EventArgs e)
        {
            int employeeToChangeID = (int)employeesDataGridView.SelectedRows[0].Cells[0].Value;
            EMPLOYEE employeeToChange = _railwayEntities.EMPLOYEES.Find(employeeToChangeID);
            Form addNewEmployeeForm = new AddNewEmployeeForm(_railwayEntities, CurrentEmployee, employeeToChange);
            addNewEmployeeForm.ShowDialog();
            UpdateAllInfo();
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            int employeeIDNumber = (int)employeesDataGridView.SelectedRows[0].Cells[0].Value;
            if (employeeIDNumber == CurrentEmployee.employee_id_number)
            {
                Program.ShowMessage("Не можна звільнити самого себе");
                return;
            }
            _railwayEntities.EMPLOYEES.Remove(_railwayEntities.EMPLOYEES.Find(employeeIDNumber));
            _railwayEntities.SaveChanges();
            UpdateAllInfo();
            Program.ShowMessage("Працівника звільнено");
        }

        private class StationClass
        {
            public StationClass(STATION station)
            {
                Station = station;
                MinimalDistance = int.MaxValue;
                IsVisited = false;
            }

            public STATION Station { get; }
            public int MinimalDistance { get; set; }
            public bool IsVisited { get; set; }
        }

    }
}
