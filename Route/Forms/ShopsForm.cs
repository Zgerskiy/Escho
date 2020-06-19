using DevExpress.Map;
using DevExpress.XtraMap;
using Route.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route
{
    public partial class ShopsForm : Form
    {
        public CoordPoint ShopLocation { get; private set; }

        public ShopsForm()
        {
            InitializeComponent();
        }

        private void ShopsForm_Load(object sender, EventArgs e)
        {
            ConnectionHandler.HandleConnection(this, () =>
            {
                this.shopViewTableAdapter.Fill(this.milkWorkDataSet.ShopView); 
               
                this.regionTableAdapter.Fill(this.milkWorkDataSet.Region);
            });
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            shopViewBindingSource.AddNew();

            milkWorkDataSet.Area.Clear();
            milkWorkDataSet.LocalityView.Clear();
            milkWorkDataSet.Street.Clear();

            shopInfoGroupBox.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, shopViewBindingSource, () =>
            {
                shopInfoGroupBox.Enabled = true;
            });
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, shopViewBindingSource, () =>
            {
                shopViewBindingSource.RemoveCurrent();
                shopViewTableAdapter.Update(milkWorkDataSet.ShopView);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                if (ShopLocation is null)
                {
                    MessageBox.Show(this, "Необходимо указать месторасположение магазина", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                (shopViewBindingSource.Current as DataRowView)["Shop_x_coord"] = ShopLocation.GetX();
                (shopViewBindingSource.Current as DataRowView)["Shop_y_coord"] = ShopLocation.GetY();
                shopViewBindingSource.EndEdit();
                shopViewTableAdapter.Update(milkWorkDataSet.ShopView);
                shopViewTableAdapter.Fill(milkWorkDataSet.ShopView);
                shopInfoGroupBox.Enabled = false;

                ShopLocation = null;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            shopViewBindingSource.CancelEdit();
            shopInfoGroupBox.Enabled = false;
        }

        private CoordPoint GetGeoPointOfCursor()
        {
            var point = mapControl1.PointToClient(Cursor.Position);

            return mapControl1.ScreenPointToCoordPoint(point);
        }

        private void mapControl1_DoubleClick(object sender, EventArgs e)
        {
            CreatePushPin();
        }

        private void CreatePushPin()
        {
            ClearPushPins();

            var p = GetGeoPointOfCursor();

            var pushPin = new MapPushpin() { Location = p, Text = "Здесь", ToolTipPattern = "Месторасположение магазина" };

            mapItemStorage1.Items.Add(pushPin);

            ShopLocation = p;
        }

        private void ClearPushPins()
        {
            mapItemStorage1.Items.Clear();
        }

        private void shopsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (shopViewBindingSource.Count == 0)
                return;

            ClearPushPins();
            ShopLocation = null;

            double? x = (double?)(shopViewBindingSource.Current as DataRowView)["Shop_x_coord"];
            double? y = (double?)(shopViewBindingSource.Current as DataRowView)["Shop_y_coord"];

            if (x.HasValue && y.HasValue)
            {
                ShopLocation = new GeoPoint(y.Value, x.Value);
                mapItemStorage1.Items.Add(new MapPushpin() { Location = ShopLocation, Text = "Здесь", ToolTipPattern = "Месторасположение магазина" });
                mapControl1.Zoom(4);
                mapControl1.CenterPoint = ShopLocation;
            }

            int? idRegion = (int?)(shopViewBindingSource.Current as DataRowView)["Id_region"];
            if (idRegion.HasValue)
            {
                areaTableAdapter.FillByRegion(milkWorkDataSet.Area, idRegion.Value);
            }

            int? idArea = (int?)(shopViewBindingSource.Current as DataRowView)["Id_area"];
            if(idArea.HasValue)
            {
                localityViewTableAdapter.FillByArea(milkWorkDataSet.LocalityView, idArea.Value);
            }

            int? idLocality = (int?)(shopViewBindingSource.Current as DataRowView)["Id_locality"];
            if(idLocality.HasValue)
            {
                streetTableAdapter.FillByLocality(milkWorkDataSet.Street, idLocality.Value);
            }
        }

        private void regionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idRegion = (int?)regionComboBox.SelectedValue;

            if (idRegion.HasValue)
            {
                areaTableAdapter.FillByRegion(milkWorkDataSet.Area, idRegion.Value);

                areaComboBox.SelectedIndex = -1;
                LocalityComboBox.SelectedIndex = -1;
                streetComboBox.SelectedIndex = -1;

                milkWorkDataSet.LocalityView.Clear();
                milkWorkDataSet.Street.Clear();
            }
        }

        private void areaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idArea = (int?)areaComboBox.SelectedValue;

            if (idArea.HasValue)
            {
                localityViewTableAdapter.FillByArea(milkWorkDataSet.LocalityView, idArea.Value);

                LocalityComboBox.SelectedIndex = -1;
                streetComboBox.SelectedIndex = -1;

                milkWorkDataSet.Street.Clear();
            }
        }

        private void LocalityComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idLocality = (int?)LocalityComboBox.SelectedValue;

            if (idLocality.HasValue)
            {
                streetTableAdapter.FillByLocality(milkWorkDataSet.Street, idLocality.Value);
               
                streetComboBox.SelectedIndex = -1;
            }
        }
    }
}
