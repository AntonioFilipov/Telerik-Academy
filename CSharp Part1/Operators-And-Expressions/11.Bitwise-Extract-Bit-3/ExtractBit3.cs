using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Bitwise_Extract_Bit_3
{
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            uint number = uint.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine((number>>3&1) == 0 ? 0:1);
        }
    }
}
