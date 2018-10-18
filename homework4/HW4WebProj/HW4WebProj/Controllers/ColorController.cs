using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4WebProj.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            ViewBag.Message = "Enter colors you wish to mix in HTML hexadecimal format. Ex: #AABBCC";

            return View();
        }

        public ActionResult Color()
        {
            ViewBag.Message = "Your converter page.";

            return View();
        }
    }
}