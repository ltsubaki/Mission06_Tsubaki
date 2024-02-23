using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using missionSixLilian.Models;
using static System.Net.Mime.MediaTypeNames;

namespace missionSixLilian.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieSubmission()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View(new MovieSub());
        }
        [HttpPost]
        public IActionResult MovieSubmission(MovieSub response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryId)
                    .ToList();
                return View(response);
            }
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .Include("Category")
                .ToList();


            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieSubmission", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(MovieSub updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList"); //instead of going to the view MovieList, it will go to the ACTION
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(MovieSub submission)
        {
            _context.Movies.Remove(submission);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
