//Problem 3. Static class
//Write a static class with a static method to calculate the distance between two points in the 3D space.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    static class Distance
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            return Math.Sqrt((double)((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z)));
        }
    }
}
