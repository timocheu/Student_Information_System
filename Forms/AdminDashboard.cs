using LinqKit;
using LinqKit.Core;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using System.Data;

namespace Student_Information_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly SisContext db = new SisContext();
        private User? current_User;

        // Toggles
        private bool ShowInactiveStudents = false;
        private bool ShowInactiveTeachers = false;

        // Binding source for students
        private BindingSource studentSource = new();
        private int totalStudents = 0;

        // Binding source for students
        private BindingSource courseSource = new();
        private int totalCourses = 0;

        public AdminDashboard(int userId)
        {
            InitializeComponent();

            GetUserInfo(userId);

            // Initialize data for students
            RefreshStudents();
            RefreshCourse();
            dgv_Students.DataSource = studentSource;
            dgv_Courses.DataSource = courseSource;
            dgv_Courses.Rows[0].Selected = true;
        }

        private void GetUserInfo(int user_id)
        {
            User? current_User = db.Users.FirstOrDefault(u => u.UserId == user_id);

            if (current_User is null)
            {
                throw new Exception("Unable to find the user in the database.");
            }

            this.current_User = current_User;
            lbl_Welcome.Text = $"Welcome {current_User?.FirstName}";
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var result = CrownMessageBox.ShowInformation("Are you sure you want to continue?", "Confirm logout", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

            if (result == DialogResult.Yes) this.Close();
        }


        #region Student features
        public void RefreshStudents()
        {
            var predicate = PredicateBuilder.New<User>(false);

            if (!ShowInactiveStudents)
            {
                predicate = predicate.And(u => u.Student != null && u.Student.Status == 1);
            }

            var refreshedUser = db.Users
                .Where(predicate)
                .OrderByDescending(u => u.UserId)
                .Select(u => new
                {
                    u.UserId,
                    u.FirstName,
                    u.LastName,
                    u.Gender,
                    u.DateOfBirth,
                    u.Email,
                    u.Phone,
                    Enrollment_date = u.Student!.EnrollmentDate,
                })
                .ToList();

            studentSource.DataSource = refreshedUser;
            totalStudents = refreshedUser.Count;
            lbl_StudentResult.Text = $"{refreshedUser.Count} Out of {totalStudents}";
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            UserAdd StudentAddForm = new UserAdd(IsTeacher: false);
            StudentAddForm.FormClosed += (s, args) =>
            {
                this.Enabled = true;
                RefreshStudents();
            };

            this.Enabled = false;
            StudentAddForm.Show();
        }
        private void btn_DeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgv_Students.SelectedRows.Count > 0)
            {
                var result = PoisonMessageBox.Show(this, "Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);
                if (result == DialogResult.Yes)
                {
                    HashSet<int> ids = dgv_Students.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(row => (int)row.Cells[0].Value)
                        // use hashset for more effecient look up
                        .ToHashSet<int>();

                    db.Students
                        .Where(s => ids.Contains(s.UserId))
                        .ExecuteUpdateAsync(s => s.SetProperty(
                            s => s.Status,
                            s => 0));

                    RefreshStudents();
                }
            }
            else
            {
                MessageBox.Show("Select rows first");
            }
        }
        private void btn_UpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgv_Students.SelectedRows.Count == 1)
            {
                int userID = (int)dgv_Students.SelectedRows[0].Cells[0].Value;

                Form form = new UpdateCredentials(IsTeacher: false, userID, this);
                form.FormClosed += (s, args) => this.Enabled = true;

                this.Enabled = false;
                form.Show();
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }
        }
        private void btn_ShowCourse_Click(object sender, EventArgs e)
        {
            if (dgv_Students.SelectedRows.Count == 1)
            {
                int userID = (int)dgv_Students.SelectedRows[0].Cells[0].Value;

                Form form = new ShowDetailStudent(userID);
                form.FormClosed += (s, args) => this.Enabled = true;

                this.Enabled = false;
                form.Show();
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }
        }
        private void toggle_InactiveStudent_MouseCaptureChanged(object sender, EventArgs e)
        {
            ShowInactiveStudents ^= true;
            RefreshStudents();
        }
        private void tb_SearchStudent_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchStudent.Text.ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshStudents();
                return;
            }
            var predicates = PredicateBuilder.New<User>(false);

            if (cb_UserId.Checked)
            {
                predicates = predicates
                    .Or(u => u.UserId.ToString().Contains(filter));
            }

            if (cb_Name.Checked)
            {
                predicates = predicates
                    .Or(u => (!string.IsNullOrEmpty(u.FirstName) && u.FirstName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.LastName) && u.LastName.ToLower().Contains(filter)));
            }

            if (cb_DateOfBirth.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.DateOfBirth) && u.DateOfBirth.ToLower().Contains(filter));
            }

            if (cb_Gender.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Gender) && u.Gender.ToLower() == filter);
            }

            if (cb_Email.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Email) && u.Email.ToLower().Contains(filter));
            }

            if (cb_Phone.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Phone) && u.Phone.ToLower().Contains(filter));
            }

            if (cb_EnrollmentDate.Checked)
            {
                predicates = predicates.Or(u => u.Student != null && !string.IsNullOrEmpty(u.Student.EnrollmentDate) && u.Student.EnrollmentDate.ToLower().Contains(filter));
            }

            if (!ShowInactiveStudents)
            {
                predicates = predicates.And(u => u.Student != null && u.Student.Status == 1);
            }

            var filteredStudents = db.Users
                .AsExpandable()
                .Where(predicates)
                .Select(u => new
                {
                    u.UserId,
                    u.FirstName,
                    u.LastName,
                    u.Gender,
                    u.DateOfBirth,
                    u.Email,
                    u.Phone,
                    Enrollment_date = u.Student!.EnrollmentDate,
                })
                .ToList();

            studentSource.DataSource = filteredStudents;
            lbl_StudentResult.Text = $"{filteredStudents.Count} Out of {totalStudents}";
        }
        #endregion

        #region Teacher features
        private void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            Form TeacherAddForm = new UserAdd(IsTeacher: true);
            TeacherAddForm.FormClosed += (s, args) => this.Enabled = true;

            this.Enabled = false;
            TeacherAddForm.Show();
        }
        #endregion

        private void toggle_InactiveStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hopeCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        #region Courses
        private void btn_CreateCourse_Click(object sender, EventArgs e)
        {
            CourseAdd CourseAddForm = new CourseAdd();
            CourseAddForm.FormClosed += (s, args) =>
            {
                this.Enabled = true;
                RefreshCourse();
            };

            this.Enabled = false;
            CourseAddForm.Show();
        }

        private void RefreshCourse()
        {
            var refreshedCourses = db.Courses
                .OrderByDescending(u => u.CourseId)
                .Select(u => new
                {
                    u.CourseId,
                    u.CourseCode,
                    u.CourseName,
                    u.Description,
                    u.Department,
                    u.Credits,
                    u.TeacherId
                })
                .ToList();

            courseSource.DataSource = refreshedCourses;
            totalCourses = refreshedCourses.Count;

            lbl_StudentResult.Text = $"{refreshedCourses.Count} Out of {totalCourses}";
        }

        private void btn_DeleteCourse_Click(object sender, EventArgs e)
        {
            if (dgv_Courses.SelectedRows.Count > 0)
            {
                var result = PoisonMessageBox.Show(this, "Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);
                if (result == DialogResult.Yes)
                {
                    int courseId = (int)dgv_Courses.SelectedRows[0].Cells[0].Value;

                    db.Courses
                        .Where(c => c.CourseId == courseId)
                        .ExecuteDelete();

                    RefreshCourse();
                }
            }
        }

        private void dgv_Courses_CellClick(object sender, DataGridViewCellEventArgs e) => LoadStudentSelection();
        private void toggle_CourseTaken_CheckedChanged(object sender, EventArgs e) => LoadStudentSelection();
        private void LoadStudentSelection()
        {
            var targetCourse = (int)dgv_Courses.SelectedRows[0].Cells["CourseId"].Value;

            var predicate = PredicateBuilder.New<Student>(false);

            if (toggle_CourseTaken.Checked)
            {
                predicate.Or(s => db.CourseTakens
                .Any(ct => ct.StudentId == s.UserId && ct.CourseId == targetCourse));
            }
            else
            {
                predicate.Or(s => !db.CourseTakens
                .Any(ct => ct.StudentId == s.UserId && ct.CourseId == targetCourse));
            }

            var students = db.Students
                .AsExpandable()
                .Where(predicate)
                .Select(s => new
                {
                    s.UserId,
                    Name = s.User.FirstName + " " + s.User.LastName,
                    s.Program
                })
                .ToList();

            dgv_StudentSelection.DataSource = students;
        }


        private void btn_AssignCourse_Click(object sender, EventArgs e)
        {
            var targetCourseId = (int)dgv_Courses.SelectedRows[0].Cells["CourseId"].Value;

            if (dgv_StudentSelection.SelectedRows.Count > 0)
            {
                var result = PoisonMessageBox.Show(this,
                    "Are you sure you want to add the courses to the selected students?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, 200);

                if (result == DialogResult.Yes)
                {
                    HashSet<int> ids = dgv_StudentSelection.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(row => (int)row.Cells[0].Value)
                        // use hashset for more effecient look up
                        .ToHashSet<int>();

                    var selectedStudents = ids.Select(studentId => new CourseTaken
                    {
                        StudentId = studentId,
                        CourseId = targetCourseId,
                    });

                    db.CourseTakens.AddRange(selectedStudents);
                    db.SaveChanges();

                    LoadStudentSelection();
                }
                else
                {
                    MessageBox.Show("Select rows first");
                }
            }
        }
        #endregion

    }
}
