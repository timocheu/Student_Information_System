using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Utilities
{
    public class Account
    {
        public static string sqliteDbPath()
        {
            string basePath = AppContext.BaseDirectory;
            string relativePath = Path.Combine(basePath, @"..\..\..\SIS.db");
            string fullPath = Path.GetFullPath(relativePath);
            return $"Data Source={fullPath}";
        }

        public static int QueryAccountLogin(SqliteConnection conn, string username, string password)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Unable to query: Connection is close.");
            }

            string query = "SELECT * FROM User_login WHERE username = @username";

            using (var cmd = new SqliteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                var r = cmd.ExecuteReader();

                // If a row exist, read then Verify the matching hash using salt
                if (r.Read() &&
                    Cryptography.VerifyPassword(password, (byte[])r["password_salt"], (byte[])r["password_hash"]))
                {
                    return r.GetInt32(0);
                }      
                
                return -1;
            }
        }
    }
}
