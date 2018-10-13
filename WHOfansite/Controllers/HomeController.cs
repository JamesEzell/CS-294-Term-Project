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
        SiteSubmissions story;
        public HomeController()
        {
            if (Repository.Submissions.Count == 0)  
            {
                story = new SiteSubmissions()
                {
                    Title = "The Caves of Androzani",
                    Date = new DateTime(2018, 10, 6),
                    Story = "Start your story here"
                };
                Repository.AddSubmission(story);
            }
        }

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
            List<SiteSubmissions> submissions = Repository.Submissions;
            return View(submissions);
        }

        [HttpGet] //responding to a get request, will display messages
        public ViewResult StoriesForm() => View();

        [HttpPost]
        public RedirectToActionResult AddSubmission(string name, string title, DateTime date, SiteSubmissions story)
        {
            story = new SiteSubmissions();
            story.Name = name;
            story.Date = date;
            story.Title = title;
            
            Repository.AddSubmission(story);  


            return RedirectToAction("Index");
        }
        

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Use this space to summarize your privacy and cookie use policy.";

            return View();
        }

        [HttpPost]
        public ViewResult StoriesForm(SiteSubmissions guestSubmission)
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

        public ViewResult ListSubmissions() => View(Repository.Submissions);

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
