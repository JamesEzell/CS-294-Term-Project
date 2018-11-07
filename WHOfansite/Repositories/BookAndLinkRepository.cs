using System.Collections.Generic;
using WHOfansite.Models;

namespace WHOfansite.Repositories
{
    public class BookAndLinkRepository
    {
        public static List<Book> Books { get; } = new List<Book>();
        public static List<Link> Links { get; } = new List<Link>();
    }
}
