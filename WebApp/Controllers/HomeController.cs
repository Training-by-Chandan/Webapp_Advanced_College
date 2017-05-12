using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private WebApp.Models.WebAppModel db = new Models.WebAppModel();
        private Models.NorthwindEntities db1 = new Models.NorthwindEntities();
        public ActionResult Index()
        {
            bool isloggedin = Convert.ToBoolean(Session["LoggedIn"]);
            if (isloggedin)
            {
                return RedirectToAction("Prerana");
            }
            else
            {
                return View();

            }
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
        public ActionResult Prerana(string abc="")
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

        public ActionResult NameClass()
        {
            var res = db.NameClass.ToList();
            return View(res);
        }


        public ActionResult ProductList()
        {
            return PartialView(db1.Products.ToList());
        }

        public ActionResult TabsPartial(Models.Product model)
        {
            return PartialView(model);
        }
    }
}