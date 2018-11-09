using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiphyProj.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public JsonResult HelloWorld(string id)
        {
            var data = new
            {
                test = id,
                message = "Hello",
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}