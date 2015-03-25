namespace _03.Animal_hierarchy
{
    using _03.Animal_hierarchy.Interfaces;
    using System;
    using System.Collections.Generic;

    class Kitten:Cat, ISound
    {
        public Kitten(string name, int age, Gender sex)
            : base(name, age, Gender.Female)
        {
        }
    }
}
