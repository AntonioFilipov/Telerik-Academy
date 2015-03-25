//*Each teacher teaches a set of disciplines.
//*Teachers have name.
//*Both teachers and students are people. 
//*Students, classes, teachers and disciplines could have optional comments (free text block).

namespace _01.School_classes
{
    using System;
    using System.Collections.Generic;

    class Teacher:Person, IComment
    {
        //FIELDS
        private List<Discipline> setOfDesciplines;

        //PROPERTIES
        public List<Discipline> SetOfDesciplines
        {
            get { return setOfDesciplines; }
            set { setOfDesciplines = value; }
        }
        public string Comment { get; private set; }
        
        //CONSTRUCTORS
        public Teacher(string name):base(name)
        {
            this.SetOfDesciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> set):base(name)
        {
            this.SetOfDesciplines = set;
        }

        //Implementting IComment Interface
        void IComment.Comment(string text)
        {
            this.Comment = text;
        }
    }
}
