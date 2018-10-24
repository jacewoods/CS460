using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5SimpleDB.Models;
using HW5SimpleDB.DAL;

namespace HW5SimpleDB.Controllers
{
    public class HomeController : Controller
    {
        public UserCollection uc = new UserCollection();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllForms()
        {
            return View(uc.Users);
        }

        // GET-POST-Redirect to GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            Debug.WriteLine(user);
            if (ModelState.IsValid)
            {
                uc.Users.Add(user);
                return RedirectToAction("AllForms");
            }
            return View();
        }
    }
}