using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldIndicator.Connections;


namespace WorldIndicator.Models
{
    public class Country
    {
        public string CountryCode { set; get; }

        public string CountryName { set; get; }

        public List<Country> getAllCountries() 
        {
            List<Country> listCountries = new List<Country>();
            listCountries = Connection.GetListData<Country>(ConnectionNameEnum.AdmisionTest, "GetAllCountries", new { }); 
            return listCountries;
        }
    }
}