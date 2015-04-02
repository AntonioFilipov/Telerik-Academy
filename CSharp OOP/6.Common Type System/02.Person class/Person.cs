using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person_class
{
    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name:{0}\nAge:{1}", this.Name, "not specified");
            }

            return string.Format("Name:{0}\nAge:{1}", this.Name, this.Age);
            
            
            
        }
    }
}
