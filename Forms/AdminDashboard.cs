using Microsoft.Data.Sqlite;
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
        }

        private async void GetUserInfo(int user_id)
        {
            using var conn = new SqliteConnection(Account.SqliteDbPath());
            conn.Open();

            using var cmd = new SqliteCommand($"SELECT * FROM User WHERE user_id = {user_id}", conn);
            using var r = cmd.ExecuteReader();

            if (!r.Read()) return;

            int fields = r.GetValues(user!);
            MessageBox.Show($"the fields of user is: {fields}");
        }

        private void tab_Logout_Click(object sender, EventArgs e)
        {

        }
    }
}
