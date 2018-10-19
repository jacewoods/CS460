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
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Enter colors you wish to mix in HTML hexadecimal format. Ex: #AABBCC";
            ViewBag.show = false;
            return View();
        }

        [HttpPost]
        public ActionResult Color(string firstColor, string secondColor)
        {
            firstColor = Request.Form["colorOne"];
            secondColor = Request.Form["colorTwo"];

            return View();
        }
    }
}