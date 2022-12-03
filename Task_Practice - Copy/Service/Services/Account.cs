using Service.Enum;
using Service.Helpers.Constants;
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
            if (email==AccountConstants.Email && password==AccountConstants.Password)
            {
                if (CheckRole(role))
                {
                    return AccountConstants.SuperAdminMessageValid;
                }
                else
                {
                    return AccountConstants.SuperAdminMessageInvalid;
                }
            }
            else
            {
                return AccountConstants.EmailOrPasswordInvalid;
            }
        }

        private bool CheckRole(int role)
        {
            return role == (int)Roles.SuperAdmin;
        }
    }
}