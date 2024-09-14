using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW2_project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BanPlayer()
        {
            return View();

        }
        public ActionResult UploadGames()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AddNews()
        {
            return View();
        }
    }
}