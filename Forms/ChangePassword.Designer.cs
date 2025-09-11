namespace Student_Information_System.Forms
{
    partial class ChangePassword
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
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            lbl_ForgotPassword = new Label();
            tb_Password = new ReaLTaiizor.Controls.HopeTextBox();
            btn_ResetPassword = new ReaLTaiizor.Controls.HopeButton();
            tb_ConfirmPassword = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Poppins", 12F);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = null;
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.MaximizeBox = false;
            hopeForm1.MinimizeBox = false;
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(340, 40);
            hopeForm1.TabIndex = 8;
            hopeForm1.Text = "Forgot Password";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Font = new Font("Poppins", 20F);
            lbl_ForgotPassword.Location = new Point(50, 66);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(230, 48);
            lbl_ForgotPassword.TabIndex = 15;
            lbl_ForgotPassword.Text = "Reset Password";
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.White;
            tb_Password.BaseColor = SystemColors.Control;
            tb_Password.BorderColorA = Color.FromArgb(64, 158, 255);
            tb_Password.BorderColorB = Color.FromArgb(64, 158, 255);
            tb_Password.Font = new Font("Poppins", 12F);
            tb_Password.ForeColor = Color.FromArgb(48, 49, 51);
            tb_Password.Hint = "Password";
            tb_Password.Location = new Point(40, 117);
            tb_Password.MaxLength = 32767;
            tb_Password.Multiline = false;
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '\0';
            tb_Password.ScrollBars = ScrollBars.None;
            tb_Password.SelectedText = "";
            tb_Password.SelectionLength = 0;
            tb_Password.SelectionStart = 0;
            tb_Password.Size = new Size(250, 40);
            tb_Password.TabIndex = 14;
            tb_Password.TabStop = false;
            tb_Password.UseSystemPasswordChar = false;
            // 
            // btn_ResetPassword
            // 
            btn_ResetPassword.BorderColor = Color.Black;
            btn_ResetPassword.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_ResetPassword.DangerColor = Color.FromArgb(245, 108, 108);
            btn_ResetPassword.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_ResetPassword.Font = new Font("Poppins", 16F);
            btn_ResetPassword.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_ResetPassword.InfoColor = Color.FromArgb(144, 147, 153);
            btn_ResetPassword.Location = new Point(40, 240);
            btn_ResetPassword.Margin = new Padding(30, 3, 3, 3);
            btn_ResetPassword.Name = "btn_ResetPassword";
            btn_ResetPassword.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_ResetPassword.Size = new Size(250, 40);
            btn_ResetPassword.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_ResetPassword.TabIndex = 13;
            btn_ResetPassword.Text = "Change Password";
            btn_ResetPassword.TextColor = Color.White;
            btn_ResetPassword.WarningColor = Color.FromArgb(230, 162, 60);
            btn_ResetPassword.Click += btn_ResetPassword_Click;
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.BackColor = Color.White;
            tb_ConfirmPassword.BaseColor = SystemColors.Control;
            tb_ConfirmPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            tb_ConfirmPassword.BorderColorB = Color.FromArgb(64, 158, 255);
            tb_ConfirmPassword.Font = new Font("Poppins", 12F);
            tb_ConfirmPassword.ForeColor = Color.FromArgb(48, 49, 51);
            tb_ConfirmPassword.Hint = "Confirm Password";
            tb_ConfirmPassword.Location = new Point(40, 173);
            tb_ConfirmPassword.MaxLength = 32767;
            tb_ConfirmPassword.Multiline = false;
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.PasswordChar = '\0';
            tb_ConfirmPassword.ScrollBars = ScrollBars.None;
            tb_ConfirmPassword.SelectedText = "";
            tb_ConfirmPassword.SelectionLength = 0;
            tb_ConfirmPassword.SelectionStart = 0;
            tb_ConfirmPassword.Size = new Size(250, 40);
            tb_ConfirmPassword.TabIndex = 12;
            tb_ConfirmPassword.TabStop = false;
            tb_ConfirmPassword.UseSystemPasswordChar = false;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 313);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(tb_Password);
            Controls.Add(btn_ResetPassword);
            Controls.Add(tb_ConfirmPassword);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimizeBox = false;
            MinimumSize = new Size(190, 40);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private Label lbl_ForgotPassword;
        private ReaLTaiizor.Controls.HopeTextBox tb_Password;
        private ReaLTaiizor.Controls.HopeButton btn_ResetPassword;
        private ReaLTaiizor.Controls.HopeTextBox tb_ConfirmPassword;
    }
}