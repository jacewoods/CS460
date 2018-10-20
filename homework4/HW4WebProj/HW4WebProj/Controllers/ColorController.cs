using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Diagnostics;

namespace HW4WebProj.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.show = false;
            return View();
        }

        [HttpPost]
        public ActionResult Create(string firstColor, string secondColor)
        {
            firstColor = Request.Form["colorOne"];
            secondColor = Request.Form["colorTwo"];

            if (firstColor != null && secondColor != null)
            {
                ViewBag.show = true;
                ViewBag.item1 = firstColor;
            }
            return View();
        }
    }
}