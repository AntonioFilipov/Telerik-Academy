using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students_and_workers
{
    class Student:Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade):base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Grade:{2}", this.FirstName, this.LastName, this.Grade);
        }
        

    }
}
