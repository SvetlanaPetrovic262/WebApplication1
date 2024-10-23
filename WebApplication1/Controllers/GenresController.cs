using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fantasy()
        {
            return View();
        }

        public IActionResult ScienceFiction()
        {
            return View();
        }
    }
}
