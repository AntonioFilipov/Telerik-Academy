//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Longest_string
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "dasd", "dsa", "maxString", "1" };

            var result = (from item in array
                         orderby item.Length descending
                         select item).ToArray();

            Console.WriteLine("String with max length:{0}",result[0]);
        }
    }
}
