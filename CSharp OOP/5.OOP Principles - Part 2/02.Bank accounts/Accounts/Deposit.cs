using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts.Accounts
{
    class Deposit:BankAccount, IDepositable, IWithDrawable
    {

        public Deposit():base()
        {

        }

        public Deposit(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override void AddDeposit(decimal amount)
        {
            this.Balance += amount;
        }

       
        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Withdrawal amount cannot excede available balance");
            }
            this.Balance -= amount;
        }
           
        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be < 0");
            }

            if (this.Balance < 1000)
            {
                return 0;
            }
            return this.Balance * ((decimal)this.InterestRate / 100) * months;
        }


    }
}
