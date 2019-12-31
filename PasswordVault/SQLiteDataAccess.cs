using Dapper;
using PasswordVault.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class SQLiteDataAccess
    {
        public static List<Vault> LoadVault()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString(Constants.DATABASE_ID)))
            {
                var output = con.Query<Vault>("SELECT * FROM VAULT", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveVault(Vault vault)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString(Constants.DATABASE_ID)))
            {
                con.Execute("INSERT INTO () VALUES ()", vault);
            }
        }

        public static void UpdateVault(Vault vault)
        {
            using(IDbConnection con = new SQLiteConnection(LoadConnectionString(Constants.DATABASE_ID)))
            {
                con.Execute("UPDATE VAULT", vault);
            }
        }

        public static void DeleteVault(int id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString(Constants.DATABASE_ID)))
            {
                con.Execute("DELETE FROM VAULT WHERE ID=@ID", new { ID = id});
            }
        }

        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static User GetUser(string username)
        {
            User _user = null;

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString(Constants.DATABASE_ID)))
            {
                try
                {   
                    _user = con.QuerySingle<User>("SELECT * FROM USER WHERE USERNAME=@USERNAME", new { USERNAME = username });
                }
                catch (Exception)
                {

                }
            }

            return _user;
        }
    }
}
