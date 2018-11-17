using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class User
    {
        private List<Story> submissions = new List<Story>();
        private List<Comment> comments = new List<Comment>();


        public int UserID { get; set; }     // This will become the PK

        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Story> Submissions { get { return submissions; } }

        public ICollection<Comment> Comments { get { return comments; } }
    }
}
