//Problem 1. Structure
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Problem 2. Static read-only field
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    struct Point3D
    {
        //----Fields----//
        private decimal x;
        private decimal y;
        private decimal z;
        private static readonly Point3D o = new Point3D(0,0,0);


        //---Constructor---//
        public Point3D(decimal x, decimal y, decimal z ):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //---Properties---//
        public decimal X {set; get;}
        public decimal Y {set; get;}
        public decimal Z {set; get;}
        public static Point3D O { get { return Point3D.o; } }

        //---Overriding---// 
        public override string ToString()
        {

            return String.Format("X:{0} Y:{1} Z:{2}",this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            decimal[] xyz = new decimal[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    decimal coord = decimal.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
