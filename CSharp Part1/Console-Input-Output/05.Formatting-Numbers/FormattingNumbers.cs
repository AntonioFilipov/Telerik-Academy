/*Write a program that reads 3 numbers:
 * nteger a (0 <= a <= 500)
 * floating-point b
 * 
*/

/*The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
 * The number a should be printed in hexadecimal, left aligned
 * Then the number a should be printed in binary form, padded with zeroes
 * The number b should be printed with 2 digits after the decimal point, right aligned
 * The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class FormattingNumbers
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;
        Console.WriteLine("Use . in flaoting point numbers!");
        string stringNumber;

        int a;
        do
        {
            Console.Write("Enter the first number(integer from 0 to 500):");
            stringNumber = Console.ReadLine();
        }
        while (!int.TryParse(stringNumber, out a) || a < 0 || a > 500);

        double b;
        do
        {
            Console.Write("Enter the second number(floating-point):");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out b));

        double c;
        do
        {
            Console.Write("Enter the third number(floating-point):");
            stringNumber = Console.ReadLine();
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out c));

        Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|",a,Convert.ToString(a,2).PadLeft(10,'0'),b,c);
    }
}

