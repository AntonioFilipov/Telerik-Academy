//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//Use LINQ.
using _10.Student_groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Extract_students_by_marks
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 61832, "+358876546372", "ivan_ivanov@abv.bg", new List<decimal>{3,4,3,2,2}, 2),
                new Student("Peter", "Velkov", 61232, "+358876256332", "peter_velkov@abv.bg", new List<decimal>{3,3,4,5,6}, 2),
                new Student("Iordan", "Ganchev", 80134, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 1),
                new Student("Anto", "Ganchev", 80134, "+3588234546354", "anto_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 2)
            };

            var result = from student in studentList
                         where student.Marks.Contains(6)
                         select new
                         {
                             FullName = student.FirstName + " " + student.LastName,
                             Marks = student.Marks
                         };

            foreach (var item in result)
            {
                Console.WriteLine("{0} - Marks:{1}", item.FullName, string.Join(", ", item.Marks));
            }

        }
    }
}
