//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divisible_by_7_and_3
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 4, 3, 5, 3, 21, 7, 49, 9,42 };
            var linqExtension = input.Where(x => x % 3 == 0 && x % 7 == 0);
            var linqQuery = from num in input
                            where num % 3 == 0 && num % 7 == 0
                            select num;
            Console.WriteLine("Sort with LINQ extension method");
            foreach (var item in linqExtension)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sort with LINQ query");
            foreach (var item in linqQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
