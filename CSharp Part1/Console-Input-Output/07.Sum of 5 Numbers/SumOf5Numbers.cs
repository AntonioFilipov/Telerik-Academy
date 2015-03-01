/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/
using System;
using System.Globalization;
using System.Threading;

class SumOf5Numbers
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;
        Console.WriteLine("Use . in flaoting point numbers!");
        string input = Console.ReadLine();
        string[] splitedInput = input.Split(' ');
        if (splitedInput.Length != 5)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            double sum = 0;
            foreach (var item in splitedInput)
            {
                sum += Convert.ToDouble(item);
            }
            Console.WriteLine("Sum=" + sum);
        }
    }
}

