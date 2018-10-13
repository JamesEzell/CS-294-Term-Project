using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class User
    {
        private List<SiteSubmissions> stories = new List<SiteSubmissions>();
        private List<Comment> comments = new List<Comment>();


        public string Name { get; set; }
        public string Email { get; set; }

        public List<SiteSubmissions> Stories { get { return stories; } }
        public List<Comment> Comments { get { return comments; } }

    }
}
