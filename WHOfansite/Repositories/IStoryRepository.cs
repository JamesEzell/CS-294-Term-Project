using System.Collections.Generic;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public interface IStoryRepository
    {
        List<Story> Submissions { get; }

        void AddSubmission(Story submission);

        void AddComment(Comment comment);

        Story GetStoryByTitle(string title);

    }
}
