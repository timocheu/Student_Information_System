using ReaLTaiizor.Controls;
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
        bool isTeacher = false;

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
            if (isTeacher)
            {
                foreach (Control c in pnl_TeacherEnabled.Controls)
                {
                    if (c is MaterialMultiLineTextBoxEdit tb)
                    {
                        if (tb.Enabled && string.IsNullOrEmpty(tb.Text))
                        {
                            // Snackbar error
                            MaterialSnackBar Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true);
                            Snackbar.Show(this);

                            return;
                        }
                    }
                }
            }
            

            // Check if all textbox in user panel is fillouted
            foreach (Control control in pnl_UserDetails.Controls)
            {
                if (control is MaterialTextBoxEdit textbox)
                {
                    if (textbox.Enabled && string.IsNullOrEmpty(textbox.Text))
                    {
                        // Snackbar error
                        MaterialSnackBar Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true);
                        Snackbar.Show(this); 

                        return;
                    }
                }
            }

            // Email verification using regex

            // Disable userdetail panel
            if (pnl_UserDetails.Enabled)
            {
                pnl_UserDetails.Enabled = false;
                pnl_UserLogin.Enabled = true;
            }
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
