using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProj.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            //ViewData["name"] = "Prakash";
            //ViewData["today"] = DateTime.Now.ToString();
            //TempData["name"] = "JYOTI";
            //TempData["today"] = DateTime.Now.ToString();

            Session["name"] = "Rashmi";
            Session["today"] = DateTime.Now.ToString();
            
            return RedirectToAction("World", "Hello");
            //return View();
        }

        public ActionResult World() 
        {
            //ViewData["name"] = "Prakash";
            //ViewData["today"] = DateTime.Now.ToString();
            ViewBag.name = "Prakash";
            ViewBag.today = DateTime.Now.ToString();
            return View("HomePage");
            
        }
    }
}