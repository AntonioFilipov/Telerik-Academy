//Extract all students with phones in Sofia.
//Use LINQ.
using _10.Student_groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Extract_students_by_phone
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 61832, "0258876546372", "ivan_ivanov@abv.bg", new List<decimal>(){3,4,3,2,6}, 2),
                new Student("Peter", "Velkov", 61232, "+358876256332", "peter_velkov@gmail.bg", new List<decimal>(){3,3,4,5,6}, 2),
                new Student("Iordan", "Ganchev", 80134, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>(){6,6,6,6,3}, 1),
                new Student("Anto", "Ganchev", 80134, "02662736", "anto_ganchev@yahoo.bg", new List<decimal>(){6,6,6,6,3}, 2)
            };

            var result = from student in studentList
                         where student.Tel.StartsWith("02")
                         select student;

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
