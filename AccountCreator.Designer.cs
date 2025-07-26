namespace Student_Information_System
{
    partial class AccountCreator
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
            tb_Firstname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Lastname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Email = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_User = new Label();
            lb_gender = new ListBox();
            lb_Role = new ListBox();
            label1 = new Label();
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_Register = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // tb_Firstname
            // 
            tb_Firstname.AnimateReadOnly = false;
            tb_Firstname.AutoCompleteMode = AutoCompleteMode.None;
            tb_Firstname.AutoCompleteSource = AutoCompleteSource.None;
            tb_Firstname.BackgroundImageLayout = ImageLayout.None;
            tb_Firstname.CharacterCasing = CharacterCasing.Normal;
            tb_Firstname.Depth = 0;
            tb_Firstname.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Firstname.HideSelection = true;
            tb_Firstname.Hint = "Firstname";
            tb_Firstname.LeadingIcon = null;
            tb_Firstname.Location = new Point(63, 97);
            tb_Firstname.MaxLength = 32767;
            tb_Firstname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.PasswordChar = '\0';
            tb_Firstname.PrefixSuffixText = null;
            tb_Firstname.ReadOnly = false;
            tb_Firstname.RightToLeft = RightToLeft.No;
            tb_Firstname.SelectedText = "";
            tb_Firstname.SelectionLength = 0;
            tb_Firstname.SelectionStart = 0;
            tb_Firstname.ShortcutsEnabled = true;
            tb_Firstname.Size = new Size(239, 48);
            tb_Firstname.TabIndex = 0;
            tb_Firstname.TabStop = false;
            tb_Firstname.TextAlign = HorizontalAlignment.Left;
            tb_Firstname.TrailingIcon = null;
            tb_Firstname.UseSystemPasswordChar = false;
            // 
            // tb_Lastname
            // 
            tb_Lastname.AnimateReadOnly = false;
            tb_Lastname.AutoCompleteMode = AutoCompleteMode.None;
            tb_Lastname.AutoCompleteSource = AutoCompleteSource.None;
            tb_Lastname.BackgroundImageLayout = ImageLayout.None;
            tb_Lastname.CharacterCasing = CharacterCasing.Normal;
            tb_Lastname.Depth = 0;
            tb_Lastname.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Lastname.HideSelection = true;
            tb_Lastname.Hint = "Lastname";
            tb_Lastname.LeadingIcon = null;
            tb_Lastname.Location = new Point(63, 172);
            tb_Lastname.MaxLength = 32767;
            tb_Lastname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.PasswordChar = '\0';
            tb_Lastname.PrefixSuffixText = null;
            tb_Lastname.ReadOnly = false;
            tb_Lastname.RightToLeft = RightToLeft.No;
            tb_Lastname.SelectedText = "";
            tb_Lastname.SelectionLength = 0;
            tb_Lastname.SelectionStart = 0;
            tb_Lastname.ShortcutsEnabled = true;
            tb_Lastname.Size = new Size(239, 48);
            tb_Lastname.TabIndex = 1;
            tb_Lastname.TabStop = false;
            tb_Lastname.TextAlign = HorizontalAlignment.Left;
            tb_Lastname.TrailingIcon = null;
            tb_Lastname.UseSystemPasswordChar = false;
            // 
            // tb_Email
            // 
            tb_Email.AnimateReadOnly = false;
            tb_Email.AutoCompleteMode = AutoCompleteMode.None;
            tb_Email.AutoCompleteSource = AutoCompleteSource.None;
            tb_Email.BackgroundImageLayout = ImageLayout.None;
            tb_Email.CharacterCasing = CharacterCasing.Normal;
            tb_Email.Depth = 0;
            tb_Email.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Email.HideSelection = true;
            tb_Email.Hint = "email";
            tb_Email.LeadingIcon = null;
            tb_Email.Location = new Point(63, 236);
            tb_Email.MaxLength = 32767;
            tb_Email.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Email.Name = "tb_Email";
            tb_Email.PasswordChar = '\0';
            tb_Email.PrefixSuffixText = null;
            tb_Email.ReadOnly = false;
            tb_Email.RightToLeft = RightToLeft.No;
            tb_Email.SelectedText = "";
            tb_Email.SelectionLength = 0;
            tb_Email.SelectionStart = 0;
            tb_Email.ShortcutsEnabled = true;
            tb_Email.Size = new Size(239, 48);
            tb_Email.TabIndex = 2;
            tb_Email.TabStop = false;
            tb_Email.TextAlign = HorizontalAlignment.Left;
            tb_Email.TrailingIcon = null;
            tb_Email.UseSystemPasswordChar = false;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_User.Location = new Point(104, 37);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(95, 25);
            lbl_User.TabIndex = 5;
            lbl_User.Text = "user table";
            // 
            // lb_gender
            // 
            lb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_gender.FormattingEnabled = true;
            lb_gender.ItemHeight = 21;
            lb_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            lb_gender.Location = new Point(63, 302);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(239, 25);
            lb_gender.TabIndex = 7;
            // 
            // lb_Role
            // 
            lb_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Role.FormattingEnabled = true;
            lb_Role.ItemHeight = 21;
            lb_Role.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            lb_Role.Location = new Point(63, 348);
            lb_Role.Name = "lb_Role";
            lb_Role.Size = new Size(239, 25);
            lb_Role.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 411);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 9;
            label1.Text = "user login";
            // 
            // tb_Username
            // 
            tb_Username.AnimateReadOnly = false;
            tb_Username.AutoCompleteMode = AutoCompleteMode.None;
            tb_Username.AutoCompleteSource = AutoCompleteSource.None;
            tb_Username.BackgroundImageLayout = ImageLayout.None;
            tb_Username.CharacterCasing = CharacterCasing.Normal;
            tb_Username.Depth = 0;
            tb_Username.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Username.HideSelection = true;
            tb_Username.Hint = "Username";
            tb_Username.LeadingIcon = null;
            tb_Username.Location = new Point(50, 471);
            tb_Username.MaxLength = 32767;
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
            tb_Username.Size = new Size(239, 48);
            tb_Username.TabIndex = 10;
            tb_Username.TabStop = false;
            tb_Username.TextAlign = HorizontalAlignment.Left;
            tb_Username.TrailingIcon = null;
            tb_Username.UseSystemPasswordChar = false;
            // 
            // tb_Password
            // 
            tb_Password.AnimateReadOnly = false;
            tb_Password.AutoCompleteMode = AutoCompleteMode.None;
            tb_Password.AutoCompleteSource = AutoCompleteSource.None;
            tb_Password.BackgroundImageLayout = ImageLayout.None;
            tb_Password.CharacterCasing = CharacterCasing.Normal;
            tb_Password.Depth = 0;
            tb_Password.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Password.HideSelection = true;
            tb_Password.Hint = "Password";
            tb_Password.LeadingIcon = null;
            tb_Password.Location = new Point(50, 546);
            tb_Password.MaxLength = 32767;
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
            tb_Password.Size = new Size(239, 48);
            tb_Password.TabIndex = 11;
            tb_Password.TabStop = false;
            tb_Password.TextAlign = HorizontalAlignment.Left;
            tb_Password.TrailingIcon = null;
            tb_Password.UseSystemPasswordChar = false;
            // 
            // btn_Register
            // 
            btn_Register.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btn_Register.Font = new Font("Segoe UI", 9F);
            btn_Register.Image = null;
            btn_Register.Location = new Point(396, 549);
            btn_Register.Name = "btn_Register";
            btn_Register.NoRounding = false;
            btn_Register.Size = new Size(100, 45);
            btn_Register.TabIndex = 12;
            btn_Register.Text = "Register";
            btn_Register.Transparent = false;
            // 
            // AccountCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 649);
            Controls.Add(btn_Register);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(label1);
            Controls.Add(lb_Role);
            Controls.Add(lb_gender);
            Controls.Add(lbl_User);
            Controls.Add(tb_Email);
            Controls.Add(tb_Lastname);
            Controls.Add(tb_Firstname);
            Name = "AccountCreator";
            Text = "AccountCreator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Firstname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Lastname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Email;
        private Label lbl_User;
        private ListBox lb_gender;
        private ListBox lb_Role;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private ReaLTaiizor.Controls.AirButton btn_Register;
    }
}