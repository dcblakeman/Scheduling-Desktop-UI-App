using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class City
    {
        public City() { }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public City InsertCity(string cityName, int countryId)
        {
            this.CityName = cityName;
            this.CountryId = countryId;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = User.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = User.UserName;
            return new City();
        }
        public City UpdateCity(int cityId, string cityName, int countryId)
        {
            this.CityId = cityId;
            this.CityName = cityName;
            this.CountryId = countryId;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = User.UserName;
            return new City();
        }
        public City DeleteCity(int cityId)
        {
            this.CityId = cityId;
            return new City();
        }
        public City GetCity(int cityId)
        {
            this.CityId = cityId;
            return new City();
        }
    }
}
