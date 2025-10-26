using Microsoft.EntityFrameworkCore;
using Student_Information_System.Models;
using ReaLTaiizor.Controls;
using LinqKit.Core;
using LinqKit;

namespace Student_Information_System.Forms
{
    public partial class UpdateCourse : Form
    {
        // Logger
        private SisContextLogger logger;

        private SisContext db = new();
        private Course _currentCourse;
        public UpdateCourse(int courseID, SisContextLogger logger)
        {
            this.logger = logger;
            _currentCourse = db.Courses
                .Include(c => c.Teacher)
                .First(c => c.CourseId == courseID);
            InitializeComponent();

            // Set the datas
            tb_CourseCode.Text = _currentCourse.CourseCode;
            tb_CourseName.Text = _currentCourse.CourseName;
            tb_CourseDepartment.Text = _currentCourse.Department;
            tb_CourseDescription.Text = _currentCourse.Description;
            cbb_Credits.Text = _currentCourse.Credits.ToString();
            lbl_TeacherID.Text = "TeacherID: " + _currentCourse!.Teacher!.UserId.ToString();

            loadTeachers();
        }

        private void loadTeachers()
        {
            dgv_Teachers.DataSource = db.Users
                .Where(u => u.Role == 2 && u.Teacher != null && u.Teacher.Status == 1)
                .OrderByDescending(u => u.UserId)
                .Select(u => new
                {
                    u.UserId,
                    Name = u.FirstName + " " + u.LastName,
                    u.Teacher!.Department,
                    u.Teacher.Specialization,
                })
                .ToList();
        }

        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (dgv_Teachers.SelectedRows.Count > 0)
            {
                _currentCourse.CourseName = tb_CourseName.Text;
                _currentCourse.CourseCode = tb_CourseCode.Text;
                _currentCourse.Description = tb_CourseDescription.Text;
                _currentCourse.Department = tb_CourseDepartment.Text;
                _currentCourse.Credits = int.Parse(cbb_Credits.Text);
                _currentCourse.TeacherId = (int)dgv_Teachers.SelectedRows[0].Cells[0].Value;

                var result = CrownMessageBox.ShowInformation("Is this the correct information?", "Confirm Update Course", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.SaveChanges();
                        logger.Information(
                                "Update Course", 
                                $"Updating CourseId: {_currentCourse.CourseId}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Update failed: {ex.GetType} says {ex.Message}");
                        logger.Error(
                                "Update Course", 
                                $"{ex.GetType} says {ex.Message}");
                    }

                    this.Close();
                }
            }
            else
            {
                CrownMessageBox.ShowInformation("Please select a row first",
                    "Missing fields",
                    ReaLTaiizor.Enum.Crown.DialogButton.Ok);
            }

        }

        private void dgv_Teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Teachers.SelectedRows.Count == 1)
            {
                tb_CourseDepartment.Text = (string)dgv_Teachers.SelectedRows[0].Cells["Department"].Value;
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }
        }

        private void tb_SearchInstructor_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchInstructor.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                loadTeachers();
                return;
            }

            var predicates = PredicateBuilder.New<User>(false)
                .And(u => u.Role == 2);

            if (cb_UserID.Checked)
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

            if (cb_Department.Checked)
            {
                predicates = predicates
                    .Or(u => string.IsNullOrEmpty(u.Teacher!.Department) && u.Teacher!.Department!.Contains(filter));
            }

            if (cb_Specialization.Checked)
            {
                predicates = predicates
                    .Or(u => string.IsNullOrEmpty(u.Teacher!.Department) && u.Teacher!.Specialization!.Contains(filter));
            }

            predicates = predicates.And(u => u.Role == 2 && u.Teacher!.Status == 1);

            dgv_Teachers.DataSource = db.Users
                .AsExpandable()
                .Where(predicates)
                .Select(u => new
                {
                    u.UserId,
                    Name = u.FirstName + " " + u.LastName,
                    u.Teacher!.Department,
                    u.Teacher.Specialization,
                })
                .ToList();
        }
    }
}
