using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreExistingRelationalDB.Models;
using PreExistingRelationalDB.Models.ViewModels;


namespace PreExistingRelationalDB.Controllers
{
    public class HomeController : Controller
    {
        private WorldWideImportersContext db = new WorldWideImportersContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}