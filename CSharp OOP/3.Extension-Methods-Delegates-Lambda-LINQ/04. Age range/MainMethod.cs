//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.First_before_last;
namespace _04.Age_range
{
    class MainMethod
    {
        public static IEnumerable<Student> AgeRange(Student[] array)
        {
            //var extension = array.Where(x => x.Age > 18 && x.Age < 24);
            var linq = from student in array
                       where student.Age > 18 && student.Age < 24
                       select student;
            return linq;
        }

        static void Main(string[] args)
        {
            Student[] arrayOfStudents = new Student[]
            {
                new Student("Peter","Georgiev",19),
                new Student("George", "Elvis",20),
                new Student("Boril", "Kocev",18),
                new Student("Filip", "Borislavov",60)
            };

            var list = AgeRange(arrayOfStudents);
            foreach (var item in list)
            {
                Console.WriteLine("First name:{0} \nLast name:{1}\nAge:{2}",item.FirstName,item.LastName,item.Age);
                Console.WriteLine();
            }
        }
    }
}
