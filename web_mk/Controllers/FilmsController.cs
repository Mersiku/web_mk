using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_mk.DAL;
using web_mk.Models;

namespace web_mk.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment webHost;


        public FilmsController(FilmsContext db, IWebHostEnvironment webHost)
        {
            this.db = db;
            this.webHost = webHost;
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            AddViewModel model = new AddViewModel();
            model.AllCategories = db.Categories.ToList();
            return View(model);

        }

        [HttpPost]
        public IActionResult AddFilm(AddViewModel model)
        {
            var posterFolderPath = Path.Combine(webHost.WebRootPath, "posters");
            var uniquePosterName = model.Poster.FileName + "_" + Guid.NewGuid().ToString() + Path.GetExtension(model.Poster.FileName);

            var filePath = Path.Combine(posterFolderPath, uniquePosterName);
            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));

            model.NewFilm.Poster = uniquePosterName;
            db.Films.Add(model.NewFilm);
            db.SaveChanges();
            return RedirectToAction("AddFilm");
        }

        public IActionResult FilmsList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c=> c.Name.ToUpper() == categoryName.ToUpper()).Single();

            var films = category.Films.ToList();


            return View(films);
        }


        public IActionResult Details(int filmId)
        {
            var film = db.Films.Find(filmId);
            if(film!= null)
            {
                db.Categories.Find(film.CategoryId);
            }
            return View(film);

        }

        public IActionResult AllFilms()
        {
            var films = db.Films.Include(f => f.Category).ToList();
            return View(films);
        }
    }

}
