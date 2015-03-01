/*Write a program that gets two numbers from the console and prints the greater of them.
 * Try to implement this without if statements.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class NumberComparer
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
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out a));

        double b;
        do
        {
            Console.Write("Enter the second number:");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out b));

        Console.WriteLine("{0} > {1}", a>b ? a : b, a<b ? a:b);
    }

}

