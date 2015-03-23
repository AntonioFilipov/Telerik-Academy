//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.First_before_last;


namespace _05.Order_students
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Student[] arrayOfStudents = new Student[]
            {
                new Student("Peter","Georgiev",12),
                new Student("George", "Elvis",20),
                new Student("George", "Georgiev",20),
                new Student("Boril", "Kocev",18),
                new Student("Filip", "Borislavov",60)
            };

            var resultExtension = arrayOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine("Sort with LINQ extension method");
            foreach (var item in resultExtension)
            {
                Console.WriteLine("First name:{0} | Last name:{1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("Sort with LINQ query");
            var linq = from student in arrayOfStudents
                       orderby student.FirstName descending, student.LastName descending
                       select student;
            foreach (var item in linq)
            {
                Console.WriteLine("First name:{0} | Last name:{1}", item.FirstName, item.LastName);
            }
        }
    }
}
