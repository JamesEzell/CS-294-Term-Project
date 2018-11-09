using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WHOfansite.Models;
using WHOfansite.Repositories;

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
            List<Story> submissions = StoryRepository.Submissions;
            submissions.Sort((s1, s2) => s1.Title.CompareTo(s2.Title));
            return View(submissions);
            
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
                StoryRepository.AddSubmission(guestSubmission);
                return View("Thanks", guestSubmission);
            }
            else
            {
                return View();
            }
        }
        
        [HttpPost]
        public ViewResult AddComment(Comment comment)
        {
            StoryRepository.AddComment(comment);
            return View("Thanks", comment);        
        }

    }
}
