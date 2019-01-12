using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            if (!context.Submissions.Any())
            {
                User user = new User { FirstName = "Issac", LastName = "Ishimura" };
                context.Users.Add(user);

                Story submission = new Story
                {
                    Title = "The Invasion of Time",
                    Date = DateTime.Parse("2/4/1978"),
                    StoryText = "Start your story here"
                };
                context.Submissions.Add(submission);

                Comment comment = new Comment
                {
                    Commentor = user,
                    CommentText = "The best Doctor Who story ever!",

                };
                submission.Comments.Add(comment);
                context.Comments.Add(comment);

                Story submission1 = new Story
                {
                    Title = "The Caves of Androzani",
                    Date = DateTime.Parse("3/8/1984"),
                    StoryText = "Start your story here"
                };
                context.Submissions.Add(submission1);

                Story submission2 = new Story
                {
                    Title = "The Pirate Planet",
                    Date = DateTime.Parse("30/9/1978"),
                    StoryText = "Start your story here"
                };
                context.Submissions.Add(submission2);

                Story submission3 = new Story
                {
                    Title = "The Twin Dilemma",
                    Date = DateTime.Parse("22/3/1984"),
                    StoryText = "Start your story here"
                };
                context.Submissions.Add(submission3);

                context.SaveChanges(); 
            }
        }
    }
}
