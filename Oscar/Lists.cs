using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscar
{
    public class Lists
    {
        public interface Ilist 
            public void List
        {
            var names = new List<string> {"ioana", "Ana", "Fiona"};
            foreach (var name in names)
        {
          Console.WriteLine($"hello {name.ToUpper()}!");
         }
        }
    }
}

