/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 * Use a sequence of if operators.
*/

using System;
using System.Globalization;

class MultiplicationSign
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
        } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.InvariantCulture, out a ));

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

        char[] signs = new char[3];
        //----------------------------
        if (a > 0)
        {
            signs[0] = '+';
        }
        else if (a<0)
        {
            signs[0] = '-';
        }
        else
        {
            signs[0] = '0';
        }
        //----------------------------
        if (b > 0)
        {
            signs[1] = '+';
        }
        else if (b < 0)
        {
            signs[1] = '-';
        }
        else
        {
            signs[1] = '0';
        }
        //----------------------------
        if (c > 0)
        {
            signs[2] = '+';
        }
        else if (c < 0)
        {
            signs[2] = '-';
        }
        else
        {
            signs[2] = '0';
        }

        int minusCounter = 0;
        int zeroCounter = 0;
        for (int i = 0; i < signs.Length; i++)
        {
            if (signs[i] == '-')
            {
                minusCounter++;
            }
            else if (signs[i] == '0')
            {
                zeroCounter++;
                break;
            }
        }

        if (minusCounter % 2 == 1)
        {
            Console.WriteLine('-');
        }
        else if (zeroCounter == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine('+');
        }

    }
}

