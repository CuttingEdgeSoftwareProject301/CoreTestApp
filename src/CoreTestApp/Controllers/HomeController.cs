using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreTestApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Register2() //
        {
            ViewData["Message"] = "Your full register page.";

            return View();
        }


        public IActionResult Events() //
        {
            ViewData["Message"] = "Your events page";

            return View();
        }


        public IActionResult Information() //
        {
            ViewData["Message"] = "Your Info page";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
