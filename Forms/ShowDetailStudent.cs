using Microsoft.EntityFrameworkCore;
using Student_Information_System.Models;
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
    public partial class ShowDetailStudent : Form
    {
        private readonly int userID;
        private BindingSource courseSource;

        public ShowDetailStudent(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            loadCourse();
        }

        private void loadCourse()
        {
            using (SisContext db = new())
            {
                courseSource.DataSource = db.CourseTakens
                    .Where(ct => ct.StudentId == userID)
                    .Include(ct => ct.Course)
                    .Select(ct => ct.Course)
                    .ToList();
            }
        }
    }
}
