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
    }
}
