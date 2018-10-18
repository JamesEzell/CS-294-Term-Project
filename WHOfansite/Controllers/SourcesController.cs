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
        
        public SourcesController()
        {
            Book book;
            Link link;

            book = (new Book()
            {
                Author = "Marc Platt",
                Title = "Lungbarrow",
                PubDate = new DateTime(1997, 1, 1)
            });
            Repository.AddBook(book);
            
            book = (new Book()
            {
                Author = "Steve Lyons",
                Title = "Head Games",
                PubDate = new DateTime(1997, 1, 1)
            });
            Repository.AddBook(book);

            link = (new Link()
            {
                PageTitle = "The TARDIS Library",
                PageUrl = "http://www.timelash.com/tardis/",
                PageInfo = "Online hub for information and sales of Doctor Who merchandise in very medium imaginable",
            });
            Repository.AddLink(link);

            link = (new Link()
            {
                PageTitle = "List of Doctor Who Serials from 1963-1989",
                PageUrl = "https://en.wikipedia.org/wiki/List_of_Doctor_Who_episodes_(1963%E2%80%931989)",
                PageInfo = "Every serial from the show's first run, because it's the only run that matters",
            });
            Repository.AddLink(link);
        }

        public IActionResult Books()
        {
            List<Book> books = Repository.Books;
            books.Sort((b1, b2) => b1.Title.CompareTo(b2.Title));
            return View(books);
        }

        public IActionResult Links()
        { 
            List<Link> pageLinks = Repository.Links;
            pageLinks.Sort((b1, b2) => b1.PageTitle.CompareTo(b2.PageTitle));
            return View(pageLinks);
        }
        
    }
}