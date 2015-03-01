using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Or_Even_Integers
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool isOdd = Math.Abs(number) % 2 == 1;
            Console.WriteLine("Is odd? {0}", isOdd);
        }
    }
}
