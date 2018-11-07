using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public class StoryRepository : IStoryRepositiory
    {
        public  List<Story> submissions { get; } = new List<Story>();
        public  List<Comment> comments { get; } = new List<Comment>();

        public List<Story> Submissions => throw new NotImplementedException();

        public void AddSubmission(Story submission) => submissions.Add(submission);

        public void AddComment(Comment comments) => comments.Add(comments);
        static StoryRepository() => AddTestData();

        public StoryRepository()
        {
        }

        static void AddTestData()
        {
            

           
                Story story = new Story()
                {
                    Name = "Some Body",
                    Title = "The Caves of Androzani",
                    Date = new DateTime(2018, 10, 6),
                    StoryText = "Start your story here"
                };
                Comment comment0 = new Comment() { CommentText = "The best Doctor Who story ever!" };
                comments.Add(comment0);
                submissions.Add(story);

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
                Story.AddSubmission(story);
            
        }
    }
}
