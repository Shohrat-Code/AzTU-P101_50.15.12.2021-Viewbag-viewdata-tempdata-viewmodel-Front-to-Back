using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIntro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Qasim";
            ViewData["Surname"] = "Abbasov";
            TempData["Age"] = 15;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
