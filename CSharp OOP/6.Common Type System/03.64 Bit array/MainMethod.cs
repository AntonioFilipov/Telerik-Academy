using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._64_Bit_array
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            var testNumber = new BitArray64(254);

            Console.WriteLine(string.Join("", testNumber.BitArray));

            Console.WriteLine(testNumber[60]);
            Console.WriteLine(testNumber[5]);

            foreach (var bit in testNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            var testNumber2 = new BitArray64(254);
            var testNumber3 = new BitArray64(122);

            Console.WriteLine(testNumber.Equals(testNumber2));
            Console.WriteLine(testNumber.Equals("11111110"));
            Console.WriteLine(testNumber.Equals(testNumber3));
            Console.WriteLine(testNumber == testNumber2);
            Console.WriteLine(testNumber != testNumber3);
        }
    }
}
