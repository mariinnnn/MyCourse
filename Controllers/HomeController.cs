using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCourse.Controllers
{

    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return Content("Sono nell'index dell homepage");
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}