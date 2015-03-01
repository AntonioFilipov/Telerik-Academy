using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Point_In_A_Circle
{
    class CirclePoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use \".\" for floating-point numbers!");
            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;
            Console.Write("Enter x:");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            float y = float.Parse(Console.ReadLine());
            const byte radius = 2;
            Console.WriteLine(Math.Sqrt(x*x + y*y) > 2? false:true);
        }
    }
}
