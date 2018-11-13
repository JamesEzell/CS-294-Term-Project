using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WHOfansite.Models;
using WHOfansite.Repositories;

namespace WHOfansite.Controllers
{
    public class HomeController : Controller
    {
        IStoryRepository repo;

        public HomeController(IStoryRepository r) => repo = r;

        public IActionResult Index() => View();

        public IActionResult History()
        {
            ViewData["Message"] = "A brief history of the person!";

            return View();
        }

        public IActionResult Stories()
        {
            List<Story> submissions = repo.Submissions;
            submissions.Sort((s1, s2) => s1.Title.CompareTo(s2.Title));
            return View(submissions);
            
        }

        public IActionResult StoriesForm(string guestSubmission) => View();

        
        public IActionResult AddComment() => View();

        [HttpPost]
        public ViewResult StoriesForm(Story guestSubmission)
        {
            if (ModelState.IsValid)
            {
                repo.AddSubmission(guestSubmission);
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
            repo.AddComment(comment);
            return View("Thanks", comment);        
        }

    }
}
