using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10.Point_Inside_A_Circle_And_Outside_Of_A_Rectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use \".\" for floating-point numbers!");
            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;
            Console.Write("Enter x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;
            bool isInCircle = Math.Sqrt((Math.Abs(x) - 1.0) * (Math.Abs(x) - 1.0) + (Math.Abs(y) - 1.0) * (Math.Abs(y) - 1.0)) <= radius;
            //Console.WriteLine("Is in circle?"+isInCircle);
            bool isInRectangle = x >= -1 && x <= 5 && y <= 1 && y >= -1;
            //Console.WriteLine("Is in rectangle?"+isInRectangle);
            Console.WriteLine(isInCircle == true && isInRectangle == false ? "yes":"no");
        }
    }
}