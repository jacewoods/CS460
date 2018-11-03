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
        //Establishes the database to use within the Controller
        private WorldWideImportersContext db = new WorldWideImportersContext();

        /// <summary>
        /// Landing page Controller
        /// </summary>
        /// <param name="input"> as selected by the user, a string that is used to search for all Persons 
        /// that contain the specific string somewhere in their name </param>
        /// <returns> All people that had a name matching or containing that of the input string </returns>
        public ActionResult Index(String input)
        {
            input = Request.QueryString["input"];
            if (input == null)
            {
                ViewBag.show = false;
                return View();
            }
            else
            {
                ViewBag.show = true;
                return View(db.People.Where(search => search.FullName.Contains(input)).ToList());
            }
        }

        /// <summary>
        /// ViewModel gets database information from specific person
        /// </summary>
        /// <param name="id"> Person selected in search has unique ID, added here </param>
        /// <returns> ViewModel with Person information </returns>
        public ActionResult Employee(int? id)
        {
            ViewModel vm = new ViewModel();

            vm.Person = db.People.Find(id);

            return View(vm);
        }
    }
}