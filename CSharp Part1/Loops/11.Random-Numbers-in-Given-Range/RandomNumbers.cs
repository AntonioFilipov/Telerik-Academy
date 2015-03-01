/*Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/
using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        uint number = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        checked
        {
            try
            {
                do
                {
                    Console.Write("Enter n(n>0):");
                    number = uint.Parse(Console.ReadLine());
                } while (number<=0);


                Console.Write("Enter min (min < max):");
                min = int.Parse(Console.ReadLine());

                do
                {
                    Console.Write("Enter max(max > min):");
                    max = int.Parse(Console.ReadLine());
                } while (max <= min);

                Random rnd = new Random();

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(rnd.Next(min, max+1));
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

