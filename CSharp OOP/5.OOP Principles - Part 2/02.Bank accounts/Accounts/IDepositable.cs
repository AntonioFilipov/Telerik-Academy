using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts.Accounts
{
    interface IDepositable
    {
        void AddDeposit(decimal amount);
    }
}
