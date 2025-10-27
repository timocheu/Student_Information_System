using Microsoft.Extensions.Logging;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;

namespace Student_Information_System.Forms
{
    public partial class UserAdd : Form
    {
        private SisContextLogger logger;

        private int currentID = -1;

        private bool isTeacher = false;
        private bool showPass = false;

        private User? _user;
        private string userType;

        public UserAdd(bool IsTeacher, SisContextLogger logger)
        {
            this.logger = logger;
            this.isTeacher = IsTeacher;
            userType = (isTeacher) ? "Teacher" : "Student";
            this.currentID = Account.GetLastId();
            InitializeComponent();

            if (IsTeacher)
            {
                pnl_TeacherEnabled.Enabled = true;
                pnl_TeacherEnabled.Visible = true;

                lbl_Program.Visible = false;
                cbb_Program.Visible = false;
            }

            hope_UserAdd.Text = IsTeacher ? "Add Teacher" : "Add Student";
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (isTeacher && (string.IsNullOrEmpty(tb_Department.Text) || string.IsNullOrEmpty(tb_Specialization.Text)))
            {
                var Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true);
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
                        var Snackbar = new MaterialSnackBar("Please fill up the following input", 3000, "OK", true);
                        Snackbar.Show(this);

                        return;
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

            // Check for existing unique attributes
            using (SisContext db = new SisContext())
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
            }

            _user = new User()
            {
                FirstName = tb_Firstname.Text,
                LastName = tb_Lastname.Text,
                Email = tb_Email.Text,
                DateOfBirth = dt_BirthDate.Text,
                Gender = cbb_Gender.Text,
                Address = tb_Address.Text,
                Role = isTeacher ? 2 : 3,
                Phone = tb_Phone.Text,
                UserLogin = new()
                {
                    Username = $"{DateTime.Now.Year % 2_000}-{currentID.ToString("D6")}"
                }
            };

            // Set the auto generated userlogin
            tb_UserLogin.Text = _user.UserLogin.Username;

            // Disable userdetail panel
            if (pnl_UserDetails.Enabled)
            {
                pnl_UserDetails.Enabled = false;
                pnl_UserLogin.Enabled = true;
            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            _user.UserLogin!.PasswordSalt = Cryptography.GenerateSalt();
            _user.UserLogin.PasswordHash = Cryptography.HashPassword(tb_UserPassword.Text, _user.UserLogin.PasswordSalt);

            var result = CrownMessageBox.ShowInformation("Are you sure that the information are correct?", "Confirm create", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

            if (result == DialogResult.Yes)
            {
                using (SisContext db = new SisContext())
                {
                    try
                    {
                        if (isTeacher)
                        {
                            _user.Teacher = new Teacher
                            {
                                UserId = currentID,
                                HireDate = DateTime.Now.ToShortDateString(),
                                Department = tb_Department.Text,
                                Specialization = tb_Specialization.Text,
                                Status = 1
                            };
                        }
                        else
                        {
                            _user.Student = new Student
                            {
                                UserId = currentID,
                                EnrollmentDate = DateTime.Now.ToShortDateString(),
                                Program = cbb_Program.Text,
                                Status = 1
                            };
                        }

                        db.Users.Add(_user!);
                        db.SaveChanges();

                        logger.Information(
                            $"Add {userType}", 
                            $"Added ", (isTeacher) ? _user.Teacher : _user.Student);
                    }
                    catch (Exception ex)
                    {
                        logger.Error(
                            $"Add {userType}", 
                            $"Unable to add {userType}", ex);
                    }
                }
                this.Close();
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

        private void ShowPassword(object sender, EventArgs e)
        {
            tb_UserPassword.UseSystemPasswordChar ^= true;
            showPass ^= true;

            if (showPass)
            {
                tb_UserPassword.PasswordChar = '\0';
                tb_UserPassword.TrailingIcon = Properties.Resources.view;
            }
            else
            {
                tb_UserPassword.TrailingIcon = Properties.Resources.eye;
            }
        }
    }
}
