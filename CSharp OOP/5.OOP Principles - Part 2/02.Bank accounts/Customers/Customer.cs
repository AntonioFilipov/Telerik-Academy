using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts
{
    public abstract class Customer
    {
        public string Name { get; set; }

        public Customer()
        {
        }

        public Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("Name:{0}", this.Name);
        }
    }
}
