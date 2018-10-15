using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WHOfansite.Models
{
    public class Links : IEnumerable<Links>
    {
        private static List<Links> pageLinks = new List<Links>();

        public string PageTitle { get; set; }
        public string PageUrl { get; set; }
        public string PageInfo { get; set; }

        public static List<Links> PageLinks { get { return pageLinks; } }

        public interface IEnumerable<Link>
        {
            IEnumerator<Links> GetEnumerator();
        }

        public IEnumerator<Links> GetEnumerator()
        {
            foreach (Links l in pageLinks)
            {
                yield return l;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
