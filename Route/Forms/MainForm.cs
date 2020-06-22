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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            new CarsForm().ShowDialog();
        }

        private void shopsButton_Click(object sender, EventArgs e)
        {
            new ShopsForm().ShowDialog();
        }

        private void routsButton_Click(object sender, EventArgs e)
        {
            new RouteForm().ShowDialog();
        }

        private void shopRequestsButton_Click(object sender, EventArgs e)
        {
            new ShopRequestsForm().ShowDialog();
        }

        private void marksButton_Click(object sender, EventArgs e)
        {
            new MarksForm().ShowDialog();
        }

        private void modelsButton_Click(object sender, EventArgs e)
        {
            new ModelsForm().ShowDialog();
        }

        private void carTypesButton_Click(object sender, EventArgs e)
        {
            new CarTypesForm().ShowDialog();
        }

        private void unitsButton_Click(object sender, EventArgs e)
        {
            new UnitsForm().ShowDialog();
        }

        private void prodTypeButtons_Click(object sender, EventArgs e)
        {
            new productTypesForm().ShowDialog();
        }

        private void regionsButton_Click(object sender, EventArgs e)
        {
            new RegionForm().ShowDialog();
        }

        private void localityTypesButton_Click(object sender, EventArgs e)
        {
            new LocalityTypesForm().ShowDialog();
        }

        private void areasButton_Click(object sender, EventArgs e)
        {
            new AreasForm().ShowDialog();
        }

        private void localitiesButton_Click(object sender, EventArgs e)
        {
            new LocalitiesForm().ShowDialog();
        }

        private void streetsButton_Click(object sender, EventArgs e)
        {
            new StreetsForm().ShowDialog();
        }
    }
}
