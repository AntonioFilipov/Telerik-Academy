using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts.Accounts
{
    public interface IWithDrawable
    {
        void Withdraw(decimal amount);
    }
}
