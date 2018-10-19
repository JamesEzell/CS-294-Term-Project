using System;
using System.Collections.Generic;


namespace WHOfansite.Models
{
    public static class Repository
    {
        public static List<Story> Submissions { get; } = new List<Story>();
        public static List<Comment> Comments { get; } = new List<Comment>();
        public static List<Book> Books { get; } = new List<Book>();
        public static List<Link> Links { get; } = new List<Link>();


        public static void AddSubmission(Story submission)
        {
            Submissions.Add(submission);
        }

        public static void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public static void AddBook(Book book)
        {
            Books.Add(book);
        }

        public static void AddLink(Link link)
        {
            Links.Add(link);
        }

        static Repository()
        {
            AddTestData();
        }

        static void AddTestData()
        {
            Book book;
            Link link;
            Story story;

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

            if (Repository.Submissions.Count == 0)
            {
                story = new Story()
                {
                    Title = "The Caves of Androzani",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comments = new Comment() { CommentText = "The best Doctor Who story ever!" };
                Repository.AddComment(comments);
                Repository.AddSubmission(story);

                story = new Story()
                {
                    Title = "Remembrance of the Daleks",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment1 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                Repository.AddComment(comments);
                Repository.AddSubmission(story);

                story = new Story()
                {
                    Title = "Robot",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment2 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                Repository.AddComment(comments);
                Repository.AddSubmission(story);

            }
        }

    }
}
