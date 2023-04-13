using aspnet_core_unit_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspnet_core_unit_1.Controllers
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

        public ActionResult CheckCountValue(int i)
        {
            if (i < 20)
            {
                // Ovdje ide neka random logika
            }
            else
            {
                throw (new Exception("Broj je izvan raspona"));
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}