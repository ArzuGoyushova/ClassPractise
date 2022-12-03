using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_Practice.Controllers
{
    public class AccountControllers
    {
        public void Login()
        {
            Console.WriteLine("Please add your email:");
            string email = Console.ReadLine();
            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                Console.WriteLine("Please add your email correctly:");
                email = Console.ReadLine();
            }
            Console.WriteLine("Please add your password:");
            string password = Console.ReadLine();

            int role = 0;

            IAccount account = new Account();
            Console.WriteLine(account.Login(email,password,role));
        }
    }
    
}
