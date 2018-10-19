using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4WebProj.Controllers
{
    /// <summary>
    /// Declares the Index, or "Home" tab, as well as the Converter tab
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index is initialized and used as "Home" tab
        /// </summary>
        /// <returns> Successful redirection URL to /Home </returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Adds a new tab from the /Home directory, and does math to convert miles to metric
        /// </summary>
        /// <returns> Successful Home/Converter URL, and user inputted math to convert miles to metric </returns>
        [HttpGet]
        public ActionResult Converter()
        {
            //Requests the miles input by user into "miles"
            string miles = Request.QueryString["mileInput"];
            //Requests the metric unit input by user into "metric"
            string metric = Request.QueryString["chooseMetric"];
            double mileVal = 0;

            if (miles != null)
            {
                mileVal = Convert.ToDouble(miles);
                if (metric == "mm")
                {
                    mileVal = mileVal * 1609344.0;
                }
                else if (metric == "cm")
                {
                    mileVal = mileVal * 160934.4;
                }
                else if (metric == "m")
                {
                    mileVal = mileVal * 1609.344;
                }
                else if (metric == "km")
                {
                    mileVal = mileVal * 1.609344;
                }

                string outputNum = mileVal.ToString();

                ViewBag.message = outputNum;
            }





            return View();

        }
    }
}