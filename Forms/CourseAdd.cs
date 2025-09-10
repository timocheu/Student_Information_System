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
            dgv_Teachers.CellClick += Dgv_Teachers_CellClick;
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
                .ToList();
        }

        private void Dgv_Teachers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Teachers.SelectedRows.Count == 1)
            {
                string department = (string) dgv_Teachers.SelectedRows[0].Cells["Department"].Value;

                tb_CourseDepartment.Text = department;
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }
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
