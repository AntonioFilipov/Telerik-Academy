//*Disciplines have name, number of lectures and number of exercises.
//Students, classes, teachers and disciplines could have optional comments (free text block).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_classes
{
    class Discipline:IComment
    {
        //FIELDS
        private string name;
        private int numberOfLecture;
        private int numberOfExercise;

        //PROPERTIES
        public int NumberOfExercise
        {
            get { return this.numberOfExercise; }
            set { this.numberOfExercise = value; }
        }
        
        public int NumberOfLecture
        {
            get { return this.numberOfLecture; }
            set { this.numberOfLecture = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Comment { get; set; }

        //CONSTRUCTORS
        public Discipline(string name, int numberOfLecture, int numberOfExercise)
        {
            this.Name = name;
            this.NumberOfLecture = numberOfLecture;
            this.NumberOfExercise = NumberOfExercise;
        }

        //Implementting IComment Interface
        void IComment.Comment(string text)
        {
            this.Comment = text;
        }
        
    }
}
