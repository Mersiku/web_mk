using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_mk.DAL;
//using web_mk.Models;

namespace web_mk.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var kategorie = db.Categories.ToList();
            return View(kategorie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult footerSites(string viewName){
            var kategorie = db.Categories.ToList();
            return View(viewName, kategorie);
        }

    }
}