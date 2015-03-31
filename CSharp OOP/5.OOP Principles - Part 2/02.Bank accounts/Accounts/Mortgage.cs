using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts.Accounts
{
    class Mortgage:BankAccount, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, double interestRate)
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

            if (this.CustomerType is Customers.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                return this.Balance * ((decimal)this.InterestRate / 100) * (months - 6);
            }

            if (months <= 12)
            {
                return (this.Balance * ((decimal)this.InterestRate / 100) * months) / 2;
            }
            return this.Balance * ((decimal)this.InterestRate / 100) * (months - 12) +
                (this.Balance * ((decimal)this.InterestRate / 100) * 6);
        }

    }
}
