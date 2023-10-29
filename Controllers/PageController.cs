using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProj.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Main()
        {
            ViewData["Name"] = "Prakash";
            ViewBag.Surname = "Jaiswal";
            TempData["Address"] = "Deoria-UP";
            Session["Mobile"] = "+91-7838391111";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}