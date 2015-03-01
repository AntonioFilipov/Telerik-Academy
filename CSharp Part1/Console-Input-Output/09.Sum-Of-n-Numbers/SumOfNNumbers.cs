/*Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
Note: You may need to use a for-loop.*/
using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;
        Console.WriteLine("Use . in flaoting point numbers!");
        string stringNumber = string.Empty;
        int n;
        do
        {
            Console.Write("Enter a number:");
            stringNumber = Console.ReadLine();     
        } while (!int.TryParse(stringNumber, out n) || n <= 0);

        double tempNumber;
        double sum = 0;

        try
        {
            checked
            {
                for (int i = 0; i < n; i++)
                {
                    do
                    {
                        Console.Write("Enter number to sum:");
                        stringNumber = Console.ReadLine();
                    } while (!double.TryParse(stringNumber, NumberStyles.Float, CultureInfo.CurrentCulture, out tempNumber));
                    sum += tempNumber;
                }
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }

        
        Console.WriteLine("Sum="+sum);
    }
}

