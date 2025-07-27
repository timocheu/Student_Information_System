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
            ReaLTaiizor.Controls.TabPage TabControl;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            tab_Home = new TabPage();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            asd = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            sPanel_Welcome = new Student_Information_System.UI.SPanel();
            lbl_WelcomeUser = new Label();
            tab_Create = new TabPage();
            hope_AdminDashboard = new ReaLTaiizor.Forms.HopeForm();
            TabControl = new ReaLTaiizor.Controls.TabPage();
            TabControl.SuspendLayout();
            tab_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            sPanel_Welcome.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.ActiveForeColor = Color.FromArgb(254, 255, 255);
            TabControl.ActiveLineTabColor = Color.FromArgb(187, 134, 252);
            TabControl.ActiveTabColor = Color.FromArgb(35, 36, 38);
            TabControl.Alignment = TabAlignment.Left;
            TabControl.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            TabControl.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            TabControl.ControlBackColor = Color.FromArgb(54, 57, 64);
            TabControl.Controls.Add(tab_Home);
            TabControl.Controls.Add(tab_Create);
            TabControl.Dock = DockStyle.Fill;
            TabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabControl.Font = new Font("Poppins", 12F);
            TabControl.FrameColor = Color.FromArgb(238, 242, 245);
            TabControl.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            TabControl.ItemSize = new Size(44, 135);
            TabControl.LineColor = Color.FromArgb(25, 26, 28);
            TabControl.LineTabColor = Color.FromArgb(54, 57, 64);
            TabControl.Location = new Point(0, 40);
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.NormalForeColor = Color.FromArgb(159, 162, 167);
            TabControl.PageColor = Color.FromArgb(238, 242, 245);
            TabControl.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1200, 660);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TabControl.StringType = StringAlignment.Near;
            TabControl.TabColor = Color.FromArgb(54, 57, 64);
            TabControl.TabIndex = 3;
            TabControl.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tab_Home
            // 
            tab_Home.BackColor = Color.FromArgb(238, 242, 245);
            tab_Home.Controls.Add(poisonDataGridView1);
            tab_Home.Controls.Add(sPanel_Welcome);
            tab_Home.Location = new Point(139, 4);
            tab_Home.Name = "tab_Home";
            tab_Home.Padding = new Padding(3);
            tab_Home.Size = new Size(1057, 652);
            tab_Home.TabIndex = 0;
            tab_Home.Text = "Home";
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(17, 17, 17);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poisonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { asd, Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(109, 109, 109);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(17, 17, 17);
            poisonDataGridView1.Location = new Point(48, 118);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(752, 150);
            poisonDataGridView1.TabIndex = 2;
            poisonDataGridView1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // asd
            // 
            asd.HeaderText = "Column1";
            asd.Name = "asd";
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // sPanel_Welcome
            // 
            sPanel_Welcome.BackgroundFillColor = Color.White;
            sPanel_Welcome.BorderColor = Color.White;
            sPanel_Welcome.Controls.Add(lbl_WelcomeUser);
            sPanel_Welcome.Dock = DockStyle.Top;
            sPanel_Welcome.Font = new Font("Poppins", 12F);
            sPanel_Welcome.Location = new Point(3, 3);
            sPanel_Welcome.Name = "sPanel_Welcome";
            sPanel_Welcome.Size = new Size(1051, 71);
            sPanel_Welcome.TabIndex = 1;
            // 
            // lbl_WelcomeUser
            // 
            lbl_WelcomeUser.Anchor = AnchorStyles.Left;
            lbl_WelcomeUser.AutoSize = true;
            lbl_WelcomeUser.BackColor = Color.White;
            lbl_WelcomeUser.Font = new Font("Poppins", 16F);
            lbl_WelcomeUser.Location = new Point(26, 19);
            lbl_WelcomeUser.Name = "lbl_WelcomeUser";
            lbl_WelcomeUser.Size = new Size(121, 39);
            lbl_WelcomeUser.TabIndex = 0;
            lbl_WelcomeUser.Text = "Welcome";
            // 
            // tab_Create
            // 
            tab_Create.BackColor = Color.FromArgb(238, 242, 245);
            tab_Create.Location = new Point(139, 4);
            tab_Create.Name = "tab_Create";
            tab_Create.Padding = new Padding(3);
            tab_Create.Size = new Size(1057, 652);
            tab_Create.TabIndex = 1;
            tab_Create.Text = "Create";
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
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1200, 700);
            Controls.Add(TabControl);
            Controls.Add(hope_AdminDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TabControl.ResumeLayout(false);
            tab_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            sPanel_Welcome.ResumeLayout(false);
            sPanel_Welcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_AdminDashboard;
        private TabPage tab_Home;
        private UI.SPanel sPanel_Welcome;
        private Label lbl_WelcomeUser;
        private TabPage tab_Create;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private DataGridViewTextBoxColumn asd;
        private DataGridViewTextBoxColumn Column1;
    }
}