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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Information_System.Forms
{
    public partial class UserAdd : Form
    {
        private bool isTeacher = false;
        private User _user = null;
        private UserLogin _userLogin = null;


        public UserAdd(bool IsTeacher)
        {
            this.isTeacher = IsTeacher;

            InitializeComponent();

            if (IsTeacher)
            {
                pnl_TeacherEnabled.Enabled = true;
                pnl_TeacherEnabled.Visible = true;
            }

            hope_UserAdd.Text = IsTeacher ? "Add Teacher" : "Add Student";
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            using (var Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true))
            {
                if (isTeacher && (string.IsNullOrEmpty(tb_Department.Text) || string.IsNullOrEmpty(tb_Specialization.Text)))
                {
                    Snackbar.Show(this);
                    return;
                }

                // Check if all textbox in user panel is fillouted
                foreach (Control control in pnl_UserDetails.Controls)
                {
                    if (control is MaterialTextBoxEdit textbox)
                    {
                        if (textbox.Enabled && string.IsNullOrEmpty(textbox.Text))
                        {
                            // Snackbar error
                            Snackbar.Show(this);

                            return;
                        }
                    }
                }
            }

            // Email verification using regex
            if (!StringExtension.IsValidEmail(tb_Email.Text))
            {
                var Snackbar = new MaterialSnackBar("Invalid email, please try again.", 3000, "OK", true);
                Snackbar.Show(this);

                return;
            }

            // Disable userdetail panel
            if (pnl_UserDetails.Enabled)
            {
                pnl_UserDetails.Enabled = false;
                pnl_UserLogin.Enabled = true;
            }

            _user = new User()
            {
                FirstName = tb_Firstname.Text,
                LastName = tb_Lastname.Text,
                Email = tb_Email.Text,
                DateOfBirth = dt_BirthDate.Text,
                Gender = cb_Gender.Text,
                Address = tb_Address.Text,
                Role = isTeacher ? 2 : 3,
                Phone = tb_Phone.Text,
            };
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Clear text on password box
            tb_UserPassword.Clear();

            if (pnl_UserLogin.Enabled)
            {
                pnl_UserLogin.Enabled = false;
                pnl_UserDetails.Enabled = true;
            }
        }
    }
}
