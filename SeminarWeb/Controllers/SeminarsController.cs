using SeminarWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SeminarWeb.Controllers
{
    public class SeminarsController : Controller
    {
        // GET: Seminars
        public ActionResult Index()
        {
            var seminar = new Seminar
            {
                Subject = "Основы программирования",
                Description = "На семинаре вы узнаете...",
                Presenter = "Василий Петров",
                Time = new DateTime(2018, 05, 16, 01, 24, 20, 30)
            };

            return View("Index", seminar);
        }
        public ActionResult All()
        {
            var seminars = new List<Seminar>
            {
                new Seminar
                {
                Subject = "Основы программирования",
                Description = "На семинаре вы узнаете...",
                Presenter = "Василий Петров",
                Time = new DateTime(2018, 05, 16, 01, 24, 20, 30)
                },

                new Seminar
                {
                Subject = "Семинар 1",
                Description = "На семинаре вы узнаете...",
                Presenter = "Скарина",
                Time = new DateTime(2015, 05, 16, 01, 24, 20, 30)
                },

                new Seminar
                {
                Subject = "Семинар 2",
                Description = "На семинаре вы узнаете...",
                Presenter = "Витушкин",
                Time = new DateTime(2016, 05, 16, 01, 24, 20, 30)
                },

                new Seminar
                {
                Subject = "Семинар 3",
                Description = "На семинаре вы узнаете...",
                Presenter = "Ларин",
                Time = new DateTime(2013, 05, 16, 01, 24, 20, 30)
                }
            };
            return View("All", seminars.OrderBy(x => x.Time));
        }
        //public ActionResult Create()
        
    }
}