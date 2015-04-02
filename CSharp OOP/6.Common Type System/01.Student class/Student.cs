using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using _01.Student_class.Enumerations;
using _01.Student_class.Interfaces;

namespace _01.Student_class
{
    class Student:IClonable, IComparablle<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public ESpecialties Speciality { get; set; }
        public EUniversities University { get; set; }
        public ESpecialties  Faculity { get; set; }


        public Student()
        {
        }

        public Student(string firstName, string middleName, string lastName, string ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;
            if (objAsStudent == null)
            {
                return false;
            }

            if (this.SSN != objAsStudent.SSN)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first,second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var field in this.GetType().GetRuntimeFields())
            {
                result.AppendLine(field.Name + ": " + field.GetValue(this));
            }

            return result.ToString();
        }      


        public object Clone()
        {
            var cloneStudent = new Student();
            cloneStudent.FirstName = this.FirstName;
            cloneStudent.MiddleName = this.MiddleName;
            cloneStudent.LastName = this.LastName;
            cloneStudent.SSN = this.SSN;
            cloneStudent.Address = this.Address;
            cloneStudent.Email = this.Email;
            cloneStudent.Course = this.Course;
            cloneStudent.Speciality = this.Speciality;
            cloneStudent.University = this.University;
            cloneStudent.Faculity = this.Faculity;
            return cloneStudent;
        }

        public int CompareTo(Student other)
        {
            string fullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = other.FirstName + other.MiddleName + other.LastName;
            var listNames = new List<string>() { fullName, otherFullName };
            var listSSN = new List<string>() { this.SSN, other.SSN};
            var firstName = listNames.OrderBy(x=>x).First().ToString();
            var firstSSN = listSSN.OrderBy(x => x).First().ToString();

            if (fullName == otherFullName)
            {
                if (firstSSN == this.SSN)
                {
                    return 1;
                }
                else if(firstSSN == otherFullName)
                {
                    return -1;
                }
            }
            else if (firstName == fullName)
            {
                return 1;
            }
            else if (firstName == otherFullName)
            {
                return -1;
            }

            return 0;
            
        }
    }
}
