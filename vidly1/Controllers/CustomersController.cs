using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vidly1.Data;
//using vidly1.ViewModels;
namespace vidly1.Controllers
{
    public class CustomersController : Controller
    {
        //public IActionResult Index()
        // {

        // var customer = new Customer() { Name = "Elon Musk" };

        //     var customers = new List<Customer> {
        //          new Customer { Id = 1, Name = "Elon Musk" },
        //          new Customer { Id = 2, Name = "Tim Cook" }
        //     };

        //      return View(customers);
        //  }
        private ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ViewResult Index()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipTypes).ToList();
            //var customers = _context.Customers.Include(c => c.Name).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return Content("No Customers");

            return View(customer);
        }
//        private IEnumerable<Customer> GetCustomers()
 //       {
 //           return new List<Customer>
 //           {
 //               new Customer { Id = 1, Name = "John Smith" },
 //               new Customer { Id = 2, Name = "Mary Williams" }
 //           };
 //       }
    }//
}
