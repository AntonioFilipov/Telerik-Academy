using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Bits_Exchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number:");
            //int number = int.Parse(Console.ReadLine());
            UInt32 number = 2369124121;
            byte thirdBit = (byte)(number >> 3 & 1);
            byte fourthBit = (byte)(number >> 4 & 1);
            byte fifthBit = (byte)(number >> 5 & 1);
            byte twentyFourthBit = (byte)(number >> 24 & 1);
            byte twentyFifthBit = (byte)(number >> 25 & 1);
            byte twentySixthBit = (byte)(number >> 26 & 1);
            byte[] bitsArray = {thirdBit, fourthBit, fifthBit, twentyFourthBit, twentyFifthBit, twentySixthBit};
            UInt32 exchangedNumber = number;
            byte tempPosition = 23;
            for (int i = 0; i < bitsArray.Length/2; i++)
            {
                tempPosition++;
                if (bitsArray[i] != bitsArray[i+3])
                {
                    exchangedNumber = (UInt32)(exchangedNumber ^ 1 << tempPosition - 21);
                    exchangedNumber = (UInt32)(exchangedNumber ^ 1 << tempPosition);
                }
            }
             
            Console.WriteLine(exchangedNumber);
           
        }
    }
}
