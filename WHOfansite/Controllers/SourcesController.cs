using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WHOfansite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            ViewData["Message"] = "Books and print media about the person or persons";

            return View();
        }

        public IActionResult Links()
        {
            ViewData["Message"] = "Links to online media about a person or persons";

            return View();
        }
    }
}