using Route.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route.Forms
{
    public partial class CarTypesForm : Form
    {
        public CarTypesForm()
        {
            InitializeComponent();
        }

        private void CarTypesForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {
                this.car_typeTableAdapter.Fill(this.milkWorkDataSet.Car_type);
            });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            car_typeBindingSource.AddNew();
            carTypeGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, car_typeBindingSource, () =>
            {
                carTypeGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, car_typeBindingSource, () =>
            {
                car_typeBindingSource.RemoveCurrent();
                car_typeTableAdapter.Update(milkWorkDataSet.Car_type);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                car_typeBindingSource.EndEdit();
                car_typeTableAdapter.Update(milkWorkDataSet.Car_type);
                carTypeGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            car_typeBindingSource.CancelEdit();
            carTypeGroupBox.Enabled = false;
        }
    }
}
