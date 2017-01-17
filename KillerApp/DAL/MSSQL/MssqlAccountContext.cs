using KillerApp.DAL.General;
using KillerApp.DAL.Interfaces;
using KillerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace KillerApp.DAL.MSSQL
{
    public class MssqlAccountContext : IAccount
    {
        public SqlCommand command { get; set; }
        //sql querrys
        public bool GetAccount(string email, string wachtwoord)
        {
            Account login;
            try
            {
                Datacom.OpenConnection();
                command = new SqlCommand();
                command.CommandText = "SELECT Email, Naam, Username, Wachtwoord From Profiel p inner join Wachtwoord w on p.email = w.Profiel_Email Where p.email = '"+email+"' and w.Wachtwoord = '"+wachtwoord+"'";

                command.Connection = Datacom.connect;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Account.loggedinUser = new Account(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]));
                }
                if (Account.loggedinUser.Naam == null || Account.loggedinUser.Username == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                Datacom.CloseConnection();
            }
            
        }

        public bool SetAccount(string email, string naam, string username, string wachtwoord)
        {
            try
            {
                Datacom.OpenConnection();
                command = new SqlCommand();
                command.CommandText = "Insert into Profiel Values('"+email+"','"+naam+"','"+username+"');";
                command.Connection = Datacom.connect;
                command.ExecuteNonQuery();
                command.CommandText = "Insert into Wachtwoord Values('"+email+"','"+wachtwoord+"');";
                command.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
    }
}