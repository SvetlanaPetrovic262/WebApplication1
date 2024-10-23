using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Books> books = new();

            books.Add(new Books
            {
                Id = 1,
                Name = "Dune",
                Rating = 5,
            });
            books.Add(new Books
            {
                Id = 2,
                Name = "Hobbit",
                Rating = 5,
            });
            books.Add(new Books
            {
                Id = 3,
                Name = "Lord of the rings",
                Rating = 5,
            });

            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
