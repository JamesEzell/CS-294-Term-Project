﻿using System;
using System.Collections.Generic;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public class BookAndLinkRepository
    {
        public static List<Link> Links { get; set; } = new List<Link>();

        public static List<Book> Books { get; set; } = new List<Book>();

        public static void AddBook(Book book) => Books.Add(book);

        public static void AddLink(Link link) => Links.Add(link);

        public BookAndLinkRepository() => AddTestData();

        void AddTestData()
        { 
           Book  book = (new Book()
            {
                Author = "Marc Platt",
                Title = "Lungbarrow",
                PubDate = new DateTime(1997, 1, 1)
            });
            BookAndLinkRepository.AddBook(book);

            book = (new Book()
            {
                Author = "Steve Lyons",
                Title = "Head Games",
                PubDate = new DateTime(1997, 1, 1)
            });
            BookAndLinkRepository.AddBook(book);

            Link link = (new Link()
            {
                PageTitle = "The TARDIS Library",
                PageUrl = "http://www.timelash.com/tardis/",
                PageInfo = "Online hub for information and sales of Doctor Who merchandise in very medium imaginable",
            });
            BookAndLinkRepository.AddLink(link);

            link = (new Link()
            {
                PageTitle = "List of Doctor Who Serials from 1963-1989",
                PageUrl = "https://en.wikipedia.org/wiki/List_of_Doctor_Who_episodes_(1963%E2%80%931989)",
                PageInfo = "Every serial from the show's first run, because it's the only run that matters",
            });
            BookAndLinkRepository.AddLink(link);
        }
    }
}
