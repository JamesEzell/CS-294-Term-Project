﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WHOfansite.Models
{
    public class SiteSubmissions
    {
        private List<Comment> comments = new List<Comment>();
        private List<Rate> ratings = new List<Rate>();


        //[Required(ErrorMessage = "Please enter your username")]
        public User UserName { get; set; }

        [Required(ErrorMessage = "Please enter a date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a story(It IS why you're here after all)!")]
        public string Story { get; set; }
    }
}
