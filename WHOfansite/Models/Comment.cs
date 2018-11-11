using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Comment
    {
        public int CommentID { get; set; }       // This will become the PK

        public User Commentor { get; set; }

        public string CommentText { get; set; }
    }
}
