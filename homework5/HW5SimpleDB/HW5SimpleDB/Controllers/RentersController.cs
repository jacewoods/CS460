using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW5SimpleDB.DAL;
using HW5SimpleDB.Models;


/// <summary>
/// Controller for the Create Form and Table List views
/// </summary>
namespace HW5SimpleDB.Controllers
{
    public class RentersController : Controller
    {
        private RenterContext db = new RenterContext();

        // GET: Renters
        public ActionResult Index()
        {
            return View(db.Renters.ToList());
        }


        // GET: Renters/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Renter renter)
        {
            if (ModelState.IsValid)
            {
                db.Renters.Add(renter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(renter);
        }
    }
}
