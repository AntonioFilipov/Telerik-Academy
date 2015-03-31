using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Bank_accounts.Customers;
using _02.Bank_accounts.Accounts;

namespace _02.Bank_accounts
{
    public abstract class BankAccount
    {
        private Customer customerType;
        private decimal balance;
        private double  interestRate;

        public BankAccount()
        {

        }

        public BankAccount(Customer customer, decimal balance, double interestRate)
        {
            this.CustomerType = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public double  InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public Customer CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * ((decimal)this.InterestRate / 100) * months;
        }

        public abstract void AddDeposit(decimal amount);


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Customer:" + this.CustomerType);
            str.AppendLine("Balance:" + this.Balance);
            str.AppendLine("Interest rate:" + this.InterestRate);
            return str.ToString();
        }
        
    }
}
