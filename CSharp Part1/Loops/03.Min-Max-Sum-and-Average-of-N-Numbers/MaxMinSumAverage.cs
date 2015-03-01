/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum 
and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxMinSumAverage
{
    static void Main()
    {
        
        int input = 0;
        try
        {
            checked
            {
                do
                {
                    Console.Write("How many number do you want to input:");
                    input = int.Parse(Console.ReadLine());
                } while (input <= 0);
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        int number;
        double sum = 0;
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter a number:");
            try
            {
                checked
                {
                    number = int.Parse(Console.ReadLine());
                }

                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }

                sum += number;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine("min=" + min);
        Console.WriteLine("max=" + max);
        Console.WriteLine("sum="+sum);
        Console.WriteLine("average= {0:N2}",sum / (double)input);
    }
}
