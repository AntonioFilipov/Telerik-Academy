using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine(i * Math.Pow(-1, i));
            }
        }
    }
}
