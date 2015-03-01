/*Write an if-statement that takes two double variables a and b and exchanges their values
if the first one is greater than the second one. As a result print the values a and b, separated by a space.
*/
using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string stringNumber = String.Empty;
        Console.WriteLine("Use \".\" seaparator for floating-point numbers");

        double a;
        do
        {
            Console.Write("Enter first number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out a));

        double b;
        do
        {
            Console.Write("Enter second number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out b));

        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
            Console.WriteLine("{0} {1}", a, b);

    }
}

