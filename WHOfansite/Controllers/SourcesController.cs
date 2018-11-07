using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WHOfansite.Models;

namespace WHOfansite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Books()
        {
            List<Book> books = BookAndLinkRepository.Books;
            books.Sort((b1, b2) => b1.Title.CompareTo(b2.Title));
            return View(books);
        }

        public IActionResult Links()
        { 
            List<Link> pageLinks = BookAndLinkRepository.Links;
            pageLinks.Sort((b1, b2) => b1.PageTitle.CompareTo(b2.PageTitle));
            return View(pageLinks);
        }
        
    }
}