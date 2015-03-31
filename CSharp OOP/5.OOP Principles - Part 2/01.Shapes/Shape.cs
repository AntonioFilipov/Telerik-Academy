//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public abstract class Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Shape(double height, double width)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();

    }
}
