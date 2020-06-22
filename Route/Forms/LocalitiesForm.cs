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
    public partial class LocalitiesForm : Form
    {
        public LocalitiesForm()
        {
            InitializeComponent();
        }

        private void LocalitiesForm_Load(object sender, EventArgs e)
        {
             ConnectionHandler.HandleConnection(this, () =>
             {
                this.locality_typeTableAdapter.Fill(this.milkWorkDataSet.Locality_type);
                this.regionTableAdapter.Fill(this.milkWorkDataSet.Region);
                this.localityTableAdapter.Fill(this.milkWorkDataSet.Locality);
             });
        }

        private void region_nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idRegion = (int?)region_nameComboBox.SelectedValue;

            if (idRegion.HasValue)
            {
                areaTableAdapter.FillByRegion(milkWorkDataSet.Area, idRegion.Value);

                area_nameComboBox.SelectedIndex = -1;               
            }
        }

        private void localitiesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (localityBindingSource.Count == 0 || localityBindingSource.Current == null)
                return;

            int? idRegion = (int?)(localityBindingSource.Current as DataRowView)["Id_region"];
            if (idRegion != null)
            {
                areaTableAdapter.FillByRegion(milkWorkDataSet.Area, idRegion.Value);
            }            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            localityBindingSource.AddNew();
            localityGroupBox.Enabled = true;
            milkWorkDataSet.Area.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, localityBindingSource, () =>
            {
                localityGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, localityBindingSource, () =>
            {
                localityBindingSource.RemoveCurrent();
                localityTableAdapter.Update(milkWorkDataSet.Locality);
                localityTableAdapter.Fill(milkWorkDataSet.Locality);
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            localityBindingSource.CancelEdit();
            localityGroupBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                localityBindingSource.EndEdit();
                localityTableAdapter.Update(milkWorkDataSet.Locality);
                localityTableAdapter.Fill(milkWorkDataSet.Locality);
                localityGroupBox.Enabled = false;
            });
        }
    }
}
