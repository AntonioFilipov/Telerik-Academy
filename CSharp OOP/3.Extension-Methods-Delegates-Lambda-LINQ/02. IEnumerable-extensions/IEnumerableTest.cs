//Implement a set of extension methods for IEnumerable<T> that implement the following
//group functions: sum, product, min, max, average.
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerable_extensions
{
    class IEnumerableTest
    {
        static void Main(string[] args)
        {
            var listInt = new List<int> { 1, 2, 3, 4, 5 };
            Console.Write("Sum:");
            Console.WriteLine(listInt.Sum());

            Console.Write("Product:");
            Console.WriteLine(listInt.Product());

            Console.Write("Min:");
            Console.WriteLine(listInt.Min());

            Console.Write("Max:");
            Console.WriteLine(listInt.Max());

            Console.Write("Average:");
            Console.WriteLine(listInt.Average());


        }
    }
}
