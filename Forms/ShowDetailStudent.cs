using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using System.Data;

namespace Student_Information_System.Forms
{
    public partial class ShowDetailStudent : Form
    {
        SisContext db = new();
        private readonly int userID;
        private BindingSource courseSource = new();

        public ShowDetailStudent(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            loadData();
            dgv_Courses.DataSource = courseSource;
        }

        private void loadData()
        {
            var user = db.Users
                .Include(u => u.UserLogin)
                .FirstOrDefault(u => u.UserId == userID);

            lbl_StudentID.Text = "Student ID: " + user?.UserLogin?.Username;
            lbl_StudentName.Text = "Student Name: " + $"{user?.LastName}, {user?.FirstName}";

            courseSource.DataSource = db.CourseTakens
                .Where(ct => ct.StudentId == userID)
                .Include(ct => ct.Course)
                .Select(ct => ct.Course)
                .ToList();
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            var studentCourse = new CourseTaken
            {
                StudentId = userID,
            };

            db.CourseTakens.Add(studentCourse);
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            var result = CrownMessageBox.ShowInformation("Are you sure the details are correct?", "Save Changes", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}
