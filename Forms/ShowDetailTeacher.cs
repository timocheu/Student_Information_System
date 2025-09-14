using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using System.Data;

namespace Student_Information_System.Forms
{
    public partial class ShowDetailTeacher : Form
    {
        private SisContext db = new();
        private User _currentTeacher;
        private readonly int teacherID;

        public ShowDetailTeacher(int teacherID)
        {
            InitializeComponent();
            this.teacherID = teacherID;

            loadData();
        }

        private void loadData()
        {
            _currentTeacher = db.Users
                .Include(u => u.Teacher)
                .First(t => t.UserId == teacherID);

            lbl_TeacherID.Text = "Teacher ID: " + _currentTeacher?.UserLogin?.Username;
            lbl_TeacherName.Text = "Teacher Name: " + $"{_currentTeacher?.LastName}, {_currentTeacher?.FirstName}";
            lbl_TeacherDepartment.Text = "Teacher Department: " + _currentTeacher!.Teacher!.Department;
            lbl_TeacherSpecialization.Text = "Teacher Specialization: " + _currentTeacher!.Teacher!.Specialization;

            dgv_CoursesHandled.DataSource = db.Courses.
                Where(c => c.TeacherId == teacherID)
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
        }

        private void dgv_CoursesHandled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_CoursesHandled.SelectedRows.Count > 0)
            {
                // get the value of the courseid
                int courseTargetID = (int)dgv_CoursesHandled.SelectedRows[0].Cells[0].Value;

                dgv_StudentUnder.DataSource = db.Students
                    .Where(s => db.CourseTakens.
                        Any(ct => ct.StudentId == s.UserId && ct.CourseId == courseTargetID))
                    .Select(s => new
                    {
                        s.UserId,
                        Name = s.User.FirstName + " " + s.User.LastName,
                        s.Program
                    })
                    .ToList();
            }
            else
            {
                CrownMessageBox.ShowInformation("Please select a single row", "Missing target", ReaLTaiizor.Enum.Crown.DialogButton.Ok);
            }
        }
    }
}
