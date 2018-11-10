using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace GiphyProj.Controllers
{
    public class WordController : Controller
    {
        // GET: Hello
        public JsonResult WordConvert(string id)
        {
            var data = new
            {
                inputText = id
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FindGiphy(string id)
        {
            string apiKey = System.Web.Configuration.WebConfigurationManager.AppSettings["GiphyAPI"];
            var data2 = new WebClient().DownloadString("https://api.giphy.com/v1/stickers/translate?api_key=" + apiKey + "&s=" + id);

            return Content(data2, "application/json");
        }
    }
}