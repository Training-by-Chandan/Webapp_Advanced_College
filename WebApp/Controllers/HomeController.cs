using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
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
        public ActionResult Prerana(string abc)
        {
            ViewBag.Title = "Prerana";
            ViewBag.Message = "This is test message from prerana.";
            ViewBag.Prerana = "Prerana Bajracharya " +abc;
            ViewBag.Sriti = "Sriti Prajapati "+abc;
            return View();
        }

        public ActionResult Sriti()
        {
            return View();
        }

        public ActionResult GetNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetNew(Models.NewModel model)
        {
            return View();
        }
    }
}