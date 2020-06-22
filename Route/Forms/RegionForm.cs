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
    public partial class RegionForm : Form
    {
        public RegionForm()
        {
            InitializeComponent();
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () => this.regionTableAdapter.Fill(this.milkWorkDataSet.Region));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            regionBindingSource.AddNew();
            regionGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, regionBindingSource, () =>
             regionGroupBox.Enabled = true
             );
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, regionBindingSource, () =>
            {
                regionBindingSource.RemoveCurrent();
                regionTableAdapter.Update(milkWorkDataSet.Region);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                regionBindingSource.EndEdit();
                regionTableAdapter.Update(milkWorkDataSet.Region);
                regionGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            regionBindingSource.CancelEdit();
            regionGroupBox.Enabled = false;
        }
    }
}
