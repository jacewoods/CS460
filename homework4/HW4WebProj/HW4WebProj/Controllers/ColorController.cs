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
        /// <summary>
        /// Create tab in Color Controller is created
        /// </summary>
        /// <returns> Returns to a second "HttpPost" Create function </returns>
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.show = false;
            return View();
        }

        /// <summary>
        /// Receives user input and does calculation to return a mixed color
        /// </summary>
        /// <param name="firstColor"> First Hexadecimal input from user </param>
        /// <param name="secondColor"> Second Hexadecimal input from user </param>
        /// <returns> if there is a user input for the colors, returns these colors along with a mixed color </returns>
        [HttpPost]
        public ActionResult Create(string firstColor, string secondColor)
        {
            //Grabs user inputs
            firstColor = Request.Form["colorOne"];
            secondColor = Request.Form["colorTwo"];

            //Does not create colors if there is no input
            if (firstColor != null && secondColor != null)
            {
                ViewBag.show = true;

                //Creates RGB color values from user inputs
                Color inputOne = ColorTranslator.FromHtml(firstColor);
                Color inputTwo = ColorTranslator.FromHtml(secondColor);

                //New color established to be created after user inputs have been calculated
                Color mixedColor = new Color();

                //Initialize RGB to plug into mixedColor
                int red, green, blue = 0;

                //Math done to make sure R,G,B values do not become larger than 255
                if (inputOne.R + inputTwo.R > 255)
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

                //mixedColor given an RGB value established from math in above if-statements
                mixedColor = Color.FromArgb(255, red, green, blue);
                //mixedColor converted to an html format in the form of string "thirdColor"
                string thirdColor = ColorTranslator.ToHtml(mixedColor);

                //Returns some css + html hexadecimal values for all three colors into Create.cshtml 
                ViewBag.color1 = "background:" + firstColor;
                ViewBag.color2 = "background:" + secondColor;
                ViewBag.color3 = "background:" + thirdColor;
            }
            return View();
        }
    }
}