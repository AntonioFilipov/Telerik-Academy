//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_before_last
{
    class MainMethod
    {
        static IEnumerable<Student> Alphabetically(Student[] array)
        {
            //var extension = array.Where(x => x.LastName.CompareTo(x.FirstName) > 0);
            var linqQuery = from student in array
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;
            return linqQuery;
        }

        static void Main(string[] args)
        {
            Student[] arrayOfStudents = new Student[]
            {
                new Student("Peter","Georgiev"),
                new Student("George", "Elvis"),
                new Student("Boril", "Kocev"),
                new Student("Filip", "Borislavov")

            };  

            var sortedList = Alphabetically(arrayOfStudents);

            foreach (var item in sortedList)
            {
                System.Console.WriteLine("First name:{0} \nLast name:{1}",item.FirstName, item.LastName);
                System.Console.WriteLine();
            }


        }
    }
}
