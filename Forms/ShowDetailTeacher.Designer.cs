namespace Student_Information_System.Forms
{
    partial class ShowDetailTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            hope_TeacherDetails = new ReaLTaiizor.Forms.HopeForm();
            dgv_StudentUnder = new ReaLTaiizor.Controls.PoisonDataGridView();
            dgv_CoursesHandled = new ReaLTaiizor.Controls.PoisonDataGridView();
            lbl_TeacherDepartment = new Label();
            lbl_TeacherID = new Label();
            lbl_TeacherName = new Label();
            lbl_TeacherSpecialization = new Label();
            lbl_StudentsUnder = new Label();
            lbl_Course = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_StudentUnder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_CoursesHandled).BeginInit();
            SuspendLayout();
            // 
            // hope_TeacherDetails
            // 
            hope_TeacherDetails.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_TeacherDetails.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_TeacherDetails.ControlBoxColorN = Color.White;
            hope_TeacherDetails.Dock = DockStyle.Top;
            hope_TeacherDetails.Font = new Font("Poppins", 14.25F);
            hope_TeacherDetails.ForeColor = Color.FromArgb(242, 246, 252);
            hope_TeacherDetails.Image = Properties.Resources.FormIcon;
            hope_TeacherDetails.Location = new Point(0, 0);
            hope_TeacherDetails.Name = "hope_TeacherDetails";
            hope_TeacherDetails.Size = new Size(898, 40);
            hope_TeacherDetails.TabIndex = 4;
            hope_TeacherDetails.Text = "Student Details";
            hope_TeacherDetails.ThemeColor = Color.FromArgb(204, 102, 0);
            // 
            // dgv_StudentUnder
            // 
            dgv_StudentUnder.AllowUserToAddRows = false;
            dgv_StudentUnder.AllowUserToDeleteRows = false;
            dgv_StudentUnder.AllowUserToResizeColumns = false;
            dgv_StudentUnder.AllowUserToResizeRows = false;
            dgv_StudentUnder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_StudentUnder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_StudentUnder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_StudentUnder.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_StudentUnder.BorderStyle = BorderStyle.None;
            dgv_StudentUnder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_StudentUnder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_StudentUnder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_StudentUnder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_StudentUnder.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_StudentUnder.EnableHeadersVisualStyles = false;
            dgv_StudentUnder.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_StudentUnder.GridColor = Color.Black;
            dgv_StudentUnder.Location = new Point(32, 363);
            dgv_StudentUnder.Name = "dgv_StudentUnder";
            dgv_StudentUnder.ReadOnly = true;
            dgv_StudentUnder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_StudentUnder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_StudentUnder.RowHeadersVisible = false;
            dgv_StudentUnder.RowHeadersWidth = 20;
            dgv_StudentUnder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_StudentUnder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_StudentUnder.Size = new Size(840, 212);
            dgv_StudentUnder.TabIndex = 21;
            dgv_StudentUnder.UseCustomBackColor = true;
            dgv_StudentUnder.UseCustomForeColor = true;
            dgv_StudentUnder.UseStyleColors = true;
            // 
            // dgv_CoursesHandled
            // 
            dgv_CoursesHandled.AllowUserToAddRows = false;
            dgv_CoursesHandled.AllowUserToDeleteRows = false;
            dgv_CoursesHandled.AllowUserToResizeColumns = false;
            dgv_CoursesHandled.AllowUserToResizeRows = false;
            dgv_CoursesHandled.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_CoursesHandled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CoursesHandled.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_CoursesHandled.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_CoursesHandled.BorderStyle = BorderStyle.None;
            dgv_CoursesHandled.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_CoursesHandled.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_CoursesHandled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_CoursesHandled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_CoursesHandled.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_CoursesHandled.EnableHeadersVisualStyles = false;
            dgv_CoursesHandled.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_CoursesHandled.GridColor = Color.Black;
            dgv_CoursesHandled.Location = new Point(32, 174);
            dgv_CoursesHandled.Name = "dgv_CoursesHandled";
            dgv_CoursesHandled.ReadOnly = true;
            dgv_CoursesHandled.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_CoursesHandled.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_CoursesHandled.RowHeadersVisible = false;
            dgv_CoursesHandled.RowHeadersWidth = 20;
            dgv_CoursesHandled.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_CoursesHandled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CoursesHandled.Size = new Size(840, 140);
            dgv_CoursesHandled.TabIndex = 20;
            dgv_CoursesHandled.UseCustomBackColor = true;
            dgv_CoursesHandled.UseCustomForeColor = true;
            dgv_CoursesHandled.UseStyleColors = true;
            dgv_CoursesHandled.CellClick += dgv_CoursesHandled_CellClick;
            // 
            // lbl_TeacherDepartment
            // 
            lbl_TeacherDepartment.AutoSize = true;
            lbl_TeacherDepartment.Font = new Font("Poppins", 12F);
            lbl_TeacherDepartment.Location = new Point(444, 62);
            lbl_TeacherDepartment.Name = "lbl_TeacherDepartment";
            lbl_TeacherDepartment.Size = new Size(182, 28);
            lbl_TeacherDepartment.TabIndex = 24;
            lbl_TeacherDepartment.Text = "Teacher Department:";
            // 
            // lbl_TeacherID
            // 
            lbl_TeacherID.AutoSize = true;
            lbl_TeacherID.Font = new Font("Poppins", 12F);
            lbl_TeacherID.Location = new Point(32, 62);
            lbl_TeacherID.Name = "lbl_TeacherID";
            lbl_TeacherID.Size = new Size(100, 28);
            lbl_TeacherID.TabIndex = 23;
            lbl_TeacherID.Text = "Teacher ID:";
            // 
            // lbl_TeacherName
            // 
            lbl_TeacherName.AutoSize = true;
            lbl_TeacherName.Font = new Font("Poppins", 12F);
            lbl_TeacherName.Location = new Point(32, 100);
            lbl_TeacherName.Name = "lbl_TeacherName";
            lbl_TeacherName.Size = new Size(133, 28);
            lbl_TeacherName.TabIndex = 22;
            lbl_TeacherName.Text = "Teacher Name:";
            // 
            // lbl_TeacherSpecialization
            // 
            lbl_TeacherSpecialization.AutoSize = true;
            lbl_TeacherSpecialization.Font = new Font("Poppins", 12F);
            lbl_TeacherSpecialization.Location = new Point(444, 102);
            lbl_TeacherSpecialization.Name = "lbl_TeacherSpecialization";
            lbl_TeacherSpecialization.Size = new Size(196, 28);
            lbl_TeacherSpecialization.TabIndex = 25;
            lbl_TeacherSpecialization.Text = "Teacher Specialization:";
            // 
            // lbl_StudentsUnder
            // 
            lbl_StudentsUnder.AutoSize = true;
            lbl_StudentsUnder.Font = new Font("Poppins", 12F);
            lbl_StudentsUnder.Location = new Point(32, 332);
            lbl_StudentsUnder.Name = "lbl_StudentsUnder";
            lbl_StudentsUnder.Size = new Size(136, 28);
            lbl_StudentsUnder.TabIndex = 26;
            lbl_StudentsUnder.Text = "Students under:";
            // 
            // lbl_Course
            // 
            lbl_Course.AutoSize = true;
            lbl_Course.Font = new Font("Poppins", 12F);
            lbl_Course.Location = new Point(32, 143);
            lbl_Course.Name = "lbl_Course";
            lbl_Course.Size = new Size(71, 28);
            lbl_Course.TabIndex = 27;
            lbl_Course.Text = "Course:";
            // 
            // ShowDetailTeacher
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(898, 599);
            Controls.Add(lbl_Course);
            Controls.Add(lbl_StudentsUnder);
            Controls.Add(lbl_TeacherSpecialization);
            Controls.Add(lbl_TeacherDepartment);
            Controls.Add(lbl_TeacherID);
            Controls.Add(lbl_TeacherName);
            Controls.Add(dgv_StudentUnder);
            Controls.Add(dgv_CoursesHandled);
            Controls.Add(hope_TeacherDetails);
            Font = new Font("Poppins", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "ShowDetailTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowDetailTeacher";
            ((System.ComponentModel.ISupportInitialize)dgv_StudentUnder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_CoursesHandled).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_TeacherDetails;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_StudentUnder;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_CoursesHandled;
        private Label lbl_TeacherDepartment;
        private Label lbl_TeacherID;
        private Label lbl_TeacherName;
        private Label lbl_TeacherSpecialization;
        private Label lbl_StudentsUnder;
        private Label lbl_Course;
    }
}