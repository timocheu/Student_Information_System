namespace Student_Information_System.Forms
{
    partial class TeacherDashboard
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
            hope_StudentDashboard = new ReaLTaiizor.Forms.HopeForm();
            tab_Home = new TabPage();
            sPanel_Welcome = new Student_Information_System.UI.SPanel();
            lbl_WelcomeUser = new Label();
            tab_Settings = new TabPage();
            TabControl = new ReaLTaiizor.Controls.TabPage();
            TabControl.SuspendLayout();
            tab_Home.SuspendLayout();
            sPanel_Welcome.SuspendLayout();
            SuspendLayout();
            // 
            // hope_StudentDashboard
            // 
            hope_StudentDashboard.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_StudentDashboard.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_StudentDashboard.ControlBoxColorN = Color.White;
            hope_StudentDashboard.Dock = DockStyle.Top;
            hope_StudentDashboard.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hope_StudentDashboard.ForeColor = Color.FromArgb(242, 246, 252);
            hope_StudentDashboard.Image = Properties.Resources.FormIcon;
            hope_StudentDashboard.Location = new Point(0, 0);
            hope_StudentDashboard.Name = "hope_StudentDashboard";
            hope_StudentDashboard.Size = new Size(1200, 40);
            hope_StudentDashboard.TabIndex = 2;
            hope_StudentDashboard.Text = "Student Dashboard";
            hope_StudentDashboard.ThemeColor = Color.FromArgb(30, 30, 30);
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
            TabControl.Controls.Add(tab_Settings);
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
            TabControl.TabIndex = 4;
            TabControl.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tab_Home
            // 
            tab_Home.BackColor = Color.FromArgb(238, 242, 245);
            tab_Home.Controls.Add(sPanel_Welcome);
            tab_Home.Location = new Point(139, 4);
            tab_Home.Name = "tab_Home";
            tab_Home.Padding = new Padding(3);
            tab_Home.Size = new Size(1057, 652);
            tab_Home.TabIndex = 0;
            tab_Home.Text = "Home";
            // 
            // sPanel_Welcome
            // 
            sPanel_Welcome.BackgroundFillColor = Color.White;
            sPanel_Welcome.BorderColor = Color.White;
            sPanel_Welcome.Controls.Add(lbl_WelcomeUser);
            sPanel_Welcome.Dock = DockStyle.Top;
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
            lbl_WelcomeUser.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_WelcomeUser.Location = new Point(28, 21);
            lbl_WelcomeUser.Name = "lbl_WelcomeUser";
            lbl_WelcomeUser.Size = new Size(116, 37);
            lbl_WelcomeUser.TabIndex = 0;
            lbl_WelcomeUser.Text = "Welcome";
            // 
            // tab_Settings
            // 
            tab_Settings.BackColor = Color.FromArgb(238, 242, 245);
            tab_Settings.Location = new Point(139, 4);
            tab_Settings.Name = "tab_Settings";
            tab_Settings.Padding = new Padding(3);
            tab_Settings.Size = new Size(1057, 652);
            tab_Settings.TabIndex = 1;
            tab_Settings.Text = "Settings";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(TabControl);
            Controls.Add(hope_StudentDashboard);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "TeacherDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDashboard";
            TabControl.ResumeLayout(false);
            tab_Home.ResumeLayout(false);
            sPanel_Welcome.ResumeLayout(false);
            sPanel_Welcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_StudentDashboard;
        private TabPage tab_Home;
        private UI.SPanel sPanel_Welcome;
        private Label lbl_WelcomeUser;
        private TabPage tab_Settings;
    }
}