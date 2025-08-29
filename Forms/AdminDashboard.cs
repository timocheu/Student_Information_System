using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using Student_Information_System.Models;
using Student_Information_System.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private SisContext db = new SisContext();
        User current_User;

        public AdminDashboard(int userId)
        {
            InitializeComponent();

            GetUserInfo(userId);
            lbl_Welcome.Text = $"Welcome {current_User?.FirstName}";

            // Query all students
            RefreshStudents();

            RefreshTeacher();
        }

        private void GetUserInfo(int user_id)
        {
            using (var context = new SisContext())
            {
                User? current_User = context.Users.FirstOrDefault(u => u.UserId == user_id);
                if (current_User is null)
                {
                    throw new Exception("Unable to find the user in the database.");
                }

                this.current_User = current_User;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var result = PoisonMessageBox.Show(this, "Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);

            if (result == DialogResult.Yes) this.Close();
        }

        #region Student features
        private void RefreshStudents()
        {
            var users = db.Users
                               .Where(u => u.Role == 3 && u.Student != null && u.Student.Status == 1)
                               .Select(u => new
                               {
                                   u.UserId,
                                   u.FirstName,
                                   u.LastName,
                                   u.Gender,
                                   u.DateOfBirth,
                                   u.Email,
                                   u.Phone,
                                   Enrollment_date = u.Student.EnrollmentDate,
                               })
                               .OrderByDescending(u => u.UserId)
                               .ToList();

            dgv_Student.DataSource = users;
            lbl_StudentResult.Text = $"Result: {users.Count}";
        }
        private void btn_RefreshStudent_Click(object sender, EventArgs e) => RefreshStudents();


        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            Form StudentAddForm = new UserAdd(IsTeacher: false);
            StudentAddForm.FormClosed += (s, args) => this.Enabled = true;

            this.Enabled = false;
            StudentAddForm.Show();
        }

        private void btn_DeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgv_Student.SelectedRows.Count > 0)
            {
                var result = PoisonMessageBox.Show(this, "Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);
                if (result == DialogResult.Yes)
                {
                    using SisContext db = new();

                    HashSet<int> ids = dgv_Student.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(row => (int)row.Cells[0].Value)
                        // use hashset for more effecient look up
                        .ToHashSet<int>();

                    db.Students
                        .Where(s => ids.Contains(s.UserId))
                        .ExecuteUpdateAsync(s => s.SetProperty(
                            s => s.Status,
                            s => 0));
                }
            }
            else
            {
                MessageBox.Show("Select rows first");
            }
        }

        private void btn_UpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgv_Student.SelectedRows.Count == 1)
            {
                var row = dgv_Student.SelectedRows[0];

                User user;
                using (SisContext db = new())
                {
                    user = db.Users.First(u => u.UserId == (int)row.Cells[0].Value);
                }

                Form form = new UserAdd(false, user);
                form.FormClosed += (s, args) => this.Enabled = true;

                this.Enabled = false;
                form.Show();
            }
            else
            {
                MessageBox.Show("Select a single row first");
            }
        }

        #endregion




        #region Teacher features
        private void RefreshTeacher()
        {
            using (var context = new SisContext())
            {
                var users = context.Users
                                   .Where(u => u.Role == 2 && u.Teacher != null && u.Teacher.Status == 1)
                                   .Select(u => new
                                   {
                                       u.UserId,
                                       u.FirstName,
                                       u.LastName,
                                       u.Gender,
                                       u.Email,
                                       u.Phone,
                                       Department = u.Teacher != null ? u.Teacher.Department : null,
                                       Specialization = u.Teacher != null ? u.Teacher.Specialization : null,
                                   })
                                   .ToList();

                dgv_Teacher.DataSource = users;
            }
        }
        private void btn_RefreshTeacher_Click(object sender, EventArgs e) => RefreshTeacher();

        private void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            Form TeacherAddForm = new UserAdd(IsTeacher: true);
            TeacherAddForm.FormClosed += (s, args) => this.Enabled = true;

            this.Enabled = false;
            TeacherAddForm.Show();
        }

        #endregion


        private void tb_SearchStudent_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchStudent.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshStudents();
            }
            else
            {
                var user = db.Users
                    .Where(u => u.Role == 3 && u.Student != null && u.Student.Status == 1 &&
                    ((!string.IsNullOrEmpty(u.FirstName) && u.FirstName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.LastName) && u.LastName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.Address) && u.Address.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.DateOfBirth) && u.DateOfBirth.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.Gender) && u.Gender.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.Phone) && u.Phone.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(u.Email) && u.Email.ToLower().Contains(filter))))
                    .Select(u => new
                    {
                        u.UserId,
                        u.FirstName,
                        u.LastName,
                        u.Gender,
                        u.DateOfBirth,
                        u.Email,
                        u.Phone,
                        Enrollment_date = u.Student.EnrollmentDate,
                    })
                    .OrderByDescending(u => u.UserId)
                    .ToList();

                dgv_Student.DataSource = user;
                lbl_StudentResult.Text = $"Result: {user.Count}";
            }
        }
    }
}
