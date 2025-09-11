using Microsoft.Data.Sqlite;
using ReaLTaiizor.Controls;
using Student_Information_System.Forms;
using Student_Information_System.Models;
using Student_Information_System.UserControls;
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
                MaterialSnackBar Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true);
                Snackbar.Show(this);

                return;
            }

            string password = tb_Password.Text.Trim();
            string username = tb_Username.Text;
            tb_Password.Clear();

            btn_Login.Enabled = false;

            try
            {
                bool ExistButWrongPass;
                bool LimitReached;
                var user = Account.QueryAccountLogin(username, 
                    password, 
                    out ExistButWrongPass, 
                    out LimitReached);

                if (LimitReached)
                {
                    MaterialSnackBar Snackbar = new MaterialSnackBar("Account login attempts reached limit", 3000, "OK", true);
                    Snackbar.Show(this);

                    return;
                }

                if (ExistButWrongPass)
                {
                    MaterialSnackBar Snackbar = new MaterialSnackBar("The account exist, but wrong password", 3000, "OK", true);
                    Snackbar.Show(this);

                    return;
                }

                if (user == null)
                {
                    MessageBox.Show("Unable to find a matching user login.",
                        "Incorrect Credentials",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                Form? directedForm = user.Role switch
                {
                    1 => new AdminDashboard(user.UserId),
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

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login_Click(sender, e);
                e.Handled = true;
            }

        }

        private void tb_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login_Click(sender, e);
                e.Handled = true;
            }
        }

        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword fg = new();

            fg.Show();
        }
    }
}
