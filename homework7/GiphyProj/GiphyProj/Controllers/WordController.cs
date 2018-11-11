using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using GiphyProj.DAL;
using GiphyProj.Models;

namespace GiphyProj.Controllers
{


    public class WordController : Controller
    {
        //Establishes DB in Controller to log information
        private GiphyContext db = new GiphyContext();

        /// <summary>
        /// creates a json version of the input string and stores information in a database
        /// </summary>
        /// <param name="id"> the last word typed in the view input box </param>
        /// <returns></returns>
        public JsonResult BoringWords(string id)
        {
            var data = new
            {
                //JSON object that simply contains the last word typed in the view input box
                inputText = id
            };

            // Create a log and collect information for the DB
            Giphy DBLog = new Giphy();
            DBLog.InputTerm = id;
            DBLog.IPAddress = Request.UserHostAddress;
            DBLog.BrowserType = Request.UserAgent;

            // Adds and saves information to the DB
            db.Giphies.Add(DBLog);
            db.SaveChanges();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// ActionResult to gather HTML version of json URL using WebClient
        /// </summary>
        /// <param name="id"> the last word typed in the view input box </param>
        /// <returns> JSON formatted data received from Giphy using the Giphy API Key </returns>
        public ActionResult FindGiphy(string id)
        {
            // apiKey is a hidden key that allows access to the Giphy API
            string apiKey = System.Web.Configuration.WebConfigurationManager.AppSettings["GiphyAPI"];

            // stores JSON data from the URL as text
            var data2 = new WebClient().DownloadString("https://api.giphy.com/v1/stickers/translate?api_key=" + apiKey + "&s=" + id);

            // Create a log and collect information for the DB
            Giphy DBLog = new Giphy();
            DBLog.InputTerm = id;
            DBLog.IPAddress = Request.UserHostAddress;
            DBLog.BrowserType = Request.UserAgent;

            // Adds and saves information to the DB
            db.Giphies.Add(DBLog);
            db.SaveChanges();

            // Returns Content instead of JSON as the latter will double wrap the JSON using WebClient
            return Content(data2, "application/json");
        }
    }
}