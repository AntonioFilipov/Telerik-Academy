using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prime_Number_Check
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number <= 1)
            {
                isPrime = false;
            }
            else if (number == 2 || number == 3)
            {
                isPrime = true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);

                
            
               
        }
    }
}
