using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldIndicator.Models;

namespace WorldIndicator.Controllers
{
    public class IndicatorController : Controller
    {
        //
        // GET: /Indicator/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult getIndicator(string countryCode, string startYear, string endYear)
        {
            Indicator indicator = new Indicator();
            List<Indicator> listIndicator = indicator.getIndicators(countryCode, startYear, endYear);
            return Json(listIndicator);
        }

    }
}
