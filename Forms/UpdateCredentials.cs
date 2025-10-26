using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;

namespace Student_Information_System.Forms
{
    public partial class UpdateCredentials : Form
    {
      // loger
      private SisContextLogger logger;
        private AdminDashboard parentReference;
        private SisContext db = new();

        private bool isTeacher = false;
        private bool showPass = false;

        User user;

        public UpdateCredentials(
            bool IsTeacher, 
            int userID, 
            AdminDashboard parent,
            SisContextLogger logger)
        {
            this.isTeacher = IsTeacher;
            this.parentReference = parent;
            this.logger = logger;

            // Set user
            user = db.Users
                .Include(u => u.UserLogin)
                .Include(u => u.Teacher)
                .Include(u => u.Student)
                .FirstOrDefault(u => u.UserId == userID) ?? new User();

            InitializeComponent();

            if (IsTeacher)
            {
                pnl_TeacherEnabled.Enabled = true;
                pnl_TeacherEnabled.Visible = true;

                tb_Department.Text = user.Teacher?.Department;
                tb_Specialization.Text = user.Teacher?.Specialization;
            }
            else
            {
                tb_Program.Visible = true;
                tb_Program.Text = user.Student?.Program;
            }

            // Set ui text details
            tb_Firstname.Text = user.FirstName;
            tb_Lastname.Text = user.LastName;
            tb_Phone.Text = user.Phone;
            tb_Email.Text = user.Email;
            tb_Address.Text = user.Address;
            cb_Gender.SelectedItem = user.Gender;
            dt_BirthDate.Value = DateTime.Parse(user.DateOfBirth ?? "01/01/2000");

            // Set userlogin
            tb_UserLogin.Text = user.UserLogin.Username;
            tb_UserLogin.Enabled = false;
        }
        private void btn_UpdateUserDetail_Click(object sender, EventArgs e)
        {
            if (db.Users
                .Any(u => u.Email == tb_Email.Text && 
                  user.Email != tb_Email.Text))
            {
                var Snackbar = new MaterialSnackBar("Email already exist. Please try other email", 3000, "OK", true);
                Snackbar.Show(this);

                logger.Warning("Update", $"Tried to update user:[{user.UserId}] but email already existed.");

                return;
            }
            else if (db.Users
                .Any(u => u.Phone == tb_Phone.Text && 
                  user.Phone != tb_Phone.Text))
            {
                var Snackbar = new MaterialSnackBar("Phone number is taken. Please try other number", 3000, "OK", true);
                Snackbar.Show(this);
                logger.Warning("Update", $"Tried to update user:[{user.UserId}] but number already existed.");

                return;
            }

            var result = CrownMessageBox.ShowInformation("Are you sure this is the correct information?", "Update Credentials", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

            if (result == DialogResult.Yes)
            {
                //var user = db.Users.FirstOrDefault(u => u.UserId == currentID);
                user.FirstName = tb_Firstname.Text.Trim();
                user.LastName = tb_Lastname.Text.Trim();
                user.Phone = tb_Phone.Text.Trim();
                user.Email = tb_Email.Text.Trim();
                user.Address = tb_Address.Text.Trim();
                user.Gender = cb_Gender.Text.Trim();
                user.DateOfBirth = dt_BirthDate.Text.Trim();

                // Set corresponding datas
                if (isTeacher)
                {
                    user.Teacher.Department = tb_Department.Text.Trim();
                    user.Teacher.Specialization = tb_Specialization.Text.Trim();
                }
                else
                {
                    user.Student.Program = tb_Program.Text.Trim();
                }

                db.SaveChanges();
                
                // Log
                logger.Information($"Update {(isTeacher) ? "Teacher" : "Student"}", 
                    $"Successfully updated user:[{user.UserId}] details");

                // Refresh
                if (isTeacher)
                {
                    parentReference.RefreshTeachers();
                }
                else
                {
                    parentReference.RefreshStudents();
                }
            }
        }

        private void btn_UpdateUserLogin_Click(object sender, EventArgs e)
        {
            user.UserLogin.PasswordSalt = Cryptography.GenerateSalt();
            user.UserLogin.PasswordHash = Cryptography.HashPassword(tb_UserPassword.Text, user.UserLogin.PasswordSalt);

            var result = CrownMessageBox.ShowInformation("Are you sure this is the correct information?", "Update Credentials", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

            if (result == DialogResult.Yes)
            {
                db.SaveChanges();
                logger.Information($"Update {(isTeacher) ? "Teacher" : "Student"}", $"Successfully updated user:[{user.UserId}] login credentials");
            }
        }
    }
}
