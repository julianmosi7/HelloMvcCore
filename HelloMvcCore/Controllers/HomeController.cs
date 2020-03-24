using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloMvcCore.Models;
using NorthwindBackendDb;

namespace HelloMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindBackendContext db;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, NorthwindBackendContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            int nr = db.Categories.Count();
            ViewBag.NrCategories = nr;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dummy()
        {
            return View();
        }

        public IActionResult Show(int id)
        {
            Console.WriteLine($"HomeController::Show({id})");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
