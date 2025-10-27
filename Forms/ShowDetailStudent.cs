using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;
using System.Data;

namespace Student_Information_System.Forms
{
    public partial class ShowDetailStudent : Form
    {
        private SisContextLogger logger;
         
        SisContext db = new();
        User _currentStudent;
        private readonly int userID;
        private BindingSource courseSource = new();

        public ShowDetailStudent(int userID, SisContextLogger logger)
        {
            InitializeComponent();
            this.userID = userID;
            this.logger = logger;

            loadData(); 
            dgv_Courses.DataSource = courseSource;
        }

        private void loadData()
        {
            _currentStudent = db.Users
                .Include(u => u.UserLogin)
                .Include(u => u.Student)
                .First(u => u.UserId == userID);

            lbl_StudentID.Text = "Student ID: " + _currentStudent?.UserLogin?.Username;
            lbl_StudentName.Text = "Student Name: " + $"{_currentStudent?.LastName}, {_currentStudent?.FirstName}";
            lbl_StudentProgram.Text = "Student Program: " + _currentStudent!.Student!.Program;

            courseSource.DataSource = db.CourseTakens
                .Where(ct => ct.StudentId == userID)
                .Include(ct => ct.Course)
                .Select(ct => ct.Course)
                .ToList();
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            var result = CrownMessageBox.ShowInformation("Are you sure the details are correct?", "Save Changes", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

            if (result == DialogResult.Yes)
            {
                db.SaveChanges();
                this.Close();
            }
        }

        private void btn_RemoveCourse_Click(object sender, EventArgs e)
        {
            int courseTargetId = (int)dgv_Courses.SelectedRows[0].Cells[0].Value;

            var taken = db.CourseTakens.FirstOrDefault(u => u.StudentId == _currentStudent.UserId && u.CourseId == courseTargetId);
            if (taken is null)
            {
                CrownMessageBox.ShowInformation(
                    "Error: Course not found",
                    "Error finding",
                    ReaLTaiizor.Enum.Crown.DialogButton.YesNo);

                return;
            }

            db.CourseTakens.Remove(taken);
            // Remove from display
            dgv_Courses.Rows.Remove(dgv_Courses.SelectedRows[0]);
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
