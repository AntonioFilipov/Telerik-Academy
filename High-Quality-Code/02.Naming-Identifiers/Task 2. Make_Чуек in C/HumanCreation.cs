using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Make_Чуек_in_C
{
    class HumanCreation
    {
        enum GenderType { Male, Female };

        class Human
        {
            public GenderType Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public Human CreateHuman(int uniqueNumber)
        {
            Human humanInstance = new Human();
            humanInstance.Age = uniqueNumber;
            if (uniqueNumber % 2 == 0)
            {
                humanInstance.Name = "Батката";
                humanInstance.Gender = GenderType.Male;
            }
            else
            {
                humanInstance.Name = "Мацето";
                humanInstance.Gender = GenderType.Female;
            }

            return humanInstance;
        }
        
        static void Main(string[] args)
        {
            var human = new HumanCreation();
            var person = human.CreateHuman(2);
            Console.WriteLine("Name: "+ person.Name);
            Console.WriteLine("Gender: "+person.Gender);
        }

    }
}
