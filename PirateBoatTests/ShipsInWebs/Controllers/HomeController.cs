﻿using BoatBuilderThing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShipsInWebs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var shipyard = new ShipYard();
            var ship = shipyard.GetClipper();
            ViewBag.ship = ship.ToString();
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
    }
}