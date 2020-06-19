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
    public partial class ModelsForm : Form
    {
        public ModelsForm()
        {
            InitializeComponent();
        }

        private void ModelsForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {
                this.modelTableAdapter.Fill(this.milkWorkDataSet.Model);
                this.markTableAdapter.Fill(this.milkWorkDataSet.Mark);
            });

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            modelBindingSource.AddNew();
            modelGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, modelBindingSource, () =>
            {
                modelGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, modelBindingSource, () =>
            {
                modelBindingSource.RemoveCurrent();
                modelTableAdapter.Update(milkWorkDataSet.Model);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                modelBindingSource.EndEdit();
                modelTableAdapter.Update(milkWorkDataSet.Model);
                modelGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            modelBindingSource.CancelEdit();
            modelGroupBox.Enabled = false;
        }
    }
}
