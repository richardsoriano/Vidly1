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
<<<<<<< HEAD
         public ViewResult Index()
        {
            var movies = _context.Movies.Include(m=>m.GenreType).ToList();
            return View(movies);
        }

=======
>>>>>>> c16370ff062cf943f08d470515b56fade20f828e
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
<<<<<<< HEAD
            var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return Content("Not Found");
            return View(movie);

=======
            return Content("id=" + movieId);
        }
        public IActionResult Index(int? pageIndex, string sortBy) 
        {
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;
            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";
            //return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));
            var movies = _context.Movies.Include(m => m.GenreType).ToList();
            //var customers = _context.Customers.Include(c => c.Name).ToList();
            return View(movies);
        }
        [Route("movies/released/{year}/{month}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
             return Content(year + "/" + month);
            //return Content("Hello");
            
>>>>>>> c16370ff062cf943f08d470515b56fade20f828e
        }
        protected override void Dispose(bool disposing) { _context.Dispose(); }

    }
}
