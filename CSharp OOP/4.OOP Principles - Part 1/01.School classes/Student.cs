//*Students have name and unique class number.
//*Both teachers and students are people. 
//*Students, classes, teachers and disciplines could have optional comments (free text block).

namespace _01.School_classes
{
    using System;
    using System.Collections.Generic;

    class Student:Person, IComment
    {
        //FIELDS
        private int classNumber;

        //PROPERTIES
        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }
        public string Comment { get; private set; }

        //CONSTRUCTORS
        public Student():base()
        {

        }

        public Student(string name, int classNumber):base(name)
        {
            this.ClassNumber = classNumber;
        }

        //Implementting IComment Interface
        void IComment.Comment(string text)
        {
            this.Comment = text;
        }
        
    }
}
