using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Comment
    {
        public string Name { get; set; }
        public Story CommentedStory { get; set; }
        public string CommentText { get; set; }
    }
}
