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
            {

                string name = Request.QueryString["user_name"];
                if (name != null)
                {
                    string message = "Hello " + name + "! Welcome.";
                    ViewBag.message = message;
                    // Same as 
                    //ViewData["message"] = message;
                }

                return View();
            }

        }
    }
}