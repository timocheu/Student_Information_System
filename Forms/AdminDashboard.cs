using Microsoft.Data.Sqlite;
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
                                       u.Role,
                                       Enrollment_Date = u.Student.EnrollmentDate,
                                   })
                                   .ToList();

                dgv_Student.DataSource = users;
            }
        }

        private void RefreshTeacher()
        {
            using (var context = new SisContext())
            {
                var users = context.Users
                                   .Where(u => u.Role == 2 && u.Teacher.Status == 1)
                                   .Select(u => new
                                   {
                                       u.UserId,
                                       u.FirstName,
                                       u.LastName,
                                       u.Gender,
                                       u.Email,
                                       u.Phone,
                                       u.Teacher.Department,
                                       u.Teacher.Specialization,
                                   })
                                   .ToList();

                dgv_Teacher.DataSource = users;
            }

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
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            Form StudentAddForm = new UserAdd(false);
            StudentAddForm.FormClosed += (s, args) =>
            {
                this.Show();
                RefreshStudent();
            };

            this.Hide();
            StudentAddForm.Show();
        }

        private void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            Form TeacherAddForm = new UserAdd(false);
            TeacherAddForm.FormClosed += (s, args) =>
            {
                this.Show();
                RefreshStudent();
            };

            this.Hide();
            TeacherAddForm.Show();
        }

        private void btn_RefreshStudent_Click(object sender, EventArgs e) => RefreshStudent();
        private void btn_RefreshTeacher_Click(object sender, EventArgs e) => RefreshTeacher();
    }
}
