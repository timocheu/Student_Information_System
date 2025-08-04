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
            lbl_Welcome = new Label();
            tab_Student = new TabPage();
            layout_Buttons = new FlowLayoutPanel();
            btn_AddStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteStudent = new ReaLTaiizor.Controls.HopeButton();
            btn_UpdateStudent = new ReaLTaiizor.Controls.HopeButton();
            tb_SearchStudent = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dgv_Student = new ReaLTaiizor.Controls.PoisonDataGridView();
            tab_Teacher = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_AddTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_DeleteTeacher = new ReaLTaiizor.Controls.HopeButton();
            btn_UpdateTeacher = new ReaLTaiizor.Controls.HopeButton();
            tb_SearchTeacher = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dgv_Teacher = new ReaLTaiizor.Controls.PoisonDataGridView();
            tab_Subject = new TabPage();
            tab_Logs = new TabPage();
            tab_Reports = new TabPage();
            tab_Settings = new TabPage();
            btn_Logout = new ReaLTaiizor.Controls.NightButton();
            hope_AdminDashboard = new ReaLTaiizor.Forms.HopeForm();
            tab_Control = new ReaLTaiizor.Controls.TabPage();
            tab_Control.SuspendLayout();
            tab_Dashboard.SuspendLayout();
            tab_Student.SuspendLayout();
            layout_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Student).BeginInit();
            tab_Teacher.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).BeginInit();
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
            tab_Control.Font = new Font("Microsoft Sans Serif", 12F);
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
            tab_Dashboard.Controls.Add(lbl_Welcome);
            tab_Dashboard.Location = new Point(204, 4);
            tab_Dashboard.Name = "tab_Dashboard";
            tab_Dashboard.Padding = new Padding(3);
            tab_Dashboard.Size = new Size(992, 652);
            tab_Dashboard.TabIndex = 0;
            tab_Dashboard.Text = "Dashboard";
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Location = new Point(31, 23);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(117, 20);
            lbl_Welcome.TabIndex = 4;
            lbl_Welcome.Text = "Welcome User!";
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
            btn_AddStudent.Font = new Font("Microsoft Sans Serif", 14F);
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
            btn_DeleteStudent.Font = new Font("Microsoft Sans Serif", 14F);
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
            btn_UpdateStudent.Font = new Font("Microsoft Sans Serif", 14F);
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
            tb_SearchStudent.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 255);
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
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Student.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Student.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Student.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Student.Size = new Size(900, 400);
            dgv_Student.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            dgv_Student.TabIndex = 0;
            // 
            // tab_Teacher
            // 
            tab_Teacher.BackColor = Color.FromArgb(238, 242, 245);
            tab_Teacher.Controls.Add(flowLayoutPanel1);
            tab_Teacher.Controls.Add(tb_SearchTeacher);
            tab_Teacher.Controls.Add(dgv_Teacher);
            tab_Teacher.Location = new Point(204, 4);
            tab_Teacher.Name = "tab_Teacher";
            tab_Teacher.Padding = new Padding(3);
            tab_Teacher.Size = new Size(992, 652);
            tab_Teacher.TabIndex = 2;
            tab_Teacher.Text = "Teacher";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btn_AddTeacher);
            flowLayoutPanel1.Controls.Add(btn_DeleteTeacher);
            flowLayoutPanel1.Controls.Add(btn_UpdateTeacher);
            flowLayoutPanel1.Location = new Point(200, 550);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(556, 50);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btn_AddTeacher
            // 
            btn_AddTeacher.BorderColor = Color.Black;
            btn_AddTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_AddTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_AddTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_AddTeacher.Font = new Font("Microsoft Sans Serif", 14F);
            btn_AddTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_AddTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_AddTeacher.Location = new Point(30, 3);
            btn_AddTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_AddTeacher.Name = "btn_AddTeacher";
            btn_AddTeacher.PrimaryColor = Color.FromArgb(0, 192, 0);
            btn_AddTeacher.Size = new Size(144, 40);
            btn_AddTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_AddTeacher.TabIndex = 2;
            btn_AddTeacher.Text = "Add New";
            btn_AddTeacher.TextColor = Color.White;
            btn_AddTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_DeleteTeacher
            // 
            btn_DeleteTeacher.BorderColor = Color.FromArgb(220, 223, 230);
            btn_DeleteTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_DeleteTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_DeleteTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_DeleteTeacher.Font = new Font("Microsoft Sans Serif", 14F);
            btn_DeleteTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_DeleteTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_DeleteTeacher.Location = new Point(207, 3);
            btn_DeleteTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_DeleteTeacher.Name = "btn_DeleteTeacher";
            btn_DeleteTeacher.PrimaryColor = Color.Red;
            btn_DeleteTeacher.Size = new Size(144, 40);
            btn_DeleteTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_DeleteTeacher.TabIndex = 3;
            btn_DeleteTeacher.Text = "Delete";
            btn_DeleteTeacher.TextColor = Color.White;
            btn_DeleteTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_UpdateTeacher
            // 
            btn_UpdateTeacher.BorderColor = Color.FromArgb(220, 223, 230);
            btn_UpdateTeacher.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_UpdateTeacher.DangerColor = Color.FromArgb(245, 108, 108);
            btn_UpdateTeacher.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_UpdateTeacher.Font = new Font("Microsoft Sans Serif", 14F);
            btn_UpdateTeacher.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_UpdateTeacher.InfoColor = Color.FromArgb(144, 147, 153);
            btn_UpdateTeacher.Location = new Point(384, 3);
            btn_UpdateTeacher.Margin = new Padding(30, 3, 3, 3);
            btn_UpdateTeacher.Name = "btn_UpdateTeacher";
            btn_UpdateTeacher.PrimaryColor = Color.FromArgb(255, 128, 0);
            btn_UpdateTeacher.Size = new Size(144, 40);
            btn_UpdateTeacher.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_UpdateTeacher.TabIndex = 4;
            btn_UpdateTeacher.Text = "Update";
            btn_UpdateTeacher.TextColor = Color.White;
            btn_UpdateTeacher.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // tb_SearchTeacher
            // 
            tb_SearchTeacher.AnimateReadOnly = false;
            tb_SearchTeacher.AutoCompleteMode = AutoCompleteMode.None;
            tb_SearchTeacher.AutoCompleteSource = AutoCompleteSource.None;
            tb_SearchTeacher.BackgroundImageLayout = ImageLayout.None;
            tb_SearchTeacher.CharacterCasing = CharacterCasing.Normal;
            tb_SearchTeacher.Depth = 0;
            tb_SearchTeacher.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_SearchTeacher.HideSelection = true;
            tb_SearchTeacher.LeadingIcon = (Image)resources.GetObject("tb_SearchTeacher.LeadingIcon");
            tb_SearchTeacher.Location = new Point(700, 66);
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
            tb_SearchTeacher.TabIndex = 7;
            tb_SearchTeacher.TabStop = false;
            tb_SearchTeacher.Text = "Search";
            tb_SearchTeacher.TextAlign = HorizontalAlignment.Left;
            tb_SearchTeacher.TrailingIcon = null;
            tb_SearchTeacher.UseSystemPasswordChar = false;
            // 
            // dgv_Teacher
            // 
            dgv_Teacher.AllowUserToAddRows = false;
            dgv_Teacher.AllowUserToDeleteRows = false;
            dgv_Teacher.AllowUserToResizeRows = false;
            dgv_Teacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Teacher.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Teacher.BorderStyle = BorderStyle.None;
            dgv_Teacher.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Teacher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Teacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Teacher.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Teacher.EnableHeadersVisualStyles = false;
            dgv_Teacher.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Teacher.GridColor = Color.FromArgb(255, 255, 255);
            dgv_Teacher.Location = new Point(50, 120);
            dgv_Teacher.Name = "dgv_Teacher";
            dgv_Teacher.ReadOnly = true;
            dgv_Teacher.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Teacher.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Teacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teacher.Size = new Size(900, 400);
            dgv_Teacher.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            dgv_Teacher.TabIndex = 6;
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
            tab_Settings.Controls.Add(btn_Logout);
            tab_Settings.Location = new Point(204, 4);
            tab_Settings.Name = "tab_Settings";
            tab_Settings.Padding = new Padding(3);
            tab_Settings.Size = new Size(992, 652);
            tab_Settings.TabIndex = 6;
            tab_Settings.Text = "Settings";
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.Transparent;
            btn_Logout.DialogResult = DialogResult.None;
            btn_Logout.Font = new Font("Segoe UI", 10F);
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
            btn_Logout.Radius = 20;
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
            tab_Dashboard.ResumeLayout(false);
            tab_Dashboard.PerformLayout();
            tab_Student.ResumeLayout(false);
            tab_Student.PerformLayout();
            layout_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Student).EndInit();
            tab_Teacher.ResumeLayout(false);
            tab_Teacher.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).EndInit();
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
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Student;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchStudent;
        private ReaLTaiizor.Controls.HopeButton btn_AddStudent;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateStudent;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteStudent;
        private TabPage tab_Settings;
        private FlowLayoutPanel layout_Buttons;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.HopeButton btn_AddTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_DeleteTeacher;
        private ReaLTaiizor.Controls.HopeButton btn_UpdateTeacher;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SearchTeacher;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Teacher;
        private ReaLTaiizor.Controls.NightButton btn_Logout;
        private Label lbl_Welcome;
    }
}