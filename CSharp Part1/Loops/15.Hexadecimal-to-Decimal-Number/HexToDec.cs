/*Using loops write a program that converts a hexadecimal integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
 */
using System;

class HexToDec
{
    static void Main()
    {
        string hexNumber = string.Empty;
        byte digit = 0;
        long decNumber = 0;
        Console.WriteLine("Enter number in hex:");
        hexNumber = Console.ReadLine();
        for (int i = hexNumber.Length-1, k=0; i >= 0; i--, k++)
        {
            if ((byte.TryParse(Convert.ToString(hexNumber[i]), out digit) == true))
            {
                decNumber += (long)(digit * Math.Pow(16, k));
            }
            else
            {
                switch (hexNumber[i])
                {
                    case 'A': digit = 10; break;
                    case 'B': digit = 11; break;
                    case 'C': digit = 12; break;
                    case 'D': digit = 13; break;
                    case 'E': digit = 14; break;
                    case 'F': digit = 15; break;
                    default:
                        break;
                }
                decNumber += (long)(digit * Math.Pow(16, k));
            }
            
        }
        Console.WriteLine(decNumber);
    }
}

