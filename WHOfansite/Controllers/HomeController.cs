using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WHOfansite.Models;

namespace WHOfansite.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "A brief history of the person!";

            return View();
        }

        public IActionResult Stories()
        {
            List<Story> submissions = Repository.Submissions;
            submissions.Sort((s1, s2) => s1.Title.CompareTo(s2.Title));
            return View(submissions);
            
        }
        
        public IActionResult Privacy()
        {
            ViewData["Message"] = "Use this space to summarize your privacy and cookie use policy.";

            return View();
        }

        [HttpGet] //responding to a get request, will display messages
        public ViewResult StoriesForm() => View();

        [HttpGet]
        public ViewResult AddComment() => View();

        [HttpPost]
        public ViewResult StoriesForm(Story guestSubmission)
        {
            if (ModelState.IsValid)
            {
                Repository.AddSubmission(guestSubmission);
                return View("Thanks", guestSubmission);
            }
            else
            {
                return View();
            }
        }
        
        [HttpPost]
        public ViewResult AddComment(Story comment)
        {
            if (ModelState.IsValid)
            {
                Repository.AddComment(comment);
                return View("Thanks", comment);
            }
            else
            {
                return View();
            }
        }
        
        public ViewResult ListSubmissions() => View(Repository.Submissions);

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
