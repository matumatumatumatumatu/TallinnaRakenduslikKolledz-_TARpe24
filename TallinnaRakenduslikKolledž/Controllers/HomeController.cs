using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TallinnaRakenduslikKolledž.Models;

namespace TallinnaRakenduslikKolledž.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Värv"] = "punane";
            return View();
        }
        public IActionResult Privacy2()
        {
            ViewData["Värv"] = "roheline";
            return View("Home","Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
