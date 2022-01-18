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
    public partial class AddNewEmployeeForm : Form
    {
        private RailwayEntities _railwayEntities;
        private EMPLOYEE _currentEmployee;
        private EMPLOYEE _employeeToChange;

        public AddNewEmployeeForm(RailwayEntities railwayEntities, EMPLOYEE currentEmployee, EMPLOYEE employeeToChange = null)
        {
            InitializeComponent();

            _railwayEntities = railwayEntities;
            _currentEmployee = currentEmployee;
            _employeeToChange = employeeToChange;
        }
        
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_currentEmployee.position_id >= (int)positionComboBox.SelectedValue)
            {
                Program.ShowMessage("У вас нема прав на призначення працівника з ширшими або такими ж правами" +
                    " (поточна посада: " + _currentEmployee.POSITION.position_name + ")");
                return;
            }
            else if (_currentEmployee.position_id > 1 && (int)stationComboBox.SelectedValue != _currentEmployee.station_id)
            {
                Program.ShowMessage("У вас нема прав на призначення працівника на будь-яку станцію, крім поточної" +
                    " (поточна станція: " + _currentEmployee.STATION.station_name + ")");
                return;
            }

            if (_employeeToChange != null)
            {
                _employeeToChange.employee_id_number = int.Parse(idNumberTextBox.Text);
                _employeeToChange.first_name = firstNameTextBox.Text;
                _employeeToChange.last_name = lastNameTextBox.Text;
                _employeeToChange.birth_date = birthDateDateTimePicker.Value.Date;
                _employeeToChange.telephone_number = telephoneTextBox.Text;
                _employeeToChange.station_id = (int)stationComboBox.SelectedValue;
                _employeeToChange.position_id = (int)positionComboBox.SelectedValue;
                Program.ShowMessage("Працівника змінено");
            }
            else
            {
                EMPLOYEE newEmployee = new EMPLOYEE
                {
                    employee_id_number = int.Parse(idNumberTextBox.Text),
                    first_name = firstNameTextBox.Text,
                    last_name = lastNameTextBox.Text,
                    birth_date = birthDateDateTimePicker.Value.Date,
                    telephone_number = telephoneTextBox.Text,
                    station_id = (int)stationComboBox.SelectedValue,
                    position_id = (int)positionComboBox.SelectedValue,
                    employer_id_number = _currentEmployee.employee_id_number,
                    appointment_date = DateTime.Now
                };
                _railwayEntities.EMPLOYEES.Add(newEmployee);
                Program.ShowMessage("Працівника додано");
            }
            _railwayEntities.SaveChanges();
            Close();
        }

        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {
            stationComboBox.ValueMember = "station_id";
            stationComboBox.DisplayMember = "station_name";
            stationComboBox.DataSource = _railwayEntities.STATIONS
                .Where(station => station.has_depo)
                .AsNoTracking().ToList();
            stationComboBox.SelectedIndex = -1;

            positionComboBox.ValueMember = "position_id";
            positionComboBox.DisplayMember = "position_name";
            positionComboBox.DataSource = _railwayEntities.POSITIONS.AsNoTracking().ToList();
            positionComboBox.SelectedIndex = -1;

            if (_employeeToChange != null)
            {
                Text = "Зміна працівника";
                addEmployeeButton.Text = "Змінити";

                idNumberTextBox.Text = _employeeToChange.employee_id_number.ToString();
                lastNameTextBox.Text = _employeeToChange.last_name;
                firstNameTextBox.Text = _employeeToChange.first_name;
                birthDateDateTimePicker.Value = _employeeToChange.birth_date;
                telephoneTextBox.Text = _employeeToChange.telephone_number;
                stationComboBox.SelectedIndex = _railwayEntities.STATIONS.AsNoTracking().ToList()
                    .FindIndex(station => station.station_id == _employeeToChange.station_id);
                positionComboBox.SelectedIndex = _railwayEntities.POSITIONS.AsNoTracking().ToList()
                    .FindIndex(position => position.position_id == _employeeToChange.position_id);
            }
        }
    }
}
