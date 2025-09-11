using Microsoft.Data.Sqlite;
using Student_Information_System.Utilities;

namespace Student_Information_System
{
    public partial class AccountCreator : Form
    {
        public AccountCreator()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string basePath = AppContext.BaseDirectory;
            string relativePath = Path.Combine(basePath, @"..\..\..\SIS.db");
            string fullPath = Path.GetFullPath(relativePath);
            string connectionString = $"Data Source={fullPath}";

            string query = $"INSERT INTO User(first_name, last_name, email, gender, role, date_of_birth, phone, address) " +
                $"VALUES(@first_name, @last_name, @email, @gender, @role, @date_of_birth, @phone, @address)";

            string queryUser = $"SELECT user_id FROM User WHERE email = @email";

            int role = cb_Role.SelectedItem switch
            {
                "Admin" => 1,
                "Teacher" => 2,

                // Student
                _ => 3,
            };

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", tb_Firstname.Text);
                    cmd.Parameters.AddWithValue("@last_name", tb_Lastname.Text);
                    cmd.Parameters.AddWithValue("@email", tb_Email.Text);
                    cmd.Parameters.AddWithValue("@gender", cb_Gender.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@date_of_birth", dtp_Birth.Value.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@phone", tb_Phone.Text);
                    cmd.Parameters.AddWithValue("@address", tb_Address.Text);

                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SqliteCommand(queryUser, conn))
                {
                    cmd.Parameters.AddWithValue("@email", tb_Email.Text);
                    var r = cmd.ExecuteReader();
                    r.Read();

                    string queryInsert = $"INSERT INTO User_login(user_id, username, password_hash, password_salt) " +
                        $"VALUES(@user_id, @username, @password_hash, @password_salt)";

                    using (var cmd2 = new SqliteCommand(queryInsert, conn))
                    {
                        byte[] salt = Cryptography.GenerateSalt();
                        byte[] hash = Cryptography.HashPassword(tb_Password.Text, salt);

                        cmd2.Parameters.AddWithValue("@user_id", r.GetInt32(0));
                        cmd2.Parameters.AddWithValue("@username", tb_Username.Text);
                        cmd2.Parameters.AddWithValue("@password_hash", hash);
                        cmd2.Parameters.AddWithValue("@password_salt", salt);

                        cmd2.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
