using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using missionSixLilian.Models;

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
            return View();
        }
        [HttpPost]
        public IActionResult MovieSubmission(MovieSub response)
        {
            _context.MovieSubmissions.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }
    }
}
