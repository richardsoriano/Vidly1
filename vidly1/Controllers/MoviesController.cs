using Microsoft.AspNetCore.Mvc;
using vidly1.ViewModels;
using vidly1.Models;
using vidly1.Data;
using Microsoft.EntityFrameworkCore;

namespace vidly1.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
         public ViewResult Index()
        {
            var movies = _context.Movies.Include(m=>m.GenreType).ToList();
            return View(movies);
        }

        public IActionResult Random()
        {
           var movie = new Movie() { Name = "Shrek!" };
           var customers = new List<Customer>
            {
               new Customer { Name = "Carnival Row"},
               new Customer { Name = "Nightmare Alley" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return Content("Not Found");
            return View(movie);

        }
        protected override void Dispose(bool disposing) { _context.Dispose(); }

    }
}
