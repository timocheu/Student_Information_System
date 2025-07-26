using Microsoft.Data.Sqlite;
using ReaLTaiizor.Controls;
using Student_Information_System.Forms;
using Student_Information_System.Utilities;

namespace Student_Information_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Please fill up the following input.",
                        "Insufficient Details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }

            btn_Login.Enabled = false;

            try
            {
                int role = await Task.Run(() =>
                {
                    using var conn = new SqliteConnection(Account.sqliteDbPath());
                    conn.Open();

                    int user_id = Account.QueryAccountLogin(conn, tb_Username.Text, tb_Password.Text);
                    if (user_id == -1) return -1;

                    using var cmd = new SqliteCommand("SELECT role FROM User WHERE user_id = @user_id", conn);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    using var r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        return r.GetInt32(0);
                    }
                    return -1;
                });

                if (role == -1)
                {
                    MessageBox.Show("Unable to find a matching user login.",
                        "Incorrect Credentials",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                // Role-based redirection
                switch (role)
                {
                    case 1:
                        new AdminDashboard().Show();
                        break;
                    case 2:
                        new TeacherDashboard().Show();
                        break;
                    case 3:
                        new StudentDasboard().Show();
                        break;
                    default:
                        MessageBox.Show("Unable to find the corresponding role of the account.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
            finally
            {
                btn_Login.Enabled = true;
            }
        }

        //private void btn_Login_Click(object sender, EventArgs e)
        //{
        //    int role;

        //    using (var conn = new SqliteConnection(Account.sqliteDbPath()))
        //    {
        //        conn.Open();
        //        int user_id = Account.QueryAccountLogin(conn, tb_Username.Text, tb_Password.Text);
        //        if (user_id == -1) return;
        //        {
        //            // Todo
        //        }

        //        using var cmd = new SqliteCommand($"SELECT role FROM User WHERE user_id = {user_id}", conn);
        //        var r = cmd.ExecuteReader();
        //        r.Read();

        //        role = r.GetInt32(0);
        //    }

        //    switch (role)
        //    {
        //        case 1:
        //            new AdminDashboard().Show();
        //            break;
        //        case 2:
        //            new TeacherDashboard().Show();
        //            break;
        //        case 3:
        //            new StudentDasboard().Show();
        //            break;
        //        default:
        //            MessageBox.Show("Unable to find the corresponding role of the account.");
        //            break;
        //    }
        //}
    }
}
