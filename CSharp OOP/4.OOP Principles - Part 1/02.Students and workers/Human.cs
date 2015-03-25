//Define abstract class Human with first name and last name.
namespace _02.Students_and_workers
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName { get; set; }

        public string LastName { get; set; }
        

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
    }
}
