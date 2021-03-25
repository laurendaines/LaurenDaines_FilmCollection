using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaurenDaines_FilmCollection.Models;

namespace LaurenDaines_FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IMoviesRepository _repository;

        public HomeController(ILogger<HomeController> logger, IMoviesRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //home page
        public IActionResult Index()
        {
            return View();
        }

        //privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        //enter a movie page
        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                tempStorage.AddMovie(movie);
                return View("Confirmation", movie);
            }
            else
            {
                return View();
            }
        }

        //view movies page
        public IActionResult ViewMovie()
        {
            return View(tempStorage.Movies);
        }

        //podcast page
        public IActionResult Podcast()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
