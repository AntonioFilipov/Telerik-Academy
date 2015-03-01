/*Write a program that enters n integer n and prints the numbers 1, 2, …, n in random order.*/
using System;



class Randomize
{
    static void Main()
    {
        byte number = 0;
        checked
        {
            try
            {
                do
                {
                    Console.Write("Enter number:");
                    number = byte.Parse(Console.ReadLine());
                } while (number <= 0);

                Random rnd = new Random();
                for (int i = 0; i < number; i++)
                {
                    Console.Write(1 + rnd.Next(number)+ " ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

