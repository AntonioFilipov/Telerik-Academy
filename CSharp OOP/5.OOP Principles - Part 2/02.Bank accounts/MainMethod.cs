//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months).
//In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
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
