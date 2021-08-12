using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestCsharp.Filters;

namespace TestCsharp.Controllers
{
    public class HomeController : Controller
    {
        [AuthorizeUser(idOperacion:1)]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeUser(idOperacion: 3)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AuthorizeUser(idOperacion: 4)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}