/*Using loops write a program that converts a binary integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
*/
using System;


class BinToDec
{
    static void Main()
    {
        string binaryNumber = string.Empty;
        byte bit = 0;
        long decNumber = 0;
        Console.Write("Enter binary number:");
        //binaryNumber = "1010101010101011";
        binaryNumber = Console.ReadLine();
        for (int i = binaryNumber.Length -1 , k = 0; i >= 0 ; i--, k++)
        {
            bit = byte.Parse(Convert.ToString(binaryNumber[i]));
            decNumber += (long)(bit * Math.Pow(2, k));
        }
        Console.WriteLine(decNumber);
    }
}

