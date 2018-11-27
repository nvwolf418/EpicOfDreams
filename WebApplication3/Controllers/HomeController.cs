using System;
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

        public ActionResult FeaturedContent()
        {
            ViewBag.Message = "Welcome To Your Fantasy";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to Contact Us";

            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Shop";

            return View();
        }

        public ActionResult BLOGS()
        {
            ViewBag.Message = "Blogs";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "News";

            return View();
        }

        public ActionResult Forum()
        {
            ViewBag.Message = "Forum";

            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "About Us";

            return View();
        }
    }
}