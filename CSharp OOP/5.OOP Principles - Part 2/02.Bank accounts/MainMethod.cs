using _02.Bank_accounts.Accounts;
using _02.Bank_accounts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
                                    {
                                        new Companies("PMG"),
                                        new Individual("Human"),
                                    };

            List<BankAccount> accounts = new List<BankAccount>()
                                            {
                                                new Deposit(customers[0],10001,6),
                                                new Loan(customers[1],200,10),
                                                new Mortgage(customers[0],12312,2),
                                            };

            
            foreach (var item in accounts)
            {
                item.AddDeposit(222);
                Console.WriteLine("Interst rate:"+item.CalculateInterest(30));
                Console.WriteLine(item);
            }

            Bank a = new Bank("BNB", accounts, customers);
        }
    }
}
