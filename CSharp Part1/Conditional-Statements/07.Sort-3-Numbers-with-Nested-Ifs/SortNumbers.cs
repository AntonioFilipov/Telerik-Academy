/*Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortNumbers
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

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }



    }
}

