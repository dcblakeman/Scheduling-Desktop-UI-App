using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Device.Location;


namespace Scheduling_Desktop_UI_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Console.WriteLine(CityCoordinates.CityCoordinatesList["New York"].Coordinates.Latitude);
            Console.WriteLine(CityCoordinates.CityCoordinatesList["New York"].Coordinates.Longitude);
            Console.WriteLine(CityCoordinates.CityCoordinatesList["Phoenix"].Coordinates.Latitude);
            Console.WriteLine(CityCoordinates.CityCoordinatesList["Phoenix"].Coordinates.Longitude);
            Console.WriteLine(CityCoordinates.CityCoordinatesList["London"].Coordinates.Latitude);
            Console.WriteLine(CityCoordinates.CityCoordinatesList["London"].Coordinates.Longitude);
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
