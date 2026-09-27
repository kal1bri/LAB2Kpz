using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoutesLibrary.Base;
using RoutesLibrary.Bicycle;
using RoutesLibrary.Car;
using RoutesLibrary.Hiking;
using RoutesLibrary.Water;

namespace LAB2Kpz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (CBRoute.Items.Count > 0)
            {
                CBRoute.SelectedIndex = 0;
            }
        }

        private void DisplayRoute(RouteFactory factory, Image image)
        {
            Route myRoute = factory.CreateRoute();

            txtDetails.Text = myRoute.GetRouteDetails();
            PBRoute.Image = image;
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            switch (CBRoute.SelectedIndex)
            {
                case 0:
                    DisplayRoute(new HikingRouteFactory(), Properties.Resources.Hiking);
                    break;
                case 1:
                    DisplayRoute(new BicycleRouteFactory(), Properties.Resources.Bike);
                    break;
                case 2:
                    DisplayRoute(new CarRouteFactory(), Properties.Resources.Car);
                    break;
                case 3:
                    DisplayRoute(new WaterRouteFactory(), Properties.Resources.Water);
                    break;
                default:
                    MessageBox.Show("Будь ласка, оберіть маршрут зі списку.");
                    break;
            }
        }
    }
}
