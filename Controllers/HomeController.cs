using Aure_DbConnection_01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aure_DbConnection_01.Controllers
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
            var mySecret = Environment.GetEnvironmentVariable("MySecret");

            if (mySecret == null)
            {
                mySecret = "Not Today";
            }

            ViewData["MySecret"] = mySecret;

            return View();
        }

        public IActionResult Privacy()
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