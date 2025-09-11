using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.UserControls;
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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_CreateStudent_Click(object sender, EventArgs e)
        {
            using (SisContext db = new())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == tb_Email.Text);

                if (user != null)
                {
                    ChangePassword cp = new(user.UserId);
                    cp.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };

                    cp.Show();
                    this.Hide();
                }
                else
                {
                    CrownMessageBox.ShowInformation(
                        "Unable to find corresponding email in database.",
                        "Email not found",
                        ReaLTaiizor.Enum.Crown.DialogButton.Ok);

                    return;
                }
            }
        }
    }
}
