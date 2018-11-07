using System.Collections.Generic;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public interface IStoryRepositiory
    {
        List<Story> Submissions { get; }
        void AddSubmission(Story submission);

    }
}
