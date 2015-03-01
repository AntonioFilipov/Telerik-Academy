/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that
the reminder of the division by 5 is 0.*/
using System;
using System.Collections.Generic;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        string firstStringNumber = String.Empty;
        string secondStringNumber = String.Empty;
        int firstNumber;
        int secondNumber;
        do
        {
            Console.Write("Enter first number:");
            firstStringNumber = Console.ReadLine();
        } while (!int.TryParse(firstStringNumber, out firstNumber) || firstNumber <= 0);

        do
        {
            Console.Write("Enter second number:");
            secondStringNumber = Console.ReadLine();
        } while (!int.TryParse(secondStringNumber, out secondNumber) || secondNumber <= 0);

        List<int> result = new List<int>();
        int counter = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                result.Add(i);
            }   
        }
        string joinedResult = string.Join(",", result.ToArray());
        Console.WriteLine("{0} numbers exist between {1} and {2}!", counter, firstNumber, secondNumber);
        Console.WriteLine(joinedResult);
    }
}

