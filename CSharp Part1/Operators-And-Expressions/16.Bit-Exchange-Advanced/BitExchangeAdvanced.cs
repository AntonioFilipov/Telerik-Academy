using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Bit_Exchange_Advanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            uint number=0;
            try
            {
                Console.Write("Enter number:");
                number = uint.Parse(Console.ReadLine());
                Console.Write("Enter position P: ");
                sbyte p = sbyte.Parse(Console.ReadLine());
                Console.Write("Enter position Q: ");
                sbyte q = sbyte.Parse(Console.ReadLine());
                Console.Write("Enter step K: ");
                sbyte k = sbyte.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)
            {

                Console.WriteLine(ex);
            }
            
            //uint number = 3333333333;
            //sbyte p = -1;
            //sbyte q = 0;
            //sbyte k = 33;
            if(p+k > 32 || q+k > 32)
            {
                Console.WriteLine("Out of range");
            }
            else if ((p < k && p + k >= q) || (p > k && q + k >= p))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                List<sbyte> pArray = new List<sbyte>();
                for (int i = p; i < p + k; i++)
                {
                    pArray.Add((sbyte)(number >> i & 1));
                }

                List<sbyte> qArray = new List<sbyte>();
                for (int i = q; i < q + k; i++)
                {
                    qArray.Add((sbyte)(number >> i & 1));
                }

                uint exchangedNumber = number;
                for (int i = 0; i < k; i++)
                {
                    if (pArray[i] != qArray[i])
                    {
                        exchangedNumber = (uint)(exchangedNumber ^ (1 << p));
                        exchangedNumber = (uint)(exchangedNumber ^ (1 << q));
                    }
                    p++;
                    q++;
                }
                Console.WriteLine(exchangedNumber);
            }
         }
    }
}
