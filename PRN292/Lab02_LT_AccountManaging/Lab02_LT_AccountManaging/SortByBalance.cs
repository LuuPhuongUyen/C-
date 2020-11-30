using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_AccountManaging
{
    class SortByBalance : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Balance.CompareTo(y.Balance);
        }
    }
}
