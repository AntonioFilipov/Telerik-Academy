//All animals can produce sound (specified by the ISound interface).
//All animals are described by age, name and sex.
//Kittens can be only female and tomcats can be only male.
//Each animal produces a specific sound.

namespace _03.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using _03.Animal_hierarchy.Interfaces;

    public abstract class Animal:ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public abstract void Sound();

    }
}
