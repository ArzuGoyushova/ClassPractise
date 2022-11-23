using BankAccount.BalanceService;
using System;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountBalances balance = new AccountBalances();
            Console.Write("Balance1: ");
            balance.Balance1=int.Parse(Console.ReadLine());
            Console.Write("Deposit1: ");
            balance.Deposit1=int.Parse(Console.ReadLine());
            Console.Write("Balance2: ");
            balance.Balance2=int.Parse(Console.ReadLine());
            Console.Write("Deposit2: ");
            balance.Deposit2=int.Parse(Console.ReadLine());
            Console.WriteLine(balance.SumOfBalance());
            Console.WriteLine(balance.BalanceAfterSpendings(30));
        }
    }
}
