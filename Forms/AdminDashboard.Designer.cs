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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tab_Dashboard = new TabPage();
            tab_Student = new TabPage();
            layout_Buttons = new FlowLayoutPanel();
            btn_AddStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_UpdateStudent = new ReaLTaiizor.Controls.HopeButton();
            tb_SearchStudent = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dgv_Student = new ReaLTaiizor.Controls.PoisonDataGridView();
            col_Name = new DataGridViewTextBoxColumn();
            col_Age = new DataGridViewTextBoxColumn();
            col_Nickname = new DataGridViewTextBoxColumn();
            col_Employee = new DataGridViewTextBoxColumn();
            tab_Teacher = new TabPage();
            tab_Subject = new TabPage();
            tab_Logs = new TabPage();
            tab_Reports = new TabPage();
            tab_Settings = new TabPage();
            hope_AdminDashboard = new ReaLTaiizor.Forms.HopeForm();
            flowLayoutPanel1 = new FlowLayoutPanel();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            hopeButton3 = new ReaLTaiizor.Controls.HopeButton();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tab_Control = new ReaLTaiizor.Controls.TabPage();
            tab_Control.SuspendLayout();
            tab_Student.SuspendLayout();
            layout_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Student).BeginInit();
            tab_Teacher.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
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
            tab_Control.Font = new Font("Poppins", 12F);
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
            tab_Control.Size = new Size(1200, 660);
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
            tab_Dashboard.Location = new Point(204, 4);
            tab_Dashboard.Name = "tab_Dashboard";
            tab_Dashboard.Padding = new Padding(3);
            tab_Dashboard.Size = new Size(992, 652);
            tab_Dashboard.TabIndex = 0;
            tab_Dashboard.Text = "Dashboard";
            // 
            // tab_Student
            // 
            tab_Student.BackColor = Color.FromArgb(238, 242, 245);
            tab_Student.Controls.Add(layout_Buttons);
            tab_Student.Controls.Add(tb_SearchStudent);
            tab_Student.Controls.Add(dgv_Student);
            tab_Student.Location = new Point(204, 4);
            tab_Student.Name = "tab_Student";
            tab_Student.Padding = new Padding(3);
            tab_Student.Size = new Size(992, 652);
            tab_Student.TabIndex = 1;
            tab_Student.Text = "Student";
            // 
            // layout_Buttons
            // 
            layout_Buttons.AutoSize = true;
            layout_Buttons.Controls.Add(btn_AddStudent);
            layout_Buttons.Controls.Add(btn_DeleteStudent);
            layout_Buttons.Controls.Add(btn_UpdateStudent);
            layout_Buttons.Location = new Point(200, 550);
            layout_Buttons.Name = "layout_Buttons";
            layout_Buttons.Size = new Size(556, 50);
            layout_Buttons.TabIndex = 5;
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
            btn_AddStudent.Location = new Point(30, 3);
            btn_AddStudent.Margin = new Padding(30, 3, 3, 3);
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
            btn_DeleteStudent.Location = new Point(207, 3);
            btn_DeleteStudent.Margin = new Padding(30, 3, 3, 3);
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
            btn_UpdateStudent.Location = new Point(384, 3);
            btn_UpdateStudent.Margin = new Padding(30, 3, 3, 3);
            btn_UpdateStudent.Name = "btn_UpdateStudent";
            btn_UpdateStudent.PrimaryColor = Color.FromArgb(255, 128, 0);
            btn_UpdateStudent.Size = new Size(144, 40);
            btn_UpdateStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateStudent.TabIndex = 4;
            btn_UpdateStudent.Text = "Update";
            btn_UpdateStudent.TextColor = Color.White;
            btn_UpdateStudent.WarningColor = Color.FromArgb(230, 162, 60);
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
            tb_SearchStudent.Location = new Point(700, 66);
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
            // dgv_Student
            // 
            dgv_Student.AllowUserToAddRows = false;
            dgv_Student.AllowUserToDeleteRows = false;
            dgv_Student.AllowUserToResizeRows = false;
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
            dgv_Student.Location = new Point(50, 120);
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
            dgv_Student.Size = new Size(900, 400);
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
            // tab_Teacher
            // 
            tab_Teacher.BackColor = Color.FromArgb(238, 242, 245);
            tab_Teacher.Controls.Add(flowLayoutPanel1);
            tab_Teacher.Controls.Add(materialTextBoxEdit1);
            tab_Teacher.Controls.Add(poisonDataGridView1);
            tab_Teacher.Location = new Point(204, 4);
            tab_Teacher.Name = "tab_Teacher";
            tab_Teacher.Padding = new Padding(3);
            tab_Teacher.Size = new Size(992, 652);
            tab_Teacher.TabIndex = 2;
            tab_Teacher.Text = "Teacher";
            // 
            // tab_Subject
            // 
            tab_Subject.BackColor = Color.FromArgb(238, 242, 245);
            tab_Subject.Location = new Point(204, 4);
            tab_Subject.Name = "tab_Subject";
            tab_Subject.Padding = new Padding(3);
            tab_Subject.Size = new Size(992, 652);
            tab_Subject.TabIndex = 3;
            tab_Subject.Text = "Subject";
            // 
            // tab_Logs
            // 
            tab_Logs.BackColor = Color.FromArgb(238, 242, 245);
            tab_Logs.Location = new Point(204, 4);
            tab_Logs.Name = "tab_Logs";
            tab_Logs.Padding = new Padding(3);
            tab_Logs.Size = new Size(992, 652);
            tab_Logs.TabIndex = 4;
            tab_Logs.Text = "Logs";
            // 
            // tab_Reports
            // 
            tab_Reports.BackColor = Color.FromArgb(238, 242, 245);
            tab_Reports.Location = new Point(204, 4);
            tab_Reports.Name = "tab_Reports";
            tab_Reports.Padding = new Padding(3);
            tab_Reports.Size = new Size(992, 652);
            tab_Reports.TabIndex = 5;
            tab_Reports.Text = "Reports";
            // 
            // tab_Settings
            // 
            tab_Settings.BackColor = Color.FromArgb(238, 242, 245);
            tab_Settings.Location = new Point(204, 4);
            tab_Settings.Name = "tab_Settings";
            tab_Settings.Padding = new Padding(3);
            tab_Settings.Size = new Size(992, 652);
            tab_Settings.TabIndex = 6;
            tab_Settings.Text = "Settings";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(hopeButton1);
            flowLayoutPanel1.Controls.Add(hopeButton2);
            flowLayoutPanel1.Controls.Add(hopeButton3);
            flowLayoutPanel1.Location = new Point(200, 550);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(556, 50);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // hopeButton1
            // 
            hopeButton1.BorderColor = Color.Black;
            hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton1.Font = new Font("Poppins", 14F);
            hopeButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton1.Location = new Point(30, 3);
            hopeButton1.Margin = new Padding(30, 3, 3, 3);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(0, 192, 0);
            hopeButton1.Size = new Size(144, 40);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 2;
            hopeButton1.Text = "Add New";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // hopeButton2
            // 
            hopeButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton2.Font = new Font("Poppins", 14F);
            hopeButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton2.Location = new Point(207, 3);
            hopeButton2.Margin = new Padding(30, 3, 3, 3);
            hopeButton2.Name = "hopeButton2";
            hopeButton2.PrimaryColor = Color.Red;
            hopeButton2.Size = new Size(144, 40);
            hopeButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton2.TabIndex = 3;
            hopeButton2.Text = "Delete";
            hopeButton2.TextColor = Color.White;
            hopeButton2.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // hopeButton3
            // 
            hopeButton3.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton3.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton3.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton3.Font = new Font("Poppins", 14F);
            hopeButton3.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton3.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton3.Location = new Point(384, 3);
            hopeButton3.Margin = new Padding(30, 3, 3, 3);
            hopeButton3.Name = "hopeButton3";
            hopeButton3.PrimaryColor = Color.FromArgb(255, 128, 0);
            hopeButton3.Size = new Size(144, 40);
            hopeButton3.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton3.TabIndex = 4;
            hopeButton3.Text = "Update";
            hopeButton3.TextColor = Color.White;
            hopeButton3.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.LeadingIcon = (Image)resources.GetObject("materialTextBoxEdit1.LeadingIcon");
            materialTextBoxEdit1.Location = new Point(700, 66);
            materialTextBoxEdit1.MaxLength = 100;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(250, 48);
            materialTextBoxEdit1.TabIndex = 7;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.Text = "Search";
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.AllowUserToDeleteRows = false;
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle4.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poisonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(50, 120);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.ReadOnly = true;
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(900, 400);
            poisonDataGridView1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            poisonDataGridView1.TabIndex = 6;
            poisonDataGridView1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
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
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
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
            TransparencyKey = Color.Fuchsia;
            tab_Control.ResumeLayout(false);
            tab_Student.ResumeLayout(false);
            tab_Student.PerformLayout();
            layout_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Student).EndInit();
            tab_Teacher.ResumeLayout(false);
            tab_Teacher.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
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
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Student;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchStudent;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewTextBoxColumn col_Age;
        private DataGridViewTextBoxColumn col_Nickname;
        private DataGridViewTextBoxColumn col_Employee;
        private ReaLTaiizor.Controls.HopeButton btn_AddStudent;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateStudent;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteStudent;
        private TabPage tab_Settings;
        private FlowLayoutPanel layout_Buttons;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.HopeButton hopeButton3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}