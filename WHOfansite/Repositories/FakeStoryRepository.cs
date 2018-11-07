using System;
using System.Collections.Generic;


namespace WHOfansite.Models
{
    public static class FakeStoryRepository
    {
        public static List<Story> Submissions { get; } = new List<Story>();
        public static List<Story> Comments { get; } = new List<Story>();
        public static List<Book> Books { get; } = new List<Book>();
        public static List<Link> Links { get; } = new List<Link>();


        public static void AddSubmission(Story submission) => Submissions.Add(submission);

        public static void AddComment(Story comments) => Comments.Add(comments);

        public static void AddBook(Book book) => Books.Add(book);

        public static void AddLink(Link link) => Links.Add(link);

        static FakeStoryRepository() => AddTestData();

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
            FakeStoryRepository.AddBook(book);

            book = (new Book()
            {
                Author = "Steve Lyons",
                Title = "Head Games",
                PubDate = new DateTime(1997, 1, 1)
            });
            FakeStoryRepository.AddBook(book);

            link = (new Link()
            {
                PageTitle = "The TARDIS Library",
                PageUrl = "http://www.timelash.com/tardis/",
                PageInfo = "Online hub for information and sales of Doctor Who merchandise in very medium imaginable",
            });
            FakeStoryRepository.AddLink(link);

            link = (new Link()
            {
                PageTitle = "List of Doctor Who Serials from 1963-1989",
                PageUrl = "https://en.wikipedia.org/wiki/List_of_Doctor_Who_episodes_(1963%E2%80%931989)",
                PageInfo = "Every serial from the show's first run, because it's the only run that matters",
            });
            FakeStoryRepository.AddLink(link);

            if (FakeStoryRepository.Submissions.Count == 0)
            {
                story = new Story()
                {
                    Name = "Some Body",
                    Title = "The Caves of Androzani",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment0 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment0);
                FakeStoryRepository.AddSubmission(story);

                story = new Story()
                {
                    Name = "Morgan Blackhand",
                    Title = "Remembrance of the Daleks",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment1 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment1);
                FakeStoryRepository.AddSubmission(story);

                story = new Story()
                {
                    Name = "Rache Bartmoss",
                    Title = "Robot",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment2 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment2);
                FakeStoryRepository.AddSubmission(story);

            }
        }

    }
}
