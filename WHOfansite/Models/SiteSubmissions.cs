using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WHOfansite.Models
{
    public class SiteSubmissions
    {
        //in older times, be smart about speed and effciency of your code. Code runs fast and doesn't use much RAM.
        //easily maintained code is the big issue today. Easy to debug and easy to work with in a team enviroment

        //private List<SiteSubmissions> siteSubmissions = new List<SiteSubmissions>(); //circular logic, not needed
        //private List<Comment> comments = new List<Comment>();
        
        [Required(ErrorMessage = "Please enter your username")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a story(It IS why you're here after all)!")]
        public string Story { get; set; }

        //public List<Comment> Comments { get { return comments; } }
        

    }
}
