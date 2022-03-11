using _09032022_OtomatikMigrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09032022_OtomatikMigrations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();

            db.Kitaplar.ToList();

            return View();
        }
    }
}