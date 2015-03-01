/*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
 * Use the Euclidean algorithm (find it in Internet).
*/
using System;

class Gcd
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        int remainder=0;
        int devision = 0;
        checked
        {
            try
            {
                Console.Write("Enter a:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter b:");
                b = int.Parse(Console.ReadLine());
                if (a > b)
                {

                    do
                    {
                        remainder = a % b;
                        devision = a / b;
                        a = b;
                        b = remainder;
                    } while (b != 0);
                    
                    Console.WriteLine(a);
                }
                
                else if (b > a)
                {
                    do
                    {
                        remainder = b % a;
                        devision = b / a;
                        b = a;
                        a = remainder;
                    } while (a != 0);
                    Console.WriteLine(b);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

