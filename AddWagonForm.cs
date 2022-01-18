using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsOrdering
{
    public partial class AddWagonForm : Form
    {
        private RailwayEntities _railwayEntities;
        private EMPLOYEE _currentEmployee;

        public AddWagonForm(RailwayEntities railwayEntities, EMPLOYEE currentEmployee)
        {
            InitializeComponent();

            _railwayEntities = railwayEntities;
            _currentEmployee = currentEmployee;
        }

        private void addWagonButton_Click(object sender, EventArgs e)
        {
            WAGON newWagon = new WAGON
            {
                is_locomotive = wagonTypeComboBox.SelectedIndex == 1,
                wagon_number = int.Parse(wagonNumberTextBox.Text),
                weight = int.Parse(weightTextBox.Text),
                volume = wagonTypeComboBox.SelectedIndex == 0 ? (int?)int.Parse(volumeTextBox.Text) : null,
                max_load = int.Parse(maxLoadTextBox.Text),
                station_id = _currentEmployee.station_id
            };
            _railwayEntities.WAGONS.Add(newWagon);
            _railwayEntities.SaveChanges();
            Program.ShowMessage("Вагон додано");
            Close();
        }

        private void AddWagonForm_Load(object sender, EventArgs e)
        {
        }
    }
}
