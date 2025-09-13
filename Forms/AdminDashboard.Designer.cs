namespace Student_Information_System.Forms
{
    partial class AdminDashboard
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
            ReaLTaiizor.Controls.TabPage tab_Control;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tab_Dashboard = new TabPage();
            pb_ProfilePicture = new PictureBox();
            lbl_Welcome = new Label();
            tab_Student = new TabPage();
            lbl_Student_Filter = new Label();
            pnl_Student_Toggle = new Student_Information_System.UI.SPanel();
            toggle_InactiveStudent = new ReaLTaiizor.Controls.HopeToggle();
            lbl_ShowInactiveStudent = new Label();
            lbl_SearchStudents = new Label();
            dgv_Students = new ReaLTaiizor.Controls.PoisonDataGridView();
            pnl_Student_Toggles = new Student_Information_System.UI.SPanel();
            cb_Student_Program = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_Gender = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_EnrollmentDate = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_Email = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_UserId = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_Name = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_DateOfBirth = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_Address = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Student_Phone = new ReaLTaiizor.Controls.HopeCheckBox();
            pnl_Student_Modifiers = new Student_Information_System.UI.SPanel();
            btn_ShowCourse = new ReaLTaiizor.Controls.HopeButton();
            tb_SearchStudent = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_UpdateStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_CreateStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteStudent = new ReaLTaiizor.Controls.HopeButton();
            lbl_StudentResult = new Label();
            tab_Teacher = new TabPage();
            dgv_Teachers = new ReaLTaiizor.Controls.PoisonDataGridView();
            lbl_SearchTeacher = new Label();
            pnl_Toggle_Teacher = new Student_Information_System.UI.SPanel();
            lbl_Teacher_ShowInactive = new Label();
            toggle_InactiveTeacher = new ReaLTaiizor.Controls.HopeToggle();
            lbl_Teacher_Filter = new Label();
            pnl_Teacher_Modifiers = new Student_Information_System.UI.SPanel();
            btn_TeacherDetail = new ReaLTaiizor.Controls.HopeButton();
            tb_SearchTeachers = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_UpdateTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_CreateTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteTeacher = new ReaLTaiizor.Controls.HopeButton();
            pnl_Teacher_Toggles = new Student_Information_System.UI.SPanel();
            cb_Teacher_Specialization = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_Department = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_Gender = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_HireDate = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_Email = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_UserId = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_Name = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_DateOfBirth = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_Address = new ReaLTaiizor.Controls.HopeCheckBox();
            cb_Teacher_Phone = new ReaLTaiizor.Controls.HopeCheckBox();
            lbl_TeacherResults = new Label();
            tab_Subject = new TabPage();
            dgv_StudentSelection = new ReaLTaiizor.Controls.PoisonDataGridView();
            lbl_Course = new Label();
            dgv_Courses = new ReaLTaiizor.Controls.PoisonDataGridView();
            pnl_CourseStudentFeature = new Student_Information_System.UI.SPanel();
            tb_SearchStudentCourse = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cb_Course_GenderFilter = new ReaLTaiizor.Controls.HopeCheckBox();
            lbl_Taken = new Label();
            cb_Course_ProgramFilter = new ReaLTaiizor.Controls.HopeCheckBox();
            toggle_CourseTaken = new ReaLTaiizor.Controls.HopeToggle();
            cb_Course_NameFilter = new ReaLTaiizor.Controls.HopeCheckBox();
            pnl_Course_Modifier = new Student_Information_System.UI.SPanel();
            tb_SearchCourse = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_AssignCourse = new ReaLTaiizor.Controls.HopeButton();
            btn_CreateCourse = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteCourse = new ReaLTaiizor.Controls.HopeButton();
            tab_Logs = new TabPage();
            tab_Reports = new TabPage();
            tab_Settings = new TabPage();
            btn_Logout = new ReaLTaiizor.Controls.NightButton();
            hope_AdminDashboard = new ReaLTaiizor.Forms.HopeForm();
            tab_Control = new ReaLTaiizor.Controls.TabPage();
            tab_Control.SuspendLayout();
            tab_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ProfilePicture).BeginInit();
            tab_Student.SuspendLayout();
            pnl_Student_Toggle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
            pnl_Student_Toggles.SuspendLayout();
            pnl_Student_Modifiers.SuspendLayout();
            tab_Teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).BeginInit();
            pnl_Toggle_Teacher.SuspendLayout();
            pnl_Teacher_Modifiers.SuspendLayout();
            pnl_Teacher_Toggles.SuspendLayout();
            tab_Subject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_StudentSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).BeginInit();
            pnl_CourseStudentFeature.SuspendLayout();
            pnl_Course_Modifier.SuspendLayout();
            tab_Settings.SuspendLayout();
            SuspendLayout();
            // 
            // tab_Control
            // 
            tab_Control.ActiveForeColor = Color.FromArgb(254, 255, 255);
            tab_Control.ActiveLineTabColor = Color.FromArgb(187, 134, 252);
            tab_Control.ActiveTabColor = Color.FromArgb(35, 36, 38);
            tab_Control.Alignment = TabAlignment.Left;
            tab_Control.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            tab_Control.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            tab_Control.ControlBackColor = Color.FromArgb(54, 57, 64);
            tab_Control.Controls.Add(tab_Dashboard);
            tab_Control.Controls.Add(tab_Student);
            tab_Control.Controls.Add(tab_Teacher);
            tab_Control.Controls.Add(tab_Subject);
            tab_Control.Controls.Add(tab_Logs);
            tab_Control.Controls.Add(tab_Reports);
            tab_Control.Controls.Add(tab_Settings);
            tab_Control.Dock = DockStyle.Fill;
            tab_Control.DrawMode = TabDrawMode.OwnerDrawFixed;
            tab_Control.Font = new Font("Poppins", 16F);
            tab_Control.FrameColor = Color.FromArgb(238, 242, 245);
            tab_Control.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            tab_Control.ItemSize = new Size(50, 200);
            tab_Control.LineColor = Color.FromArgb(25, 26, 28);
            tab_Control.LineTabColor = Color.FromArgb(54, 57, 64);
            tab_Control.Location = new Point(0, 40);
            tab_Control.Multiline = true;
            tab_Control.Name = "tab_Control";
            tab_Control.NormalForeColor = Color.FromArgb(159, 162, 167);
            tab_Control.PageColor = Color.FromArgb(238, 242, 245);
            tab_Control.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tab_Control.SelectedIndex = 0;
            tab_Control.Size = new Size(1400, 610);
            tab_Control.SizeMode = TabSizeMode.Fixed;
            tab_Control.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tab_Control.StringType = StringAlignment.Near;
            tab_Control.TabColor = Color.FromArgb(54, 57, 64);
            tab_Control.TabIndex = 3;
            tab_Control.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // tab_Dashboard
            // 
            tab_Dashboard.BackColor = Color.FromArgb(41, 50, 63);
            tab_Dashboard.Controls.Add(pb_ProfilePicture);
            tab_Dashboard.Controls.Add(lbl_Welcome);
            tab_Dashboard.Location = new Point(204, 4);
            tab_Dashboard.Name = "tab_Dashboard";
            tab_Dashboard.Padding = new Padding(3);
            tab_Dashboard.Size = new Size(1192, 602);
            tab_Dashboard.TabIndex = 0;
            tab_Dashboard.Text = "Dashboard";
            // 
            // pb_ProfilePicture
            // 
            pb_ProfilePicture.Location = new Point(31, 65);
            pb_ProfilePicture.Name = "pb_ProfilePicture";
            pb_ProfilePicture.Size = new Size(60, 60);
            pb_ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ProfilePicture.TabIndex = 5;
            pb_ProfilePicture.TabStop = false;
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Location = new Point(31, 23);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(182, 39);
            lbl_Welcome.TabIndex = 4;
            lbl_Welcome.Text = "Welcome User!";
            // 
            // tab_Student
            // 
            tab_Student.BackColor = Color.FromArgb(41, 50, 63);
            tab_Student.Controls.Add(lbl_Student_Filter);
            tab_Student.Controls.Add(pnl_Student_Toggle);
            tab_Student.Controls.Add(lbl_SearchStudents);
            tab_Student.Controls.Add(dgv_Students);
            tab_Student.Controls.Add(pnl_Student_Toggles);
            tab_Student.Controls.Add(pnl_Student_Modifiers);
            tab_Student.Controls.Add(lbl_StudentResult);
            tab_Student.Location = new Point(204, 4);
            tab_Student.Name = "tab_Student";
            tab_Student.Padding = new Padding(3);
            tab_Student.Size = new Size(1192, 602);
            tab_Student.TabIndex = 1;
            tab_Student.Text = "Student";
            // 
            // lbl_Student_Filter
            // 
            lbl_Student_Filter.AutoSize = true;
            lbl_Student_Filter.BackColor = Color.FromArgb(238, 242, 245);
            lbl_Student_Filter.Font = new Font("Poppins", 16F);
            lbl_Student_Filter.Location = new Point(590, 11);
            lbl_Student_Filter.Name = "lbl_Student_Filter";
            lbl_Student_Filter.Size = new Size(84, 39);
            lbl_Student_Filter.TabIndex = 24;
            lbl_Student_Filter.Text = "Filters:";
            // 
            // pnl_Student_Toggle
            // 
            pnl_Student_Toggle.BackgroundFillColor = Color.White;
            pnl_Student_Toggle.BorderColor = Color.White;
            pnl_Student_Toggle.Controls.Add(toggle_InactiveStudent);
            pnl_Student_Toggle.Controls.Add(lbl_ShowInactiveStudent);
            pnl_Student_Toggle.Location = new Point(960, 0);
            pnl_Student_Toggle.Name = "pnl_Student_Toggle";
            pnl_Student_Toggle.Size = new Size(226, 52);
            pnl_Student_Toggle.TabIndex = 23;
            // 
            // toggle_InactiveStudent
            // 
            toggle_InactiveStudent.AutoSize = true;
            toggle_InactiveStudent.BackColor = Color.White;
            toggle_InactiveStudent.BaseColor = Color.White;
            toggle_InactiveStudent.BaseColorA = Color.FromArgb(220, 223, 230);
            toggle_InactiveStudent.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            toggle_InactiveStudent.HeadColorA = Color.FromArgb(220, 223, 230);
            toggle_InactiveStudent.HeadColorB = Color.FromArgb(32, 41, 50);
            toggle_InactiveStudent.HeadColorC = Color.FromArgb(64, 158, 255);
            toggle_InactiveStudent.HeadColorD = Color.FromArgb(64, 158, 255);
            toggle_InactiveStudent.Location = new Point(151, 17);
            toggle_InactiveStudent.Name = "toggle_InactiveStudent";
            toggle_InactiveStudent.Size = new Size(48, 20);
            toggle_InactiveStudent.TabIndex = 12;
            toggle_InactiveStudent.Text = "Show Inactive";
            toggle_InactiveStudent.UseVisualStyleBackColor = false;
            toggle_InactiveStudent.CheckedChanged += toggle_InactiveStudent_CheckedChanged;
            // 
            // lbl_ShowInactiveStudent
            // 
            lbl_ShowInactiveStudent.AutoSize = true;
            lbl_ShowInactiveStudent.BackColor = Color.White;
            lbl_ShowInactiveStudent.Font = new Font("Poppins", 12F);
            lbl_ShowInactiveStudent.Location = new Point(31, 14);
            lbl_ShowInactiveStudent.Name = "lbl_ShowInactiveStudent";
            lbl_ShowInactiveStudent.Size = new Size(122, 28);
            lbl_ShowInactiveStudent.TabIndex = 13;
            lbl_ShowInactiveStudent.Text = "Show Inactive";
            // 
            // lbl_SearchStudents
            // 
            lbl_SearchStudents.AutoSize = true;
            lbl_SearchStudents.BackColor = Color.FromArgb(238, 242, 245);
            lbl_SearchStudents.Location = new Point(22, 11);
            lbl_SearchStudents.Name = "lbl_SearchStudents";
            lbl_SearchStudents.Size = new Size(197, 39);
            lbl_SearchStudents.TabIndex = 6;
            lbl_SearchStudents.Text = "Search Students";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Students.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Students.EnableHeadersVisualStyles = false;
            dgv_Students.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Students.GridColor = Color.Black;
            dgv_Students.Location = new Point(0, 166);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.ReadOnly = true;
            dgv_Students.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Students.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Students.RowHeadersVisible = false;
            dgv_Students.RowHeadersWidth = 20;
            dgv_Students.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Students.Size = new Size(1180, 400);
            dgv_Students.TabIndex = 0;
            dgv_Students.UseCustomBackColor = true;
            dgv_Students.UseCustomForeColor = true;
            dgv_Students.UseStyleColors = true;
            // 
            // pnl_Student_Toggles
            // 
            pnl_Student_Toggles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnl_Student_Toggles.BackgroundFillColor = Color.White;
            pnl_Student_Toggles.BorderColor = Color.White;
            pnl_Student_Toggles.Controls.Add(cb_Student_Program);
            pnl_Student_Toggles.Controls.Add(cb_Student_Gender);
            pnl_Student_Toggles.Controls.Add(cb_Student_EnrollmentDate);
            pnl_Student_Toggles.Controls.Add(cb_Student_Email);
            pnl_Student_Toggles.Controls.Add(cb_Student_UserId);
            pnl_Student_Toggles.Controls.Add(cb_Student_Name);
            pnl_Student_Toggles.Controls.Add(cb_Student_DateOfBirth);
            pnl_Student_Toggles.Controls.Add(cb_Student_Address);
            pnl_Student_Toggles.Controls.Add(cb_Student_Phone);
            pnl_Student_Toggles.Location = new Point(574, 45);
            pnl_Student_Toggles.Name = "pnl_Student_Toggles";
            pnl_Student_Toggles.Size = new Size(615, 120);
            pnl_Student_Toggles.TabIndex = 14;
            // 
            // cb_Student_Program
            // 
            cb_Student_Program.AutoSize = true;
            cb_Student_Program.BackColor = Color.White;
            cb_Student_Program.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Program.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_Program.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_Program.Enable = true;
            cb_Student_Program.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Program.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_Program.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_Program.Font = new Font("Poppins", 12F);
            cb_Student_Program.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_Program.Location = new Point(327, 80);
            cb_Student_Program.Name = "cb_Student_Program";
            cb_Student_Program.Size = new Size(106, 20);
            cb_Student_Program.TabIndex = 24;
            cb_Student_Program.Text = "Program";
            cb_Student_Program.UseVisualStyleBackColor = false;
            // 
            // cb_Student_Gender
            // 
            cb_Student_Gender.AutoSize = true;
            cb_Student_Gender.BackColor = Color.White;
            cb_Student_Gender.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Gender.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_Gender.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_Gender.Enable = true;
            cb_Student_Gender.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Gender.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_Gender.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_Gender.Font = new Font("Poppins", 12F);
            cb_Student_Gender.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_Gender.Location = new Point(327, 26);
            cb_Student_Gender.Name = "cb_Student_Gender";
            cb_Student_Gender.Size = new Size(96, 20);
            cb_Student_Gender.TabIndex = 23;
            cb_Student_Gender.Text = "Gender";
            cb_Student_Gender.UseVisualStyleBackColor = false;
            // 
            // cb_Student_EnrollmentDate
            // 
            cb_Student_EnrollmentDate.AutoSize = true;
            cb_Student_EnrollmentDate.BackColor = Color.White;
            cb_Student_EnrollmentDate.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_EnrollmentDate.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_EnrollmentDate.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_EnrollmentDate.Enable = true;
            cb_Student_EnrollmentDate.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_EnrollmentDate.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_EnrollmentDate.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_EnrollmentDate.Font = new Font("Poppins", 12F);
            cb_Student_EnrollmentDate.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_EnrollmentDate.Location = new Point(327, 52);
            cb_Student_EnrollmentDate.Name = "cb_Student_EnrollmentDate";
            cb_Student_EnrollmentDate.Size = new Size(163, 20);
            cb_Student_EnrollmentDate.TabIndex = 22;
            cb_Student_EnrollmentDate.Text = "Enrollment Date";
            cb_Student_EnrollmentDate.UseVisualStyleBackColor = false;
            // 
            // cb_Student_Email
            // 
            cb_Student_Email.AutoSize = true;
            cb_Student_Email.BackColor = Color.White;
            cb_Student_Email.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Email.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_Email.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_Email.Enable = true;
            cb_Student_Email.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Email.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_Email.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_Email.Font = new Font("Poppins", 12F);
            cb_Student_Email.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_Email.Location = new Point(165, 26);
            cb_Student_Email.Name = "cb_Student_Email";
            cb_Student_Email.Size = new Size(80, 20);
            cb_Student_Email.TabIndex = 20;
            cb_Student_Email.Text = "Email";
            cb_Student_Email.UseVisualStyleBackColor = false;
            // 
            // cb_Student_UserId
            // 
            cb_Student_UserId.AutoSize = true;
            cb_Student_UserId.BackColor = Color.White;
            cb_Student_UserId.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_UserId.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_UserId.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_UserId.Enable = true;
            cb_Student_UserId.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_UserId.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_UserId.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_UserId.Font = new Font("Poppins", 12F);
            cb_Student_UserId.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_UserId.Location = new Point(27, 26);
            cb_Student_UserId.Name = "cb_Student_UserId";
            cb_Student_UserId.Size = new Size(87, 20);
            cb_Student_UserId.TabIndex = 15;
            cb_Student_UserId.Text = "UserID";
            cb_Student_UserId.UseVisualStyleBackColor = false;
            // 
            // cb_Student_Name
            // 
            cb_Student_Name.AutoSize = true;
            cb_Student_Name.BackColor = Color.White;
            cb_Student_Name.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Name.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_Name.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_Name.Enable = true;
            cb_Student_Name.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Name.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_Name.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_Name.Font = new Font("Poppins", 12F);
            cb_Student_Name.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_Name.Location = new Point(27, 52);
            cb_Student_Name.Name = "cb_Student_Name";
            cb_Student_Name.Size = new Size(85, 20);
            cb_Student_Name.TabIndex = 16;
            cb_Student_Name.Text = "Name";
            cb_Student_Name.UseVisualStyleBackColor = false;
            // 
            // cb_Student_DateOfBirth
            // 
            cb_Student_DateOfBirth.AutoSize = true;
            cb_Student_DateOfBirth.BackColor = Color.White;
            cb_Student_DateOfBirth.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_DateOfBirth.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_DateOfBirth.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_DateOfBirth.Enable = true;
            cb_Student_DateOfBirth.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_DateOfBirth.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_DateOfBirth.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_DateOfBirth.Font = new Font("Poppins", 12F);
            cb_Student_DateOfBirth.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_DateOfBirth.Location = new Point(27, 80);
            cb_Student_DateOfBirth.Name = "cb_Student_DateOfBirth";
            cb_Student_DateOfBirth.Size = new Size(137, 20);
            cb_Student_DateOfBirth.TabIndex = 17;
            cb_Student_DateOfBirth.Text = "Date Of Birth";
            cb_Student_DateOfBirth.UseVisualStyleBackColor = false;
            // 
            // cb_Student_Address
            // 
            cb_Student_Address.AutoSize = true;
            cb_Student_Address.BackColor = Color.White;
            cb_Student_Address.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Address.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_Address.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_Address.Enable = true;
            cb_Student_Address.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Address.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_Address.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_Address.Font = new Font("Poppins", 12F);
            cb_Student_Address.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_Address.Location = new Point(165, 52);
            cb_Student_Address.Name = "cb_Student_Address";
            cb_Student_Address.Size = new Size(102, 20);
            cb_Student_Address.TabIndex = 19;
            cb_Student_Address.Text = "Address";
            cb_Student_Address.UseVisualStyleBackColor = false;
            // 
            // cb_Student_Phone
            // 
            cb_Student_Phone.AutoSize = true;
            cb_Student_Phone.BackColor = Color.White;
            cb_Student_Phone.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Phone.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Student_Phone.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Student_Phone.Enable = true;
            cb_Student_Phone.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Student_Phone.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Student_Phone.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Student_Phone.Font = new Font("Poppins", 12F);
            cb_Student_Phone.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Student_Phone.Location = new Point(165, 80);
            cb_Student_Phone.Name = "cb_Student_Phone";
            cb_Student_Phone.Size = new Size(154, 20);
            cb_Student_Phone.TabIndex = 18;
            cb_Student_Phone.Text = "Phone Number";
            cb_Student_Phone.UseVisualStyleBackColor = false;
            // 
            // pnl_Student_Modifiers
            // 
            pnl_Student_Modifiers.BackgroundFillColor = Color.White;
            pnl_Student_Modifiers.BorderColor = Color.White;
            pnl_Student_Modifiers.Controls.Add(btn_ShowCourse);
            pnl_Student_Modifiers.Controls.Add(tb_SearchStudent);
            pnl_Student_Modifiers.Controls.Add(btn_UpdateStudent);
            pnl_Student_Modifiers.Controls.Add(btn_CreateStudent);
            pnl_Student_Modifiers.Controls.Add(btn_DeleteStudent);
            pnl_Student_Modifiers.Location = new Point(0, 45);
            pnl_Student_Modifiers.Name = "pnl_Student_Modifiers";
            pnl_Student_Modifiers.Size = new Size(584, 120);
            pnl_Student_Modifiers.TabIndex = 9;
            // 
            // btn_ShowCourse
            // 
            btn_ShowCourse.BorderColor = Color.FromArgb(220, 223, 230);
            btn_ShowCourse.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_ShowCourse.DangerColor = Color.FromArgb(245, 108, 108);
            btn_ShowCourse.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_ShowCourse.Font = new Font("Poppins", 12F);
            btn_ShowCourse.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_ShowCourse.InfoColor = Color.FromArgb(144, 147, 153);
            btn_ShowCourse.Location = new Point(428, 61);
            btn_ShowCourse.Margin = new Padding(30, 3, 3, 3);
            btn_ShowCourse.Name = "btn_ShowCourse";
            btn_ShowCourse.PrimaryColor = Color.FromArgb(204, 102, 0);
            btn_ShowCourse.Size = new Size(130, 40);
            btn_ShowCourse.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_ShowCourse.TabIndex = 5;
            btn_ShowCourse.Text = "Course Taken";
            btn_ShowCourse.TextColor = Color.White;
            btn_ShowCourse.WarningColor = Color.FromArgb(230, 162, 60);
            btn_ShowCourse.Click += btn_ShowCourse_Click;
            // 
            // tb_SearchStudent
            // 
            tb_SearchStudent.AnimateReadOnly = false;
            tb_SearchStudent.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchStudent.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchStudent.BackColor = Color.FromArgb(41, 50, 63);
            tb_SearchStudent.BackgroundImageLayout = ImageLayout.None;
            tb_SearchStudent.CharacterCasing = CharacterCasing.Normal;
            tb_SearchStudent.Depth = 0;
            tb_SearchStudent.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchStudent.HideSelection = true;
            tb_SearchStudent.Hint = "Search";
            tb_SearchStudent.LeadingIcon = (Image)resources.GetObject("tb_SearchStudent.LeadingIcon");
            tb_SearchStudent.Location = new Point(22, 37);
            tb_SearchStudent.MaxLength = 100;
            tb_SearchStudent.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_SearchStudent.Name = "tb_SearchStudent";
            tb_SearchStudent.PasswordChar = '\0';
            tb_SearchStudent.PrefixSuffixText = null;
            tb_SearchStudent.ReadOnly = false;
            tb_SearchStudent.RightToLeft = RightToLeft.No;
            tb_SearchStudent.SelectedText = "";
            tb_SearchStudent.SelectionLength = 0;
            tb_SearchStudent.SelectionStart = 0;
            tb_SearchStudent.ShortcutsEnabled = true;
            tb_SearchStudent.Size = new Size(241, 48);
            tb_SearchStudent.TabIndex = 1;
            tb_SearchStudent.TabStop = false;
            tb_SearchStudent.TextAlign = HorizontalAlignment.Left;
            tb_SearchStudent.TrailingIcon = null;
            tb_SearchStudent.UseSystemPasswordChar = false;
            tb_SearchStudent.TextChanged += tb_SearchStudent_TextChanged;
            // 
            // btn_UpdateStudent
            // 
            btn_UpdateStudent.BorderColor = Color.FromArgb(220, 223, 230);
            btn_UpdateStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_UpdateStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_UpdateStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_UpdateStudent.Font = new Font("Poppins", 12F);
            btn_UpdateStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_UpdateStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_UpdateStudent.Location = new Point(428, 16);
            btn_UpdateStudent.Margin = new Padding(30, 3, 3, 3);
            btn_UpdateStudent.Name = "btn_UpdateStudent";
            btn_UpdateStudent.PrimaryColor = Color.SeaGreen;
            btn_UpdateStudent.Size = new Size(130, 40);
            btn_UpdateStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateStudent.TabIndex = 4;
            btn_UpdateStudent.Text = "Update";
            btn_UpdateStudent.TextColor = Color.White;
            btn_UpdateStudent.WarningColor = Color.FromArgb(230, 162, 60);
            btn_UpdateStudent.Click += btn_UpdateStudent_Click;
            // 
            // btn_CreateStudent
            // 
            btn_CreateStudent.BorderColor = Color.Black;
            btn_CreateStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_CreateStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_CreateStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_CreateStudent.Font = new Font("Poppins", 12F);
            btn_CreateStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_CreateStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_CreateStudent.Location = new Point(291, 16);
            btn_CreateStudent.Margin = new Padding(30, 3, 3, 3);
            btn_CreateStudent.Name = "btn_CreateStudent";
            btn_CreateStudent.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_CreateStudent.Size = new Size(130, 40);
            btn_CreateStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_CreateStudent.TabIndex = 2;
            btn_CreateStudent.Text = "Create New";
            btn_CreateStudent.TextColor = Color.White;
            btn_CreateStudent.WarningColor = Color.FromArgb(230, 162, 60);
            btn_CreateStudent.Click += btn_AddStudent_Click;
            // 
            // btn_DeleteStudent
            // 
            btn_DeleteStudent.BorderColor = Color.FromArgb(220, 223, 230);
            btn_DeleteStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_DeleteStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_DeleteStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_DeleteStudent.Font = new Font("Poppins", 12F);
            btn_DeleteStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_DeleteStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_DeleteStudent.Location = new Point(291, 62);
            btn_DeleteStudent.Margin = new Padding(30, 3, 3, 3);
            btn_DeleteStudent.Name = "btn_DeleteStudent";
            btn_DeleteStudent.PrimaryColor = Color.FromArgb(166, 9, 22);
            btn_DeleteStudent.Size = new Size(130, 40);
            btn_DeleteStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteStudent.TabIndex = 3;
            btn_DeleteStudent.Text = "Delete";
            btn_DeleteStudent.TextColor = Color.White;
            btn_DeleteStudent.WarningColor = Color.FromArgb(230, 162, 60);
            btn_DeleteStudent.Click += btn_DeleteStudent_Click;
            // 
            // lbl_StudentResult
            // 
            lbl_StudentResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_StudentResult.AutoSize = true;
            lbl_StudentResult.BackColor = Color.Transparent;
            lbl_StudentResult.Font = new Font("Poppins", 12F);
            lbl_StudentResult.ForeColor = Color.Gray;
            lbl_StudentResult.Location = new Point(6, 569);
            lbl_StudentResult.Name = "lbl_StudentResult";
            lbl_StudentResult.Size = new Size(160, 28);
            lbl_StudentResult.TabIndex = 8;
            lbl_StudentResult.Text = "1 to 10 of 100 results";
            // 
            // tab_Teacher
            // 
            tab_Teacher.BackColor = Color.FromArgb(41, 50, 63);
            tab_Teacher.Controls.Add(dgv_Teachers);
            tab_Teacher.Controls.Add(lbl_SearchTeacher);
            tab_Teacher.Controls.Add(pnl_Toggle_Teacher);
            tab_Teacher.Controls.Add(lbl_Teacher_Filter);
            tab_Teacher.Controls.Add(pnl_Teacher_Modifiers);
            tab_Teacher.Controls.Add(pnl_Teacher_Toggles);
            tab_Teacher.Controls.Add(lbl_TeacherResults);
            tab_Teacher.Location = new Point(204, 4);
            tab_Teacher.Name = "tab_Teacher";
            tab_Teacher.Padding = new Padding(3);
            tab_Teacher.Size = new Size(1192, 602);
            tab_Teacher.TabIndex = 2;
            tab_Teacher.Text = "Teacher";
            // 
            // dgv_Teachers
            // 
            dgv_Teachers.AllowUserToAddRows = false;
            dgv_Teachers.AllowUserToDeleteRows = false;
            dgv_Teachers.AllowUserToResizeColumns = false;
            dgv_Teachers.AllowUserToResizeRows = false;
            dgv_Teachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Teachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Teachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_Teachers.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Teachers.BorderStyle = BorderStyle.None;
            dgv_Teachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Teachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Teachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Teachers.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Teachers.EnableHeadersVisualStyles = false;
            dgv_Teachers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Teachers.GridColor = Color.Black;
            dgv_Teachers.Location = new Point(0, 166);
            dgv_Teachers.Name = "dgv_Teachers";
            dgv_Teachers.ReadOnly = true;
            dgv_Teachers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Teachers.RowHeadersVisible = false;
            dgv_Teachers.RowHeadersWidth = 20;
            dgv_Teachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Teachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teachers.Size = new Size(1180, 400);
            dgv_Teachers.TabIndex = 23;
            dgv_Teachers.UseCustomBackColor = true;
            dgv_Teachers.UseCustomForeColor = true;
            dgv_Teachers.UseStyleColors = true;
            // 
            // lbl_SearchTeacher
            // 
            lbl_SearchTeacher.AutoSize = true;
            lbl_SearchTeacher.Location = new Point(22, 10);
            lbl_SearchTeacher.Name = "lbl_SearchTeacher";
            lbl_SearchTeacher.Size = new Size(201, 39);
            lbl_SearchTeacher.TabIndex = 6;
            lbl_SearchTeacher.Text = "Search Teachers";
            // 
            // pnl_Toggle_Teacher
            // 
            pnl_Toggle_Teacher.BackgroundFillColor = Color.White;
            pnl_Toggle_Teacher.BorderColor = Color.White;
            pnl_Toggle_Teacher.Controls.Add(lbl_Teacher_ShowInactive);
            pnl_Toggle_Teacher.Controls.Add(toggle_InactiveTeacher);
            pnl_Toggle_Teacher.Location = new Point(960, 0);
            pnl_Toggle_Teacher.Name = "pnl_Toggle_Teacher";
            pnl_Toggle_Teacher.Size = new Size(226, 52);
            pnl_Toggle_Teacher.TabIndex = 22;
            // 
            // lbl_Teacher_ShowInactive
            // 
            lbl_Teacher_ShowInactive.AutoSize = true;
            lbl_Teacher_ShowInactive.BackColor = Color.White;
            lbl_Teacher_ShowInactive.Font = new Font("Poppins", 12F);
            lbl_Teacher_ShowInactive.Location = new Point(22, 12);
            lbl_Teacher_ShowInactive.Name = "lbl_Teacher_ShowInactive";
            lbl_Teacher_ShowInactive.Size = new Size(122, 28);
            lbl_Teacher_ShowInactive.TabIndex = 13;
            lbl_Teacher_ShowInactive.Text = "Show Inactive";
            // 
            // toggle_InactiveTeacher
            // 
            toggle_InactiveTeacher.AutoSize = true;
            toggle_InactiveTeacher.BackColor = Color.White;
            toggle_InactiveTeacher.BaseColor = Color.White;
            toggle_InactiveTeacher.BaseColorA = Color.FromArgb(220, 223, 230);
            toggle_InactiveTeacher.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            toggle_InactiveTeacher.HeadColorA = Color.FromArgb(220, 223, 230);
            toggle_InactiveTeacher.HeadColorB = Color.FromArgb(32, 41, 50);
            toggle_InactiveTeacher.HeadColorC = Color.FromArgb(64, 158, 255);
            toggle_InactiveTeacher.HeadColorD = Color.FromArgb(64, 158, 255);
            toggle_InactiveTeacher.Location = new Point(152, 16);
            toggle_InactiveTeacher.Name = "toggle_InactiveTeacher";
            toggle_InactiveTeacher.Size = new Size(48, 20);
            toggle_InactiveTeacher.TabIndex = 12;
            toggle_InactiveTeacher.Text = "Show Inactive";
            toggle_InactiveTeacher.UseVisualStyleBackColor = false;
            toggle_InactiveTeacher.CheckedChanged += toggle_InactiveTeacher_CheckedChanged;
            // 
            // lbl_Teacher_Filter
            // 
            lbl_Teacher_Filter.AutoSize = true;
            lbl_Teacher_Filter.BackColor = Color.FromArgb(238, 242, 245);
            lbl_Teacher_Filter.Font = new Font("Poppins", 16F);
            lbl_Teacher_Filter.Location = new Point(590, 10);
            lbl_Teacher_Filter.Name = "lbl_Teacher_Filter";
            lbl_Teacher_Filter.Size = new Size(84, 39);
            lbl_Teacher_Filter.TabIndex = 21;
            lbl_Teacher_Filter.Text = "Filters:";
            // 
            // pnl_Teacher_Modifiers
            // 
            pnl_Teacher_Modifiers.BackgroundFillColor = Color.White;
            pnl_Teacher_Modifiers.BorderColor = Color.White;
            pnl_Teacher_Modifiers.Controls.Add(btn_TeacherDetail);
            pnl_Teacher_Modifiers.Controls.Add(tb_SearchTeachers);
            pnl_Teacher_Modifiers.Controls.Add(btn_UpdateTeacher);
            pnl_Teacher_Modifiers.Controls.Add(btn_CreateTeacher);
            pnl_Teacher_Modifiers.Controls.Add(btn_DeleteTeacher);
            pnl_Teacher_Modifiers.Location = new Point(0, 45);
            pnl_Teacher_Modifiers.Name = "pnl_Teacher_Modifiers";
            pnl_Teacher_Modifiers.Size = new Size(584, 120);
            pnl_Teacher_Modifiers.TabIndex = 18;
            // 
            // btn_TeacherDetail
            // 
            btn_TeacherDetail.BorderColor = Color.FromArgb(220, 223, 230);
            btn_TeacherDetail.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_TeacherDetail.DangerColor = Color.FromArgb(245, 108, 108);
            btn_TeacherDetail.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_TeacherDetail.Font = new Font("Poppins", 12F);
            btn_TeacherDetail.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_TeacherDetail.InfoColor = Color.FromArgb(144, 147, 153);
            btn_TeacherDetail.Location = new Point(429, 63);
            btn_TeacherDetail.Margin = new Padding(30, 3, 3, 3);
            btn_TeacherDetail.Name = "btn_TeacherDetail";
            btn_TeacherDetail.PrimaryColor = Color.FromArgb(204, 102, 0);
            btn_TeacherDetail.Size = new Size(130, 40);
            btn_TeacherDetail.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_TeacherDetail.TabIndex = 5;
            btn_TeacherDetail.Text = "Course Taken";
            btn_TeacherDetail.TextColor = Color.White;
            btn_TeacherDetail.WarningColor = Color.FromArgb(230, 162, 60);
            btn_TeacherDetail.Click += btn_TeacherDetail_Click;
            // 
            // tb_SearchTeachers
            // 
            tb_SearchTeachers.AnimateReadOnly = false;
            tb_SearchTeachers.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchTeachers.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchTeachers.BackColor = Color.FromArgb(41, 50, 63);
            tb_SearchTeachers.BackgroundImageLayout = ImageLayout.None;
            tb_SearchTeachers.CharacterCasing = CharacterCasing.Normal;
            tb_SearchTeachers.Depth = 0;
            tb_SearchTeachers.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchTeachers.HideSelection = true;
            tb_SearchTeachers.Hint = "Search";
            tb_SearchTeachers.LeadingIcon = (Image)resources.GetObject("tb_SearchTeachers.LeadingIcon");
            tb_SearchTeachers.Location = new Point(22, 37);
            tb_SearchTeachers.MaxLength = 100;
            tb_SearchTeachers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_SearchTeachers.Name = "tb_SearchTeachers";
            tb_SearchTeachers.PasswordChar = '\0';
            tb_SearchTeachers.PrefixSuffixText = null;
            tb_SearchTeachers.ReadOnly = false;
            tb_SearchTeachers.RightToLeft = RightToLeft.No;
            tb_SearchTeachers.SelectedText = "";
            tb_SearchTeachers.SelectionLength = 0;
            tb_SearchTeachers.SelectionStart = 0;
            tb_SearchTeachers.ShortcutsEnabled = true;
            tb_SearchTeachers.Size = new Size(241, 48);
            tb_SearchTeachers.TabIndex = 1;
            tb_SearchTeachers.TabStop = false;
            tb_SearchTeachers.TextAlign = HorizontalAlignment.Left;
            tb_SearchTeachers.TrailingIcon = null;
            tb_SearchTeachers.UseSystemPasswordChar = false;
            tb_SearchTeachers.TextChanged += tb_SearchTeachers_TextChanged;
            // 
            // btn_UpdateTeacher
            // 
            btn_UpdateTeacher.BorderColor = Color.FromArgb(220, 223, 230);
            btn_UpdateTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_UpdateTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_UpdateTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_UpdateTeacher.Font = new Font("Poppins", 12F);
            btn_UpdateTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_UpdateTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_UpdateTeacher.Location = new Point(429, 18);
            btn_UpdateTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_UpdateTeacher.Name = "btn_UpdateTeacher";
            btn_UpdateTeacher.PrimaryColor = Color.SeaGreen;
            btn_UpdateTeacher.Size = new Size(130, 40);
            btn_UpdateTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateTeacher.TabIndex = 4;
            btn_UpdateTeacher.Text = "Update";
            btn_UpdateTeacher.TextColor = Color.White;
            btn_UpdateTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            btn_UpdateTeacher.Click += btn_UpdateTeacher_Click;
            // 
            // btn_CreateTeacher
            // 
            btn_CreateTeacher.BorderColor = Color.Black;
            btn_CreateTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_CreateTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_CreateTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_CreateTeacher.Font = new Font("Poppins", 12F);
            btn_CreateTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_CreateTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_CreateTeacher.Location = new Point(292, 18);
            btn_CreateTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_CreateTeacher.Name = "btn_CreateTeacher";
            btn_CreateTeacher.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_CreateTeacher.Size = new Size(130, 40);
            btn_CreateTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_CreateTeacher.TabIndex = 2;
            btn_CreateTeacher.Text = "Create New";
            btn_CreateTeacher.TextColor = Color.White;
            btn_CreateTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            btn_CreateTeacher.Click += btn_CreateTeacher_Click;
            // 
            // btn_DeleteTeacher
            // 
            btn_DeleteTeacher.BorderColor = Color.FromArgb(220, 223, 230);
            btn_DeleteTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_DeleteTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_DeleteTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_DeleteTeacher.Font = new Font("Poppins", 12F);
            btn_DeleteTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_DeleteTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_DeleteTeacher.Location = new Point(292, 64);
            btn_DeleteTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_DeleteTeacher.Name = "btn_DeleteTeacher";
            btn_DeleteTeacher.PrimaryColor = Color.FromArgb(166, 9, 22);
            btn_DeleteTeacher.Size = new Size(130, 40);
            btn_DeleteTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteTeacher.TabIndex = 3;
            btn_DeleteTeacher.Text = "Delete";
            btn_DeleteTeacher.TextColor = Color.White;
            btn_DeleteTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            btn_DeleteTeacher.Click += btn_DeleteTeacher_Click;
            // 
            // pnl_Teacher_Toggles
            // 
            pnl_Teacher_Toggles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnl_Teacher_Toggles.BackgroundFillColor = Color.White;
            pnl_Teacher_Toggles.BorderColor = Color.White;
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Specialization);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Department);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Gender);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_HireDate);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Email);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_UserId);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Name);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_DateOfBirth);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Address);
            pnl_Teacher_Toggles.Controls.Add(cb_Teacher_Phone);
            pnl_Teacher_Toggles.Location = new Point(574, 45);
            pnl_Teacher_Toggles.Name = "pnl_Teacher_Toggles";
            pnl_Teacher_Toggles.Size = new Size(615, 120);
            pnl_Teacher_Toggles.TabIndex = 17;
            // 
            // cb_Teacher_Specialization
            // 
            cb_Teacher_Specialization.AutoSize = true;
            cb_Teacher_Specialization.BackColor = Color.White;
            cb_Teacher_Specialization.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Specialization.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Specialization.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Specialization.Enable = true;
            cb_Teacher_Specialization.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Specialization.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Specialization.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Specialization.Font = new Font("Poppins", 12F);
            cb_Teacher_Specialization.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Specialization.Location = new Point(448, 27);
            cb_Teacher_Specialization.Name = "cb_Teacher_Specialization";
            cb_Teacher_Specialization.Size = new Size(148, 20);
            cb_Teacher_Specialization.TabIndex = 25;
            cb_Teacher_Specialization.Text = "Specialization";
            cb_Teacher_Specialization.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_Department
            // 
            cb_Teacher_Department.AutoSize = true;
            cb_Teacher_Department.BackColor = Color.White;
            cb_Teacher_Department.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Department.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Department.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Department.Enable = true;
            cb_Teacher_Department.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Department.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Department.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Department.Font = new Font("Poppins", 12F);
            cb_Teacher_Department.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Department.Location = new Point(315, 79);
            cb_Teacher_Department.Name = "cb_Teacher_Department";
            cb_Teacher_Department.Size = new Size(134, 20);
            cb_Teacher_Department.TabIndex = 24;
            cb_Teacher_Department.Text = "Department";
            cb_Teacher_Department.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_Gender
            // 
            cb_Teacher_Gender.AutoSize = true;
            cb_Teacher_Gender.BackColor = Color.White;
            cb_Teacher_Gender.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Gender.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Gender.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Gender.Enable = true;
            cb_Teacher_Gender.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Gender.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Gender.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Gender.Font = new Font("Poppins", 12F);
            cb_Teacher_Gender.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Gender.Location = new Point(315, 26);
            cb_Teacher_Gender.Name = "cb_Teacher_Gender";
            cb_Teacher_Gender.Size = new Size(96, 20);
            cb_Teacher_Gender.TabIndex = 23;
            cb_Teacher_Gender.Text = "Gender";
            cb_Teacher_Gender.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_HireDate
            // 
            cb_Teacher_HireDate.AutoSize = true;
            cb_Teacher_HireDate.BackColor = Color.White;
            cb_Teacher_HireDate.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_HireDate.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_HireDate.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_HireDate.Enable = true;
            cb_Teacher_HireDate.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_HireDate.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_HireDate.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_HireDate.Font = new Font("Poppins", 12F);
            cb_Teacher_HireDate.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_HireDate.Location = new Point(315, 52);
            cb_Teacher_HireDate.Name = "cb_Teacher_HireDate";
            cb_Teacher_HireDate.Size = new Size(110, 20);
            cb_Teacher_HireDate.TabIndex = 22;
            cb_Teacher_HireDate.Text = "Hire Date";
            cb_Teacher_HireDate.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_Email
            // 
            cb_Teacher_Email.AutoSize = true;
            cb_Teacher_Email.BackColor = Color.White;
            cb_Teacher_Email.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Email.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Email.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Email.Enable = true;
            cb_Teacher_Email.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Email.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Email.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Email.Font = new Font("Poppins", 12F);
            cb_Teacher_Email.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Email.Location = new Point(162, 25);
            cb_Teacher_Email.Name = "cb_Teacher_Email";
            cb_Teacher_Email.Size = new Size(80, 20);
            cb_Teacher_Email.TabIndex = 20;
            cb_Teacher_Email.Text = "Email";
            cb_Teacher_Email.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_UserId
            // 
            cb_Teacher_UserId.AutoSize = true;
            cb_Teacher_UserId.BackColor = Color.White;
            cb_Teacher_UserId.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_UserId.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_UserId.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_UserId.Enable = true;
            cb_Teacher_UserId.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_UserId.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_UserId.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_UserId.Font = new Font("Poppins", 12F);
            cb_Teacher_UserId.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_UserId.Location = new Point(27, 26);
            cb_Teacher_UserId.Name = "cb_Teacher_UserId";
            cb_Teacher_UserId.Size = new Size(87, 20);
            cb_Teacher_UserId.TabIndex = 15;
            cb_Teacher_UserId.Text = "UserID";
            cb_Teacher_UserId.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_Name
            // 
            cb_Teacher_Name.AutoSize = true;
            cb_Teacher_Name.BackColor = Color.White;
            cb_Teacher_Name.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Name.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Name.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Name.Enable = true;
            cb_Teacher_Name.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Name.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Name.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Name.Font = new Font("Poppins", 12F);
            cb_Teacher_Name.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Name.Location = new Point(27, 52);
            cb_Teacher_Name.Name = "cb_Teacher_Name";
            cb_Teacher_Name.Size = new Size(85, 20);
            cb_Teacher_Name.TabIndex = 16;
            cb_Teacher_Name.Text = "Name";
            cb_Teacher_Name.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_DateOfBirth
            // 
            cb_Teacher_DateOfBirth.AutoSize = true;
            cb_Teacher_DateOfBirth.BackColor = Color.White;
            cb_Teacher_DateOfBirth.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_DateOfBirth.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_DateOfBirth.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_DateOfBirth.Enable = true;
            cb_Teacher_DateOfBirth.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_DateOfBirth.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_DateOfBirth.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_DateOfBirth.Font = new Font("Poppins", 12F);
            cb_Teacher_DateOfBirth.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_DateOfBirth.Location = new Point(27, 80);
            cb_Teacher_DateOfBirth.Name = "cb_Teacher_DateOfBirth";
            cb_Teacher_DateOfBirth.Size = new Size(137, 20);
            cb_Teacher_DateOfBirth.TabIndex = 17;
            cb_Teacher_DateOfBirth.Text = "Date Of Birth";
            cb_Teacher_DateOfBirth.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_Address
            // 
            cb_Teacher_Address.AutoSize = true;
            cb_Teacher_Address.BackColor = Color.White;
            cb_Teacher_Address.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Address.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Address.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Address.Enable = true;
            cb_Teacher_Address.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Address.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Address.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Address.Font = new Font("Poppins", 12F);
            cb_Teacher_Address.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Address.Location = new Point(162, 51);
            cb_Teacher_Address.Name = "cb_Teacher_Address";
            cb_Teacher_Address.Size = new Size(102, 20);
            cb_Teacher_Address.TabIndex = 19;
            cb_Teacher_Address.Text = "Address";
            cb_Teacher_Address.UseVisualStyleBackColor = false;
            // 
            // cb_Teacher_Phone
            // 
            cb_Teacher_Phone.AutoSize = true;
            cb_Teacher_Phone.BackColor = Color.White;
            cb_Teacher_Phone.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Phone.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Teacher_Phone.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Teacher_Phone.Enable = true;
            cb_Teacher_Phone.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Teacher_Phone.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Teacher_Phone.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Teacher_Phone.Font = new Font("Poppins", 12F);
            cb_Teacher_Phone.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Teacher_Phone.Location = new Point(162, 79);
            cb_Teacher_Phone.Name = "cb_Teacher_Phone";
            cb_Teacher_Phone.Size = new Size(154, 20);
            cb_Teacher_Phone.TabIndex = 18;
            cb_Teacher_Phone.Text = "Phone Number";
            cb_Teacher_Phone.UseVisualStyleBackColor = false;
            // 
            // lbl_TeacherResults
            // 
            lbl_TeacherResults.AutoSize = true;
            lbl_TeacherResults.BackColor = Color.Transparent;
            lbl_TeacherResults.Font = new Font("Poppins", 12F);
            lbl_TeacherResults.ForeColor = Color.Gray;
            lbl_TeacherResults.Location = new Point(6, 569);
            lbl_TeacherResults.Name = "lbl_TeacherResults";
            lbl_TeacherResults.Size = new Size(160, 28);
            lbl_TeacherResults.TabIndex = 15;
            lbl_TeacherResults.Text = "1 to 10 of 100 results";
            // 
            // tab_Subject
            // 
            tab_Subject.BackColor = Color.FromArgb(41, 50, 63);
            tab_Subject.Controls.Add(dgv_StudentSelection);
            tab_Subject.Controls.Add(lbl_Course);
            tab_Subject.Controls.Add(dgv_Courses);
            tab_Subject.Controls.Add(pnl_CourseStudentFeature);
            tab_Subject.Controls.Add(pnl_Course_Modifier);
            tab_Subject.Location = new Point(204, 4);
            tab_Subject.Name = "tab_Subject";
            tab_Subject.Padding = new Padding(3);
            tab_Subject.Size = new Size(1192, 602);
            tab_Subject.TabIndex = 3;
            tab_Subject.Text = "Subject";
            // 
            // dgv_StudentSelection
            // 
            dgv_StudentSelection.AllowUserToAddRows = false;
            dgv_StudentSelection.AllowUserToDeleteRows = false;
            dgv_StudentSelection.AllowUserToResizeColumns = false;
            dgv_StudentSelection.AllowUserToResizeRows = false;
            dgv_StudentSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_StudentSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_StudentSelection.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_StudentSelection.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_StudentSelection.BorderStyle = BorderStyle.None;
            dgv_StudentSelection.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_StudentSelection.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_StudentSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_StudentSelection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_StudentSelection.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_StudentSelection.EnableHeadersVisualStyles = false;
            dgv_StudentSelection.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_StudentSelection.GridColor = Color.Black;
            dgv_StudentSelection.Location = new Point(748, 151);
            dgv_StudentSelection.Name = "dgv_StudentSelection";
            dgv_StudentSelection.ReadOnly = true;
            dgv_StudentSelection.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle9.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_StudentSelection.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_StudentSelection.RowHeadersVisible = false;
            dgv_StudentSelection.RowHeadersWidth = 20;
            dgv_StudentSelection.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_StudentSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_StudentSelection.Size = new Size(436, 428);
            dgv_StudentSelection.TabIndex = 19;
            dgv_StudentSelection.UseCustomBackColor = true;
            dgv_StudentSelection.UseCustomForeColor = true;
            dgv_StudentSelection.UseStyleColors = true;
            // 
            // lbl_Course
            // 
            lbl_Course.AutoSize = true;
            lbl_Course.Location = new Point(6, 8);
            lbl_Course.Name = "lbl_Course";
            lbl_Course.Size = new Size(194, 39);
            lbl_Course.TabIndex = 18;
            lbl_Course.Text = "Offered Courses";
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_Courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgv_Courses.DefaultCellStyle = dataGridViewCellStyle11;
            dgv_Courses.EnableHeadersVisualStyles = false;
            dgv_Courses.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Courses.GridColor = Color.Black;
            dgv_Courses.Location = new Point(11, 151);
            dgv_Courses.Name = "dgv_Courses";
            dgv_Courses.ReadOnly = true;
            dgv_Courses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle12.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_Courses.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_Courses.RowHeadersVisible = false;
            dgv_Courses.RowHeadersWidth = 20;
            dgv_Courses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Courses.Size = new Size(723, 428);
            dgv_Courses.TabIndex = 15;
            dgv_Courses.UseCustomBackColor = true;
            dgv_Courses.UseCustomForeColor = true;
            dgv_Courses.UseStyleColors = true;
            dgv_Courses.CellClick += dgv_Courses_CellClick;
            // 
            // pnl_CourseStudentFeature
            // 
            pnl_CourseStudentFeature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnl_CourseStudentFeature.BackgroundFillColor = Color.White;
            pnl_CourseStudentFeature.BorderColor = Color.White;
            pnl_CourseStudentFeature.Controls.Add(tb_SearchStudentCourse);
            pnl_CourseStudentFeature.Controls.Add(cb_Course_GenderFilter);
            pnl_CourseStudentFeature.Controls.Add(lbl_Taken);
            pnl_CourseStudentFeature.Controls.Add(cb_Course_ProgramFilter);
            pnl_CourseStudentFeature.Controls.Add(toggle_CourseTaken);
            pnl_CourseStudentFeature.Controls.Add(cb_Course_NameFilter);
            pnl_CourseStudentFeature.Location = new Point(742, 8);
            pnl_CourseStudentFeature.Name = "pnl_CourseStudentFeature";
            pnl_CourseStudentFeature.Size = new Size(444, 136);
            pnl_CourseStudentFeature.TabIndex = 17;
            // 
            // tb_SearchStudentCourse
            // 
            tb_SearchStudentCourse.AnimateReadOnly = false;
            tb_SearchStudentCourse.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchStudentCourse.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchStudentCourse.BackColor = Color.FromArgb(41, 50, 63);
            tb_SearchStudentCourse.BackgroundImageLayout = ImageLayout.None;
            tb_SearchStudentCourse.CharacterCasing = CharacterCasing.Normal;
            tb_SearchStudentCourse.Depth = 0;
            tb_SearchStudentCourse.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchStudentCourse.HideSelection = true;
            tb_SearchStudentCourse.Hint = "Search";
            tb_SearchStudentCourse.LeadingIcon = (Image)resources.GetObject("tb_SearchStudentCourse.LeadingIcon");
            tb_SearchStudentCourse.Location = new Point(31, 64);
            tb_SearchStudentCourse.MaxLength = 100;
            tb_SearchStudentCourse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_SearchStudentCourse.Name = "tb_SearchStudentCourse";
            tb_SearchStudentCourse.PasswordChar = '\0';
            tb_SearchStudentCourse.PrefixSuffixText = null;
            tb_SearchStudentCourse.ReadOnly = false;
            tb_SearchStudentCourse.RightToLeft = RightToLeft.No;
            tb_SearchStudentCourse.SelectedText = "";
            tb_SearchStudentCourse.SelectionLength = 0;
            tb_SearchStudentCourse.SelectionStart = 0;
            tb_SearchStudentCourse.ShortcutsEnabled = true;
            tb_SearchStudentCourse.Size = new Size(222, 48);
            tb_SearchStudentCourse.TabIndex = 24;
            tb_SearchStudentCourse.TabStop = false;
            tb_SearchStudentCourse.TextAlign = HorizontalAlignment.Left;
            tb_SearchStudentCourse.TrailingIcon = null;
            tb_SearchStudentCourse.UseSystemPasswordChar = false;
            tb_SearchStudentCourse.TextChanged += tb_SearchStudentCourse_TextChanged;
            // 
            // cb_Course_GenderFilter
            // 
            cb_Course_GenderFilter.AutoSize = true;
            cb_Course_GenderFilter.BackColor = Color.White;
            cb_Course_GenderFilter.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Course_GenderFilter.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Course_GenderFilter.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Course_GenderFilter.Enable = true;
            cb_Course_GenderFilter.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Course_GenderFilter.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Course_GenderFilter.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Course_GenderFilter.Font = new Font("Poppins", 12F);
            cb_Course_GenderFilter.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Course_GenderFilter.Location = new Point(240, 35);
            cb_Course_GenderFilter.Name = "cb_Course_GenderFilter";
            cb_Course_GenderFilter.Size = new Size(96, 20);
            cb_Course_GenderFilter.TabIndex = 23;
            cb_Course_GenderFilter.Text = "Gender";
            cb_Course_GenderFilter.UseVisualStyleBackColor = false;
            // 
            // lbl_Taken
            // 
            lbl_Taken.AutoSize = true;
            lbl_Taken.BackColor = Color.White;
            lbl_Taken.Font = new Font("Poppins", 12F);
            lbl_Taken.Location = new Point(267, 83);
            lbl_Taken.Name = "lbl_Taken";
            lbl_Taken.Size = new Size(120, 28);
            lbl_Taken.TabIndex = 13;
            lbl_Taken.Text = "Course Taken";
            // 
            // cb_Course_ProgramFilter
            // 
            cb_Course_ProgramFilter.AutoSize = true;
            cb_Course_ProgramFilter.BackColor = Color.White;
            cb_Course_ProgramFilter.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Course_ProgramFilter.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Course_ProgramFilter.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Course_ProgramFilter.Enable = true;
            cb_Course_ProgramFilter.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Course_ProgramFilter.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Course_ProgramFilter.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Course_ProgramFilter.Font = new Font("Poppins", 12F);
            cb_Course_ProgramFilter.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Course_ProgramFilter.Location = new Point(37, 35);
            cb_Course_ProgramFilter.Name = "cb_Course_ProgramFilter";
            cb_Course_ProgramFilter.Size = new Size(106, 20);
            cb_Course_ProgramFilter.TabIndex = 15;
            cb_Course_ProgramFilter.Text = "Program";
            cb_Course_ProgramFilter.UseVisualStyleBackColor = false;
            // 
            // toggle_CourseTaken
            // 
            toggle_CourseTaken.AutoSize = true;
            toggle_CourseTaken.BackColor = Color.White;
            toggle_CourseTaken.BaseColor = Color.White;
            toggle_CourseTaken.BaseColorA = Color.FromArgb(220, 223, 230);
            toggle_CourseTaken.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            toggle_CourseTaken.HeadColorA = Color.FromArgb(220, 223, 230);
            toggle_CourseTaken.HeadColorB = Color.FromArgb(32, 41, 50);
            toggle_CourseTaken.HeadColorC = Color.FromArgb(64, 158, 255);
            toggle_CourseTaken.HeadColorD = Color.FromArgb(64, 158, 255);
            toggle_CourseTaken.Location = new Point(385, 87);
            toggle_CourseTaken.Name = "toggle_CourseTaken";
            toggle_CourseTaken.Size = new Size(48, 20);
            toggle_CourseTaken.TabIndex = 12;
            toggle_CourseTaken.Text = "Show Inactive";
            toggle_CourseTaken.UseVisualStyleBackColor = false;
            toggle_CourseTaken.CheckedChanged += toggle_CourseTaken_CheckedChanged;
            // 
            // cb_Course_NameFilter
            // 
            cb_Course_NameFilter.AutoSize = true;
            cb_Course_NameFilter.BackColor = Color.White;
            cb_Course_NameFilter.CheckedColor = Color.FromArgb(64, 158, 255);
            cb_Course_NameFilter.DisabledColor = Color.FromArgb(196, 198, 202);
            cb_Course_NameFilter.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb_Course_NameFilter.Enable = true;
            cb_Course_NameFilter.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            cb_Course_NameFilter.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb_Course_NameFilter.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb_Course_NameFilter.Font = new Font("Poppins", 12F);
            cb_Course_NameFilter.ForeColor = Color.FromArgb(48, 49, 51);
            cb_Course_NameFilter.Location = new Point(149, 35);
            cb_Course_NameFilter.Name = "cb_Course_NameFilter";
            cb_Course_NameFilter.Size = new Size(85, 20);
            cb_Course_NameFilter.TabIndex = 16;
            cb_Course_NameFilter.Text = "Name";
            cb_Course_NameFilter.UseVisualStyleBackColor = false;
            // 
            // pnl_Course_Modifier
            // 
            pnl_Course_Modifier.BackgroundFillColor = Color.White;
            pnl_Course_Modifier.BorderColor = Color.White;
            pnl_Course_Modifier.Controls.Add(tb_SearchCourse);
            pnl_Course_Modifier.Controls.Add(btn_AssignCourse);
            pnl_Course_Modifier.Controls.Add(btn_CreateCourse);
            pnl_Course_Modifier.Controls.Add(btn_DeleteCourse);
            pnl_Course_Modifier.Location = new Point(2, 50);
            pnl_Course_Modifier.Name = "pnl_Course_Modifier";
            pnl_Course_Modifier.Size = new Size(737, 94);
            pnl_Course_Modifier.TabIndex = 16;
            // 
            // tb_SearchCourse
            // 
            tb_SearchCourse.AnimateReadOnly = false;
            tb_SearchCourse.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchCourse.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchCourse.BackColor = Color.FromArgb(41, 50, 63);
            tb_SearchCourse.BackgroundImageLayout = ImageLayout.None;
            tb_SearchCourse.CharacterCasing = CharacterCasing.Normal;
            tb_SearchCourse.Depth = 0;
            tb_SearchCourse.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchCourse.HideSelection = true;
            tb_SearchCourse.Hint = "Search";
            tb_SearchCourse.LeadingIcon = (Image)resources.GetObject("tb_SearchCourse.LeadingIcon");
            tb_SearchCourse.Location = new Point(26, 23);
            tb_SearchCourse.MaxLength = 100;
            tb_SearchCourse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_SearchCourse.Name = "tb_SearchCourse";
            tb_SearchCourse.PasswordChar = '\0';
            tb_SearchCourse.PrefixSuffixText = null;
            tb_SearchCourse.ReadOnly = false;
            tb_SearchCourse.RightToLeft = RightToLeft.No;
            tb_SearchCourse.SelectedText = "";
            tb_SearchCourse.SelectionLength = 0;
            tb_SearchCourse.SelectionStart = 0;
            tb_SearchCourse.ShortcutsEnabled = true;
            tb_SearchCourse.Size = new Size(250, 48);
            tb_SearchCourse.TabIndex = 1;
            tb_SearchCourse.TabStop = false;
            tb_SearchCourse.TextAlign = HorizontalAlignment.Left;
            tb_SearchCourse.TrailingIcon = null;
            tb_SearchCourse.UseSystemPasswordChar = false;
            tb_SearchCourse.TextChanged += tb_SearchCourse_TextChanged;
            // 
            // btn_AssignCourse
            // 
            btn_AssignCourse.BorderColor = Color.FromArgb(220, 223, 230);
            btn_AssignCourse.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_AssignCourse.DangerColor = Color.FromArgb(245, 108, 108);
            btn_AssignCourse.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_AssignCourse.Font = new Font("Poppins", 12F);
            btn_AssignCourse.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_AssignCourse.InfoColor = Color.FromArgb(144, 147, 153);
            btn_AssignCourse.Location = new Point(565, 26);
            btn_AssignCourse.Margin = new Padding(30, 3, 3, 3);
            btn_AssignCourse.Name = "btn_AssignCourse";
            btn_AssignCourse.PrimaryColor = Color.FromArgb(204, 102, 0);
            btn_AssignCourse.Size = new Size(138, 40);
            btn_AssignCourse.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_AssignCourse.TabIndex = 4;
            btn_AssignCourse.Text = "Assign Student";
            btn_AssignCourse.TextColor = Color.White;
            btn_AssignCourse.WarningColor = Color.FromArgb(230, 162, 60);
            btn_AssignCourse.Click += btn_AssignCourse_Click;
            // 
            // btn_CreateCourse
            // 
            btn_CreateCourse.BorderColor = Color.Black;
            btn_CreateCourse.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_CreateCourse.DangerColor = Color.FromArgb(245, 108, 108);
            btn_CreateCourse.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_CreateCourse.Font = new Font("Poppins", 12F);
            btn_CreateCourse.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_CreateCourse.InfoColor = Color.FromArgb(144, 147, 153);
            btn_CreateCourse.Location = new Point(293, 26);
            btn_CreateCourse.Margin = new Padding(30, 3, 3, 3);
            btn_CreateCourse.Name = "btn_CreateCourse";
            btn_CreateCourse.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_CreateCourse.Size = new Size(126, 40);
            btn_CreateCourse.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_CreateCourse.TabIndex = 2;
            btn_CreateCourse.Text = "Create New";
            btn_CreateCourse.TextColor = Color.White;
            btn_CreateCourse.WarningColor = Color.FromArgb(230, 162, 60);
            btn_CreateCourse.Click += btn_CreateCourse_Click;
            // 
            // btn_DeleteCourse
            // 
            btn_DeleteCourse.BorderColor = Color.FromArgb(220, 223, 230);
            btn_DeleteCourse.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_DeleteCourse.DangerColor = Color.FromArgb(245, 108, 108);
            btn_DeleteCourse.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_DeleteCourse.Font = new Font("Poppins", 12F);
            btn_DeleteCourse.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_DeleteCourse.InfoColor = Color.FromArgb(144, 147, 153);
            btn_DeleteCourse.Location = new Point(427, 26);
            btn_DeleteCourse.Margin = new Padding(30, 3, 3, 3);
            btn_DeleteCourse.Name = "btn_DeleteCourse";
            btn_DeleteCourse.PrimaryColor = Color.FromArgb(166, 9, 22);
            btn_DeleteCourse.Size = new Size(126, 40);
            btn_DeleteCourse.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteCourse.TabIndex = 3;
            btn_DeleteCourse.Text = "Delete Course";
            btn_DeleteCourse.TextColor = Color.White;
            btn_DeleteCourse.WarningColor = Color.FromArgb(230, 162, 60);
            btn_DeleteCourse.Click += btn_DeleteCourse_Click;
            // 
            // tab_Logs
            // 
            tab_Logs.BackColor = Color.FromArgb(41, 50, 63);
            tab_Logs.Location = new Point(204, 4);
            tab_Logs.Name = "tab_Logs";
            tab_Logs.Padding = new Padding(3);
            tab_Logs.Size = new Size(1192, 602);
            tab_Logs.TabIndex = 4;
            tab_Logs.Text = "Logs";
            // 
            // tab_Reports
            // 
            tab_Reports.BackColor = Color.FromArgb(41, 50, 63);
            tab_Reports.Location = new Point(204, 4);
            tab_Reports.Name = "tab_Reports";
            tab_Reports.Padding = new Padding(3);
            tab_Reports.Size = new Size(1192, 602);
            tab_Reports.TabIndex = 5;
            tab_Reports.Text = "Reports";
            // 
            // tab_Settings
            // 
            tab_Settings.BackColor = Color.FromArgb(41, 50, 63);
            tab_Settings.Controls.Add(btn_Logout);
            tab_Settings.Location = new Point(204, 4);
            tab_Settings.Name = "tab_Settings";
            tab_Settings.Padding = new Padding(3);
            tab_Settings.Size = new Size(1192, 602);
            tab_Settings.TabIndex = 6;
            tab_Settings.Text = "Settings";
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.Transparent;
            btn_Logout.DialogResult = DialogResult.None;
            btn_Logout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Logout.ForeColor = Color.FromArgb(242, 93, 89);
            btn_Logout.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btn_Logout.HoverForeColor = Color.White;
            btn_Logout.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btn_Logout.Location = new Point(6, 6);
            btn_Logout.MinimumSize = new Size(144, 47);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.NormalBackColor = Color.FromArgb(242, 93, 89);
            btn_Logout.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btn_Logout.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btn_Logout.PressedForeColor = Color.White;
            btn_Logout.Radius = 5;
            btn_Logout.Size = new Size(144, 47);
            btn_Logout.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btn_Logout.TabIndex = 0;
            btn_Logout.Text = "Logout";
            btn_Logout.Click += btn_Logout_Click;
            // 
            // hope_AdminDashboard
            // 
            hope_AdminDashboard.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_AdminDashboard.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_AdminDashboard.ControlBoxColorN = Color.White;
            hope_AdminDashboard.Dock = DockStyle.Top;
            hope_AdminDashboard.Font = new Font("Microsoft Sans Serif", 14.25F);
            hope_AdminDashboard.ForeColor = Color.FromArgb(242, 246, 252);
            hope_AdminDashboard.Image = Properties.Resources.FormIcon;
            hope_AdminDashboard.Location = new Point(0, 0);
            hope_AdminDashboard.Name = "hope_AdminDashboard";
            hope_AdminDashboard.Size = new Size(1400, 40);
            hope_AdminDashboard.TabIndex = 0;
            hope_AdminDashboard.Text = "Admin Dashboard";
            hope_AdminDashboard.ThemeColor = Color.FromArgb(30, 30, 30);
            // 
            // AdminDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1400, 650);
            Controls.Add(tab_Control);
            Controls.Add(hope_AdminDashboard);
            Font = new Font("Poppins", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1400, 1200);
            MinimumSize = new Size(190, 40);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            TransparencyKey = Color.Fuchsia;
            tab_Control.ResumeLayout(false);
            tab_Dashboard.ResumeLayout(false);
            tab_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ProfilePicture).EndInit();
            tab_Student.ResumeLayout(false);
            tab_Student.PerformLayout();
            pnl_Student_Toggle.ResumeLayout(false);
            pnl_Student_Toggle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            pnl_Student_Toggles.ResumeLayout(false);
            pnl_Student_Toggles.PerformLayout();
            pnl_Student_Modifiers.ResumeLayout(false);
            tab_Teacher.ResumeLayout(false);
            tab_Teacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).EndInit();
            pnl_Toggle_Teacher.ResumeLayout(false);
            pnl_Toggle_Teacher.PerformLayout();
            pnl_Teacher_Modifiers.ResumeLayout(false);
            pnl_Teacher_Toggles.ResumeLayout(false);
            pnl_Teacher_Toggles.PerformLayout();
            tab_Subject.ResumeLayout(false);
            tab_Subject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_StudentSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).EndInit();
            pnl_CourseStudentFeature.ResumeLayout(false);
            pnl_CourseStudentFeature.PerformLayout();
            pnl_Course_Modifier.ResumeLayout(false);
            tab_Settings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_AdminDashboard;
        private TabPage tab_Dashboard;
        private TabPage tab_Student;
        private TabPage tab_Teacher;
        private TabPage tab_Subject;
        private TabPage tab_Logs;
        private TabPage tab_Reports;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchStudent;
        private TabPage tab_Settings;
        private ReaLTaiizor.Controls.NightButton btn_Logout;
        private Label lbl_Welcome;
        private ReaLTaiizor.Controls.HopeRoundButton btn_RefreshStudent;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Students;
        private Label lbl_StudentResult;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateStudent;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteStudent;
        private ReaLTaiizor.Controls.HopeButton btn_CreateStudent;
        private UI.SPanel pnl_Student_Modifiers;
        private ReaLTaiizor.Controls.HopeToggle toggle_InactiveStudent;
        private Label lbl_ShowInactiveStudent;
        private Label lbl_TeacherResults;
        private UI.SPanel pnl_Student_Toggles;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_UserId;
        private Label lbl_Filter;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_Email;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_Name;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_DateOfBirth;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_Address;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_Phone;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_Gender;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_EnrollmentDate;
        private ReaLTaiizor.Controls.HopeButton btn_ShowCourse;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Courses;
        private UI.SPanel pnl_CourseStudentFeature;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Course_GenderFilter;
        private Label label1;
        private Label lbl_Taken;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Course_ProgramFilter;
        private ReaLTaiizor.Controls.HopeToggle toggle_CourseTaken;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Course_NameFilter;
        private UI.SPanel pnl_Course_Modifier;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchCourse;
        private ReaLTaiizor.Controls.HopeButton btn_AssignCourse;
        private ReaLTaiizor.Controls.HopeButton btn_CreateCourse;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteCourse;
        private Label lbl_Course;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_StudentSelection;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchStudentCourse;
        private PictureBox pb_ProfilePicture;
        private UI.SPanel pnl_Teacher_Toggles;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Gender;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_HireDate;
        private Label lbl_Teacher_ShowInactive;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Email;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_UserId;
        private ReaLTaiizor.Controls.HopeToggle toggle_InactiveTeacher;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Name;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_DateOfBirth;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Address;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Phone;
        private Label lbl_SearchStudents;
        private UI.SPanel pnl_Teacher_Modifiers;
        private Label lbl_SearchTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_TeacherDetail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchTeachers;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_CreateTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteTeacher;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Department;
        private Label lbl_Teacher_Filter;
        private UI.SPanel pnl_Toggle_Teacher;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Teacher_Specialization;
        private UI.SPanel pnl_Student_Toggle;
        private Label lbl_Student_Filter;
        private ReaLTaiizor.Controls.HopeCheckBox cb_Student_Program;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Teachers;
    }
}