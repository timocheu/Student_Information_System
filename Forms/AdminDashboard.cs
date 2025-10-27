using LinqKit;
using LinqKit.Core;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;
using System.Data;
using System.Reflection.PortableExecutable;

namespace Student_Information_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly SisContext db = new SisContext();
        private SisContextLogger logger;

        private User? current_User;

        // Binding source for students
        private BindingSource studentSource = new();
        private int totalStudents = 0;

        // Binding source for teachers
        private BindingSource teacherSource = new();
        private int totalTeachers = 0;

        // Binding source for course
        private BindingSource courseSource = new();
        private int totalCourse = 0;

        public AdminDashboard(int userId)
        {
            InitializeComponent();
            GetUserInfo(userId);
            //Initialize Logger
            string logLevel= current_User.Role switch
            {
                1 => "Admin",
                2 => "Teacher",
                3 => "Student",
                _ => String.Empty
            };
            logger = new(userId: current_User.UserId, level: logLevel, context: db);
            logger.Information("Login", "Successfully login");

            // Initialize data for students
            RefreshStudents();
            RefreshTeachers();
            RefreshCourse();

            dgv_Students.DataSource = studentSource;
            dgv_Teachers.DataSource = teacherSource;
            dgv_Courses.DataSource = courseSource;
            dgv_Courses.Rows[0].Selected = true;

            // Profile picture load
            if (current_User.UserLogin.ProfileLink is not null)
            {
                pb_ProfilePicture.LoadAsync(current_User.UserLogin.ProfileLink);
            }
        }

        private void GetUserInfo(int user_id)
        {
            User? current_User = db.Users
                .Include(u => u.UserLogin)
                .FirstOrDefault(u => u.UserId == user_id);

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

            logger.Information("Logout", "User successfully logged out.");
        }


        #region Student features
        private void toggle_InactiveStudent_CheckedChanged(object sender, EventArgs e) => RefreshStudents();
        public void RefreshStudents()
        {
            var predicate = PredicateBuilder.New<User>(false).And(u => u.Student != null && u.Role == 3);

            if (!toggle_InactiveStudent.Checked)
            {
                predicate = predicate.And(u => u.Student != null && u.Student.Status == 1);
            }

            var refreshedStudents = db.Users
                .AsExpandable()
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
                    u.Student!.Program,
                    Enrollment_date = u.Student!.EnrollmentDate,
                })
                .ToList();

            studentSource.DataSource = refreshedStudents;
            totalStudents = refreshedStudents.Count;
            lbl_StudentResult.Text = $"{refreshedStudents.Count} Out of {totalStudents}";
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            UserAdd StudentAddForm = new UserAdd(IsTeacher: false, logger: logger);
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

                    logger.Information("Delete Students", 
                        $"Succesfully deleted students, affected {dgv_Students.SelectedRows.Count} rows total.");

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

                Form form = new UpdateCredentials(IsTeacher: false, userID, this, logger);
                form.FormClosed += (s, args) =>
                {
                    this.Enabled = true;
                    RefreshStudents();
                };

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

        private void tb_SearchStudent_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchStudent.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshStudents();
                return;
            }
            var predicates = PredicateBuilder.New<User>(false);

            if (cb_Student_UserId.Checked)
            {
                predicates = predicates
                    .Or(u => u.UserId.ToString().Contains(filter));
            }

            if (cb_Student_Name.Checked)
            {
                predicates = predicates
                    .Or(u => (!string.IsNullOrEmpty(u.FirstName) && u.FirstName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.LastName) && u.LastName.ToLower().Contains(filter)));
            }

            if (cb_Student_DateOfBirth.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.DateOfBirth) && u.DateOfBirth.ToLower().Contains(filter));
            }

            if (cb_Student_Gender.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Gender) && u.Gender.ToLower() == filter);
            }

            if (cb_Student_Email.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Email) && u.Email.ToLower().Contains(filter));
            }

            if (cb_Student_Phone.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Phone) && u.Phone.ToLower().Contains(filter));
            }

            if (cb_Student_EnrollmentDate.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Student.EnrollmentDate) && u.Student.EnrollmentDate.ToLower().Contains(filter));
            }

            predicates = predicates.And(u => u.Role == 3 && u.Student != null);
            if (!toggle_InactiveStudent.Checked)
            {
                predicates = predicates.And(u => u.Student!.Status == 1);
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
                    u.Student.Program,
                })
                .ToList();

            studentSource.DataSource = filteredStudents;
            lbl_StudentResult.Text = $"{filteredStudents.Count} Out of {totalStudents}";
        }
        #endregion

        #region Teacher features
        private void toggle_InactiveTeacher_CheckedChanged(object sender, EventArgs e) => RefreshTeachers();
        public void RefreshTeachers()
        {
            var predicate = PredicateBuilder.New<User>(false).And(u => u.Teacher != null && u.Role == 2);

            if (!toggle_InactiveTeacher.Checked)
            {
                predicate = predicate.And(u => u.Teacher != null && u.Teacher.Status == 1);
            }

            var refreshedTeachers = db.Users
                .Where(predicate)
                .OrderByDescending(u => u.UserId)
                .Select(u => new
                {
                    u.UserId,
                    u.FirstName,
                    u.LastName,
                    u.Gender,
                    u.Email,
                    u.Phone,
                    u.Teacher!.Specialization,
                    u.Teacher.Department,
                    u.Teacher.HireDate,
                })
                .ToList();

            teacherSource.DataSource = refreshedTeachers;
            totalTeachers = refreshedTeachers.Count;
            lbl_TeacherResults.Text = $"{refreshedTeachers.Count} Out of {totalTeachers}";
        }
        private void btn_CreateTeacher_Click(object sender, EventArgs e)
        {
            UserAdd TeacherAddForm = new UserAdd(IsTeacher: true, logger);
            TeacherAddForm.FormClosed += (s, args) =>
            {
                this.Enabled = true;
                RefreshTeachers();
            };

            this.Enabled = false;
            TeacherAddForm.Show();
        }

        private void btn_UpdateTeacher_Click(object sender, EventArgs e)
        {
            if (dgv_Teachers.SelectedRows.Count == 1)
            {
                int userID = (int)dgv_Teachers.SelectedRows[0].Cells[0].Value;

                Form form = new UpdateCredentials(IsTeacher: true, userID, this, logger);
                form.FormClosed += (s, args) =>
                {
                    this.Enabled = true;
                    RefreshTeachers();
                };

                this.Enabled = false;
                form.Show();
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }
        }

        private void btn_DeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dgv_Teachers.SelectedRows.Count > 0)
            {
                var result = PoisonMessageBox.Show(this, "Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);
                if (result == DialogResult.Yes)
                {
                    HashSet<int> ids = dgv_Teachers.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(row => (int)row.Cells[0].Value)
                        // use hashset for more effecient look up
                        .ToHashSet<int>();

                    db.Teachers
                        .Where(s => ids.Contains(s.UserId))
                        .ExecuteUpdateAsync(s => s.SetProperty(
                            s => s.Status,
                            s => 0));

                    logger.Information("Delete Teachers", 
                        $"Succesfully deleted students, affected {dgv_Teachers.SelectedRows.Count} rows total.");

                    RefreshTeachers();
                }
            }
            else
            {
                MessageBox.Show("Select rows first");
            }
        }

        private void btn_TeacherDetail_Click(object sender, EventArgs e)
        {
            if (dgv_Teachers.SelectedRows.Count > 0)
            {
                int targetTeacherID = (int)dgv_Teachers.SelectedRows[0].Cells[0].Value;

                ShowDetailTeacher form = new ShowDetailTeacher(targetTeacherID);
                form.FormClosed += (s, args) =>
                {
                    this.Enabled = true;
                    RefreshTeachers();
                };

                this.Enabled = false;
                form.Show();
            }
            else
            {
                PoisonMessageBox.Show(this, "Please select a target row first.", "Missing target", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);
            }
        }
        private void tb_SearchTeachers_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchTeachers.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshTeachers();
                return;
            }

            var predicates = PredicateBuilder.New<User>(false);

            if (cb_Teacher_UserId.Checked)
            {
                predicates = predicates
                    .Or(u => u.UserId.ToString().Contains(filter));
            }

            if (cb_Teacher_Name.Checked)
            {
                predicates = predicates
                    .Or(u => (!string.IsNullOrEmpty(u.FirstName) && u.FirstName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.LastName) && u.LastName.ToLower().Contains(filter)));
            }

            if (cb_Teacher_DateOfBirth.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.DateOfBirth) && u.DateOfBirth.ToLower().Contains(filter));
            }

            if (cb_Teacher_Gender.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Gender) && u.Gender.ToLower() == filter);
            }

            if (cb_Teacher_Email.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Email) && u.Email.ToLower().Contains(filter));
            }

            if (cb_Teacher_Phone.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Phone) && u.Phone.ToLower().Contains(filter));
            }

            if (cb_Teacher_HireDate.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Teacher!.HireDate) && u.Teacher.HireDate.ToLower().Contains(filter));
            }

            if (cb_Teacher_Department.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Teacher!.Department) && u.Teacher.Department.ToLower().Contains(filter));
            }

            if (cb_Teacher_Specialization.Checked)
            {
                predicates = predicates.Or(u => !string.IsNullOrEmpty(u.Teacher!.Specialization) && u.Teacher.Specialization.ToLower().Contains(filter));
            }

            predicates = predicates.And(u => u.Role == 2 && u.Teacher != null);
            if (!toggle_InactiveTeacher.Checked)
            {
                predicates = predicates.And(u => u.Teacher!.Status == 1);
            }

            var filteredTeachers = db.Users
                .AsExpandable()
                .Where(predicates)
                .Select(u => new
                {
                    u.UserId,
                    u.FirstName,
                    u.LastName,
                    u.Gender,
                    u.Email,
                    u.Phone,
                    u.Teacher!.Specialization,
                    u.Teacher.Department,
                    u.Teacher.HireDate,
                })
                .ToList();

            teacherSource.DataSource = filteredTeachers;
            totalTeachers = filteredTeachers.Count;
            lbl_StudentResult.Text = $"{filteredTeachers.Count} Out of {totalTeachers}";
        }
        #endregion

        #region Courses
        private void btn_CreateCourse_Click(object sender, EventArgs e)
        {
            CourseAdd CourseAddForm = new CourseAdd(logger);
            CourseAddForm.FormClosed += (s, args) =>
            {
                this.Enabled = true;
                RefreshCourse();
            };

            this.Enabled = false;
            CourseAddForm.Show();
        }

        private void toggle_CourseInactive_CheckedChanged(object sender, EventArgs e) => RefreshCourse();
        private void RefreshCourse()
        {
            var predicate = PredicateBuilder.New<Course>(false);

            if (!toggle_CourseInactive.Checked)
            {
                predicate = predicate.Or(c => c.Status == 1);
            }

            var refreshedCourses = db.Courses
                .OrderByDescending(u => u.CourseId)
                .Where(predicate)
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
            totalCourse = refreshedCourses.Count;
            lbl_CourseResult.Text = $"{refreshedCourses.Count} out of {totalCourse}";
        }

        private void btn_DeleteCourse_Click(object sender, EventArgs e)
        {
            if (dgv_Students.SelectedRows.Count > 0)
            {
                var result = PoisonMessageBox.Show(this, "Are you sure you want to delete the selected courses?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);
                if (result == DialogResult.Yes)
                {
                    HashSet<int> ids = dgv_Courses.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(row => (int)row.Cells[0].Value)
                        // use hashset for more effecient look up
                        .ToHashSet<int>();

                    db.Courses
                        .Where(c => ids.Contains(c.CourseId))
                        .ExecuteUpdateAsync(c => c.SetProperty(
                            c => c.Status,
                            c => 0));

                    logger.Information("Delete Courses", 
                        $"Succesfully deleted course, affected {dgv_Courses.SelectedRows.Count} rows total.");

                    RefreshCourse();
                }
            }
            else
            {
                var result = CrownMessageBox.ShowInformation("Please select courses from the data grid.",
                    "Missing input",
                    ReaLTaiizor.Enum.Crown.DialogButton.YesNo);
            }
        }

        private void dgv_Courses_CellClick(object sender, DataGridViewCellEventArgs e) => LoadStudentSelection();
        private void toggle_CourseTaken_CheckedChanged(object sender, EventArgs e) => LoadStudentSelection();

        private int targetCourse = 0;
        private void LoadStudentSelection()
        {
            int targetCourse = (int)dgv_Courses.SelectedRows[0].Cells["CourseId"].Value;

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
        private void tb_SearchStudentCourse_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchStudentCourse.Text.ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                LoadStudentSelection();
                return;
            }
            var predicate = PredicateBuilder.New<Student>(false);

            if (cb_Course_ProgramFilter.Checked)
            {
                predicate.Or(s => s.Program!.Contains(filter));
            }

            if (cb_Course_NameFilter.Checked)
            {
                predicate = predicate.Or(s =>
                    (!string.IsNullOrEmpty(s.User.FirstName) && s.User.FirstName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(s.User.LastName) && s.User.LastName.ToLower().Contains(filter)));
            }

            predicate = predicate.And(s => s.User.Role == 3);
            if (toggle_CourseTaken.Checked)
            {
                predicate.And(s => db.CourseTakens
                .Any(ct => ct.StudentId == s.UserId && ct.CourseId == targetCourse));
            }
            else
            {
                predicate.And(s => !db.CourseTakens
                .Any(ct => ct.StudentId == s.UserId && ct.CourseId == targetCourse));
            }

            var filteredStudents = db.Students
                .AsExpandable()
                .Where(predicate)
                .Select(s => new
                {
                    s.UserId,
                    Name = s.User.FirstName + " " + s.User.LastName,
                    s.Program
                })
                .ToList();

            dgv_StudentSelection.DataSource = filteredStudents;
        }
        private void btn_UpdateCourse_Click(object sender, EventArgs e)
        {
            if (dgv_Courses.SelectedRows.Count == 1)
            {
                int courseID = (int)dgv_Courses.SelectedRows[0].Cells[0].Value;

                Form updateForm = new UpdateCourse(courseID, logger);
                updateForm.FormClosed += (s, args) =>
                {
                    this.Enabled = true;
                    RefreshCourse();
                };

                this.Enabled = false;
                updateForm.Show();
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }

        }
        private void tb_SearchCourse_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchCourse.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshCourse();
                return;
            }

            var filteredCourse = db.Courses
                .Where(c => c.CourseId.ToString().Contains(filter) ||
                    c.CourseName.ToLower().Contains(filter))
                .Select(c => new
                {
                    c.CourseId,
                    c.CourseCode,
                    c.CourseName,
                    c.Description,
                    c.Department,
                    c.Credits,
                    c.TeacherId
                })
                .ToList();

            courseSource.DataSource = filteredCourse;
            lbl_CourseResult.Text = $"{filteredCourse.Count} out of {totalCourse}";
        }
        #endregion


        #region Account Settings

        private void btn_SaveChangesSettings_Click(object sender, EventArgs e)
        {
            var res = CrownMessageBox.ShowInformation("Are you sure you want to save changes?", "Account Info", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

            if (res == DialogResult.Yes)
            {
                current_User!.UserLogin!.ProfileLink = tb_ProfileLink.Text;
                db.SaveChanges();
                logger.Information("Change Profile", "User changed profile");

                pb_ProfilePicture.LoadAsync(tb_ProfileLink.Text);
            }
        }
        #endregion

    }
}
