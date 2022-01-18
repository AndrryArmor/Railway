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
    public partial class NewOrderForm : Form
    {
        private RailwayEntities _railwayEntities;
        private EMPLOYEE _currentEmployee;
        private ORDER _orderToChange;

        public NewOrderForm(RailwayEntities railwayEntities, EMPLOYEE currentEmployee, ORDER orderToChange = null)
        {
            InitializeComponent();

            _railwayEntities = railwayEntities;
            _currentEmployee = currentEmployee;
            _orderToChange = orderToChange;
        }

        private void newCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customersComboBox.Enabled = false;
            newCustomerPanel.Enabled = true;
        }

        private void existingCustomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customersComboBox.Enabled = true;
            newCustomerPanel.Enabled = false;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if ((int)departureStationComboBox.SelectedValue == (int)arrivalStationComboBox.SelectedValue)
            {
                Program.ShowMessage("Станції відправлення і прибуття не повинні співпадати");
                return;
            }

            int clientID = -1;
            if (newCustomerRadioButton.Checked)
            {
                CLIENT newClient = new CLIENT
                {
                    company_name = companyNameTextBox.Text == "" ? null : companyNameTextBox.Text,
                    first_name = firstNameTextBox.Text,
                    last_name = lastNameTextBox.Text,
                    telephone_number = telephoneNumberTextBox.Text
                };

                _railwayEntities.CLIENTS.Add(newClient);
                _railwayEntities.SaveChanges();
                clientID = newClient.client_id;
            }

            if (_orderToChange != null)
            {
                _orderToChange.description = descriptionTextBox.Text;
                _orderToChange.weight = int.Parse(weightTextBox.Text);
                _orderToChange.volume = int.Parse(volumeTextBox.Text);
                _orderToChange.is_fulfilled = false;
                _orderToChange.client_id = (clientID == -1 ? (int)customersComboBox.SelectedValue : clientID);
                _orderToChange.departure_station_id = (int)departureStationComboBox.SelectedValue;
                _orderToChange.arrival_station_id = (int)arrivalStationComboBox.SelectedValue;
                _orderToChange.creation_date = DateTime.Now;
                Program.ShowMessage("Замовлення змінено");
            }
            else
            {
                ORDER newOrder = new ORDER
                {
                    description = descriptionTextBox.Text,
                    weight = int.Parse(weightTextBox.Text),
                    volume = int.Parse(volumeTextBox.Text),
                    is_fulfilled = false,
                    client_id = (clientID == -1 ? (int)customersComboBox.SelectedValue : clientID),
                    departure_station_id = (int)departureStationComboBox.SelectedValue,
                    arrival_station_id = (int)arrivalStationComboBox.SelectedValue,
                    creation_date = DateTime.Now
                };
                _railwayEntities.ORDERS.Add(newOrder);
                Program.ShowMessage("Замовлення додано");
            }
            _railwayEntities.SaveChanges();
            Close();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            customersComboBox.ValueMember = "client_id";
            customersComboBox.DisplayMember = "client_name";
            customersComboBox.DataSource = _railwayEntities.CLIENTS.AsNoTracking().ToList().Select(client => new
            {
                client_id = client.client_id,
                client_name = client.company_name ?? client.first_name + " " + client.last_name
            }).ToList();
            customersComboBox.SelectedIndex = -1;

            departureStationComboBox.ValueMember = "station_id";
            departureStationComboBox.DisplayMember = "station_name";
            departureStationComboBox.DataSource = _railwayEntities.STATIONS
                .Where(station => station.has_depo)
                .AsNoTracking().ToList();
            departureStationComboBox.SelectedIndex = -1;

            arrivalStationComboBox.ValueMember = "station_id";
            arrivalStationComboBox.DisplayMember = "station_name";
            arrivalStationComboBox.DataSource = _railwayEntities.STATIONS
                .Where(station => station.has_depo)
                .AsNoTracking().ToList();
            arrivalStationComboBox.SelectedIndex = -1;

            if (_orderToChange != null)
            {
                Text = "Зміна замовлення";
                addOrderButton.Text = "Змінити";

                existingCustomeRadioButton.Checked = true;
                customersComboBox.SelectedIndex = _railwayEntities.CLIENTS.AsNoTracking().ToList()
                   .FindIndex(client => client.client_id == _orderToChange.client_id);

                descriptionTextBox.Text = _orderToChange.description.ToString();
                weightTextBox.Text = _orderToChange.weight.ToString();
                volumeTextBox.Text = _orderToChange.volume.ToString();
                departureStationComboBox.SelectedIndex = _railwayEntities.STATIONS
                    .Where(station => station.has_depo)
                    .AsNoTracking().ToList()
                    .FindIndex(station => station.station_id == _orderToChange.departure_station_id);
                arrivalStationComboBox.SelectedIndex = _railwayEntities.STATIONS
                    .Where(station => station.has_depo)
                    .AsNoTracking().ToList()
                    .FindIndex(station => station.station_id == _orderToChange.arrival_station_id);
            }
        }
    }
}
