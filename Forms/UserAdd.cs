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

      hope_UserAdd.Text = IsTeacher ? "Add Teacher" : "Add Student";
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
            // Snackbar error
            var result = PoisonMessageBox.Show(this, "Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return;
          }
        }
      }

      // Email verification using regex

      // Disable userdetail panel
      if (pnl_UserDetails.Enable)
      {
        pnl_UserDetails.Enable = false;
        pnl_UserLogin.Enable = true;
      }
    }


    private void btn_Back_Click(object sender, EventArgs e)
    {
      // Clear text on password box
      tb_UserPassword.Clear();

      if (pnl_UserLogin.Enable)
      {
        pnl_UserLogin.Enable = false;
        pnl_UserDetails.Enable = true;
      }
    }
  }
}
