namespace _01.School_classes
{
    using System;
    using System.Collections.Generic;

    class Person
    {
        //FIELDS
        private string name;

        //PROPERTIES
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Empty name!");
                }
                this.name = value;
            }
        }

        //CONSTRUCTORS
        public Person()
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
