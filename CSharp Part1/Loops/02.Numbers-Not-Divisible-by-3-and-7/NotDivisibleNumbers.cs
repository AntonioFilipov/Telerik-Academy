/*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7,
on a single line, separated by a space.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NotDivisibleNumbers
{
    static void Main()
    {
        string strNumber;
        int number;
        do
        {
            Console.Write("Enter a positive number:");
            strNumber = Console.ReadLine();
        } while (!int.TryParse(strNumber, out number) || number <= 0);

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0 )
            {
                Console.Write(i+" ");
            }
        }
        Console.WriteLine();
    }
}

