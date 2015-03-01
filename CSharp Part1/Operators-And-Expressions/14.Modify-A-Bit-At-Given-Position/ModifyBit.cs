using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Modify_A_Bit_At_Given_Position
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter a value(0|1):");
            byte value = byte.Parse(Console.ReadLine());
            Console.Write("Enter a position:");
            byte position = byte.Parse(Console.ReadLine());

            if ((number >> position & 1) != value)
            {
                Console.WriteLine(number ^ (1 << position));
            }
            else
                Console.WriteLine(number);

        }
    }
}
