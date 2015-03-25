namespace _03.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;

    class Tomcat:Cat
    {
        public Tomcat(string name, int age,Gender sex)
            : base(name, age, Gender.Male)
        {

        }
    }
}
