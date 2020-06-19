using DevExpress.Map.Native;
using DevExpress.XtraMap;
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
using static Route.MilkWorkDataSet;

namespace Route
{
    public partial class RouteForm : Form
    {
        public RouteForm()
        {
            InitializeComponent();
        }

       

        private void ProductsForm_Load(object sender, EventArgs e)
        {            
            ConnectionHandler.HandleConnection(this, () =>
            {
                this.routeTableAdapter.Fill(this.milkWorkDataSet.Route);
                this.shopViewTableAdapter.Fill(this.milkWorkDataSet.ShopView);
                this.carViewTableAdapter.Fill(this.milkWorkDataSet.CarView);
                this.carViewTableAdapter.Fill(this.milkWorkDataSet.CarView);
            });

            bingRouteDataProvider1.LayerItemsGenerating += BingRouteDataProvider1_LayerItemsGenerating;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            routeBindingSource.AddNew();
            routeGroupBox.Enabled = true;
            routeStructGroupBox.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, routeBindingSource, () =>
            {
                routeGroupBox.Enabled = true;
            });
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            BSHandler.Handle(this, routeBindingSource, () =>
            {
                routeBindingSource.RemoveCurrent();
                routeTableAdapter.Update(milkWorkDataSet.Route);
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddingHandler.Handle(this, () =>
            {
                (routeBindingSource.Current as DataRowView)["Route_date"] = route_dateDateTimePicker.Value;
                routeBindingSource.EndEdit();
                routeTableAdapter.Update(milkWorkDataSet.Route);
                routeGroupBox.Enabled = false;
                routeStructGroupBox.Enabled = true;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            routeBindingSource.CancelEdit();
            routeGroupBox.Enabled = false;
            routeStructGroupBox.Enabled = true;
        }                  

        private void BingRouteDataProvider1_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            if (e.Cancelled || (e.Error != null)) return;

            foreach (MapItem item in e.Items)
            {                
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null)
                {
                    polyline.Stroke = Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
            
            mapControl1.ZoomToFit(e.Items, 0.4);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (routeBindingSource.Current == null || routeBindingSource.Count == 0)
                return;

            int? idRoute = (int?)(routeBindingSource.Current as DataRowView)["Id_route"];

            if (idRoute.HasValue)
            {
                FillRouteStruct(idRoute.Value);
                BuildRoute();
            }
        }

        private void removePointButton_Click(object sender, EventArgs e)
        {

        }

        private void addPointButton_Click_1(object sender, EventArgs e)
        {
            if (routeBindingSource.Current == null || routeBindingSource.Count == 0)
                return;

            int id_route = (int)(routeBindingSource.Current as DataRowView)["id_route"];
            route_structViewTableAdapter.InsertQuery(1, (int)shopComboBox.SelectedValue, id_route);
            FillRouteStruct(id_route);
            BuildRoute();
        }

        private void FillRouteStruct(int id_route)
        {
            route_structViewTableAdapter.FillByRoute(milkWorkDataSet.Route_structView, id_route);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuildRoute();
        }

        private void BuildRoute()
        {
            informationLayer1.Data.Items.Clear();

            List<RouteWaypoint> waypoints = new List<RouteWaypoint>();

            foreach (Route_structViewRow row in milkWorkDataSet.Route_structView.Rows)
            {
                string shopName = row.Shop_name;
                double x = row.Shop_x_coord, y = row.Shop_y_coord;
                waypoints.Add(new RouteWaypoint(shopName, new GeoPoint(y, x)));
            }

            bingRouteDataProvider1.CalculateRoute(waypoints);
        }

        private void removePointButton_Click_1(object sender, EventArgs e)
        {
            if (routestructViewBindingSource.Count != 0)
            {
                routestructViewBindingSource.RemoveCurrent();
                route_structViewTableAdapter.Update(milkWorkDataSet.Route_structView);
                BuildRoute();
            }
        }
    }
}
