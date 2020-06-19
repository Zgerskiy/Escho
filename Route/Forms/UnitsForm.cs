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
    public partial class UnitsForm : Form
    {
        public UnitsForm()
        {
            InitializeComponent();
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, ()=> this.unitTableAdapter.Fill(this.milkWorkDataSet.Unit));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            unitBindingSource.AddNew();
            unitGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, unitBindingSource, () =>
            {
                unitGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, unitBindingSource, () =>
            {
                unitBindingSource.RemoveCurrent();
                unitTableAdapter.Update(milkWorkDataSet.Unit);
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            unitBindingSource.CancelEdit();
            unitGroupBox.Enabled = false;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                unitBindingSource.EndEdit();
                unitTableAdapter.Fill(milkWorkDataSet.Unit);
                unitGroupBox.Enabled = false;
            });
        }
    }
}
