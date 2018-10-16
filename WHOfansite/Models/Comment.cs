using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Comment
    {
        public string CommentorName { get; set; }
        public Story CommentedStory { get; set; }
        public Story CommentText { get; set; }
    }
}
