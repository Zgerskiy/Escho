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
    public partial class MarksForm : Form
    {
        public MarksForm()
        {
            InitializeComponent();
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () => this.markTableAdapter.Fill(this.milkWorkDataSet.Mark));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            markBindingSource.AddNew();
            markGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, markBindingSource, () =>
            {
                markGroupBox.Enabled = false;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, markBindingSource, () =>
            {
                markBindingSource.RemoveCurrent();
                markTableAdapter.Update(milkWorkDataSet.Mark);
                markTableAdapter.Fill(milkWorkDataSet.Mark);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                markBindingSource.EndEdit();
                markTableAdapter.Update(milkWorkDataSet.Mark);
                markGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            markBindingSource.CancelEdit();
            markGroupBox.Enabled = false;
        }
    }
}
