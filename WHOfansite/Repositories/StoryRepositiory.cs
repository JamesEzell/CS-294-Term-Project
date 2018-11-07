using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public class StoryRepository : IStoryRepositiory
    {
        public static List<Story> Submissions { get; } = new List<Story>();
        public static List<Story> Comments { get; } = new List<Story>();



        public static void AddSubmission(Story submission) => Submissions.Add(submission);

        public static void AddComment(Story comments) => Comments.Add(comments);
        static StoryRepository() => AddTestData();

        static void AddTestData()
        {
            Story story;

            if (StoryRepository.Submissions.Count == 0)
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
                StoryRepository.AddSubmission(story);

                story = new Story()
                {
                    Name = "Morgan Blackhand",
                    Title = "Remembrance of the Daleks",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment1 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment1);
                StoryRepository.AddSubmission(story);

                story = new Story()
                {
                    Name = "Rache Bartmoss",
                    Title = "Robot",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment2 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                story.Comments.Add(comment2);
                StoryRepository.AddSubmission(story);
            }
        }
    }
}
