//Define abstract class Human with first name and last name.
//Define new class Student which is derived from Human and has new field – grade.
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour()
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.using System;

namespace _02.Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Alex", "Tankov", 2),
                new Student("Petur", "Ivanov", 2),
                new Student("Ivan", "Tonchev", 3),
                new Student("Anto", "Ivanov", 2),
                new Student("Niki", "Borisov", 1),
                new Student("Emo", "Besnqka", 3),
                new Student("Fikiqta", "Storaro", 5),
                new Student("Adi", "Vutova", 2),
                new Student("Mezdra", "Vutova", 1),
                new Student("Deqn", "Neshkov", 2)

            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Alex", "Tankov", 200, 20),
                new Worker("Petur", "Ivanov", 1231,1423),
                new Worker("Ivan", "Tonchev", 1,31),
                new Worker("Anto", "Ivanov", 223,1),
                new Worker("Niki", "Borisov", 113,122),
                new Worker("Emo", "Besnqka", 322,322),
                new Worker("Fikiqta", "Storaro", 43,2),
                new Worker("Adi", "Vutova", 2,21),
                new Worker("Mezdra", "Vutova", 141,12),
                new Worker("Deqn", "Neshkov", 143,32)

            };

            var sortedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Sorted students by grade:");
            Console.WriteLine(String.Join("\n",sortedStudents));
            Console.WriteLine();

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHours);
            Console.WriteLine("Sorted workers by money per hour:");
            Console.WriteLine(String.Join("\n", sortedWorkers));

            Console.WriteLine();
            Console.WriteLine("Merged list");
            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            foreach (var person in merged)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
