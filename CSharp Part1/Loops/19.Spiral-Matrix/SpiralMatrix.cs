/*Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers
 * from 1 to n*n in the form of square spiral like in the examples below.
*/
using System;
using System.Collections.Generic;

class SpiralMatrix
{
    static void Main()
    {
        int number;
        try
        {
            Console.Write("Enter a number(1..20):");
            number = int.Parse(Console.ReadLine());
            if (number <= 1 || number >= 20)
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            List<string> spiral = new List<string>();
            int counter = 0;
            int iterator = number;
            int k=1;
            for (int i = 1; i <= number * number; i++)
            {

                if (k < 2)
                {
                    if (counter < iterator)
                    {
                        spiral.Add(i.ToString());
                        counter++;
                    }
                    else
                    {
                        spiral.Add(";");
                        counter = 0;
                        k++;
                        i--;
                    }
                }
                else
                {
                    k = 0;
                    iterator--;
                    counter = 0;
                    i--;
                }

            }
            string strSpiral = string.Join("  ", spiral.ToArray());
            string[] spiralParts = strSpiral.Split(';');
            int reverseCounter=0;
            for (int i = 0; i < spiralParts.Length; i++)
            {
                counter++;
                if (i%2==1)
                {
                    if (counter < 2)
                    {
                        foreach (var item in spiralParts[i])
                        {
                            Console.WriteLine("{0,10}", item);
                        }
                        counter++;
                    }
                    else
                    {
                        for (int j = spiralParts[i].Length-1; j >= 0; j--)
                        {
                            Console.Write(j);
                        }
                    }
                   
                }
                else
                    Console.WriteLine("{0}", spiralParts[i]);
            }
            //foreach (var item in spiral)
            //{
            //    Console.WriteLine(item);
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

