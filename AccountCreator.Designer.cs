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
            tb_Email = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_User = new Label();
            label1 = new Label();
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_Register = new ReaLTaiizor.Controls.AirButton();
            btn_Test = new ReaLTaiizor.Controls.AirButton();
            cb_Gender = new ComboBox();
            cb_Role = new ComboBox();
            tb_Firstname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Lastname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dtp_Birth = new DateTimePicker();
            tb_Phone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
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
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Test
            // 
            btn_Test.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btn_Test.Font = new Font("Segoe UI", 9F);
            btn_Test.Image = null;
            btn_Test.Location = new Point(614, 348);
            btn_Test.Name = "btn_Test";
            btn_Test.NoRounding = false;
            btn_Test.Size = new Size(100, 45);
            btn_Test.TabIndex = 13;
            btn_Test.Text = "Test";
            btn_Test.Transparent = false;
            btn_Test.Click += btn_Test_Click;
            // 
            // cb_Gender
            // 
            cb_Gender.FormattingEnabled = true;
            cb_Gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cb_Gender.Location = new Point(63, 306);
            cb_Gender.Name = "cb_Gender";
            cb_Gender.Size = new Size(239, 23);
            cb_Gender.TabIndex = 14;
            // 
            // cb_Role
            // 
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Admin", "Student", "Teacher" });
            cb_Role.Location = new Point(63, 348);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(239, 23);
            cb_Role.TabIndex = 15;
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
            // dtp_Birth
            // 
            dtp_Birth.Format = DateTimePickerFormat.Short;
            dtp_Birth.Location = new Point(330, 97);
            dtp_Birth.Name = "dtp_Birth";
            dtp_Birth.Size = new Size(200, 23);
            dtp_Birth.TabIndex = 16;
            // 
            // tb_Phone
            // 
            tb_Phone.AnimateReadOnly = false;
            tb_Phone.AutoCompleteMode = AutoCompleteMode.None;
            tb_Phone.AutoCompleteSource = AutoCompleteSource.None;
            tb_Phone.BackgroundImageLayout = ImageLayout.None;
            tb_Phone.CharacterCasing = CharacterCasing.Normal;
            tb_Phone.Depth = 0;
            tb_Phone.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Phone.HideSelection = true;
            tb_Phone.Hint = "Number";
            tb_Phone.LeadingIcon = null;
            tb_Phone.Location = new Point(330, 172);
            tb_Phone.MaxLength = 32767;
            tb_Phone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Phone.Name = "tb_Phone";
            tb_Phone.PasswordChar = '\0';
            tb_Phone.PrefixSuffixText = null;
            tb_Phone.ReadOnly = false;
            tb_Phone.RightToLeft = RightToLeft.No;
            tb_Phone.SelectedText = "";
            tb_Phone.SelectionLength = 0;
            tb_Phone.SelectionStart = 0;
            tb_Phone.ShortcutsEnabled = true;
            tb_Phone.Size = new Size(239, 48);
            tb_Phone.TabIndex = 17;
            tb_Phone.TabStop = false;
            tb_Phone.TextAlign = HorizontalAlignment.Left;
            tb_Phone.TrailingIcon = null;
            tb_Phone.UseSystemPasswordChar = false;
            // 
            // tb_Address
            // 
            tb_Address.AnimateReadOnly = false;
            tb_Address.AutoCompleteMode = AutoCompleteMode.None;
            tb_Address.AutoCompleteSource = AutoCompleteSource.None;
            tb_Address.BackgroundImageLayout = ImageLayout.None;
            tb_Address.CharacterCasing = CharacterCasing.Normal;
            tb_Address.Depth = 0;
            tb_Address.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Address.HideSelection = true;
            tb_Address.Hint = "Address";
            tb_Address.LeadingIcon = null;
            tb_Address.Location = new Point(330, 236);
            tb_Address.MaxLength = 32767;
            tb_Address.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Address.Name = "tb_Address";
            tb_Address.PasswordChar = '\0';
            tb_Address.PrefixSuffixText = null;
            tb_Address.ReadOnly = false;
            tb_Address.RightToLeft = RightToLeft.No;
            tb_Address.SelectedText = "";
            tb_Address.SelectionLength = 0;
            tb_Address.SelectionStart = 0;
            tb_Address.ShortcutsEnabled = true;
            tb_Address.Size = new Size(239, 48);
            tb_Address.TabIndex = 18;
            tb_Address.TabStop = false;
            tb_Address.TextAlign = HorizontalAlignment.Left;
            tb_Address.TrailingIcon = null;
            tb_Address.UseSystemPasswordChar = false;
            // 
            // AccountCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 649);
            Controls.Add(tb_Address);
            Controls.Add(tb_Phone);
            Controls.Add(dtp_Birth);
            Controls.Add(cb_Role);
            Controls.Add(cb_Gender);
            Controls.Add(btn_Test);
            Controls.Add(btn_Register);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(label1);
            Controls.Add(lbl_User);
            Controls.Add(tb_Email);
            Controls.Add(tb_Lastname);
            Controls.Add(tb_Firstname);
            Name = "AccountCreator";
            Text = "eswxd23erqsadfzxc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Email;
        private Label lbl_User;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private ReaLTaiizor.Controls.AirButton btn_Register;
        private ReaLTaiizor.Controls.AirButton btn_Test;
        private ComboBox cb_Gender;
        private ComboBox cb_Role;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Firstname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Lastname;
        private DateTimePicker dtp_Birth;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Phone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Address;
    }
}