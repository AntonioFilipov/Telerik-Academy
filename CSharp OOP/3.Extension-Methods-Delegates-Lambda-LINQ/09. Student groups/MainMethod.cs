//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Student_groups
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 61832, "+358876546372", "ivan_ivanov@abv.bg", new List<decimal>{3,4,3,2,6}, 2),
                new Student("Peter", "Velkov", 61232, "+358876256332", "peter_velkov@abv.bg", new List<decimal>{3,3,4,5,6}, 2),
                new Student("Iordan", "Ganchev", 80134, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 1),
                 new Student("Anto", "Ganchev", 80134, "+3588234546354", "anto_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 2)
            };

            Console.WriteLine("Students from group 2");
            var groutpTwo = from student in studentList
                            where student.GroupNumber == 2
                            orderby student.FirstName
                            select student;

            foreach (var item in groutpTwo)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
