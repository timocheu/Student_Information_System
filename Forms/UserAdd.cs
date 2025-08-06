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
    public partial class UserAdd : Form
    {
        public UserAdd(bool IsTeacher = false)
        {
            InitializeComponent();

            if (IsTeacher)
            {
                pnl_TeacherEnabled.Enabled = true;
                pnl_TeacherEnabled.Visible = true;
            }

            hope_UserAdd.Text = (IsTeacher) ? "Add Teacher" : "Add Student";
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            // Check if all textbox in user panel is fillouted
            foreach (var control in pnl_UserDetails.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox.Enabled && string.IsNullOrEmpty(textbox.Text))
                    {

                    }
                }
            }
        }
    }
}
