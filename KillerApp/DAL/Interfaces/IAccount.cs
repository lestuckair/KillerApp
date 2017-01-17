using KillerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp.DAL.Interfaces
{
    public interface IAccount
    {
        bool GetAccount(string email, string wachtwoord);
        bool SetAccount(string email, string naam, string username, string wachtwoord);
    }
}
