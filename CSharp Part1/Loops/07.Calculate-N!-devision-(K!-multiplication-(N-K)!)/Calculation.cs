/*Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/
using System;
using System.Numerics;

class Calculation
{
    static void Main()
    {
        byte n, k;
        BigInteger result;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;
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

                for (int p = 1; p <= n-k; p++)
			    {
			        nMinusKFactorial*=p;
			    }

                result = nFactorial / (kFactorial * nMinusKFactorial);
                Console.WriteLine(result);
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

