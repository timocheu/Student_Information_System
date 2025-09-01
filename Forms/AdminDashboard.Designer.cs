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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            ReaLTaiizor.Controls.PoisonDataGridView dgv_Teachers;
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tab_Dashboard = new TabPage();
            lbl_Welcome = new Label();
            tab_Student = new TabPage();
            dgv_Students = new ReaLTaiizor.Controls.PoisonDataGridView();
            pnl_Toggles = new Student_Information_System.UI.SPanel();
            lbl_ShowInactiveStudent = new Label();
            toggle_InactiveStudent = new ReaLTaiizor.Controls.HopeToggle();
            pnl_Modifiers = new Student_Information_System.UI.SPanel();
            tb_SearchStudent = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_UpdateStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_CreateStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteStudent = new ReaLTaiizor.Controls.HopeButton();
            lbl_StudentResult = new Label();
            tab_Teacher = new TabPage();
            lbl_ShowInactiveTeacher = new Label();
            toggle_InactiveTeacher = new ReaLTaiizor.Controls.HopeToggle();
            pnl_TeacherModifiers = new Student_Information_System.UI.SPanel();
            tb_SearchTeacher = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_UpdateTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_CreateTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteTeacher = new ReaLTaiizor.Controls.HopeButton();
            lbl_TeacherResults = new Label();
            tab_Subject = new TabPage();
            tab_Logs = new TabPage();
            tab_Reports = new TabPage();
            tab_Settings = new TabPage();
            btn_Logout = new ReaLTaiizor.Controls.NightButton();
            hope_AdminDashboard = new ReaLTaiizor.Forms.HopeForm();
            tab_Control = new ReaLTaiizor.Controls.TabPage();
            dgv_Teachers = new ReaLTaiizor.Controls.PoisonDataGridView();
            tab_Control.SuspendLayout();
            tab_Dashboard.SuspendLayout();
            tab_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
            pnl_Toggles.SuspendLayout();
            pnl_Modifiers.SuspendLayout();
            tab_Teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).BeginInit();
            pnl_TeacherModifiers.SuspendLayout();
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
            tab_Control.Size = new Size(1200, 610);
            tab_Control.SizeMode = TabSizeMode.Fixed;
            tab_Control.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tab_Control.StringType = StringAlignment.Near;
            tab_Control.TabColor = Color.FromArgb(54, 57, 64);
            tab_Control.TabIndex = 3;
            tab_Control.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // tab_Dashboard
            // 
            tab_Dashboard.BackColor = Color.FromArgb(238, 242, 245);
            tab_Dashboard.Controls.Add(lbl_Welcome);
            tab_Dashboard.Location = new Point(204, 4);
            tab_Dashboard.Name = "tab_Dashboard";
            tab_Dashboard.Padding = new Padding(3);
            tab_Dashboard.Size = new Size(992, 602);
            tab_Dashboard.TabIndex = 0;
            tab_Dashboard.Text = "Dashboard";
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
            tab_Student.BackColor = Color.FromArgb(238, 242, 245);
            tab_Student.Controls.Add(dgv_Students);
            tab_Student.Controls.Add(pnl_Toggles);
            tab_Student.Controls.Add(pnl_Modifiers);
            tab_Student.Controls.Add(lbl_StudentResult);
            tab_Student.Location = new Point(204, 4);
            tab_Student.Name = "tab_Student";
            tab_Student.Padding = new Padding(3);
            tab_Student.Size = new Size(992, 602);
            tab_Student.TabIndex = 1;
            tab_Student.Text = "Student";
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_Students.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_Students.EnableHeadersVisualStyles = false;
            dgv_Students.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Students.GridColor = Color.Black;
            dgv_Students.Location = new Point(0, 132);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.ReadOnly = true;
            dgv_Students.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle9.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_Students.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_Students.RowHeadersVisible = false;
            dgv_Students.RowHeadersWidth = 20;
            dgv_Students.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Students.Size = new Size(980, 428);
            dgv_Students.TabIndex = 0;
            dgv_Students.UseCustomBackColor = true;
            dgv_Students.UseCustomForeColor = true;
            dgv_Students.UseStyleColors = true;
            // 
            // pnl_Toggles
            // 
            pnl_Toggles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnl_Toggles.BackgroundFillColor = Color.White;
            pnl_Toggles.BorderColor = Color.White;
            pnl_Toggles.Controls.Add(lbl_ShowInactiveStudent);
            pnl_Toggles.Controls.Add(toggle_InactiveStudent);
            pnl_Toggles.Location = new Point(760, 65);
            pnl_Toggles.Name = "pnl_Toggles";
            pnl_Toggles.Size = new Size(224, 71);
            pnl_Toggles.TabIndex = 14;
            // 
            // lbl_ShowInactiveStudent
            // 
            lbl_ShowInactiveStudent.AutoSize = true;
            lbl_ShowInactiveStudent.BackColor = Color.White;
            lbl_ShowInactiveStudent.Font = new Font("Poppins", 12F);
            lbl_ShowInactiveStudent.Location = new Point(29, 24);
            lbl_ShowInactiveStudent.Name = "lbl_ShowInactiveStudent";
            lbl_ShowInactiveStudent.Size = new Size(122, 28);
            lbl_ShowInactiveStudent.TabIndex = 13;
            lbl_ShowInactiveStudent.Text = "Show Inactive";
            lbl_ShowInactiveStudent.Click += lbl_ShowInactiveStudent_Click;
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
            toggle_InactiveStudent.Location = new Point(157, 27);
            toggle_InactiveStudent.Name = "toggle_InactiveStudent";
            toggle_InactiveStudent.Size = new Size(48, 20);
            toggle_InactiveStudent.TabIndex = 12;
            toggle_InactiveStudent.Text = "Show Inactive";
            toggle_InactiveStudent.UseVisualStyleBackColor = false;
            toggle_InactiveStudent.CheckedChanged += toggle_InactiveStudent_CheckedChanged;
            toggle_InactiveStudent.MouseCaptureChanged += toggle_InactiveStudent_MouseCaptureChanged;
            // 
            // pnl_Modifiers
            // 
            pnl_Modifiers.BackgroundFillColor = Color.White;
            pnl_Modifiers.BorderColor = Color.White;
            pnl_Modifiers.Controls.Add(tb_SearchStudent);
            pnl_Modifiers.Controls.Add(btn_UpdateStudent);
            pnl_Modifiers.Controls.Add(btn_CreateStudent);
            pnl_Modifiers.Controls.Add(btn_DeleteStudent);
            pnl_Modifiers.Location = new Point(-5, 42);
            pnl_Modifiers.Name = "pnl_Modifiers";
            pnl_Modifiers.Size = new Size(629, 94);
            pnl_Modifiers.TabIndex = 9;
            // 
            // tb_SearchStudent
            // 
            tb_SearchStudent.AnimateReadOnly = false;
            tb_SearchStudent.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchStudent.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchStudent.BackgroundImageLayout = ImageLayout.None;
            tb_SearchStudent.CharacterCasing = CharacterCasing.Normal;
            tb_SearchStudent.Depth = 0;
            tb_SearchStudent.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchStudent.HideSelection = true;
            tb_SearchStudent.Hint = "Search";
            tb_SearchStudent.LeadingIcon = (Image)resources.GetObject("tb_SearchStudent.LeadingIcon");
            tb_SearchStudent.Location = new Point(26, 23);
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
            tb_SearchStudent.Size = new Size(250, 48);
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
            btn_UpdateStudent.Location = new Point(518, 26);
            btn_UpdateStudent.Margin = new Padding(30, 3, 3, 3);
            btn_UpdateStudent.Name = "btn_UpdateStudent";
            btn_UpdateStudent.PrimaryColor = Color.FromArgb(204, 102, 0);
            btn_UpdateStudent.Size = new Size(80, 40);
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
            btn_CreateStudent.Location = new Point(293, 26);
            btn_CreateStudent.Margin = new Padding(30, 3, 3, 3);
            btn_CreateStudent.Name = "btn_CreateStudent";
            btn_CreateStudent.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_CreateStudent.Size = new Size(126, 40);
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
            btn_DeleteStudent.Location = new Point(427, 26);
            btn_DeleteStudent.Margin = new Padding(30, 3, 3, 3);
            btn_DeleteStudent.Name = "btn_DeleteStudent";
            btn_DeleteStudent.PrimaryColor = Color.FromArgb(166, 9, 22);
            btn_DeleteStudent.Size = new Size(80, 40);
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
            tab_Teacher.BackColor = Color.FromArgb(238, 242, 245);
            tab_Teacher.Controls.Add(dgv_Teachers);
            tab_Teacher.Controls.Add(lbl_ShowInactiveTeacher);
            tab_Teacher.Controls.Add(toggle_InactiveTeacher);
            tab_Teacher.Controls.Add(pnl_TeacherModifiers);
            tab_Teacher.Controls.Add(lbl_TeacherResults);
            tab_Teacher.Location = new Point(204, 4);
            tab_Teacher.Name = "tab_Teacher";
            tab_Teacher.Padding = new Padding(3);
            tab_Teacher.Size = new Size(992, 602);
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Teachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgv_Teachers.DefaultCellStyle = dataGridViewCellStyle11;
            dgv_Teachers.EnableHeadersVisualStyles = false;
            dgv_Teachers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Teachers.GridColor = Color.Black;
            dgv_Teachers.Location = new Point(4, 132);
            dgv_Teachers.Name = "dgv_Teachers";
            dgv_Teachers.ReadOnly = true;
            dgv_Teachers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle12.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_Teachers.RowHeadersVisible = false;
            dgv_Teachers.RowHeadersWidth = 20;
            dgv_Teachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Teachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teachers.Size = new Size(980, 428);
            dgv_Teachers.TabIndex = 14;
            dgv_Teachers.UseCustomBackColor = true;
            dgv_Teachers.UseCustomForeColor = true;
            dgv_Teachers.UseStyleColors = true;
            // 
            // lbl_ShowInactiveTeacher
            // 
            lbl_ShowInactiveTeacher.AutoSize = true;
            lbl_ShowInactiveTeacher.Font = new Font("Poppins", 12F);
            lbl_ShowInactiveTeacher.Location = new Point(806, 101);
            lbl_ShowInactiveTeacher.Name = "lbl_ShowInactiveTeacher";
            lbl_ShowInactiveTeacher.Size = new Size(122, 28);
            lbl_ShowInactiveTeacher.TabIndex = 18;
            lbl_ShowInactiveTeacher.Text = "Show Inactive";
            // 
            // toggle_InactiveTeacher
            // 
            toggle_InactiveTeacher.AutoSize = true;
            toggle_InactiveTeacher.BaseColor = Color.FromArgb(238, 242, 245);
            toggle_InactiveTeacher.BaseColorA = Color.FromArgb(220, 223, 230);
            toggle_InactiveTeacher.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            toggle_InactiveTeacher.HeadColorA = Color.FromArgb(220, 223, 230);
            toggle_InactiveTeacher.HeadColorB = Color.FromArgb(32, 41, 50);
            toggle_InactiveTeacher.HeadColorC = Color.FromArgb(64, 158, 255);
            toggle_InactiveTeacher.HeadColorD = Color.FromArgb(64, 158, 255);
            toggle_InactiveTeacher.Location = new Point(926, 104);
            toggle_InactiveTeacher.Name = "toggle_InactiveTeacher";
            toggle_InactiveTeacher.Size = new Size(48, 20);
            toggle_InactiveTeacher.TabIndex = 17;
            toggle_InactiveTeacher.Text = "Show Inactive";
            toggle_InactiveTeacher.UseVisualStyleBackColor = true;
            // 
            // pnl_TeacherModifiers
            // 
            pnl_TeacherModifiers.BackgroundFillColor = Color.White;
            pnl_TeacherModifiers.BorderColor = Color.White;
            pnl_TeacherModifiers.Controls.Add(tb_SearchTeacher);
            pnl_TeacherModifiers.Controls.Add(btn_UpdateTeacher);
            pnl_TeacherModifiers.Controls.Add(btn_CreateTeacher);
            pnl_TeacherModifiers.Controls.Add(btn_DeleteTeacher);
            pnl_TeacherModifiers.Location = new Point(-5, 42);
            pnl_TeacherModifiers.Name = "pnl_TeacherModifiers";
            pnl_TeacherModifiers.Size = new Size(629, 94);
            pnl_TeacherModifiers.TabIndex = 16;
            // 
            // tb_SearchTeacher
            // 
            tb_SearchTeacher.AnimateReadOnly = false;
            tb_SearchTeacher.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchTeacher.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchTeacher.BackgroundImageLayout = ImageLayout.None;
            tb_SearchTeacher.CharacterCasing = CharacterCasing.Normal;
            tb_SearchTeacher.Depth = 0;
            tb_SearchTeacher.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchTeacher.HideSelection = true;
            tb_SearchTeacher.Hint = "Search";
            tb_SearchTeacher.LeadingIcon = (Image)resources.GetObject("tb_SearchTeacher.LeadingIcon");
            tb_SearchTeacher.Location = new Point(26, 23);
            tb_SearchTeacher.MaxLength = 100;
            tb_SearchTeacher.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_SearchTeacher.Name = "tb_SearchTeacher";
            tb_SearchTeacher.PasswordChar = '\0';
            tb_SearchTeacher.PrefixSuffixText = null;
            tb_SearchTeacher.ReadOnly = false;
            tb_SearchTeacher.RightToLeft = RightToLeft.No;
            tb_SearchTeacher.SelectedText = "";
            tb_SearchTeacher.SelectionLength = 0;
            tb_SearchTeacher.SelectionStart = 0;
            tb_SearchTeacher.ShortcutsEnabled = true;
            tb_SearchTeacher.Size = new Size(250, 48);
            tb_SearchTeacher.TabIndex = 1;
            tb_SearchTeacher.TabStop = false;
            tb_SearchTeacher.TextAlign = HorizontalAlignment.Left;
            tb_SearchTeacher.TrailingIcon = null;
            tb_SearchTeacher.UseSystemPasswordChar = false;
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
            btn_UpdateTeacher.Location = new Point(518, 26);
            btn_UpdateTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_UpdateTeacher.Name = "btn_UpdateTeacher";
            btn_UpdateTeacher.PrimaryColor = Color.FromArgb(204, 102, 0);
            btn_UpdateTeacher.Size = new Size(80, 40);
            btn_UpdateTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateTeacher.TabIndex = 4;
            btn_UpdateTeacher.Text = "Update";
            btn_UpdateTeacher.TextColor = Color.White;
            btn_UpdateTeacher.WarningColor = Color.FromArgb(230, 162, 60);
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
            btn_CreateTeacher.Location = new Point(293, 26);
            btn_CreateTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_CreateTeacher.Name = "btn_CreateTeacher";
            btn_CreateTeacher.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_CreateTeacher.Size = new Size(126, 40);
            btn_CreateTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_CreateTeacher.TabIndex = 2;
            btn_CreateTeacher.Text = "Create New";
            btn_CreateTeacher.TextColor = Color.White;
            btn_CreateTeacher.WarningColor = Color.FromArgb(230, 162, 60);
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
            btn_DeleteTeacher.Location = new Point(427, 26);
            btn_DeleteTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_DeleteTeacher.Name = "btn_DeleteTeacher";
            btn_DeleteTeacher.PrimaryColor = Color.FromArgb(166, 9, 22);
            btn_DeleteTeacher.Size = new Size(80, 40);
            btn_DeleteTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteTeacher.TabIndex = 3;
            btn_DeleteTeacher.Text = "Delete";
            btn_DeleteTeacher.TextColor = Color.White;
            btn_DeleteTeacher.WarningColor = Color.FromArgb(230, 162, 60);
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
            tab_Subject.BackColor = Color.FromArgb(238, 242, 245);
            tab_Subject.Location = new Point(204, 4);
            tab_Subject.Name = "tab_Subject";
            tab_Subject.Padding = new Padding(3);
            tab_Subject.Size = new Size(992, 602);
            tab_Subject.TabIndex = 3;
            tab_Subject.Text = "Subject";
            // 
            // tab_Logs
            // 
            tab_Logs.BackColor = Color.FromArgb(238, 242, 245);
            tab_Logs.Location = new Point(204, 4);
            tab_Logs.Name = "tab_Logs";
            tab_Logs.Padding = new Padding(3);
            tab_Logs.Size = new Size(992, 602);
            tab_Logs.TabIndex = 4;
            tab_Logs.Text = "Logs";
            // 
            // tab_Reports
            // 
            tab_Reports.BackColor = Color.FromArgb(238, 242, 245);
            tab_Reports.Location = new Point(204, 4);
            tab_Reports.Name = "tab_Reports";
            tab_Reports.Padding = new Padding(3);
            tab_Reports.Size = new Size(992, 602);
            tab_Reports.TabIndex = 5;
            tab_Reports.Text = "Reports";
            // 
            // tab_Settings
            // 
            tab_Settings.BackColor = Color.FromArgb(238, 242, 245);
            tab_Settings.Controls.Add(btn_Logout);
            tab_Settings.Location = new Point(204, 4);
            tab_Settings.Name = "tab_Settings";
            tab_Settings.Padding = new Padding(3);
            tab_Settings.Size = new Size(992, 602);
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
            hope_AdminDashboard.Size = new Size(1200, 40);
            hope_AdminDashboard.TabIndex = 0;
            hope_AdminDashboard.Text = "Admin Dashboard";
            hope_AdminDashboard.ThemeColor = Color.FromArgb(30, 30, 30);
            hope_AdminDashboard.Click += hope_AdminDashboard_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1200, 650);
            Controls.Add(tab_Control);
            Controls.Add(hope_AdminDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 900);
            MinimumSize = new Size(190, 40);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            TransparencyKey = Color.Fuchsia;
            tab_Control.ResumeLayout(false);
            tab_Dashboard.ResumeLayout(false);
            tab_Dashboard.PerformLayout();
            tab_Student.ResumeLayout(false);
            tab_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            pnl_Toggles.ResumeLayout(false);
            pnl_Toggles.PerformLayout();
            pnl_Modifiers.ResumeLayout(false);
            tab_Teacher.ResumeLayout(false);
            tab_Teacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).EndInit();
            pnl_TeacherModifiers.ResumeLayout(false);
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
        private UI.SPanel pnl_Modifiers;
        private ReaLTaiizor.Controls.HopeToggle toggle_InactiveStudent;
        private Label lbl_ShowInactiveStudent;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Teachers;
        private Label lbl_ShowInactiveTeacher;
        private ReaLTaiizor.Controls.HopeToggle toggle_InactiveTeacher;
        private UI.SPanel pnl_TeacherModifiers;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_CreateTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteTeacher;
        private Label lbl_TeacherResults;
        private UI.SPanel pnl_Toggles;
    }
}