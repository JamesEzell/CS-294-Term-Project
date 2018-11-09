using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public class StoryRepository : IStoryRepositiory
    {
        private List<Story> submissions = new List<Story>();

        private List<Comment> comments = new List<Comment>();


        public List<Story> Submissions { get { return submissions; } }

        public List<Comment> Comments { get { return comments; } }

        public void AddSubmission(Story submission) => submissions.Add(submission);

        public void AddComment(Comment comment) => comments.Add(comment);

        public StoryRepository() => AddTestData();

        void AddTestData()
        {
            Story story = new Story()
            {
                Name = "Some Body",
                Title = "The Caves of Androzani",
                Date = new DateTime(2018, 10, 6),
                StoryText = "Start your story here"
            };
            Comment comment0 = new Comment() { CommentText = "The best Doctor Who story ever!" };
            AddComment(comment0);
            AddSubmission(story);

            story = new Story()
            {
                Name = "Morgan Blackhand",
                Title = "Remembrance of the Daleks",
                Date = new DateTime(2018, 10, 6),
                StoryText = "Start your story here"
            };
            Comment comment1 = new Comment() { CommentText = "The best Doctor Who story ever!" };
            AddComment(comment1);
            AddSubmission(story);

            story = new Story()
            {
                Name = "Rache Bartmoss",
                Title = "Robot",
                Date = new DateTime(2018, 10, 6),
                StoryText = "Start your story here"
            };
            Comment comment2 = new Comment() { CommentText = "The best Doctor Who story ever!" };
            AddComment(comment2);
            AddSubmission(story);
            
        }
    }
}
