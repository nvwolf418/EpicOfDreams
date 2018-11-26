﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Videos()
        {
            ViewBag.Message = "Videos!";

            return View();
        }

        public ActionResult BLOGS()
        {
            ViewBag.Message = "BLOGS!";

            return View();
        }
        
    }
}