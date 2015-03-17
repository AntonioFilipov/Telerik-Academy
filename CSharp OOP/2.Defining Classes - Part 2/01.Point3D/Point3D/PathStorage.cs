//Problem 4. Path
//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    static class PathStorage
    {
        public static void SavePath(Path path, string pathIdentifier) //saves the file in the main project directory
        {                                                             //where all the .cs files are
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {
                for (int i = 0; i < path.Sequence.Count; i++)
                {
                    sw.WriteLine(path.Sequence[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.Add(nextPoint);
                }
            }

            return path;
        }
    }
}
