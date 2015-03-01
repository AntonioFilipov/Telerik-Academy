/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine(new String('-',22));
        Console.WriteLine("1--->int");
        Console.WriteLine("2--->double");
        Console.WriteLine("3--->string");
        Console.WriteLine(new String('-', 22));
        Console.Write("Please choose a type:");
        byte number = 0;
        try
        {
            checked
            {
                number = byte.Parse(Console.ReadLine());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        switch (number)
        {
            case 1: 
                Console.Write("Please enter a int number:");
                int intNumber = 0;
                try
                {
                    checked
                    {
                        intNumber = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(intNumber+1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;

            case 2:
                Console.Write("Please enter a double number(use \".\" separator):");
                string doubleInput;
                double doubleNumber;
                doubleInput = Console.ReadLine();
                if (!double.TryParse(doubleInput, NumberStyles.Float, CultureInfo.InvariantCulture, out doubleNumber))
                {
                    Console.WriteLine("Wrong input!");
                }
                else
                {
                    Console.WriteLine(doubleNumber+1.0);
                }
                break;

            case 3:
                Console.Write("Please enter a string:");
                string input = Console.ReadLine();
                Console.WriteLine(input+'*');
                break;
            default:
                break;
        }
       
    }
}

