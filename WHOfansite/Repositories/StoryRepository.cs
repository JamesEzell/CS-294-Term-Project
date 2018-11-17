using WHOfansite.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WHOfansite.Repositories
{
    public class StoryRepository : IStoryRepository
    {
        private ApplicationDbContext context;

        public IQueryable<Story> Submissions => context.Submissions;// Include("Comments");

        public IQueryable<Comment> Comments => context.Comments;


        public StoryRepository(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
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
