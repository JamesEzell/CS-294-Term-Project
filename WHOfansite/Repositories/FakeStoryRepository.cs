using System;
using System.Collections.Generic;
using System.Linq;
using WHOfansite.Models;



namespace WHOfansite.Repositories
{
    public class FakeStoryRepository : IStoryRepository
    {
        private List<Story> submissions = new List<Story>();

        private List<Comment> comments = new List<Comment>();

        public IQueryable<Story> Submissions { get { return (IQueryable<Story>)submissions; } }

        public IQueryable<Comment> Comments { get { return (IQueryable<Comment>) comments; } }



        public void AddSubmission(Story submission) => submissions.Add(submission);

        public void AddComment(Story submission, Comment comment) => comments.Add(comment);

        public FakeStoryRepository() => AddTestData();

        public Story GetStoryByTitle(string title)
        {
            Story submission = submissions.Find(s => s.Title == title);
            return submission;
        }

        void AddTestData()
        {
            Story story = new Story()
            {
                Title = "The Caves of Androzani",
                Date = new DateTime(2018, 10, 6),
                StoryText = "Start your story here"
            };
            Comment comment0 = new Comment() { CommentText = "The best Doctor Who story ever!" };
            AddComment(story, comment0);
            AddSubmission(story);

            story = new Story()
            {
                Title = "Remembrance of the Daleks",
                Date = new DateTime(2018, 10, 6),
                StoryText = "Start your story here"
            };
            Comment comment1 = new Comment() { CommentText = "The best Doctor Who story ever!" };
            AddComment(story, comment1);
            AddSubmission(story);

            story = new Story()
            {
                Title = "Robot",
                Date = new DateTime(2018, 10, 6),
                StoryText = "Start your story here"
            };
            Comment comment2 = new Comment() { CommentText = "The best Doctor Who story ever!" };
            AddComment(story, comment2);
            AddSubmission(story);
            
        }
    }
}
