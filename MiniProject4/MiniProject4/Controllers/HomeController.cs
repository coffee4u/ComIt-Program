using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniProject4.Models;

namespace MiniProject4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(PersonModel person)
        {
            ViewData["fullname"] = String.Format("{0} {1}", person.fname , person.lname);
            ViewData["car"] = person.cars;
            ViewData["Description"] = person.description;
            return View();
        }
        //public IActionResult PersonDetail(string fname, string lname)
        //{
        //    ViewData["Result"] = fname + lname;
        //    return View();
        //}


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
