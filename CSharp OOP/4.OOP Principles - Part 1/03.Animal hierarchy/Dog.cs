


namespace _03.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using _03.Animal_hierarchy.Interfaces;

    class Dog:Animal, ISound
    {
        public Dog(string name, int age, Gender sex):base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Bauuu!");
        }
    }
}
