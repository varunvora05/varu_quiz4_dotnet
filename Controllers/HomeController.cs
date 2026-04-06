using Microsoft.AspNetCore.Mvc;

namespace varu_quiz4_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Database access has already been done on April 6, 2026 by Varun";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}