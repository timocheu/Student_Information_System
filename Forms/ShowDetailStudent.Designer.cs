namespace Student_Information_System.Forms
{
    partial class ShowDetailStudent
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            hope_StudentDetails = new ReaLTaiizor.Forms.HopeForm();
            dgv_Courses = new ReaLTaiizor.Controls.PoisonDataGridView();
            btn_RemoveCourse = new ReaLTaiizor.Controls.HopeButton();
            lbl_StudentName = new Label();
            lbl_StudentID = new Label();
            btn_SaveChanges = new ReaLTaiizor.Controls.HopeButton();
            lbl_StudentProgram = new Label();
            btn_Back = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).BeginInit();
            SuspendLayout();
            // 
            // hope_StudentDetails
            // 
            hope_StudentDetails.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_StudentDetails.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_StudentDetails.ControlBoxColorN = Color.White;
            hope_StudentDetails.Dock = DockStyle.Top;
            hope_StudentDetails.Font = new Font("Poppins", 14.25F);
            hope_StudentDetails.ForeColor = Color.FromArgb(242, 246, 252);
            hope_StudentDetails.Image = Properties.Resources.FormIcon;
            hope_StudentDetails.Location = new Point(0, 0);
            hope_StudentDetails.MaximizeBox = false;
            hope_StudentDetails.Name = "hope_StudentDetails";
            hope_StudentDetails.Size = new Size(900, 40);
            hope_StudentDetails.TabIndex = 3;
            hope_StudentDetails.Text = "Student Details";
            hope_StudentDetails.ThemeColor = Color.FromArgb(204, 102, 0);
            // 
            // dgv_Courses
            // 
            dgv_Courses.AllowUserToAddRows = false;
            dgv_Courses.AllowUserToDeleteRows = false;
            dgv_Courses.AllowUserToResizeColumns = false;
            dgv_Courses.AllowUserToResizeRows = false;
            dgv_Courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Courses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_Courses.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Courses.BorderStyle = BorderStyle.None;
            dgv_Courses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Courses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Courses.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Courses.EnableHeadersVisualStyles = false;
            dgv_Courses.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Courses.GridColor = Color.Black;
            dgv_Courses.Location = new Point(33, 186);
            dgv_Courses.Name = "dgv_Courses";
            dgv_Courses.ReadOnly = true;
            dgv_Courses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Courses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Courses.RowHeadersVisible = false;
            dgv_Courses.RowHeadersWidth = 20;
            dgv_Courses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Courses.Size = new Size(836, 347);
            dgv_Courses.TabIndex = 4;
            dgv_Courses.UseCustomBackColor = true;
            dgv_Courses.UseCustomForeColor = true;
            dgv_Courses.UseStyleColors = true;
            // 
            // btn_RemoveCourse
            // 
            btn_RemoveCourse.BorderColor = Color.FromArgb(220, 223, 230);
            btn_RemoveCourse.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_RemoveCourse.DangerColor = Color.FromArgb(245, 108, 108);
            btn_RemoveCourse.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_RemoveCourse.Font = new Font("Poppins", 12F);
            btn_RemoveCourse.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_RemoveCourse.InfoColor = Color.FromArgb(144, 147, 153);
            btn_RemoveCourse.Location = new Point(729, 131);
            btn_RemoveCourse.Margin = new Padding(30, 3, 3, 3);
            btn_RemoveCourse.Name = "btn_RemoveCourse";
            btn_RemoveCourse.PrimaryColor = Color.FromArgb(166, 9, 22);
            btn_RemoveCourse.Size = new Size(140, 40);
            btn_RemoveCourse.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_RemoveCourse.TabIndex = 6;
            btn_RemoveCourse.Text = "Delete Course";
            btn_RemoveCourse.TextColor = Color.White;
            btn_RemoveCourse.WarningColor = Color.FromArgb(230, 162, 60);
            btn_RemoveCourse.Click += btn_RemoveCourse_Click;
            // 
            // lbl_StudentName
            // 
            lbl_StudentName.AutoSize = true;
            lbl_StudentName.Font = new Font("Poppins", 12F);
            lbl_StudentName.Location = new Point(33, 118);
            lbl_StudentName.Name = "lbl_StudentName";
            lbl_StudentName.Size = new Size(129, 28);
            lbl_StudentName.TabIndex = 7;
            lbl_StudentName.Text = "Student Name:";
            // 
            // lbl_StudentID
            // 
            lbl_StudentID.AutoSize = true;
            lbl_StudentID.Font = new Font("Poppins", 12F);
            lbl_StudentID.Location = new Point(33, 80);
            lbl_StudentID.Name = "lbl_StudentID";
            lbl_StudentID.Size = new Size(96, 28);
            lbl_StudentID.TabIndex = 8;
            lbl_StudentID.Text = "Student ID:";
            // 
            // btn_SaveChanges
            // 
            btn_SaveChanges.BorderColor = Color.Black;
            btn_SaveChanges.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_SaveChanges.DangerColor = Color.FromArgb(245, 108, 108);
            btn_SaveChanges.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_SaveChanges.Font = new Font("Poppins", 12F);
            btn_SaveChanges.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_SaveChanges.InfoColor = Color.FromArgb(144, 147, 153);
            btn_SaveChanges.Location = new Point(739, 550);
            btn_SaveChanges.Margin = new Padding(30, 3, 3, 3);
            btn_SaveChanges.Name = "btn_SaveChanges";
            btn_SaveChanges.PrimaryColor = Color.DarkGreen;
            btn_SaveChanges.Size = new Size(130, 40);
            btn_SaveChanges.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_SaveChanges.TabIndex = 11;
            btn_SaveChanges.Text = "Save Changes";
            btn_SaveChanges.TextColor = Color.White;
            btn_SaveChanges.WarningColor = Color.FromArgb(230, 162, 60);
            btn_SaveChanges.Click += btn_SaveChanges_Click;
            // 
            // lbl_StudentProgram
            // 
            lbl_StudentProgram.AutoSize = true;
            lbl_StudentProgram.Font = new Font("Poppins", 12F);
            lbl_StudentProgram.Location = new Point(33, 155);
            lbl_StudentProgram.Name = "lbl_StudentProgram";
            lbl_StudentProgram.Size = new Size(150, 28);
            lbl_StudentProgram.TabIndex = 12;
            lbl_StudentProgram.Text = "Student Program:";
            // 
            // btn_Back
            // 
            btn_Back.BorderColor = Color.Black;
            btn_Back.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_Back.DangerColor = Color.FromArgb(245, 108, 108);
            btn_Back.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_Back.Font = new Font("Poppins", 12F);
            btn_Back.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_Back.InfoColor = Color.FromArgb(144, 147, 153);
            btn_Back.Location = new Point(32, 550);
            btn_Back.Margin = new Padding(30, 3, 3, 3);
            btn_Back.Name = "btn_Back";
            btn_Back.PrimaryColor = Color.DarkSlateGray;
            btn_Back.Size = new Size(97, 40);
            btn_Back.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_Back.TabIndex = 13;
            btn_Back.Text = "Back";
            btn_Back.TextColor = Color.White;
            btn_Back.WarningColor = Color.FromArgb(230, 162, 60);
            btn_Back.Click += hopeButton1_Click;
            // 
            // ShowDetailStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(btn_Back);
            Controls.Add(lbl_StudentProgram);
            Controls.Add(btn_SaveChanges);
            Controls.Add(lbl_StudentID);
            Controls.Add(lbl_StudentName);
            Controls.Add(btn_RemoveCourse);
            Controls.Add(dgv_Courses);
            Controls.Add(hope_StudentDetails);
            Font = new Font("Poppins", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "ShowDetailStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowDetailStudent";
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_StudentDetails;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Courses;
        private ReaLTaiizor.Controls.HopeButton btn_RemoveCourse;
        private Label lbl_StudentName;
        private Label lbl_StudentID;
        private ReaLTaiizor.Controls.HopeButton btn_SaveChanges;
        private Label lbl_StudentProgram;
        private ReaLTaiizor.Controls.HopeButton btn_Back;
    }
}