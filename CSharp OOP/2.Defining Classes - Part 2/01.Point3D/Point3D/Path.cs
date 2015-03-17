//Problem 4. Path
//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Path
    {
        //----Fields----//
        private List<Point3D> sequence;

        //---Constructor---//
        public Path()
        {
            this.Sequence = new List<Point3D>();
        }

        //---Properties---//
        public List<Point3D> Sequence
        {
            get { return this.sequence; }
            private set { this.sequence = value; }
        }

        //---Adding point---//
        public void Add(Point3D point)
        {
            this.Sequence.Add(point);
        }
    }
}
