﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_mk.DAL;

namespace web_mk.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

        public FilmsController(FilmsContext db)
        {
            this.db = db;
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
