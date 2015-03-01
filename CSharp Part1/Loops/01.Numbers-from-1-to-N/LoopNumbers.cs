/*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
on a single line, separated by a space.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LoopNumbers
{
    static void Main()
    {
       
        int number = 0;
        try
        {
            checked
            {
                do
                {
                    Console.Write("Enter positive number:");
                    number = int.Parse(Console.ReadLine());
                } while (number <= 0);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

