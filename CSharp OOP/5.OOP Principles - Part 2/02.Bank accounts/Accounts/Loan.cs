using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts.Accounts
{
    class Loan:BankAccount, IDepositable
    {

        public Loan():base()
        {

        }
        public Loan(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override void AddDeposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if ((this.CustomerType is Customers.Individual && months <= 3) || (this.CustomerType is Customers.Companies && months <= 2))
            {
                return 0;
            }

            return this.Balance * ((decimal)this.InterestRate / 100) * (months - (CustomerType is Customers.Individual ? 3 : 2));
        }        
    }
}
