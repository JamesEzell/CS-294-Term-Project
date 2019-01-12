using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class User : IdentityUser
    {
        private List<Story> submissions = new List<Story>();
        private List<Comment> comments = new List<Comment>();


        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Story> Submissions { get { return submissions; } }

        public ICollection<Comment> Comments { get { return comments; } }
    }
}
