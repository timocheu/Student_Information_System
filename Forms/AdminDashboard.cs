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
        object[]? user = new object[9];

        public AdminDashboard(int user_id)
        {
            InitializeComponent();

            GetUserInfo(user_id);
            lbl_Welcome.Text = $"Welcom {user[1]}";

            RefreshTeacher();
            RefreshStudent();
        }

        private void GetUserInfo(int user_id)
        {
            using var conn = new SqliteConnection(Account.SqliteDbPath());
            conn.Open();

            using var cmd = new SqliteCommand($"SELECT * FROM User WHERE user_id = {user_id}", conn);
            using var r = cmd.ExecuteReader();

            if (!r.Read()) return;

            int fields = r.GetValues(user!);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var result = PoisonMessageBox.Show(this, "Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 200);

            if (result == DialogResult.Yes) this.Close();
        }


        #region Student features
        private void RefreshStudent()
        {
            using (var context = new SisContext())
            {
                var users = context.Users
                                   .Where(u => u.Role == 3 && u.Student.Status == 1)
                                   .Select(u => new
                                   {
                                       u.UserId,
                                       u.FirstName,
                                       u.LastName,
                                       u.Gender,
                                       u.Email,
                                       u.Phone,
                                       Enrollment_Date = u.Student.EnrollmentDate,
                                   })
                                   .ToList();

                dgv_Student.DataSource = users;
            }
        }
        private void btn_RefreshStudent_Click(object sender, EventArgs e) => RefreshStudent();


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


    }
}
