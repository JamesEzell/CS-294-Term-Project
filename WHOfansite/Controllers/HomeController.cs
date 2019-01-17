using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Authorization;
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
            List<Story> submissions = repo.Submissions.ToList();
            List<Comment> comments = repo.Comments.ToList();
            submissions.Sort((s1, s2) => s1.Title.CompareTo(s2.Title));
            return View(submissions);
            
        }

        [HttpPost]
        public IActionResult Stories(string title)
        {
            List<Story> submissions = (from s in repo.Submissions
                                       where s.Title == title
                                       select s).ToList();
            return View(submissions);
        }

        [HttpPost]
        public IActionResult Stories(DateTime date)
        {
            List<Story> submissions = (from s in repo.Submissions
                                       where s.Date == date
                                       select s).ToList();
            return View(submissions);
        }

        public IActionResult StoriesForm() => View();

        
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
        public ViewResult AddComment(Story submission, Comment comment)
        {
            if (ModelState.IsValid)
            {
                repo.AddComment(submission, comment);
                return View("Thanks", comment);
            }
            else
            {
                return View();
            }  
        }

    }
}
