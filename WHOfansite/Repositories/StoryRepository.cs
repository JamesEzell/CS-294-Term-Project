using WHOfansite.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WHOfansite.Repositories
{
    public class StoryRepository : IStoryRepository
    {
        private ApplicationDbContext context;

        public List<Story> Submissions
        {
            get
            {
                var submissions = context.Submissions;//.Include("Comments");
                return submissions.ToList<Story>();
            }
        }

        public List<Comment> Comments
        {
            get
            {
                var comments = context.Comments;
                return comments.ToList<Comment>();
            }
        }


        public StoryRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public void AddSubmission(Story submission)
        {
            context.Submissions.Update(submission);
            context.SaveChanges();
        }


        public void AddComment(Comment comment)
        {
            context.Comments.Update(comment);
            context.SaveChanges();
        }

        public Story GetStoryByTitle(string title)
        {
            Story submission = context.Submissions.First(s => s.Title == title);
            return submission;
        }
    }
}
