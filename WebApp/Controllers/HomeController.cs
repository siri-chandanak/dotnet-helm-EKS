using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "This is the About page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Contact us at contact@example.com.";
            return View();
        }

        public IActionResult Services()
        {
            ViewBag.Message = "We offer various services to our clients.";
            return View();
        }
    }
}
