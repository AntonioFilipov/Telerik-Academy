using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Isosceles_Triangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine(@"
   {0}

  {0} {0}

 {0}   {0}

{0} {0} {0} {0}", symbol);
        }
    }
}
