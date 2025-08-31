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
        private User current_User;

        // Stored data for filters
        private IQueryable<User> Students;
        private IQueryable<User> Teachers;

        // Toggles
        private bool ShowInactiveStudents = false;
        private bool ShowInactiveTeachers = false;


        public AdminDashboard(int userId)
        {
            InitializeComponent();

            GetUserInfo(userId);

            // Initialize data
            Students = db.Users
                .Where(u => u.Role == 3 && u.Student != null)
                .OrderByDescending(u => u.UserId);

            RefreshStudents();
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
        private void RefreshStudents()
        {
            var user = Students;

            if (!ShowInactiveStudents)
            {
                user = user.Where(u => u.Student.Status == 1);
            }

            dgv_Students.DataSource = user
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
                .ToList();

            lbl_StudentResult.Text = $"{user.Count()} Out of {user.Count()}";
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
                var row = dgv_Students.SelectedRows[0];

                User user;
                user = db.Users.First(u => u.UserId == (int)row.Cells[0].Value);

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
        private void toggle_InactiveStudent_MouseCaptureChanged(object sender, EventArgs e)
        {
            ShowInactiveStudents ^= true;
            RefreshStudents();
        }
        private void tb_SearchStudent_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_SearchStudent.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshStudents();
                return;
            }

            var user = Students.Where(u =>
                (!string.IsNullOrEmpty(u.FirstName) && u.FirstName.ToLower().Contains(filter)) ||
                (!string.IsNullOrEmpty(u.LastName) && u.LastName.ToLower().Contains(filter)) ||
                (!string.IsNullOrEmpty(u.Address) && u.Address.ToLower().Contains(filter)) ||
                (!string.IsNullOrEmpty(u.DateOfBirth) && u.DateOfBirth.ToLower().Contains(filter)) ||
                (!string.IsNullOrEmpty(u.Gender) && u.Gender.ToLower().Contains(filter)) ||
                (!string.IsNullOrEmpty(u.Phone) && u.Phone.ToLower().Contains(filter)) ||
                (!string.IsNullOrEmpty(u.Email) && u.Email.ToLower().Contains(filter)));

            if (!ShowInactiveStudents)
            {
                user = user.Where(u => u.Student.Status == 1);
            }

            dgv_Students.DataSource = user
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

            lbl_StudentResult.Text = $"{10} Out of {user.Count()}";
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

        private void lbl_ShowInactiveStudent_Click(object sender, EventArgs e)
        {

        }

        private void hope_AdminDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
