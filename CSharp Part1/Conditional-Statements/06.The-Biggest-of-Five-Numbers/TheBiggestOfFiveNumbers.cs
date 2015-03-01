/*Write a program that finds the biggest of five numbers by using only five if statements.*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        string stringNumber = string.Empty;

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

        double d;
        do
        {
            Console.Write("Enter the fourth number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out d));

        double e;
        do
        {
            Console.Write("Enter the fifth number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out e));

        //double a = -3;
        //double b= -0.5;
        //double c= -1.1;
        //double d= -2;
        //double e= -0.1;

        double max = a;

        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        if (d > max)
        {
            max = d;
        }
        if (e > max)
        {
            max = e;
        }
        Console.WriteLine(max);

        //if (a >= b && a >= c && a>=d && a>=e)
        //{
        //    Console.WriteLine(a);
        //}
        //else if (b >= a && b >= c && b >= d && b >= e)
        //{
        //    Console.WriteLine(b);
        //}
        //else if (c >= a && c >= b && c >= d && c >= e)
        //{
        //    Console.WriteLine(c);
        //}
        //else if (d >= a && d >= b && d >= c && d >= e)
        //{
        //    Console.WriteLine(d);
        //}
        //else if (e >= a && e >= b && e >= c && e >= d)
        //{
        //    Console.WriteLine(e);
        //}
    }
}

