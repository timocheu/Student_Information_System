using Student_Information_System.Models;
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
    public partial class UpdateCredentials : Form
    {
        private bool isTeacher = false;
        private int currentID = -1;
        private bool showPass = false;

        private User? _user;

        public UpdateCredentials(bool IsTeacher, User user) {
            this.isTeacher = IsTeacher;
            this.currentID = user.UserId;
            InitializeComponent();

            if (IsTeacher)
            {
                pnl_TeacherEnabled.Enabled = true;
                pnl_TeacherEnabled.Visible = true;

                tb_Department.Text = user.Teacher?.Department;
                tb_Specialization.Text = user.Teacher?.Specialization;
            }

            // Set ui text details
            tb_UserLogin.Text = user.UserLogin?.Username.ToString();
            tb_Firstname.Text = user.FirstName;
            tb_Lastname.Text = user.LastName;
            tb_Phone.Text = user.Phone;
            tb_Email.Text = user.Email;
            tb_Address.Text = user.Address;
            cb_Gender.SelectedItem = user.Gender;
            dt_BirthDate.Value = DateTime.Parse(user.DateOfBirth);

            // Set userlogin
            tb_UserLogin.Text = user.UserLogin.Username;
            tb_UserLogin.Enabled = false;
        }

        private void pnl_UserDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
