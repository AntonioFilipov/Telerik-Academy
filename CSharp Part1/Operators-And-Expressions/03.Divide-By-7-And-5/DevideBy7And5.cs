using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide_By_7_And_5
{
    class DevideBy7And5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number%5 == 0 && number%7 == 0 && number != 0 ? "True" : "False");
        }
    }
}
