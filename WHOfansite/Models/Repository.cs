using System;
using System.Collections.Generic;


namespace WHOfansite.Models
{
    public static class Repository
    {
        
        private static List<Story> submissions = new List<Story>();

        public static List<Story> Submissions { get { return submissions; } }

        public static void AddSubmission(Story submission)
        {
            submissions.Add(submission);
        }
    }
}
