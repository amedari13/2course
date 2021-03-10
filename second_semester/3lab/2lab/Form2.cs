using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            GetLocation();
            Close();
        }

        public static string location_p = "Unknown latitude and longitude.";
        void GetLocation()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();


            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                location_p = "Lat: " + coord.Latitude + ", Long: " + coord.Longitude;
            }
            else
            {
                location_p = "Unknown latitude and longitude.";
            }
        }
    }
}
