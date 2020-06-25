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
    public partial class ShopRequestsForm : Form
    {
        public ShopRequestsForm()
        {
            InitializeComponent();
        }

        private void ShopRequestsForm_Load(object sender, EventArgs e)
        {
           ConnectionHandler.HandleConnection(this, () =>
            {
               this.productViewTableAdapter.Fill(this.milkWorkDataSet.ProductView);
                this.shopViewTableAdapter.Fill(this.milkWorkDataSet.ShopView);
                this.shopRequestViewTableAdapter.Fill(this.milkWorkDataSet.ShopRequestView);
            });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            shopRequestViewBindingSource.AddNew();
            shopRequestGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (shopRequestViewBindingSource.Count != 0)
            {
                shopRequestGroupBox.Enabled = true;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (shopRequestViewBindingSource.Count == 0)
                return;

            shopRequestViewBindingSource.RemoveCurrent();
            shopRequestViewTableAdapter.Update(milkWorkDataSet.ShopRequestView);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                (shopRequestViewBindingSource.Current as DataRowView)["Date_of_request"] = date_of_requestDateTimePicker.Value;
                shopRequestViewBindingSource.EndEdit();
                shopRequestViewTableAdapter.Update(milkWorkDataSet.ShopRequestView);
                shopRequestViewTableAdapter.Fill(milkWorkDataSet.ShopRequestView);
                shopRequestGroupBox.Enabled = false;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            shopRequestViewBindingSource.CancelEdit();
            shopRequestViewTableAdapter.Update(milkWorkDataSet.ShopRequestView);
            shopRequestViewTableAdapter.Fill(milkWorkDataSet.ShopRequestView);
        }

        private void shopRequestsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (shopRequestViewBindingSource.Count == 0 || shopRequestViewBindingSource.Current == null)
                return;

            int? idShopRequest = (shopRequestViewBindingSource.Current as DataRowView)["Id_shop_request"] as int?;

            if (idShopRequest != null)
            {
                requestStructViewTableAdapter.FillByShopRequest(milkWorkDataSet.RequestStructView, idShopRequest.Value);
            }
        }

        private void addStructButton_Click(object sender, EventArgs e)
        {
            requestStructViewBindingSource.AddNew();
            shopRequestStructGroupBox.Enabled = true;
        }

        private void editStructButton_Click(object sender, EventArgs e)
        {
            if (requestStructViewBindingSource.Count == 0)
                return;

            shopRequestStructGroupBox.Enabled = true;
        }

        private void removeStructButton_Click(object sender, EventArgs e)
        {
            if (requestStructViewBindingSource.Count == 0)
                return;

            requestStructViewBindingSource.RemoveCurrent();
            requestStructViewTableAdapter.Update(milkWorkDataSet.RequestStructView);
        }

        private void saveRequestButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                int idShopRequest = (int)(shopRequestViewBindingSource.Current as DataRowView)["Id_shop_request"];
                (requestStructViewBindingSource.Current as DataRowView)["Id_shop_request"] = idShopRequest;
                requestStructViewBindingSource.EndEdit();
                requestStructViewTableAdapter.Update(milkWorkDataSet.RequestStructView);
                requestStructViewTableAdapter.FillByShopRequest(milkWorkDataSet.RequestStructView, idShopRequest);

                shopRequestStructGroupBox.Enabled = false;
            });
        }
       
   

        private void cancelRequestButton_Click(object sender, EventArgs e)
        {
            requestStructViewBindingSource.CancelEdit();

            shopRequestStructGroupBox.Enabled = false;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            new ShopRequestReporter().Report(milkWorkDataSet.ShopRequestView);
        }
    }
}
