/*Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below.
Use two nested loops.
*/
using System;


class Matrix
{
    static void Main()
    {
        byte n;
        try 
	    {
            do
            {
                Console.Write("Enter number[1..20]:");
                n = byte.Parse(Console.ReadLine());
            } while (n<1 || n > 20);

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row ; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            
	    }
	    catch (Exception ex)
	    {
            Console.WriteLine(ex.Message);
	    }
    }
}

