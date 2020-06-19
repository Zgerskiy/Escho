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
    public partial class productTypesForm : Form
    {
        public productTypesForm()
        {
            InitializeComponent();
        }

        private void productTypesForm_Load(object sender, EventArgs e)
        {
          ConnectionHandler.HandleConnection(this, () =>
          this.product_typeTableAdapter.Fill(this.milkWorkDataSet.Product_type));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            prodTypeGroupBox.Enabled = true;
            producttypeBindingSource.AddNew();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, producttypeBindingSource, () =>
            {
                prodTypeGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, producttypeBindingSource, () =>
            {
                producttypeBindingSource.RemoveCurrent();
                product_typeTableAdapter.Update(milkWorkDataSet.Product_type);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                producttypeBindingSource.EndEdit();
                product_typeTableAdapter.Update(milkWorkDataSet.Product_type);
                prodTypeGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            producttypeBindingSource.CancelEdit();
            prodTypeGroupBox.Enabled = false;
        }
    }
}
