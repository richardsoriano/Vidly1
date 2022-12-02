using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using vidly1.Models;
//using vidly1.ViewModels;

namespace vidly1.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {

           // var customer = new Customer() { Name = "Elon Musk" };

            var customers = new List<Customer> {
                 new Customer { Id = 1, Name = "Elon Musk" },
                 new Customer { Id = 2, Name = "Tim Cook" }
            };
   
            return View(customers);
        }
    }
}
