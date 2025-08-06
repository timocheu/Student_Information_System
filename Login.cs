using Microsoft.Data.Sqlite;
using ReaLTaiizor.Controls;
using Student_Information_System.Forms;
using Student_Information_System.Utilities;

namespace Student_Information_System
{
    public partial class Login : Form
    {
        private bool showPass = false;

        public Login()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                // var result = PoisonMessageBox.Show(this, "Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MaterialSnackBar Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true);
                Snackbar.Show(this);

                return;
            }

            string password = tb_Password.Text;
            tb_Password.Clear();

            btn_Login.Enabled = false;

            try
            {
                using var conn = new SqliteConnection(Account.SqliteDbPath());
                int user_id = await Task.Run(() =>
                {
                    conn.Open();
                    return Account.QueryAccountLogin(conn, tb_Username.Text, password);
                });

                if (user_id == -1)
                {
                    MessageBox.Show("Unable to find a matching user login.",
                        "Incorrect Credentials",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                int role = await Task.Run(() =>
                {
                    using (var cmd = new SqliteCommand("SELECT role FROM User WHERE user_id = @user_id", conn))
                    {
                        // Add the user_id
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read()) return r.GetInt32(0);
                        }
                    }

                    return -1;
                });

                Form? directedForm = role switch
                {
                    1 => new AdminDashboard(user_id),
                    2 => new TeacherDashboard(),
                    3 => new StudentDasboard(),
                    _ => null
                };

                if (directedForm is null)
                {
                    MessageBox.Show("Unable to find the corresponding role of the account.");
                    return;
                }

                // Add delegate to FormClosed event
                directedForm.FormClosed += (s, args) => this.Show();
                directedForm.Show();

                this.Hide();
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

        private void tb_Password_TrailingIconClick(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar ^= true;
            showPass ^= true;

            if (showPass)
            {
                tb_Password.PasswordChar = '\0';
                tb_Password.TrailingIcon = Properties.Resources.view;
            } 
            else
            {
                tb_Password.TrailingIcon = Properties.Resources.eye;
            }
        }
    }
}
