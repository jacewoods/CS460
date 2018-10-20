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

                Color inputOne = ColorTranslator.FromHtml(firstColor);
                Color inputTwo = ColorTranslator.FromHtml(secondColor);
                Color mixedColor = new Color();

                int red, green, blue = 0;

                if(inputOne.R + inputTwo.R > 255)
                {
                    red = 255;
                }
                else
                {
                    red = inputOne.R + inputTwo.R;
                }

                if (inputOne.G + inputTwo.G > 255)
                {
                    green = 255;
                }
                else
                {
                    green = inputOne.G + inputTwo.G;
                }

                if (inputOne.B + inputTwo.B > 255)
                {
                    blue = 255;
                }
                else
                {
                    blue = inputOne.B + inputTwo.B;
                }

                mixedColor = Color.FromArgb(255, red, green, blue);
                string thirdColor = ColorTranslator.ToHtml(mixedColor);

                ViewBag.color1 = "background:" + firstColor;
                ViewBag.color2 = "background:" + secondColor;
                ViewBag.color3 = "background:" + thirdColor;
            }
            return View();
        }
    }
}