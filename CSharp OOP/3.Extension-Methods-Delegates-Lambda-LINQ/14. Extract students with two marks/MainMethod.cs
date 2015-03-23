//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.
using _10.Student_groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Extract_students_with_two_marks
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 61832, "+358876546372", "ivan_ivanov@abv.bg", new List<decimal>{3,4,3,2,6}, 2),
                new Student("Peter", "Velkov", 61232, "+358876256332", "peter_velkov@abv.bg", new List<decimal>{3,3,4,2,2,5,6}, 2),
                new Student("Iordan", "Ganchev", 80134, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 1),
                new Student("Anto", "Ganchev", 80134, "+3588234546354", "anto_ganchev@abv.bg", new List<decimal>{6,3}, 2)
            };

            var result = studentList.Where(x => x.Marks.Count(m => m == 2) == 2);

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
