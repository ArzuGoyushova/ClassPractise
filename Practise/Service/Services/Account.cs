using Service.Enum;
using Service.Helpers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class Account : IAccount
    {
        public string Login(string email, string password, int role)
        {
            if (email=="test@code.edu.az" && password == "test12345")
            {
                if (CheckRoles(role))
                {
                    return AccountConstants.SuperAdminValid;
                }
                else
                {
                    return AccountConstants.SuperAdminInvalid;
                }
            }
            else
            {
                return AccountConstants.PasswordOrEmailInvalid;
            }
        }

        public bool CheckRoles(int role)
        {
            return role == (int)Roles.SuperAdmin;
        }
    }
}
