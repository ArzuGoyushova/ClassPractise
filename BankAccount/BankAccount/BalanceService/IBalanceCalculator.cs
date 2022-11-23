using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.BalanceService
{
    internal interface IBalanceCalculator
    {
        string SumOfBalance();
        string BalanceAfterSpendings(int spending);
    }
}
