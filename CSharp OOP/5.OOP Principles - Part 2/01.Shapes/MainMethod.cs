//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of
//the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width
//and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes
//(Square, Rectangle, Triangle) stored in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Shape[] shape =
                            {
                                new Rectangle(3,4),
                                new Triangle(3,4),
                                new Square(3),
                            };

            foreach (var item in shape)
            {
                Console.WriteLine("{0} area: {1}",item.GetType().Name, item.CalculateSurface());
            }
        }
    }
}
