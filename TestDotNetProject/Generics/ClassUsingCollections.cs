using System.Collections.Generic;
using System.Linq;

namespace TestDotNetProject.Generics
{
    public class ClassUsingCollections
    {
        public Dictionary<int, List<int>> GetDictionary()
        {
            var l = Enumerable.Range(1, 10).ToList();
            var res = new Dictionary<int, List<int>>();

            for (int i = 0; i < l.Count(); i++)
            {
                res.Add(i, l);    
            }

            return res;
        }
    }
}