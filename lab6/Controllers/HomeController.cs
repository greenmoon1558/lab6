using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab6.Models;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        CinemaContext db = new CinemaContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Cinema> cinemas = db.Cinemas;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Cinemas = cinemas;
            // возвращаем представление
            return View();
        }


    }
}