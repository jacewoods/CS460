﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiphyProj.Controllers
{
    public class GiphyController : Controller
    {
        // GET: Giphy
        public ActionResult Index()
        {
            return View();
        }
    }
}