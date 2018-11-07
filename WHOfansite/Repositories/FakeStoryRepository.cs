using System;
using System.Collections.Generic;
using WHOfansite.Models;


namespace WHOfansite.Repositories
{
    public static class FakeStoryRepository
    {
        public static List<Story> Submissions { get; } = new List<Story>();
        public static List<Story> Comments { get; } = new List<Story>();
       


        public static void AddSubmission(Story submission) => Submissions.Add(submission);

        public static void AddComment(Story comments) => Comments.Add(comments);
        static FakeStoryRepository() => AddTestData();

        static void AddTestData()
        {
            Story story;

            if (FakeStoryRepository.Submissions.Count == 0)
            {
                story = new Story()
                {
                    Name = "Some Body",
                    Title = "The Caves of Androzani",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment0 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment0);
                FakeStoryRepository.AddSubmission(story);

                story = new Story()
                {
                    Name = "Morgan Blackhand",
                    Title = "Remembrance of the Daleks",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment1 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment1);
                FakeStoryRepository.AddSubmission(story);

                story = new Story()
                {
                    Name = "Rache Bartmoss",
                    Title = "Robot",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment2 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment2);
                FakeStoryRepository.AddSubmission(story);
            }
        }
    }
}
