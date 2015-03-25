//*In the school there are classes of students.
//*Each class has a set of teachers.
//*Classes have unique text identifier.
//Students, classes, teachers and disciplines could have optional comments (free text block).

namespace _01.School_classes
{
    using System;
    using System.Collections.Generic;

    class Class:IComment
    {
        //FIELDS
        private string textIdentifier;

        //PROPERTIES
        public List<Student> Student { get; set; }
        public List<Teacher> Teacher { get; set; }
        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier cannot be empty or null");
                }
                this.textIdentifier = value;
            }
        }
        public string Comment { get; private set; }

        //CONSTRUCTORS
        public Class()
        {
            this.Student = new List<Student>();
            this.Teacher = new List<Teacher>();
        }

        public Class(string textIdentifier):this(textIdentifier, new List<Student>(), new List<Teacher>())
        {

        }

        public Class(string textIdentifier, List<Student> students,List<Teacher> teachers)
        {
            this.TextIdentifier = textIdentifier;
            this.Student = students;
            this.Teacher = teachers;
        }

        //Implementting IComment Interface
        void IComment.Comment(string text)
        {
            this.Comment = text;
        }
    }
}
