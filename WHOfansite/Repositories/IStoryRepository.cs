using System.Collections.Generic;
using System.Linq;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public interface IStoryRepository
    {
        IQueryable<Story> Submissions { get; }

        IQueryable<Comment> Comments { get; }

        void AddSubmission(Story submission);

        void AddComment(Comment comment);

        Story GetStoryByTitle(string title);

    }
}
