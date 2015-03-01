/*Using loops write a program that converts an integer number to its binary representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
*/
using System;

class DecToBin
{
    static void Main(string[] args)
    {
        try
        {
            long decNumber = 0;
            string bitNumber = string.Empty;
            Console.Write("Enter decimal number:");
            decNumber = long.Parse(Console.ReadLine());

            while (decNumber >= 1)
            {
                bitNumber += (byte)(decNumber % 2);
                decNumber /= 2;
            }

            for (int i = bitNumber.Length-1; i >= 0; i--)
            {
                Console.Write(bitNumber[i]);
            }
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}

