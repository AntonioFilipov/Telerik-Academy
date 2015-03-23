//Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.Student_groups;

namespace _18.Grouped_by_GroupNumber
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 618332, "+358876546372", "ivan_ivanov@abv.bg", new List<decimal>{3,4,3,2,6}, 2),
                new Student("Peter", "Velkov", 612232, "+358876256332", "peter_velkov@abv.bg", new List<decimal>{3,3,4,2,2,5,6}, 2),
                new Student("Iordan", "Ganchev", 820106, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 1),
                new Student("Anto", "Ganchev", 803134, "+3588234546354", "anto_ganchev@abv.bg", new List<decimal>{6,3}, 2)
            };

            var groupedStudents = from student in studentList
                                  group student by student.GroupNumber
                                  into groups
                                  select new
                                  {
                                    Group = groups.Key,
                                    Students = groups.ToList()
                                  };

            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                    string.Join("\r\n\r\n", grouped.Students));
            }
        }
    }
}
