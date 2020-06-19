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
using System.Windows.Forms.VisualStyles;

namespace Route
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (productViewBindingSource.Count != 0)
            {
                productViewBindingSource.RemoveCurrent();
                productViewTableAdapter.Update(milkWorkDataSet.ProductView);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {
               this.unitTableAdapter.Fill(this.milkWorkDataSet.Unit);
               this.product_typeTableAdapter.Fill(this.milkWorkDataSet.Product_type);
               this.productViewTableAdapter.Fill(this.milkWorkDataSet.ProductView);
            });

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            productViewBindingSource.AddNew();
            productGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            productGroupBox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            productViewBindingSource.EndEdit();
            productViewTableAdapter.Update(milkWorkDataSet.ProductView);
            productViewTableAdapter.Fill(milkWorkDataSet.ProductView);
            productGroupBox.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            productViewBindingSource.CancelEdit();
            productGroupBox.Enabled = false;
        }

        private void addProductTypeButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm("Добавление типа продукта", "Введите тип продукта");
            inputForm.ShowDialog();

            if (inputForm.DialogResult == DialogResult.Yes)
            {
                string prodTypeName = inputForm.Value;
                int idProdType = product_typeTableAdapter.Insert(prodTypeName);
                product_typeTableAdapter.Fill(milkWorkDataSet.Product_type);
                id_product_typeComboBox.SelectedValue = idProdType;
            }
        }

        private void addUnitButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm("Добавление единицы измерения", "Введите единицу измерения");
            inputForm.ShowDialog();

            if (inputForm.DialogResult == DialogResult.Yes)
            {
                string unitName = inputForm.Value;
                int idUnit = unitTableAdapter.Insert(unitName);
                unitTableAdapter.Fill(milkWorkDataSet.Unit);
                id_unitComboBox.SelectedValue = idUnit;
            }
        }       
    }
}
