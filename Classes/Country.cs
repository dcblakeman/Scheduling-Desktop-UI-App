using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class Country
    {
        public Country() { }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public Country InsertCountry(string countryName)
        {
            this.CountryName = countryName;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = User.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = User.UserName;
            return new Country();
        }
        public Country UpdateCountry(int countryId, string countryName)
        {
            this.CountryId = countryId;
            this.CountryName = countryName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = User.UserName;
            return new Country();
        }
        public Country DeleteCountry(int countryId)
        {
            this.CountryId = countryId;
            return new Country();
        }
        public Country GetCountry(int countryId)
        {
            this.CountryId = countryId;
            return new Country();
        }
    }
}
