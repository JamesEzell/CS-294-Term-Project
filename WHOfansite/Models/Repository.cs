using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Repository
    {
        private static List<SiteSubmissions> submissions = new List<SiteSubmissions>();

        public static IEnumerable<SiteSubmissions> Submissions { get => submissions; }

        public static void AddSubmission(SiteSubmissions submission) => submissions.Add(submission);
    }
}
