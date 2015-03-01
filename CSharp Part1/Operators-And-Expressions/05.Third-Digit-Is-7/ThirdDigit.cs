using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_Digit_Is_7
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            number /= 100;
            Console.WriteLine(number%10 == 7 ? "True":"False");
        }
    }
}
