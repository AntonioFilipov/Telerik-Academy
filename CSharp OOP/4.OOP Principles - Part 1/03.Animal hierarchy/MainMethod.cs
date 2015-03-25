using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animal_hierarchy
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog("Rex",3, Gender.Male),
                new Dog("Jorko",1, Gender.Male),
                new Dog("Pepa",3, Gender.Female),
                new Dog("Pesho",2, Gender.Male),

                new Frog("Jabko",1, Gender.Male),
                new Frog("Kikerica",2, Gender.Female),
                
                new Cat("Maca", 3, Gender.Female), 
                new Tomcat("Tom", 5,Gender.Female), 
                new Tomcat("Gosho", 3,Gender.Female),
                new Kitten("Puhcho", 1,Gender.Female)
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);

            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);
        }
    }
}
