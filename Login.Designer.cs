namespace Student_Information_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbl_StudentInformationSystem = new Label();
            btn_Login = new ReaLTaiizor.Controls.NightButton();
            lbl_LoginDescription = new Label();
            lbl_Login = new Label();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pb_Mascot = new PictureBox();
            hope_LoginForm = new ReaLTaiizor.Forms.HopeForm();
            pictureBox1 = new PictureBox();
            png_LoginForm = new Student_Information_System.UI.SPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_Mascot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            png_LoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbl_StudentInformationSystem
            // 
            lbl_StudentInformationSystem.AutoSize = true;
            lbl_StudentInformationSystem.Font = new Font("Poppins SemiBold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_StudentInformationSystem.Location = new Point(740, 128);
            lbl_StudentInformationSystem.Name = "lbl_StudentInformationSystem";
            lbl_StudentInformationSystem.Size = new Size(433, 339);
            lbl_StudentInformationSystem.TabIndex = 0;
            lbl_StudentInformationSystem.Text = "Student\r\nInformation\r\nSystem";
            lbl_StudentInformationSystem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Transparent;
            btn_Login.DialogResult = DialogResult.None;
            btn_Login.Font = new Font("Poppins", 12F);
            btn_Login.ForeColor = Color.WhiteSmoke;
            btn_Login.HoverBackColor = Color.Black;
            btn_Login.HoverForeColor = Color.Gray;
            btn_Login.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.High;
            btn_Login.Location = new Point(61, 339);
            btn_Login.MinimumSize = new Size(144, 47);
            btn_Login.Name = "btn_Login";
            btn_Login.NormalBackColor = Color.WhiteSmoke;
            btn_Login.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            btn_Login.PressedBackColor = Color.DarkGray;
            btn_Login.PressedForeColor = Color.DimGray;
            btn_Login.Radius = 5;
            btn_Login.Size = new Size(144, 47);
            btn_Login.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.Click += btn_Login_Click;
            // 
            // lbl_LoginDescription
            // 
            lbl_LoginDescription.AutoSize = true;
            lbl_LoginDescription.BackColor = Color.FromArgb(30, 30, 30);
            lbl_LoginDescription.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_LoginDescription.ForeColor = Color.WhiteSmoke;
            lbl_LoginDescription.Location = new Point(64, 140);
            lbl_LoginDescription.Margin = new Padding(0);
            lbl_LoginDescription.Name = "lbl_LoginDescription";
            lbl_LoginDescription.Size = new Size(201, 28);
            lbl_LoginDescription.TabIndex = 3;
            lbl_LoginDescription.Text = "Please login to continue";
            lbl_LoginDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Login.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Login.ForeColor = Color.WhiteSmoke;
            lbl_Login.Location = new Point(61, 93);
            lbl_Login.Margin = new Padding(0);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(93, 48);
            lbl_Login.TabIndex = 2;
            lbl_Login.Text = "Login";
            lbl_Login.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tb_Password
            // 
            tb_Password.AnimateReadOnly = false;
            tb_Password.AutoCompleteMode = AutoCompleteMode.None;
            tb_Password.AutoCompleteSource = AutoCompleteSource.None;
            tb_Password.BackgroundImageLayout = ImageLayout.None;
            tb_Password.CharacterCasing = CharacterCasing.Normal;
            tb_Password.Depth = 0;
            tb_Password.Font = new Font("Poppins", 15.75F);
            tb_Password.HideSelection = true;
            tb_Password.Hint = "Password";
            tb_Password.LeadingIcon = Properties.Resources.padlock;
            tb_Password.Location = new Point(64, 257);
            tb_Password.MaxLength = 50;
            tb_Password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '●';
            tb_Password.PrefixSuffixText = null;
            tb_Password.ReadOnly = false;
            tb_Password.RightToLeft = RightToLeft.No;
            tb_Password.SelectedText = "";
            tb_Password.SelectionLength = 0;
            tb_Password.SelectionStart = 0;
            tb_Password.ShortcutsEnabled = true;
            tb_Password.Size = new Size(250, 48);
            tb_Password.TabIndex = 1;
            tb_Password.TabStop = false;
            tb_Password.TextAlign = HorizontalAlignment.Left;
            tb_Password.TrailingIcon = Properties.Resources.eye;
            tb_Password.UseSystemPasswordChar = true;
            tb_Password.TrailingIconClick += tb_Password_TrailingIconClick;
            // 
            // tb_Username
            // 
            tb_Username.AnimateReadOnly = false;
            tb_Username.AutoCompleteMode = AutoCompleteMode.None;
            tb_Username.AutoCompleteSource = AutoCompleteSource.None;
            tb_Username.BackgroundImageLayout = ImageLayout.None;
            tb_Username.CharacterCasing = CharacterCasing.Normal;
            tb_Username.Depth = 0;
            tb_Username.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Username.HideSelection = true;
            tb_Username.Hint = "Username";
            tb_Username.LeadingIcon = Properties.Resources.user;
            tb_Username.Location = new Point(61, 188);
            tb_Username.MaxLength = 50;
            tb_Username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Username.Name = "tb_Username";
            tb_Username.PasswordChar = '\0';
            tb_Username.PrefixSuffixText = null;
            tb_Username.ReadOnly = false;
            tb_Username.RightToLeft = RightToLeft.No;
            tb_Username.SelectedText = "";
            tb_Username.SelectionLength = 0;
            tb_Username.SelectionStart = 0;
            tb_Username.ShortcutsEnabled = true;
            tb_Username.Size = new Size(250, 48);
            tb_Username.TabIndex = 0;
            tb_Username.TabStop = false;
            tb_Username.TextAlign = HorizontalAlignment.Left;
            tb_Username.TrailingIcon = null;
            tb_Username.UseSystemPasswordChar = false;
            // 
            // pb_Mascot
            // 
            pb_Mascot.Image = Properties.Resources.Login_Pics;
            pb_Mascot.Location = new Point(619, 484);
            pb_Mascot.Name = "pb_Mascot";
            pb_Mascot.Size = new Size(496, 235);
            pb_Mascot.TabIndex = 2;
            pb_Mascot.TabStop = false;
            // 
            // hope_LoginForm
            // 
            hope_LoginForm.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_LoginForm.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_LoginForm.ControlBoxColorN = Color.White;
            hope_LoginForm.Dock = DockStyle.Top;
            hope_LoginForm.Font = new Font("Poppins", 12F);
            hope_LoginForm.ForeColor = Color.FromArgb(242, 246, 252);
            hope_LoginForm.Image = Properties.Resources.FormIcon;
            hope_LoginForm.Location = new Point(0, 0);
            hope_LoginForm.Margin = new Padding(2, 1, 2, 1);
            hope_LoginForm.Name = "hope_LoginForm";
            hope_LoginForm.Size = new Size(1200, 40);
            hope_LoginForm.TabIndex = 3;
            hope_LoginForm.Text = "Student Information System";
            hope_LoginForm.ThemeColor = Color.FromArgb(30, 30, 30);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(187, 134, 252);
            pictureBox1.Location = new Point(0, 668);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 42);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // png_LoginForm
            // 
            png_LoginForm.BackgroundFillColor = Color.FromArgb(30, 30, 30);
            png_LoginForm.BorderColor = Color.FromArgb(30, 30, 30);
            png_LoginForm.Controls.Add(tb_Username);
            png_LoginForm.Controls.Add(lbl_LoginDescription);
            png_LoginForm.Controls.Add(btn_Login);
            png_LoginForm.Controls.Add(tb_Password);
            png_LoginForm.Controls.Add(lbl_Login);
            png_LoginForm.Font = new Font("Poppins", 9F);
            png_LoginForm.Location = new Point(58, 128);
            png_LoginForm.Name = "png_LoginForm";
            png_LoginForm.Size = new Size(400, 476);
            png_LoginForm.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(187, 134, 252);
            pictureBox2.Location = new Point(336, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 43);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(187, 134, 252);
            pictureBox3.Location = new Point(390, 614);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 92);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1200, 700);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(png_LoginForm);
            Controls.Add(pictureBox1);
            Controls.Add(hope_LoginForm);
            Controls.Add(pb_Mascot);
            Controls.Add(lbl_StudentInformationSystem);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information System";
            ((System.ComponentModel.ISupportInitialize)pb_Mascot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            png_LoginForm.ResumeLayout(false);
            png_LoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_StudentInformationSystem;
        private PictureBox pb_Mascot;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private Label lbl_Login;
        private Label lbl_LoginDescription;
        private ReaLTaiizor.Controls.NightButton btn_Login;
        private ReaLTaiizor.Forms.HopeForm hope_LoginForm;
        private PictureBox pictureBox1;
        private UI.SPanel png_LoginForm;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
