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
            lbl_StudentInformationSystem = new Label();
            pnl_LoginForm = new Panel();
            pb_Mascot = new PictureBox();
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
            pnl_LoginForm.BackgroundImage = Properties.Resources.LoginForm;
            pnl_LoginForm.Location = new Point(47, 62);
            pnl_LoginForm.Name = "pnl_LoginForm";
            pnl_LoginForm.Size = new Size(400, 600);
            pnl_LoginForm.TabIndex = 1;
            // 
            // pb_Mascot
            // 
            pb_Mascot.Image = Properties.Resources.Login_Pics;
            pb_Mascot.Location = new Point(625, 482);
            pb_Mascot.Name = "pb_Mascot";
            pb_Mascot.Size = new Size(496, 235);
            pb_Mascot.TabIndex = 2;
            pb_Mascot.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1184, 729);
            Controls.Add(pb_Mascot);
            Controls.Add(pnl_LoginForm);
            Controls.Add(lbl_StudentInformationSystem);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information System";
            ((System.ComponentModel.ISupportInitialize)pb_Mascot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_StudentInformationSystem;
        private Panel pnl_LoginForm;
        private PictureBox pb_Mascot;
    }
}
