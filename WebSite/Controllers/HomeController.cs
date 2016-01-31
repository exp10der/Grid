using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var tests = new List<Test>
            {
                new Test {Id = 1, Name = "Kos", Guid = new Guid("18a5666f-2f2c-4ad8-a3a2-bec42325418b")},
                new Test {Id = 2, Name = "Some Text", Guid = new Guid("08ba631f-4c89-41c5-99ab-fd060f8684f0")}
            };
            return View(tests);
        }
    }
}