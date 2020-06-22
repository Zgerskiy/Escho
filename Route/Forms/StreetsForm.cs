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
    public partial class StreetsForm : Form
    {
        public StreetsForm()
        {
            InitializeComponent();
        }

        private void StreetsForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {
                this.locality_typeTableAdapter.Fill(this.milkWorkDataSet.Locality_type);
                this.regionTableAdapter.Fill(this.milkWorkDataSet.Region);
                this.streetTableAdapter.Fill(this.milkWorkDataSet.Street);
            });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            streetBindingSource.AddNew();
            streetGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, streetBindingSource, () =>
            {
                streetGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, streetBindingSource, () =>
            {
                streetBindingSource.RemoveCurrent();
                streetTableAdapter.Update(milkWorkDataSet.Street);
                streetTableAdapter.Fill(milkWorkDataSet.Street);
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            streetBindingSource.CancelEdit();
            streetGroupBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                streetBindingSource.EndEdit();
                streetTableAdapter.Update(milkWorkDataSet.Street);
                streetTableAdapter.Fill(milkWorkDataSet.Street);
                streetGroupBox.Enabled = false;
            });
        }

        private void streetsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (streetBindingSource.Current == null || streetBindingSource.Count == 0)            
                return;  

            int? idRegion = (int?)(streetBindingSource.Current as DataRowView)["Id_region"];
            if (idRegion.HasValue)
            {
                areaTableAdapter.FillByRegion(milkWorkDataSet.Area, idRegion.Value);
            }

            int? idArea = (int?)(streetBindingSource.Current as DataRowView)["Id_area"];
            if (idArea.HasValue)
            {
                localityTableAdapter.FillByArea(milkWorkDataSet.Locality, idArea.Value);
            }           
        }

        private void region_nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idRegion = (int?)region_nameComboBox.SelectedValue;

            if (idRegion.HasValue)
            {
                areaTableAdapter.FillByRegion(milkWorkDataSet.Area, idRegion.Value);

                area_nameComboBox.SelectedIndex = -1;
                locality_nameComboBox.SelectedIndex = -1;

                milkWorkDataSet.Locality.Clear();
            }
        }

        private void area_nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idArea = (int?)area_nameComboBox.SelectedValue;

            if (idArea.HasValue)
            {
                localityTableAdapter.FillByArea(milkWorkDataSet.Locality, idArea.Value);

                locality_nameComboBox.SelectedIndex = -1;
            }
        }
    }
}
