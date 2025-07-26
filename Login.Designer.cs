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
            pnl_LoginForm = new Panel();
            nightButton1 = new ReaLTaiizor.Controls.NightButton();
            lbl_LoginDescription = new Label();
            lbl_Login = new Label();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pb_Mascot = new PictureBox();
            hope_LoginForm = new ReaLTaiizor.Forms.HopeForm();
            pnl_LoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Mascot).BeginInit();
            SuspendLayout();
            // 
            // lbl_StudentInformationSystem
            // 
            lbl_StudentInformationSystem.AutoSize = true;
            lbl_StudentInformationSystem.Font = new Font("Poppins SemiBold", 62F, FontStyle.Bold);
            lbl_StudentInformationSystem.Location = new Point(598, 62);
            lbl_StudentInformationSystem.Name = "lbl_StudentInformationSystem";
            lbl_StudentInformationSystem.Size = new Size(562, 438);
            lbl_StudentInformationSystem.TabIndex = 0;
            lbl_StudentInformationSystem.Text = "Student\r\nInformation\r\nSystem";
            lbl_StudentInformationSystem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnl_LoginForm
            // 
            pnl_LoginForm.BackColor = Color.LightGray;
            pnl_LoginForm.BackgroundImage = Properties.Resources.LoginForm;
            pnl_LoginForm.Controls.Add(nightButton1);
            pnl_LoginForm.Controls.Add(lbl_LoginDescription);
            pnl_LoginForm.Controls.Add(lbl_Login);
            pnl_LoginForm.Controls.Add(tb_Password);
            pnl_LoginForm.Controls.Add(tb_Username);
            pnl_LoginForm.Location = new Point(38, 77);
            pnl_LoginForm.Name = "pnl_LoginForm";
            pnl_LoginForm.Size = new Size(400, 600);
            pnl_LoginForm.TabIndex = 1;
            // 
            // nightButton1
            // 
            nightButton1.BackColor = Color.Transparent;
            nightButton1.DialogResult = DialogResult.None;
            nightButton1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nightButton1.ForeColor = Color.WhiteSmoke;
            nightButton1.HoverBackColor = Color.Black;
            nightButton1.HoverForeColor = Color.Gray;
            nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.High;
            nightButton1.Location = new Point(61, 328);
            nightButton1.MinimumSize = new Size(144, 47);
            nightButton1.Name = "nightButton1";
            nightButton1.NormalBackColor = Color.WhiteSmoke;
            nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            nightButton1.PressedBackColor = Color.DarkGray;
            nightButton1.PressedForeColor = Color.DimGray;
            nightButton1.Radius = 5;
            nightButton1.Size = new Size(144, 47);
            nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton1.TabIndex = 4;
            nightButton1.Text = "Login";
            // 
            // lbl_LoginDescription
            // 
            lbl_LoginDescription.AutoSize = true;
            lbl_LoginDescription.BackColor = Color.FromArgb(30, 30, 30);
            lbl_LoginDescription.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_LoginDescription.ForeColor = Color.WhiteSmoke;
            lbl_LoginDescription.Location = new Point(64, 129);
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
            lbl_Login.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold);
            lbl_Login.ForeColor = Color.WhiteSmoke;
            lbl_Login.Location = new Point(61, 82);
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
            tb_Password.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Password.HideSelection = true;
            tb_Password.Hint = "Password";
            tb_Password.LeadingIcon = Properties.Resources.padlock;
            tb_Password.Location = new Point(64, 246);
            tb_Password.MaxLength = 50;
            tb_Password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '\0';
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
            tb_Password.TrailingIcon = null;
            tb_Password.UseSystemPasswordChar = false;
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
            tb_Username.Location = new Point(64, 168);
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
            pb_Mascot.Location = new Point(522, 471);
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
            hope_LoginForm.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hope_LoginForm.ForeColor = Color.FromArgb(242, 246, 252);
            hope_LoginForm.Image = Properties.Resources.FormIcon;
            hope_LoginForm.Location = new Point(0, 0);
            hope_LoginForm.Margin = new Padding(2, 2, 2, 2);
            hope_LoginForm.Name = "hope_LoginForm";
            hope_LoginForm.Size = new Size(1200, 40);
            hope_LoginForm.TabIndex = 3;
            hope_LoginForm.Text = "Student Information System";
            hope_LoginForm.ThemeColor = Color.FromArgb(30, 30, 30);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1200, 700);
            Controls.Add(hope_LoginForm);
            Controls.Add(pb_Mascot);
            Controls.Add(pnl_LoginForm);
            Controls.Add(lbl_StudentInformationSystem);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information System";
            pnl_LoginForm.ResumeLayout(false);
            pnl_LoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Mascot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_StudentInformationSystem;
        private Panel pnl_LoginForm;
        private PictureBox pb_Mascot;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private Label lbl_Login;
        private Label lbl_LoginDescription;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Forms.HopeForm hope_LoginForm;
    }
}
