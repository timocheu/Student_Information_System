using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;

namespace Student_Information_System.Forms
{
    public partial class UpdateCredentials : Form
    {
        private bool isTeacher = false;
        private int currentID = -1;
        private bool showPass = false;

        public UpdateCredentials(bool IsTeacher, User user)
        {
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
            using (SisContext db = new())
            {
                if (db.Users.Any(u => u.Email == tb_Email.Text))
                {
                    var Snackbar = new MaterialSnackBar("Email already exist. Please try other email", 3000, "OK", true);
                    Snackbar.Show(this);

                    return;
                }
                else if (db.Users.Any(u => u.Phone == tb_Phone.Text))
                {
                    var Snackbar = new MaterialSnackBar("Phone number is taken. Please try other number", 3000, "OK", true);
                    Snackbar.Show(this);

                    return;
                }

                var user = db.Users.FirstOrDefault(u => u.UserId == currentID);
                user.FirstName = tb_Firstname.Text;
                user.LastName = tb_Lastname.Text;
                user.Phone = tb_Phone.Text;
                user.Email = tb_Email.Text;
                user.Address = tb_Address.Text;
                user.Gender = tb_Address.Text;
                user.DateOfBirth = dt_BirthDate.Text;

                db.SaveChanges();
            }
        }

        private void btn_UpdateUserLogin_Click(object sender, EventArgs e)
        {
            using (SisContext db = new())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == currentID);
                // Change password
                user.UserLogin.PasswordSalt = Cryptography.GenerateSalt();
                user.UserLogin.PasswordHash = Cryptography.HashPassword(tb_UserPassword.Text, user.UserLogin.PasswordSalt);

                db.SaveChanges();
            }
        }
    }
}
