using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}