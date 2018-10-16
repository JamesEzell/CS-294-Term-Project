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



        public static void AddSubmission(Story submission)
        {
            submissions.Add(submission);
        }

        public static void AddComment(Comment comment)
        {
            comments.Add(comment);
        }
    }
}
