using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4WebProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Converter()
        {

            string miles = Request.QueryString["mileInput"];
            string metric = Request.QueryString["chooseMetric"];
            string outputNum = metric;
            if (miles != null)
            {
                ViewBag.message = outputNum;
            }





            return View();

        }
    }
}