namespace Student_Information_System.UserControls
{
    partial class EnterPin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_CreateStudent = new ReaLTaiizor.Controls.HopeButton();
            lbl_EnterEmail = new Label();
            lbl_ForgotPassword = new Label();
            tb_Email = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // btn_CreateStudent
            // 
            btn_CreateStudent.BorderColor = Color.Black;
            btn_CreateStudent.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_CreateStudent.DangerColor = Color.FromArgb(245, 108, 108);
            btn_CreateStudent.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_CreateStudent.Font = new Font("Poppins", 16F);
            btn_CreateStudent.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_CreateStudent.InfoColor = Color.FromArgb(144, 147, 153);
            btn_CreateStudent.Location = new Point(50, 161);
            btn_CreateStudent.Margin = new Padding(30, 3, 3, 3);
            btn_CreateStudent.Name = "btn_CreateStudent";
            btn_CreateStudent.PrimaryColor = Color.FromArgb(118, 74, 245);
            btn_CreateStudent.Size = new Size(250, 40);
            btn_CreateStudent.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_CreateStudent.TabIndex = 7;
            btn_CreateStudent.Text = "Continue";
            btn_CreateStudent.TextColor = Color.White;
            btn_CreateStudent.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // lbl_EnterEmail
            // 
            lbl_EnterEmail.AutoSize = true;
            lbl_EnterEmail.Font = new Font("Poppins", 12F);
            lbl_EnterEmail.ForeColor = Color.Gray;
            lbl_EnterEmail.Location = new Point(107, 66);
            lbl_EnterEmail.Name = "lbl_EnterEmail";
            lbl_EnterEmail.Size = new Size(126, 28);
            lbl_EnterEmail.TabIndex = 6;
            lbl_EnterEmail.Text = "Enter your OTP";
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Font = new Font("Poppins", 20F);
            lbl_ForgotPassword.Location = new Point(50, 24);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(242, 48);
            lbl_ForgotPassword.TabIndex = 5;
            lbl_ForgotPassword.Text = "Forgot Password";
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.White;
            tb_Email.BaseColor = SystemColors.Control;
            tb_Email.BorderColorA = Color.FromArgb(64, 158, 255);
            tb_Email.BorderColorB = Color.FromArgb(220, 223, 230);
            tb_Email.Font = new Font("Poppins", 12F);
            tb_Email.ForeColor = Color.FromArgb(48, 49, 51);
            tb_Email.Hint = "OTP";
            tb_Email.Location = new Point(50, 100);
            tb_Email.MaxLength = 32767;
            tb_Email.Multiline = false;
            tb_Email.Name = "tb_Email";
            tb_Email.PasswordChar = '\0';
            tb_Email.ScrollBars = ScrollBars.None;
            tb_Email.SelectedText = "";
            tb_Email.SelectionLength = 0;
            tb_Email.SelectionStart = 0;
            tb_Email.Size = new Size(250, 40);
            tb_Email.TabIndex = 4;
            tb_Email.TabStop = false;
            tb_Email.UseSystemPasswordChar = false;
            // 
            // EnterPin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_CreateStudent);
            Controls.Add(lbl_EnterEmail);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(tb_Email);
            Name = "EnterPin";
            Size = new Size(350, 230);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeButton btn_CreateStudent;
        private Label lbl_EnterEmail;
        private Label lbl_ForgotPassword;
        private ReaLTaiizor.Controls.HopeTextBox tb_Email;
    }
}
