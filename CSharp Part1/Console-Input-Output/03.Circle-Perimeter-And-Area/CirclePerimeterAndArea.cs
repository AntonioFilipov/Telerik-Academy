/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class CirclePerimeterAndArea
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;
        Console.WriteLine("Use . in flaoting point numbers!");
        string radiusAsString = String.Empty;
        double radius;
        do
        {
            Console.Write("Enter radius:");
            radiusAsString = Console.ReadLine();
        } while (!double.TryParse(radiusAsString, NumberStyles.Number, CultureInfo.InvariantCulture, out radius) || radius < 0.0);


        Console.WriteLine("The perimeter of circle with {0} radius is: {1:F2}", radius, 2 * Math.PI * radius);
        Console.WriteLine("The area of circle with {0} radius is: {1:F2}", radius, Math.PI * Math.Pow(radius, 2));
    }
}
