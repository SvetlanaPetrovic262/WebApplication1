using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BookClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clubs()
        {
            return View();
        }
    }
}
