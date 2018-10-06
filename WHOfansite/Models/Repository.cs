using System;
using System.Collections.Generic;


namespace WHOfansite.Models
{
    public static class Repository
    {
        
        private static List<SiteSubmissions> submissions = new List<SiteSubmissions>();

        public static List<SiteSubmissions> Submissions { get { return submissions; } }

        public static void AddSubmission(SiteSubmissions submission)
        {
            submissions.Add(submission);
        }
    }
}
