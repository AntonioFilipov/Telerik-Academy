/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 * Use only one loop.
*/

using System;

class Calculation
{
    static void Main()
    {
        byte n, k;
        decimal result;
        decimal nFactorial = 1;
        decimal kFactorial = 1;
        checked
        {
            try
            {
                do
                {
                    Console.Write("Enten n[1..100]:");
                    n = byte.Parse(Console.ReadLine());
                } while (n < 1 || n > 100);

                do
                {
                    Console.Write("Enten k[1..{0}]:", n);
                    k = byte.Parse(Console.ReadLine());
                } while (k < 1 || k >= n);

                for (int i = 1, j = 1; i <= n; i++, j++)
                {
                    nFactorial *= i;
                    if (j <= k)
                    {
                        kFactorial *= j;
                    }

                }
                result = nFactorial / kFactorial;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}

