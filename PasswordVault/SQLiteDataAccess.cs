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
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString("sqlite")))
            {
                var output = con.Query<Vault>("SELECT * FROM VAULT", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveVault(Vault vault)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString("sqlite")))
            {
                con.Execute("INSERT INTO () VALUES ()", vault);
            }
        }

        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }
}
