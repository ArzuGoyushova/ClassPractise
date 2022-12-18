using Service.Helpers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public void Register(string username, string password, string email)
        {
            try
            {
                if (!EmailChecker(email))
                {
                    throw new AccException(AccountConstants.EmailMessage);
                }
                else
                {
                    Console.WriteLine("Registered.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static bool EmailChecker(string email)
        {
            return Regex.IsMatch(email, @"^([a-zA-Z0-9]+)@(([a-z]+[.]{1,}[a-z]+[.]{1,})|([a-z]+[.]{1,}))([a-z]{2,4})$"); 
        }
    }
}
