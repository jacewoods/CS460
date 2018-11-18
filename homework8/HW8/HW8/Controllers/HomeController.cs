using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HW8.Models;

namespace HW8.Controllers
{
    public class HomeController : Controller
    {
        private AuctionsContext db = new AuctionsContext();

        public ActionResult Index()
        {
            var bids = db.Bids.Include(b => b.Buyer).Include(b => b.Item)
                .OrderByDescending(b => b.Timestamp).Take(10);
            return View(bids.ToList());
        }

    }
}