using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldIndicator.Connections;

namespace WorldIndicator.Models
{
    public class Indicator
    {
        public string CountryName { set; get; }
        public string Rate { set; get; }
        public string Year { set; get; }
        public string Description { set; get; }


        public List<Indicator> getBirthRateIndicator(string countryCode, string startYear, string endYear)
        {
            List<Indicator> listCountries = new List<Indicator>();
            listCountries = Connection.GetListData<Indicator>(ConnectionNameEnum.AdmisionTest, "getBirthRateIndicator", new { @countryCode = countryCode, @startYear = startYear, @endYear = endYear });
            return listCountries;
        }

        public List<Indicator> getMortalityIndicator(string countryCode, string startYear, string endYear)
        {
            List<Indicator> listCountries = new List<Indicator>();
            listCountries = Connection.GetListData<Indicator>(ConnectionNameEnum.AdmisionTest, "getMortalityIndicator", new { @countryCode = countryCode, @startYear = startYear, @endYear = endYear });
            return listCountries;
        }

        public List<Indicator> getIndicators(string countryCode, string startYear, string endYear) 
        {
            List<Indicator> totalList = new List<Indicator>();
            List<Indicator> birtRate = new List<Indicator>();
            List<Indicator> mortality = new List<Indicator>();
            Indicator indicator = new Indicator();
            birtRate = indicator.getBirthRateIndicator(countryCode, startYear, endYear);
            mortality = indicator.getMortalityIndicator(countryCode, startYear, endYear);
            totalList.AddRange(birtRate);
            totalList.AddRange(mortality);
            return totalList;
        }

    }
}
