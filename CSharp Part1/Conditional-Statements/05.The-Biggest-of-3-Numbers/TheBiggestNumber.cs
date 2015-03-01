/*Write a program that finds the biggest of three numbers.*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheBiggestNumber
{
    static void Main()
    {
        string stringNumber = String.Empty;
        Console.WriteLine("Use \".\" separatiot for floating-point numbers!");

        double a;
        do
        {
            Console.Write("Enter the first number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out a));

        double b;
        do
        {
            Console.Write("Enter the second number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out b));

        double c;
        do
        {
            Console.Write("Enter the third number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out c));

        double max = a;
        if (b>max)
        {
            max = b;
        }
        if (c>max)
        {
            max = c;
        }

        Console.WriteLine(max);
    }
        
}

