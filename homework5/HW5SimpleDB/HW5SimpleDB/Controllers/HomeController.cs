﻿using System;
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
        public DAL.RenterContext uc = new DAL.RenterContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllForms()
        {
            return View(uc.Renters);
        }

        // GET-POST-Redirect to GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Renter user)
        {
            Debug.WriteLine(user);
            if (ModelState.IsValid)
            {
                uc.Renters.Add(user);
                return RedirectToAction("AllForms");
            }
            return View();
        }
    }
}