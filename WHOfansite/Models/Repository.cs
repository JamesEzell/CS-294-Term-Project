using System;
using System.Collections.Generic;


namespace WHOfansite.Models
{
    public static class Repository
    {
        
        private static List<Story> submissions = new List<Story>();
        public static List<Story> Submissions { get { return submissions; } }

        private static List<Comment> comments = new List<Comment>();
        public static List<Comment> Comments { get { return comments; } }

        private static List<Book> books = new List<Book>();
        public static List<Book> Books { get { return books; } }

        private static List<Link> links = new List<Link>();
        public static List<Link> Links { get { return links; } }
        

        public static void AddSubmission(Story submission)
        {
            submissions.Add(submission);
        }

        public static void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        public static void AddLink(Link link)
        {
            links.Add(link);
        }
    }
}
