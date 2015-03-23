//Extract all Marks of the students that enrolled in 2006. 
//(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
using _10.Student_groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Extract_marks
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

            var result = studentList.Where(x => x.FN / 10 % 10 == 0 && x.FN % 10 == 6);

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
