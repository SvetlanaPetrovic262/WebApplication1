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
                Name = "Dina",
                Author = "Frenk Herbert",
                Rating = 5,
                Members = 200,
            });
            books.Add(new Books
            {
                Name = "Hobit",
                Author = "Dž.R.R.Tolkin",
                Rating = 4.8,
                Members = 200,
            });
            books.Add(new Books
            {
                Name = "Gospodar prstenova",
                Author = "Dž.R.R.Tolkin",
                Rating = 5,
                Members = 200,
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
