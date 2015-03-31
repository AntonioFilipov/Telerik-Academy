//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of
//the figure (heightwidth for rectangle and heightwidth/2 for triangle).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle:Shape
    {
        public Triangle(double height, double width):base(height,width)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2.0;
        }

    }
}
