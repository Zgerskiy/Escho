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
    public partial class LocalityTypesForm : Form
    {
        public LocalityTypesForm()
        {
            InitializeComponent();
        }

        private void LocalityTypesForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () => this.locality_typeTableAdapter.Fill(this.milkWorkDataSet.Locality_type));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            localitytypeBindingSource.AddNew();
            localityTypeGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, localitytypeBindingSource, () =>
            {
                localityTypeGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, localitytypeBindingSource, () =>
            {
                localitytypeBindingSource.RemoveCurrent();
                locality_typeTableAdapter.Update(milkWorkDataSet.Locality_type);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                localitytypeBindingSource.EndEdit();
                locality_typeTableAdapter.Update(milkWorkDataSet.Locality_type);
                localityTypeGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            localitytypeBindingSource.CancelEdit();
            localityTypeGroupBox.Enabled = false;
        }
    }
}
