/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class QuadraticEquation
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;
        Console.WriteLine("Use . in flaoting point numbers!");
        string stringNumber = string.Empty;
        double a;
        do
        {
            Console.Write("Enter a(a != 0):");
            stringNumber = Console.ReadLine();
        }
        while(!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out a) || a==0);
        Console.WriteLine(a);

        double b;
        do
        {
            Console.Write("Enter b:");
            stringNumber = Console.ReadLine();
        }
        while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out b));

        double c;
        do
        {
            Console.Write("Enter c:");
            stringNumber = Console.ReadLine();
        }
        while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out c));

        double descr = 0;
        try
        {
            checked
            {
                descr = b * b - 4 * a * c;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
       
        double x1, x2;
        if (descr >= 0)
        {
            x1 = (-b - Math.Sqrt(descr)) / (2 * a);
            x2 = (-b + Math.Sqrt(descr)) / (2 * a);
            Console.WriteLine("x1=" + x1);
            Console.WriteLine("x2=" + x2);
        }
        else
            Console.WriteLine("No real roots");
                      
            
    }
}

