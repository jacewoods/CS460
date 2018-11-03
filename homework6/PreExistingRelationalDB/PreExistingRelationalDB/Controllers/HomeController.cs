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

        public ActionResult Index(String input)
        {
            ViewModel vm = new ViewModel();

            input = Request.QueryString["input"];
            if (input == null)
            {
                ViewBag.show = false;
                return View();
            }
            else
            {
                ViewBag.show = true;
                return View(db.People.Where(p => p.FullName.Contains(input)).ToList());
            }
        }
    }
}