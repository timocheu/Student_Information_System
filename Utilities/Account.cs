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
            out bool LimitReached,
            out string LastAttempt)
        {
            ExistButWrongPass = false;
            LimitReached = false;
            LastAttempt = String.Empty;

            using (SisContext db = new())
            {
                // Create log
                Logs log = new()
                {
                    Timestamp = DateTime.Now.ToString(),
                    Action = "Login",
                };

                // query for user
                var login = db.UserLogins
                    .Where(u => u.Username == username)
                    .Include(u => u.User)
                    .FirstOrDefault();

                if (login != null)
                {
                    if (login.LastLoginAttempt != null)
                    {
                        DateTime lastlogin = DateTime.Parse(login.LastLoginAttempt);
                        TimeSpan diff = DateTime.Now - lastlogin;
                        //Seconds
                        if (login?.LoginAttempt >= 3 && diff.Seconds <= 15)
                        {
                            login.LastLoginAttempt = DateTime.Now.ToString();
                            db.SaveChanges();

                            LastAttempt = $"Login after 15 Seconds later.";
                            LimitReached = true;

                            // log
                            log.Message = "[User tried to login while account is locked.]";
                            db.Logs.Add(log);

                            return null;
                        }
                    }

                    if (Cryptography.VerifyPassword(password, login.PasswordSalt, login.PasswordHash))
                    {
                        login.LoginAttempt = 0;
                        login.LastLoginAttempt = DateTime.Now.ToString();

                        // log
                        log.Message = "[User succesfully logged in.]";
                        db.Logs.Add(log);

                        // Save
                        db.SaveChanges();

                        return login.User;
                    }
                    else
                    {
                        ExistButWrongPass = true;
                        login.LoginAttempt += 1;
                        login.LastLoginAttempt = DateTime.Now.ToString();

                        //log
                        log.Message = "[User tried to login with incorrect password.]";
                        db.Logs.Add(log);

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
