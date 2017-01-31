using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldIndicator.Models;

namespace WorldIndicator.Controllers
{
    public class CountryController : Controller
    {
        //
        // GET: /Country/

        public ActionResult Index()
        {
            Country country = new Country();
            List<Country> countryList = new List<Country>();
            countryList = country.getAllCountries();
            ViewBag.List = new SelectList(countryList,"CountryCode", "CountryName");
            return View("Search");
        }        

    }
}
