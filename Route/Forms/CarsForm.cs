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

namespace Route
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {
                this.carViewTableAdapter.Fill(this.milkWorkDataSet.CarView);
                this.markTableAdapter.Fill(this.milkWorkDataSet.Mark);
                this.car_typeTableAdapter.Fill(this.milkWorkDataSet.Car_type);
            });        

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            carViewBindingSource.AddNew();
            carGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, carViewBindingSource, () =>
            {
                carGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, carViewBindingSource, () =>
            {
                carViewBindingSource.RemoveCurrent();
                carViewTableAdapter.Update(milkWorkDataSet.CarView);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                carViewBindingSource.EndEdit();
                carViewTableAdapter.Update(milkWorkDataSet.CarView);
                carViewTableAdapter.Fill(milkWorkDataSet.CarView);
                carGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            carViewBindingSource.CancelEdit();
            carGroupBox.Enabled = false;
        }

        private void mark_nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idMark = (int)mark_nameComboBox.SelectedValue;

            modelTableAdapter.FillByMark(milkWorkDataSet.Model, idMark);
        }
      

        private void carsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (cartypeBindingSource.Count == 0 || carViewBindingSource.Current == null)
                return;

            int? idMark = (carViewBindingSource.Current as DataRowView)["Id_mark"] as int?;

            if (idMark != null)
            {
                modelTableAdapter.FillByMark(milkWorkDataSet.Model, idMark.Value);
            }
        }
    }
}
