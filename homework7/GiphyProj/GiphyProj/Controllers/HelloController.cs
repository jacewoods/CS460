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
        public JsonResult HelloWorld()
        {
            var data = new
            {
                message = "Hello",
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}