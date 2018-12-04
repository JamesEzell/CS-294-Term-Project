using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Comment
    {
        public int CommentID { get; set; }       // This will become the PK

        [Required(ErrorMessage = "No commenting unless we know who you are" ) ]
        public User Commentor { get; set; }

        [StringLength(260, MinimumLength = 4)]
        public string CommentText { get; set; }
    }
}
