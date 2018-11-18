using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.Models;

namespace HW8.Controllers
{
    public class BidsController : Controller
    {
        private AuctionsContext db = new AuctionsContext();

        // GET: Bids/Create
        public ActionResult Create()
        {
            ViewBag.BuyerID = new SelectList(db.Buyers, "BuyerID", "BuyerName");
            ViewBag.ItemID = new SelectList(db.Items, "ItemID", "ItemName");
            return View();
        }

        // POST: Bids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BidID,ItemID,BuyerID,Price,Timestamp")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.BuyerID = new SelectList(db.Buyers, "BuyerID", "BuyerName", bid.BuyerID);
            ViewBag.ItemID = new SelectList(db.Items, "ItemID", "ItemName", bid.ItemID);
            return View(bid);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
