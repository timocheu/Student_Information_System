using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System.Forms
{
    public partial class ChangePassword : Form
    {
        private int _userId;
        public ChangePassword(int userId)
        {
            _userId = userId;

            InitializeComponent();
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            if (tb_Password.Text != tb_ConfirmPassword.Text)
            {
                CrownMessageBox.ShowInformation(
                    "Password does not match!",
                    "Error",
                    ReaLTaiizor.Enum.Crown.DialogButton.Ok);
                return;
            }

            using (SisContext db = new())
            {
                var userlogin = db.UserLogins
                    .FirstOrDefault(u => u.UserId == _userId);

                userlogin.PasswordSalt = Cryptography.GenerateSalt();
                userlogin.PasswordHash = Cryptography.HashPassword(
                    tb_ConfirmPassword.Text,
                    userlogin.PasswordSalt
                    );

                db.SaveChanges();
            }

            this.Close();
        }
    }
}
