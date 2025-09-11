using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Student_Information_System.Models;

namespace Student_Information_System.Utilities
{
    public class Account
    {
        public static string SqliteDbPath()
        {
            string basePath = AppContext.BaseDirectory;
            string relativePath = Path.Combine(basePath, @"..\..\..\SIS.db");
            string fullPath = Path.GetFullPath(relativePath);
            return $"Data Source={fullPath}";
        }

        public static User? QueryAccountLogin(string username, 
            string password, 
            out bool ExistButWrongPass,
            out bool LimitReached)
        {
            ExistButWrongPass = false;
            LimitReached = false;

            using (SisContext db = new())
            {
                var login = db.UserLogins
                    .Where(u => u.Username == username)
                    .Include(u => u.User)
                    .FirstOrDefault();


                if (login?.LoginAttempt >= 3)
                {
                    login.LastLoginAttempt = DateTime.Now.ToString();
                    db.SaveChanges();

                    LimitReached = true;
                    return null;
                }

                if (login != null)
                {
                    if (Cryptography.VerifyPassword(password, login.PasswordSalt, login.PasswordHash))
                    {
                        login.LoginAttempt = 0;
                        login.LastLoginAttempt = DateTime.Now.ToString();
                        db.SaveChanges();

                        return login.User;
                    }
                    else
                    {
                        ExistButWrongPass = true;

                        login.LoginAttempt += 1;
                        login.LastLoginAttempt = DateTime.Now.ToString();

                        db.SaveChanges();
                    }
                }

                return null;
            }
        }

        public static int GetLastId()
        {
            string query = $"SELECT MAX(user_id) FROM User";

            using (var conn = new SqliteConnection(SqliteDbPath()))
            {
                conn.Open();

                var reader = new SqliteCommand(query, conn).ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0) + 1;
                }
            }

            return -1;
        }

        public static User GetUser(int user_id, SisContext db)
        {

            return null;
        }
    }
}
