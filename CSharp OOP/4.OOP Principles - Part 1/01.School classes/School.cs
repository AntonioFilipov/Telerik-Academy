//We are given a school.
//*In the school there are classes of students.

namespace _01.School_classes
{
    using System;
    using System.Collections.Generic;

    class School
    {
        //FIELDS
        private List<Class> setOfClass;

        //PROPERTIES
        public List<Class> SetOfClass
        {
            get { return setOfClass; }
            set { setOfClass = value; }
        }

        //CONSTRUCTORS
        public School():this(new List<Class>())
        {

        }

        public School(List<Class> setOfClass)
        {
            this.SetOfClass = setOfClass;
        }
        
    }
}
