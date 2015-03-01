/*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/
using System;
using System.Globalization;
using System.Numerics;

class FibonacciNumbers
{
    private static int Fibonacci(int number)
    {
        if (number == 0)
            return 0;
        else if (number == 1)
            return 1;
        else
            return Fibonacci(number - 1) + Fibonacci(number - 2);

    }

    static void Main()
    {
          
        string numberString = String.Empty;
        int number;
        do
        {
            Console.Write("Enter a number:");
            numberString = Console.ReadLine();
        } while (!int.TryParse(numberString, out number) || number <= 0);

        BigInteger[] fibonaciiNumbers = new BigInteger[Math.Max(number, 3)];

        for (int i = 0; i < number; i++)
        {
            fibonaciiNumbers[i] = Fibonacci(i);
        }
        Console.WriteLine(string.Join(" ",fibonaciiNumbers));
    }
}

