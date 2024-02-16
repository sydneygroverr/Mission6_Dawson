using Microsoft.AspNetCore.Mvc;
using Mission6_Dawson.Models;
using System.Diagnostics;

namespace Mission6_Dawson.Controllers
{
    public class HomeController : Controller
    {

        private MovieCollectionContext _context;

        public HomeController(MovieCollectionContext someName) //constructor
        {
            _context = someName;
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
       
    }
}
