using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1003; i++)
            {
                Console.WriteLine(i*Math.Pow(-1,i));

            }
        }
    }
}
