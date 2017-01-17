using KillerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.DAL.Repository
{
    public class AccountRepository
    {
        private IAccount accountContext;

        public AccountRepository(IAccount accountContext)
        {
            this.accountContext = accountContext;
        }
        public bool GetAccount(string email, string wachtwoord)
        {
            return accountContext.GetAccount(email, wachtwoord);
        }
        public bool SetAccount(string email, string naam, string username, string wachtwoord)
        {
            return accountContext.SetAccount(email, naam, username, wachtwoord);
        }
    }
}