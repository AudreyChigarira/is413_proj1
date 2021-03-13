using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignUpGenius.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Controllers
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

        [HttpGet]
        public IActionResult SignUpPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpPage(FormModel appResponse)
        {
            TimeTempStorage.AddApplication(appResponse);
            return View("SignUpForm", appResponse);
        }

        [HttpGet]
        public IActionResult SignUpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUpForm(FormModel appResponse)
        {
            // Still need to add other functionality in here
            return View("Index", appResponse);

            //Validate the model
            //if (ModelState.IsValid)
            //{
            //    return View("Index", appResponse);
            //}
            //else
            //{
                //List out the validation errors without going to another page yet
            //    return View();
            //}
        }

        public IActionResult Appointments()
        {
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
