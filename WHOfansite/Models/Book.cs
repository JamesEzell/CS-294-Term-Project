using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Book 
    {
        public int BookId { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public DateTime PubDate { get; set; }
 
    }
}
