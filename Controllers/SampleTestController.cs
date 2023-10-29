using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProj.Controllers
{
    public class SampleTestController : Controller
    {
        // GET: SampleTest
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Store") ]
        public ActionResult Test()
        {
               return View("Test");

        }
        [NonAction]
        public string GetName()
        {
            return "my name is Prakash";
        }

    }
}