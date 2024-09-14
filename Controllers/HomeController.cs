using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW2_project.Controllers
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
        public ActionResult Friendlist()

        {
            ViewBag.Message = "Your friends";

            return View();
        }
        public ActionResult Library()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Store()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();

        }


        
    }
}