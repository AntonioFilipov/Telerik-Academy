/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/
using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        string stringNumber;
        int number;
        do
        {
            Console.Write("Enter a number:");
            stringNumber = Console.ReadLine();
        } while (!int.TryParse(stringNumber, out number) || number <=0);

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

