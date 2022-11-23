using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.BalanceService
{
    internal class AccountBalances : IBalanceCalculator
    {
        private int _balance1;
        private int _deposit1;
        private int _account1;
        public int Balance1 
        {
           
            set { _balance1 = value; } 
        }
        public int Deposit1
        {
            
            set { _deposit1 = value;
                _account1 = _deposit1 + _balance1;
            }
        }
        

        private int _balance2;
        private int _deposit2;
        private int _account2;
        public int Balance2
        {
           
            set
            {
                _balance2 = value;
            }
        }
        public int Deposit2
        {
           
            set
            {
                _deposit2 = value;
                _account2 = _deposit2 + _balance2;
            }
        }
        public int Sum = 0;
        public string SumOfBalance()
        {
            Sum = _account1 + _account2;
            return $"Sum of Balance is: {Sum}";
        }

        public string BalanceAfterSpendings(int spending)
        {
            Sum = Sum - spending;
            return $"Balance after spendings: {Sum}.";
        }
    }
}
