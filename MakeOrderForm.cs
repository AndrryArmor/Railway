using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsOrdering
{
    public partial class MakeOrderForm : Form
    {
        private RailwayEntities _railwayEntities;
        private ORDER _orderToMake;
        private List<WAGON> _locomotives;
        private List<WAGON> _wagons;
        private List<EMPLOYEE> _drivers;
        private List<WAGON> _currentTrainWagons;
        private List<WAGON> _allOrderWagons;

        public MakeOrderForm(RailwayEntities railwayEntities, ORDER orderToMake)
        {
            InitializeComponent();

            _railwayEntities = railwayEntities;
            _orderToMake = orderToMake;
            _locomotives = _railwayEntities.WAGONS
                .Where(wagon => wagon.station_id == orderToMake.departure_station_id)
                .Where(wagon => wagon.is_locomotive == true)
                .AsNoTracking()
                .ToList();
            _wagons = _railwayEntities.WAGONS
                .Where(wagon => wagon.station_id == orderToMake.departure_station_id)
                .Where(wagon => wagon.is_locomotive == false)
                .AsNoTracking()
                .ToList();
            _drivers = _railwayEntities.EMPLOYEES
                .Where(employee => employee.position_id == 4 && employee.station_id == orderToMake.departure_station_id)
                .AsNoTracking()
                .ToList();
            _currentTrainWagons = new List<WAGON>();
            _allOrderWagons = new List<WAGON>();
            orderWeightTextBox.Text = _orderToMake.weight.ToString();
            orderVolumeTextBox.Text = _orderToMake.volume.ToString();
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            locomotiveComboBox.ValueMember = "number";
            locomotiveComboBox.DisplayMember = "description";
            locomotiveComboBox.DataSource = _locomotives
                .Select(wagon => new
                {
                    number = wagon.wagon_number,
                    description = wagon.wagon_number.ToString() + " | макс.:" + wagon.max_load + " т."
                }).ToList();
            locomotiveComboBox.SelectedIndex = -1;

            driverComboBox.ValueMember = "employee_id_number";
            driverComboBox.DisplayMember = "name";
            driverComboBox.DataSource = _drivers
                .Select(employee => new
                {
                    employee_id_number = employee.employee_id_number,
                    name = employee.first_name + " " + employee.last_name
                }).ToList();
            driverComboBox.SelectedIndex = -1;

            addWagonComboBox.ValueMember = "number";
            addWagonComboBox.DisplayMember = "description";
            addWagonComboBox.DataSource = _wagons
                .Select(wagon => new
                {
                    number = wagon.wagon_number,
                    description = wagon.wagon_number.ToString() + " | макс.:" + wagon.max_load + " т. | " + wagon.volume + "м3"
                }).ToList();
            locomotiveComboBox.SelectedIndex = -1;
        }

        private void addTrainButton_Click(object sender, EventArgs e)
        {
            WAGON newAddedLocomotive = _locomotives
                .Find(locomotive => locomotive.wagon_number == (int)locomotiveComboBox.SelectedValue);
            EMPLOYEE newAddedDriver = _drivers
                .Find(driver => driver.employee_id_number == (int)driverComboBox.SelectedValue);
            TRAIN newTrain = new TRAIN
            {
                driver_id_number = newAddedDriver.employee_id_number,
                order_id = _orderToMake.order_id
            };
            _railwayEntities.TRAINS.Add(newTrain);
            _railwayEntities.SaveChanges();

            foreach (var wagon in _currentTrainWagons)
            {
                TRAINS_WAGONS trainWagon = new TRAINS_WAGONS
                {
                    train_id = newTrain.train_id,
                    wagon_number = wagon.wagon_number
                };
                _railwayEntities.TRAINS_WAGONS.Add(trainWagon);
            }

            TRAINS_WAGONS trainLocomotive = new TRAINS_WAGONS
            {
                train_id = newTrain.train_id,
                wagon_number = newAddedLocomotive.wagon_number
            };
            _railwayEntities.TRAINS_WAGONS.Add(trainLocomotive);

            int id = newTrain.train_id;
            string driverName = newAddedDriver.first_name + " " + newAddedDriver.last_name;
            int wagonCount = _currentTrainWagons.Count;
            int trainWeight = newAddedLocomotive.weight + _currentTrainWagons.Sum(wagon => wagon.weight + wagon.max_load);
            int trainVolume = _currentTrainWagons.Sum(wagon => (int)wagon.volume);
            trainsDataGridView.Rows.Add(id, driverName, wagonCount, trainWeight, trainVolume);
            _allOrderWagons.AddRange(_currentTrainWagons);
            _allOrderWagons.Add(newAddedLocomotive);

            _locomotives.Remove(newAddedLocomotive);
            _drivers.Remove(newAddedDriver);
            _currentTrainWagons.Clear();
            wagonsDataGridView.Rows.Clear();

            MakeOrderForm_Load(this, EventArgs.Empty);
            int totalWeight = 0;
            int totalVolume = 0;
            foreach (var wagon in _allOrderWagons)
            {
                if (wagon.is_locomotive)
                {
                    totalWeight += wagon.weight;
                }
                else
                {
                    totalWeight += wagon.weight + wagon.max_load;
                    totalVolume += (int)wagon.volume;
                }
            }
            totalWeightTextBox.Text = totalWeight.ToString();
            totalVolumeTextBox.Text = totalVolume.ToString();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            _orderToMake.is_fulfilled = true;
            _orderToMake.execution_date = DateTime.Now;
            Program.ShowMessage("Замовлення виконано");
            _railwayEntities.SaveChanges();
            Close();
        }

        private void addWagonComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WAGON newAddedWagon = _wagons.Find(wagon => wagon.wagon_number == (int)addWagonComboBox.SelectedValue);
            _currentTrainWagons.Add(newAddedWagon);
            _wagons.Remove(newAddedWagon);

            int wagonNumber = newAddedWagon.wagon_number;
            int weight = newAddedWagon.weight;
            int volume = (int)newAddedWagon.volume;
            int maxLoad = newAddedWagon.max_load;
            wagonsDataGridView.Rows.Add(wagonNumber, weight, volume, maxLoad);

            addWagonComboBox.ValueMember = "number";
            addWagonComboBox.DisplayMember = "description";
            addWagonComboBox.DataSource = _wagons
                .Select(wagon => new
                {
                    number = wagon.wagon_number,
                    description = wagon.wagon_number.ToString() + " | макс.:" + wagon.max_load + " т. | " + wagon.volume + "м3"
                }).ToList();

            int trainLoad = _locomotives
                .Find(locomotive => locomotive.wagon_number == (int)locomotiveComboBox.SelectedValue)
                .weight;
            trainLoad += _currentTrainWagons.Sum(wagon => wagon.weight);
            currentTrainLoadTextBox.Text = trainLoad.ToString();
        }
    }
}
