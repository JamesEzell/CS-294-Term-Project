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
        Book book;
        
        public SourcesController()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Author = "Marc Platt",
                Title = "Lungbarrow",
                PubDate = new DateTime(1997, 1, 1)
            });
            
            books.Add(new Book()
            {
                Author = "Steve Lyons",
                Title = "Head Games",
                PubDate = new DateTime(1997, 1, 1)
            });
            
        }

        public IActionResult Books()
        {
            ViewData["Message"] = "Books and print media about the person or persons";

            List<Book> books = Book.Books;
            books.Sort((b1, b2) => b1.Title.CompareTo(b2.Title));
            return View(books);
        }

        public IActionResult Links()
        {
            ViewData["Message"] = "Links to online media about a person or persons";

            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddBook(string title,
                                              string author, string pubDate)
        {
            book = new Book();
            book.Author = author;
            book.Title = title;
            book.PubDate = DateTime.Parse(pubDate);
            
            return RedirectToAction("Books");
        }
    }
}