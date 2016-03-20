using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "What have I done?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You know why you are here.";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "The Resume.";
         
            return View();
        }
        
    }
}