using Microsoft.AspNetCore.Mvc;

namespace vidly1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
