using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using LinqKit;
using LinqKit.Core;

namespace Student_Information_System.Forms
{
    public partial class CourseAdd : Form
    {
        SisContext db = new();

        public CourseAdd()
        {
            InitializeComponent();

            loadTeachers();
            // Make the department of course, same as teacher's deparment
            dgv_Teachers.CellClick += Dgv_Teachers_CellClick;

            //  Search for teacher's department or name
            tb_SearchInstructor.TextChanged += Tb_SearchInstructor_TextChanged;
        }

        private void Tb_SearchInstructor_TextChanged(object? sender, EventArgs e)
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

            predicates = predicates.And(u => u.Role == 2 && u.Teacher.Status == 1);

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
