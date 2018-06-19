using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarWeb.Controllers
{
    public class HomeController : Controller
    {
        private Models.DBLoginEntities db = new Models.DBLoginEntities();
        public ActionResult AboutSeminars_tb()
        {
            var Items = db.Seminars_tb;
            return View(Items);
        }

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

    }
}