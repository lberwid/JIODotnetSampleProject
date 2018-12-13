using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDotNetProject
{
    public class PropertyClass
    {
        public PropertyClass()
        {
            this.b = 3;
        }

        public int a { get; set; }
        public int b { get; private set; }
        public int c { get; }
    }
}
