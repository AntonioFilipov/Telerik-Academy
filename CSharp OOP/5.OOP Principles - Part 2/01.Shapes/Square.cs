//Define class Square and suitable constructor so that at initialization height must be kept equal to width
//and implement the CalculateSurface() method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Square:Shape
    {
        public Square(double height):base(height,height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }

    }
}
