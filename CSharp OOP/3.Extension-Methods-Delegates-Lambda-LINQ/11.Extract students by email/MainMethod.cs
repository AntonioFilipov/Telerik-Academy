//Extract all students that have email in abv.bg.
//Use string methods and LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _10.Student_groups;
namespace _11.Extract_students_by_email
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 61832, "+358876546372", "ivan_ivanov@abv.bg", new List<decimal>{3,4,3,2,6}, 2),
                new Student("Peter", "Velkov", 61232, "+358876256332", "peter_velkov@gmail.bg", new List<decimal>{3,3,4,5,6}, 2),
                new Student("Iordan", "Ganchev", 80134, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 1),
                new Student("Anto", "Ganchev", 80134, "+3588234546354", "anto_ganchev@yahoo.bg", new List<decimal>{6,6,6,6,3}, 2)
            };

            var result = studentList.Where(x => x.Email.Contains("abv.bg"));

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
