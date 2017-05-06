using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class TeachersController : Controller
    {
        private WebApp.Models.WebAppModel db = new Models.WebAppModel();
        // GET: Teachers
        public ActionResult Index()
        {
            return View();
        }
    }
}