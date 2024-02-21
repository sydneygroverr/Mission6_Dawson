using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_Dawson.Models;
using System.Diagnostics;

namespace Mission6_Dawson.Controllers
{
    public class HomeController : Controller
    {

        private MovieCollectionContext _context;

        public HomeController(MovieCollectionContext temp) //constructor
        {
            _context = temp;
        } 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View("GetToKnowJoel");
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response) 
        {

            // add the record to the database
            _context.Movies.Add(response);
            _context.SaveChanges(); //commit changes to the database

            return View("Confirmation", response);
        }
       
        public IActionResult MovieData()
        {
            var collections = _context.Movies.Include("Category")
                .OrderBy(x => x.Title).ToList();

            return View(collections);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieData");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieData");
        }
    }
}
