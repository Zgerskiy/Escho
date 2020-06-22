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
    public partial class AreasForm : Form
    {
        public AreasForm()
        {
            InitializeComponent();
        }

        private void AreasForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {  
                this.regionTableAdapter.Fill(this.milkWorkDataSet.Region);            
                this.areaTableAdapter.Fill(this.milkWorkDataSet.Area);
            });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            areaBindingSource.AddNew();
            areaGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, areaBindingSource, () => areaGroupBox.Enabled = true);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, areaBindingSource, () =>
            {
                areaBindingSource.RemoveCurrent();
                areaTableAdapter.Update(milkWorkDataSet.Area);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                areaBindingSource.EndEdit();
                areaTableAdapter.Update(milkWorkDataSet.Area);
                areaTableAdapter.Fill(milkWorkDataSet.Area);
                areaGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            areaBindingSource.CancelEdit();
            areaGroupBox.Enabled = false;
        }
    }
}
