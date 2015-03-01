/*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
 * our program should work well for very big numbers, e.g. n=100000.
 */
using System;
using System.Numerics;

class TrailinfZeroes
{
    static void Main()
    {
        long number;
        BigInteger factorial = 1;
        try
        {
            Console.Write("Enter number:");
            number = long.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            string strNumber = Convert.ToString(factorial);
            int counter = 0;
            for (int i = strNumber.Length-1; i >= 0; i--)
            {
                if (strNumber[i]=='0')
                {
                    counter++;
                }
                else
                {
                    break;
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("No trailing zeroes!");
            }
            else
            {
                Console.WriteLine(counter);
            }
     
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

