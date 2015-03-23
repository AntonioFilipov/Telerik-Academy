//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10.Student_groups;

namespace _16.Groups
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Mathematics"),
                new Group(2, "Literature"),
                new Group(3, "Computer Science")
            };

            List<Student> studentList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 618332, "+358876546372", "ivan_ivanov@abv.bg", new List<decimal>{3,4,3,2,6}, 2),
                new Student("Peter", "Velkov", 612232, "+358876256332", "peter_velkov@abv.bg", new List<decimal>{3,3,4,2,2,5,6}, 2),
                new Student("Iordan", "Ganchev", 820106, "+3588234546354", "iordan_ganchev@abv.bg", new List<decimal>{6,6,6,6,3}, 1),
                new Student("Anto", "Ganchev", 803134, "+3588234546354", "anto_ganchev@abv.bg", new List<decimal>{6,3}, 2)
            };

            var studentsFromMathDpt =
               from someGroup in groups
               where someGroup.GroupNumber == 2
               join student in studentList on someGroup.GroupNumber equals student.GroupNumber
               select new // creating new anonymous class after matching group numbers from the Student class 
               {          // and the Group class to get Name from the Student instances and department from the Group ones 
                   Name = student.FirstName + " " + student.LastName,
                   Department = someGroup.DepartmentName
               };

            foreach (var student in studentsFromMathDpt)
            {
                Console.WriteLine(student);
            }

        }
    }
}
