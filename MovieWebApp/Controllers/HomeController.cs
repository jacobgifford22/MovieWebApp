using MovieWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieWebApp.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _movieContext { get; set; }

        // Constructor
        public HomeController(MovieFormContext someName)
        {
            _movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(MovieForm mf)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(mf);
                _movieContext.SaveChanges();

                return View("Confirmation", mf);
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View(mf);
            }
        }

        [HttpGet]
        public IActionResult ViewMovies()
        {
            var movieDataset = _movieContext.Movies
                .Include(x => x.Category)
                //.Where(x => x.LentTo == null)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movieDataset);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.Movies.Single(x => x.MovieId == movieid);

            return View("AddMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieForm mf)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Update(mf);
                _movieContext.SaveChanges();

                return RedirectToAction("ViewMovies");
            }
            else
            {
                return RedirectToAction("Edit", new { movieid = mf.MovieId });
            }
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _movieContext.Movies.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieForm mf)
        {
            _movieContext.Movies.Remove(mf);
            _movieContext.SaveChanges();

            return RedirectToAction("ViewMovies");
        }
    }
}
