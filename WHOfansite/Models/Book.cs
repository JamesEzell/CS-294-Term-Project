using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Book : IEnumerable<Book>
    {
        private static List<Book> books = new List<Book>();

        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime PubDate { get; set; }

        public static List<Book> Books { get { return books; } }

        public interface IEnumerable<Book>
        {
            IEnumerator<Book> GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book b in books)
            {
                yield return b;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
