using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Rate
    {
        public User Rater { get; set; }
        public int Rating { get; set; }
        public SiteSubmissions RatedStory { get; set; }
    }
}
