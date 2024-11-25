using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App
{
    internal static class CityCoordinates // Receive and compare coordinates
    {
        //Create coordinates object with name and geocoordinates
        public class City
        {
            public string Name { get; set; }
            public GeoCoordinate Coordinates { get; set; }
        }

        //Create a dictionary of cities and their coordinates
        public static Dictionary<string, City> CityCoordinatesList = new Dictionary<string, City>
        {
            { "New York", new City { Name = "New York", Coordinates = new GeoCoordinate(40.7128, 74.0060) } },
            { "Phoenix", new City { Name = "Phoenix", Coordinates = new GeoCoordinate(33.4484, 112.0740) } },
            { "London", new City { Name = "London", Coordinates = new GeoCoordinate(51.5074, 0.1278) } }
        };
    }
}
