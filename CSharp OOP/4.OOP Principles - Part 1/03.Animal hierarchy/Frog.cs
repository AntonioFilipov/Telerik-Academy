namespace _03.Animal_hierarchy
{
    using _03.Animal_hierarchy.Interfaces;
    using System;
    using System.Collections.Generic;

    class Frog:Animal, ISound
    {

        public Frog(string name, int age, Gender sex):base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Frogrrr!");
        }
    }
}
