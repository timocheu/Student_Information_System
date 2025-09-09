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
            dgv_Students = new ReaLTaiizor.Controls.PoisonDataGridView();
            btn_AddCourse = new ReaLTaiizor.Controls.HopeButton();
            btn_RemoveCourse = new ReaLTaiizor.Controls.HopeButton();
            lbl_StudentName = new Label();
            lbl_StudentID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
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
            // dgv_Students
            // 
            dgv_Students.AllowUserToAddRows = false;
            dgv_Students.AllowUserToDeleteRows = false;
            dgv_Students.AllowUserToResizeColumns = false;
            dgv_Students.AllowUserToResizeRows = false;
            dgv_Students.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Students.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_Students.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Students.BorderStyle = BorderStyle.None;
            dgv_Students.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Students.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Students.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Students.EnableHeadersVisualStyles = false;
            dgv_Students.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Students.GridColor = Color.Black;
            dgv_Students.Location = new Point(33, 186);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.ReadOnly = true;
            dgv_Students.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Students.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Students.RowHeadersVisible = false;
            dgv_Students.RowHeadersWidth = 20;
            dgv_Students.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Students.Size = new Size(836, 347);
            dgv_Students.TabIndex = 4;
            dgv_Students.UseCustomBackColor = true;
            dgv_Students.UseCustomForeColor = true;
            dgv_Students.UseStyleColors = true;
            // 
            // btn_AddCourse
            // 
            btn_AddCourse.BorderColor = Color.Black;
            btn_AddCourse.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_AddCourse.DangerColor = Color.FromArgb(245, 108, 108);
            btn_AddCourse.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_AddCourse.Font = new Font("Poppins", 12F);
            btn_AddCourse.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_AddCourse.InfoColor = Color.FromArgb(144, 147, 153);
            btn_AddCourse.Location = new Point(586, 131);
            btn_AddCourse.Margin = new Padding(30, 3, 3, 3);
            btn_AddCourse.Name = "btn_AddCourse";
            btn_AddCourse.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_AddCourse.Size = new Size(130, 40);
            btn_AddCourse.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_AddCourse.TabIndex = 5;
            btn_AddCourse.Text = "Add Course";
            btn_AddCourse.TextColor = Color.White;
            btn_AddCourse.WarningColor = Color.FromArgb(230, 162, 60);
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
            // 
            // lbl_StudentName
            // 
            lbl_StudentName.AutoSize = true;
            lbl_StudentName.Font = new Font("Poppins", 12F);
            lbl_StudentName.Location = new Point(33, 143);
            lbl_StudentName.Name = "lbl_StudentName";
            lbl_StudentName.Size = new Size(129, 28);
            lbl_StudentName.TabIndex = 7;
            lbl_StudentName.Text = "Student Name:";
            // 
            // lbl_StudentID
            // 
            lbl_StudentID.AutoSize = true;
            lbl_StudentID.Font = new Font("Poppins", 12F);
            lbl_StudentID.Location = new Point(33, 105);
            lbl_StudentID.Name = "lbl_StudentID";
            lbl_StudentID.Size = new Size(96, 28);
            lbl_StudentID.TabIndex = 8;
            lbl_StudentID.Text = "Student ID:";
            // 
            // ShowDetailStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(lbl_StudentID);
            Controls.Add(lbl_StudentName);
            Controls.Add(btn_AddCourse);
            Controls.Add(btn_RemoveCourse);
            Controls.Add(dgv_Students);
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
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_StudentDetails;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Students;
        private ReaLTaiizor.Controls.HopeButton btn_AddCourse;
        private ReaLTaiizor.Controls.HopeButton btn_RemoveCourse;
        private Label lbl_StudentName;
        private Label lbl_StudentID;
    }
}