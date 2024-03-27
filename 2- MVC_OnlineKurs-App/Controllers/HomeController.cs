using Microsoft.AspNetCore.Mvc;
using MVC_OnlineKursApp_ProjesiCozumu.Models;
using System.Diagnostics;

namespace MVC_OnlineKursApp_ProjesiCozumu.Controllers
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

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    }
}