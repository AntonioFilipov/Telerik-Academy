using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts
{
    class Bank
    {
        public List<BankAccount> Accounts { get; set; }
        public List<Customer> Customers { get; set; }
        public string Name { get; set; }

        public Bank()
        {

        }

        public Bank(string name, List<BankAccount> accounts, List<Customer> customers)
        {
            this.Name = name;
            this.Accounts = accounts;
            this.Customers = customers;
        }
    }
}
