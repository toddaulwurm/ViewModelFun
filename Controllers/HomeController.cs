using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
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
        [HttpGet("names")]
        public IActionResult Names()
        {
            string[] names = new string[]
            {
                "Sally",
                "Billy",
                "Joey",
                "Moose"
            };
            return View(names);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,
                2,
                3,
                4,
                5
            };
            return View(numbers);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            User one = new User()
            {
                FirstName = "Bob",
                LastName = "Smith"
            };
            User two = new User()
            {
                FirstName = "Boby",
                LastName = "Smith"
            };
            List<User> viewModel = new List<User>()
            {
                one,
                two
            };
            return View(viewModel);
        }
        [HttpGet("user")]
        public IActionResult UserAction()
        {
            User one = new User()
            {
                FirstName = "Bob",
                LastName = "Smith"
            };
            User two = new User()
            {
                FirstName = "Boby",
                LastName = "Smith"
            };
            return View(two);
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
