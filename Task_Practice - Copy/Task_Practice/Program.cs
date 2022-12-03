using System;
using Task_Practice.Controllers;

namespace Task_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountControllers accountController = new AccountControllers();
            accountController.Login();
        }
    }
}