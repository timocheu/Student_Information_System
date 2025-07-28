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
            TabPage tab_Logout;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tab_Dashboard = new TabPage();
            tab_Student = new TabPage();
            tab_Teacher = new TabPage();
            tab_Subject = new TabPage();
            tab_Logs = new TabPage();
            tab_Reports = new TabPage();
            hope_AdminDashboard = new ReaLTaiizor.Forms.HopeForm();
            dgv_Student = new ReaLTaiizor.Controls.PoisonDataGridView();
            col_Name = new DataGridViewTextBoxColumn();
            col_Age = new DataGridViewTextBoxColumn();
            col_Nickname = new DataGridViewTextBoxColumn();
            col_Employee = new DataGridViewTextBoxColumn();
            tb_SearchStudent = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_AddStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_UpdateStudent = new ReaLTaiizor.Controls.HopeButton();
            airTabPage1 = new ReaLTaiizor.Controls.AirTabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btn_UpdateTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_AddTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_SearchTeacher = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dgv_Teacher = new ReaLTaiizor.Controls.PoisonDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            gunaBubbleDataset1 = new Guna.Charts.WinForms.GunaBubbleDataset();
            tab_Control = new ReaLTaiizor.Controls.TabPage();
            tab_Logout = new TabPage();
            tab_Control.SuspendLayout();
            tab_Student.SuspendLayout();
            tab_Teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Student).BeginInit();
            airTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).BeginInit();
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
            tab_Control.Controls.Add(tab_Logout);
            tab_Control.Dock = DockStyle.Fill;
            tab_Control.DrawMode = TabDrawMode.OwnerDrawFixed;
            tab_Control.Font = new Font("Poppins", 12F);
            tab_Control.FrameColor = Color.FromArgb(238, 242, 245);
            tab_Control.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            tab_Control.ItemSize = new Size(44, 135);
            tab_Control.LineColor = Color.FromArgb(25, 26, 28);
            tab_Control.LineTabColor = Color.FromArgb(54, 57, 64);
            tab_Control.Location = new Point(0, 40);
            tab_Control.Multiline = true;
            tab_Control.Name = "tab_Control";
            tab_Control.NormalForeColor = Color.FromArgb(159, 162, 167);
            tab_Control.PageColor = Color.FromArgb(238, 242, 245);
            tab_Control.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tab_Control.SelectedIndex = 0;
            tab_Control.Size = new Size(1200, 660);
            tab_Control.SizeMode = TabSizeMode.Fixed;
            tab_Control.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tab_Control.StringType = StringAlignment.Near;
            tab_Control.TabColor = Color.FromArgb(54, 57, 64);
            tab_Control.TabIndex = 3;
            tab_Control.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tab_Dashboard
            // 
            tab_Dashboard.BackColor = Color.FromArgb(238, 242, 245);
            tab_Dashboard.Location = new Point(139, 4);
            tab_Dashboard.Name = "tab_Dashboard";
            tab_Dashboard.Padding = new Padding(3);
            tab_Dashboard.Size = new Size(1057, 652);
            tab_Dashboard.TabIndex = 0;
            tab_Dashboard.Text = "Dashboard";
            // 
            // tab_Student
            // 
            tab_Student.BackColor = Color.FromArgb(238, 242, 245);
            tab_Student.Controls.Add(airTabPage1);
            tab_Student.Controls.Add(btn_UpdateStudent);
            tab_Student.Controls.Add(btn_DeleteStudent);
            tab_Student.Controls.Add(btn_AddStudent);
            tab_Student.Controls.Add(tb_SearchStudent);
            tab_Student.Controls.Add(dgv_Student);
            tab_Student.Location = new Point(139, 4);
            tab_Student.Name = "tab_Student";
            tab_Student.Padding = new Padding(3);
            tab_Student.Size = new Size(1057, 652);
            tab_Student.TabIndex = 1;
            tab_Student.Text = "Student";
            // 
            // tab_Teacher
            // 
            tab_Teacher.BackColor = Color.FromArgb(238, 242, 245);
            tab_Teacher.Controls.Add(btn_UpdateTeacher);
            tab_Teacher.Controls.Add(btn_DeleteTeacher);
            tab_Teacher.Controls.Add(btn_AddTeacher);
            tab_Teacher.Controls.Add(btn_SearchTeacher);
            tab_Teacher.Controls.Add(dgv_Teacher);
            tab_Teacher.Location = new Point(139, 4);
            tab_Teacher.Name = "tab_Teacher";
            tab_Teacher.Padding = new Padding(3);
            tab_Teacher.Size = new Size(1057, 652);
            tab_Teacher.TabIndex = 2;
            tab_Teacher.Text = "Teacher";
            // 
            // tab_Subject
            // 
            tab_Subject.BackColor = Color.FromArgb(238, 242, 245);
            tab_Subject.Location = new Point(139, 4);
            tab_Subject.Name = "tab_Subject";
            tab_Subject.Padding = new Padding(3);
            tab_Subject.Size = new Size(1057, 652);
            tab_Subject.TabIndex = 3;
            tab_Subject.Text = "Subject";
            // 
            // tab_Logs
            // 
            tab_Logs.BackColor = Color.FromArgb(238, 242, 245);
            tab_Logs.Location = new Point(139, 4);
            tab_Logs.Name = "tab_Logs";
            tab_Logs.Padding = new Padding(3);
            tab_Logs.Size = new Size(1057, 652);
            tab_Logs.TabIndex = 4;
            tab_Logs.Text = "Logs";
            // 
            // tab_Reports
            // 
            tab_Reports.BackColor = Color.FromArgb(238, 242, 245);
            tab_Reports.Location = new Point(139, 4);
            tab_Reports.Name = "tab_Reports";
            tab_Reports.Padding = new Padding(3);
            tab_Reports.Size = new Size(1057, 652);
            tab_Reports.TabIndex = 5;
            tab_Reports.Text = "Reports";
            // 
            // tab_Logout
            // 
            tab_Logout.BackColor = Color.FromArgb(238, 242, 245);
            tab_Logout.Location = new Point(139, 4);
            tab_Logout.Name = "tab_Logout";
            tab_Logout.Padding = new Padding(3);
            tab_Logout.Size = new Size(1057, 652);
            tab_Logout.TabIndex = 6;
            tab_Logout.Text = "Logout";
            tab_Logout.Click += tab_Logout_Click;
            // 
            // hope_AdminDashboard
            // 
            hope_AdminDashboard.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_AdminDashboard.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_AdminDashboard.ControlBoxColorN = Color.White;
            hope_AdminDashboard.Dock = DockStyle.Top;
            hope_AdminDashboard.Font = new Font("Poppins", 14.25F);
            hope_AdminDashboard.ForeColor = Color.FromArgb(242, 246, 252);
            hope_AdminDashboard.Image = Properties.Resources.FormIcon;
            hope_AdminDashboard.Location = new Point(0, 0);
            hope_AdminDashboard.Name = "hope_AdminDashboard";
            hope_AdminDashboard.Size = new Size(1200, 40);
            hope_AdminDashboard.TabIndex = 0;
            hope_AdminDashboard.Text = "Admin Dashboard";
            hope_AdminDashboard.ThemeColor = Color.FromArgb(30, 30, 30);
            // 
            // dgv_Student
            // 
            dgv_Student.AllowUserToAddRows = false;
            dgv_Student.AllowUserToDeleteRows = false;
            dgv_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Student.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Student.BorderStyle = BorderStyle.None;
            dgv_Student.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Student.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Student.Columns.AddRange(new DataGridViewColumn[] { col_Name, col_Age, col_Nickname, col_Employee });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Student.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Student.EnableHeadersVisualStyles = false;
            dgv_Student.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Student.GridColor = Color.FromArgb(255, 255, 255);
            dgv_Student.Location = new Point(49, 124);
            dgv_Student.Name = "dgv_Student";
            dgv_Student.ReadOnly = true;
            dgv_Student.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Student.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Student.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Student.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Student.Size = new Size(962, 367);
            dgv_Student.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            dgv_Student.TabIndex = 0;
            dgv_Student.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // col_Name
            // 
            col_Name.HeaderText = "Name (job title)";
            col_Name.Name = "col_Name";
            col_Name.ReadOnly = true;
            // 
            // col_Age
            // 
            col_Age.HeaderText = "Age";
            col_Age.Name = "col_Age";
            col_Age.ReadOnly = true;
            // 
            // col_Nickname
            // 
            col_Nickname.HeaderText = "Nickname";
            col_Nickname.Name = "col_Nickname";
            col_Nickname.ReadOnly = true;
            // 
            // col_Employee
            // 
            col_Employee.HeaderText = "Employee";
            col_Employee.Name = "col_Employee";
            col_Employee.ReadOnly = true;
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
            tb_SearchStudent.LeadingIcon = (Image)resources.GetObject("tb_SearchStudent.LeadingIcon");
            tb_SearchStudent.Location = new Point(761, 43);
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
            tb_SearchStudent.Text = "Search";
            tb_SearchStudent.TextAlign = HorizontalAlignment.Left;
            tb_SearchStudent.TrailingIcon = null;
            tb_SearchStudent.UseSystemPasswordChar = false;
            // 
            // btn_AddStudent
            // 
            btn_AddStudent.BorderColor = Color.Black;
            btn_AddStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_AddStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_AddStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_AddStudent.Font = new Font("Poppins", 14F);
            btn_AddStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_AddStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_AddStudent.Location = new Point(210, 549);
            btn_AddStudent.Name = "btn_AddStudent";
            btn_AddStudent.PrimaryColor = Color.FromArgb(0, 192, 0);
            btn_AddStudent.Size = new Size(144, 40);
            btn_AddStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_AddStudent.TabIndex = 2;
            btn_AddStudent.Text = "Add New";
            btn_AddStudent.TextColor = Color.White;
            btn_AddStudent.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_DeleteStudent
            // 
            btn_DeleteStudent.BorderColor = Color.FromArgb(220, 223, 230);
            btn_DeleteStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_DeleteStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_DeleteStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_DeleteStudent.Font = new Font("Poppins", 14F);
            btn_DeleteStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_DeleteStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_DeleteStudent.Location = new Point(428, 549);
            btn_DeleteStudent.Name = "btn_DeleteStudent";
            btn_DeleteStudent.PrimaryColor = Color.Red;
            btn_DeleteStudent.Size = new Size(144, 40);
            btn_DeleteStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteStudent.TabIndex = 3;
            btn_DeleteStudent.Text = "Delete";
            btn_DeleteStudent.TextColor = Color.White;
            btn_DeleteStudent.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_UpdateStudent
            // 
            btn_UpdateStudent.BorderColor = Color.FromArgb(220, 223, 230);
            btn_UpdateStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_UpdateStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_UpdateStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_UpdateStudent.Font = new Font("Poppins", 14F);
            btn_UpdateStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_UpdateStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_UpdateStudent.Location = new Point(636, 549);
            btn_UpdateStudent.Name = "btn_UpdateStudent";
            btn_UpdateStudent.PrimaryColor = Color.FromArgb(255, 128, 0);
            btn_UpdateStudent.Size = new Size(144, 40);
            btn_UpdateStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateStudent.TabIndex = 4;
            btn_UpdateStudent.Text = "Update";
            btn_UpdateStudent.TextColor = Color.White;
            btn_UpdateStudent.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // airTabPage1
            // 
            airTabPage1.Alignment = TabAlignment.Left;
            airTabPage1.BaseColor = Color.White;
            airTabPage1.Controls.Add(tabPage1);
            airTabPage1.Controls.Add(tabPage2);
            airTabPage1.ItemSize = new Size(30, 115);
            airTabPage1.Location = new Point(1045, 510);
            airTabPage1.Multiline = true;
            airTabPage1.Name = "airTabPage1";
            airTabPage1.NormalTextColor = Color.DimGray;
            airTabPage1.SelectedIndex = 0;
            airTabPage1.SelectedTabBackColor = Color.White;
            airTabPage1.SelectedTextColor = Color.Black;
            airTabPage1.ShowOuterBorders = false;
            airTabPage1.Size = new Size(200, 100);
            airTabPage1.SizeMode = TabSizeMode.Fixed;
            airTabPage1.SquareColor = Color.FromArgb(78, 87, 100);
            airTabPage1.TabCursor = Cursors.Hand;
            airTabPage1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(119, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(77, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(119, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(77, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // btn_UpdateTeacher
            // 
            btn_UpdateTeacher.BorderColor = Color.FromArgb(220, 223, 230);
            btn_UpdateTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_UpdateTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_UpdateTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_UpdateTeacher.Font = new Font("Poppins", 14F);
            btn_UpdateTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_UpdateTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_UpdateTeacher.Location = new Point(634, 559);
            btn_UpdateTeacher.Name = "btn_UpdateTeacher";
            btn_UpdateTeacher.PrimaryColor = Color.FromArgb(255, 128, 0);
            btn_UpdateTeacher.Size = new Size(144, 40);
            btn_UpdateTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateTeacher.TabIndex = 9;
            btn_UpdateTeacher.Text = "Update";
            btn_UpdateTeacher.TextColor = Color.White;
            btn_UpdateTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_DeleteTeacher
            // 
            btn_DeleteTeacher.BorderColor = Color.FromArgb(220, 223, 230);
            btn_DeleteTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_DeleteTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_DeleteTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_DeleteTeacher.Font = new Font("Poppins", 14F);
            btn_DeleteTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_DeleteTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_DeleteTeacher.Location = new Point(426, 559);
            btn_DeleteTeacher.Name = "btn_DeleteTeacher";
            btn_DeleteTeacher.PrimaryColor = Color.Red;
            btn_DeleteTeacher.Size = new Size(144, 40);
            btn_DeleteTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteTeacher.TabIndex = 8;
            btn_DeleteTeacher.Text = "Delete";
            btn_DeleteTeacher.TextColor = Color.White;
            btn_DeleteTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_AddTeacher
            // 
            btn_AddTeacher.BorderColor = Color.Black;
            btn_AddTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_AddTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_AddTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_AddTeacher.Font = new Font("Poppins", 14F);
            btn_AddTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_AddTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_AddTeacher.Location = new Point(208, 559);
            btn_AddTeacher.Name = "btn_AddTeacher";
            btn_AddTeacher.PrimaryColor = Color.FromArgb(0, 192, 0);
            btn_AddTeacher.Size = new Size(144, 40);
            btn_AddTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_AddTeacher.TabIndex = 7;
            btn_AddTeacher.Text = "Add New";
            btn_AddTeacher.TextColor = Color.White;
            btn_AddTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_SearchTeacher
            // 
            btn_SearchTeacher.AnimateReadOnly = false;
            btn_SearchTeacher.AutoCompleteMode = AutoCompleteMode.None;
            btn_SearchTeacher.AutoCompleteSource = AutoCompleteSource.None;
            btn_SearchTeacher.BackgroundImageLayout = ImageLayout.None;
            btn_SearchTeacher.CharacterCasing = CharacterCasing.Normal;
            btn_SearchTeacher.Depth = 0;
            btn_SearchTeacher.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_SearchTeacher.HideSelection = true;
            btn_SearchTeacher.LeadingIcon = (Image)resources.GetObject("btn_SearchTeacher.LeadingIcon");
            btn_SearchTeacher.Location = new Point(759, 53);
            btn_SearchTeacher.MaxLength = 100;
            btn_SearchTeacher.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            btn_SearchTeacher.Name = "btn_SearchTeacher";
            btn_SearchTeacher.PasswordChar = '\0';
            btn_SearchTeacher.PrefixSuffixText = null;
            btn_SearchTeacher.ReadOnly = false;
            btn_SearchTeacher.RightToLeft = RightToLeft.No;
            btn_SearchTeacher.SelectedText = "";
            btn_SearchTeacher.SelectionLength = 0;
            btn_SearchTeacher.SelectionStart = 0;
            btn_SearchTeacher.ShortcutsEnabled = true;
            btn_SearchTeacher.Size = new Size(250, 48);
            btn_SearchTeacher.TabIndex = 6;
            btn_SearchTeacher.TabStop = false;
            btn_SearchTeacher.Text = "Search";
            btn_SearchTeacher.TextAlign = HorizontalAlignment.Left;
            btn_SearchTeacher.TrailingIcon = null;
            btn_SearchTeacher.UseSystemPasswordChar = false;
            // 
            // dgv_Teacher
            // 
            dgv_Teacher.AllowUserToAddRows = false;
            dgv_Teacher.AllowUserToDeleteRows = false;
            dgv_Teacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Teacher.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Teacher.BorderStyle = BorderStyle.None;
            dgv_Teacher.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Teacher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle4.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Teacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Teacher.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Teacher.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Teacher.EnableHeadersVisualStyles = false;
            dgv_Teacher.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Teacher.GridColor = Color.FromArgb(255, 255, 255);
            dgv_Teacher.Location = new Point(47, 134);
            dgv_Teacher.Name = "dgv_Teacher";
            dgv_Teacher.ReadOnly = true;
            dgv_Teacher.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Teacher.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Teacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teacher.Size = new Size(962, 367);
            dgv_Teacher.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            dgv_Teacher.TabIndex = 5;
            dgv_Teacher.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name (job title)";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Age";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nickname";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Employee";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // gunaBubbleDataset1
            // 
            gunaBubbleDataset1.Label = "Bubble1";
            gunaBubbleDataset1.PointStyle = Guna.Charts.WinForms.PointStyle.Circle;
            gunaBubbleDataset1.Rotation = 0;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1200, 700);
            Controls.Add(tab_Control);
            Controls.Add(hope_AdminDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            tab_Control.ResumeLayout(false);
            tab_Student.ResumeLayout(false);
            tab_Teacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Student).EndInit();
            airTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).EndInit();
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
        private TabPage tab_Logout;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Student;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchStudent;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewTextBoxColumn col_Age;
        private DataGridViewTextBoxColumn col_Nickname;
        private DataGridViewTextBoxColumn col_Employee;
        private ReaLTaiizor.Controls.HopeButton btn_AddStudent;
        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateStudent;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteStudent;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_AddTeacher;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit btn_SearchTeacher;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Teacher;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Guna.Charts.WinForms.GunaBubbleDataset gunaBubbleDataset1;
    }
}