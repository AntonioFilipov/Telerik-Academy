using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;
            Console.WriteLine("Use \".\" for floating-point numbers!");
            Console.Write("Enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("S="+ (a+b)*h/2);
        }
    }
}
