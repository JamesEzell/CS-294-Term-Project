﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WHOfansite.Models
{
    public class Story
    {
        public int StoryId { get; set; }

        private List<Comment> comments = new List<Comment>();

        [Required(ErrorMessage = "Please enter a date")]
        public DateTime Date { get; set; }

        [StringLength(75, MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a story(It IS why you're here after all)!")]
        public string StoryText { get; set; }

        public ICollection<Comment> Comments { get { return comments; } }
    }
}
