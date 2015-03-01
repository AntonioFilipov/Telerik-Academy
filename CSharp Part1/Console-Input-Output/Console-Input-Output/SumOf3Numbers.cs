/*Write a program that reads 3 real numbers from the console and prints their sum.*/
using System;
using System.Globalization;
using System.Threading;


class SumOf3Numbers
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;
        Console.WriteLine("Use . in flaoting point numbers!");
        string stringNumber = String.Empty;

        double a;
        do
        {
            Console.Write("Enter the first number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.AllowDecimalPoint, en, out a));

        double b;
        do
        {
            Console.Write("Enter the second number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.AllowDecimalPoint, en, out b));

        double c;
        do
        {
            Console.Write("Enter the third number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.AllowDecimalPoint, en, out c));
        Console.Write("Enter the first number:");

        double sum = 0;

        try
        {
            checked
            {
                sum = a + b + c;
            }

            Console.WriteLine("The sum of {0}, {1} and {2} equals to {3}.", a, b, c, sum);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

