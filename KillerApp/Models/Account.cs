using KillerApp.DAL.MSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Account
    {
        private MssqlAccountContext accountContext = new MssqlAccountContext();
        public static Account loggedinUser;
        private bool loginbool;

        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Naam { get; set; }
        public string Username { get; set; }

        public Account(string email, string wachtwoord)
        {

        }

        public Account(string email, string naam, string username, string wachtwoord)
        {
            Email = email;
            Wachtwoord = wachtwoord;
            Naam = naam;
            Username = username;
        }

        public bool LogInUser(string email, string password)
        {
            accountContext.GetAccount(email, password);
            if (loginbool == true)
            {
                loginbool = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CreateUser(Account account)
        {
            if (accountContext.SetAccount(account.Email, account.Naam, account.Username,account.Wachtwoord))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}