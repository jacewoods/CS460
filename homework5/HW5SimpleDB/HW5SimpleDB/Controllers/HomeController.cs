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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SeeUser()
        {
            User test = new User { FirstName = "Bob", LastName = "Roberts", DOB = new DateTime(1994, 8, 13) };
            Debug.WriteLine(test);
            return View(test);
        }

        public ActionResult AllUsers()
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
                foreach (var u in uc.Users)
                {
                    Debug.WriteLine(u);
                }
                return RedirectToAction("AllUsers");
            }
            return View();
        }
    }
}