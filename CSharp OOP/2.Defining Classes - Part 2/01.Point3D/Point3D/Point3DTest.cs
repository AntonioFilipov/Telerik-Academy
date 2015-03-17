//Problem 1. Structure
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Problem 2. Static read-only field
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

//Problem 3. Static class
//Write a static class with a static method to calculate the distance between two points in the 3D space.

//Problem 4. Path
//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3DTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D point = new Point3D(2, 3, 4);
            Point3D point1 = new Point3D(5, 6, 7);
            Path path = new Path();
            path.Add(point);
            path.Add(point1);
            PathStorage.SavePath(path, "test");
            Path loadedPath = PathStorage.LoadPath(@"../../pathtest.txt");
            for (int i = 0; i < loadedPath.Sequence.Count; i++)
            {
                Console.WriteLine(loadedPath.Sequence[i]);
            }

            Point3D staticPoint = Point3D.O;
            Console.WriteLine(staticPoint.ToString());
            Console.WriteLine("Distance:{0}",Distance.CalculateDistance(point, point1));
           
           
        }
    }
}
