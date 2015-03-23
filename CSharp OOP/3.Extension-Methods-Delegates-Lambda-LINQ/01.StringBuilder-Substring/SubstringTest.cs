//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns
//new StringBuilder and has the same functionality as Substring in the class String.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilder_Substring
{
    class SubstringTest
    {
        static void Main(string[] args)
        {
            string input = "Tests extension method Substring of class StringBuilder";
            StringBuilder test = new StringBuilder(input);
            Console.WriteLine(test.Substring(0,5));
            Console.WriteLine(test.Substring(5, 7));
            Console.WriteLine(test.Substring(12, 3));
        }
    }
}
