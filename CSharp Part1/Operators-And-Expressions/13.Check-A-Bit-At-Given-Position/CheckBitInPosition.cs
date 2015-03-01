using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Check_A_Bit_At_Given_Position
{
    class CheckBitInPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the position of bit you want to see:");
            byte bitPosition = byte.Parse(Console.ReadLine());
            Console.WriteLine(((number >> bitPosition & 1) == 1) ? true : false);
        }
    }
}
