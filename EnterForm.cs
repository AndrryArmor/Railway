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
    public partial class EnterForm : Form
    {
        private MainForm _mainForm;
        private RailwayEntities _railwayEntities;

        public EnterForm()
        {
            InitializeComponent();
            _railwayEntities = new RailwayEntities();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedIndex == -1)
                return;

            if (_mainForm == null)
                _mainForm = new MainForm(this, _railwayEntities);

            _mainForm.CurrentEmployee = _railwayEntities.EMPLOYEES.Find((int)accountComboBox.SelectedValue);
            _mainForm.Show();
            Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.ShowMessage("Справді завершити програму?", true) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            stationComboBox.ValueMember = "station_id";
            stationComboBox.DisplayMember = "station_name";
            stationComboBox.DataSource = _railwayEntities.STATIONS
                .Where(station => station.has_depo)
                .AsNoTracking().ToList();
            stationComboBox.SelectedIndex = -1;
        }

        private void stationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stationComboBox.SelectedIndex == -1)
                return;
            
            accountComboBox.ValueMember = "EmployeeIDNumber";
            accountComboBox.DisplayMember = "Name";
            accountComboBox.DataSource = _railwayEntities.EMPLOYEES.AsNoTracking()
                .Where(employee => employee.station_id == (int)stationComboBox.SelectedValue
                                   && employee.position_id != 4)
                .Select(employee => new
                {
                    EmployeeIDNumber = employee.employee_id_number,
                    Name = employee.first_name + " " + employee.last_name
                }).ToList();
            accountComboBox.SelectedIndex = -1;
        }
    }
}
