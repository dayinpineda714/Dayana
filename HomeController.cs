using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal_Web_Temático.Models;

namespace Portal_Web_Temático.Controllers
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
            return View();
        }

        public IActionResult Formula1()
        {
            return View();
        }

        public IActionResult Nascar()
        {
            return View();
        }

        public IActionResult MotoGP()
        {
            return View();
        }

        public IActionResult Motocross()
        {
            return View();
        }

        public IActionResult IsleOfManTT()
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
