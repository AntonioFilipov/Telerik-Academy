using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use \".\" for floating-point numbers!");
            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;
            Console.Write("Enter the width of rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Entet the height of rectangle:");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("The perimeter of the rectangle with width {0} and height {1} is {2}", width, height, perimeter);
            Console.WriteLine("The area of the rectangle with width {0} and height {1} is {2}", width, height, area);

        }
    }
}
