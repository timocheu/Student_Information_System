using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;

namespace Student_Information_System.Forms
{
    public partial class CourseAdd : Form
    {
        SisContext db = new();

        public CourseAdd()
        {
            InitializeComponent();

            // TODO:
            // 1. Display teachers
            loadTeachers();
            // 2. Make the department of course, same as teacher's deparment
            // 4. Search for teacher's department or name
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
                .ToList() ;
        }

        // Dispose
        private void btn_Back_Click(object sender, EventArgs e) => this.Close(); 

        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            //
            // TODO:
            //
            // 3. Confirm
            var result = CrownMessageBox.ShowInformation("Is this the correct information?", "Confirm Adding Course", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);
        }
    }
}
