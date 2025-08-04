namespace Student_Information_System.UserControls
{
    partial class UserDetails
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
            tb_Address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Phone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Email = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Lastname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Firstname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dt_BirthDate = new ReaLTaiizor.Controls.PoisonDateTime();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            lbl_Name = new Label();
            lbl_bod = new Label();
            lbl_Gender = new Label();
            btn_Next = new ReaLTaiizor.Controls.MaterialButton();
            btn_Confirm = new ReaLTaiizor.Controls.MaterialButton();
            btn_Back = new ReaLTaiizor.Controls.MaterialButton();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // tb_Address
            // 
            tb_Address.AnimateReadOnly = false;
            tb_Address.AutoCompleteMode = AutoCompleteMode.None;
            tb_Address.AutoCompleteSource = AutoCompleteSource.None;
            tb_Address.BackgroundImageLayout = ImageLayout.None;
            tb_Address.CharacterCasing = CharacterCasing.Normal;
            tb_Address.Depth = 0;
            tb_Address.Font = new Font("Poppins", 12F);
            tb_Address.HideSelection = true;
            tb_Address.Hint = "Address";
            tb_Address.LeadingIcon = null;
            tb_Address.Location = new Point(34, 364);
            tb_Address.Margin = new Padding(3, 4, 3, 4);
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
            tb_Address.Size = new Size(517, 48);
            tb_Address.TabIndex = 26;
            tb_Address.TabStop = false;
            tb_Address.TextAlign = HorizontalAlignment.Left;
            tb_Address.TrailingIcon = null;
            tb_Address.UseSystemPasswordChar = false;
            // 
            // tb_Phone
            // 
            tb_Phone.AnimateReadOnly = false;
            tb_Phone.AutoCompleteMode = AutoCompleteMode.None;
            tb_Phone.AutoCompleteSource = AutoCompleteSource.None;
            tb_Phone.BackgroundImageLayout = ImageLayout.None;
            tb_Phone.CharacterCasing = CharacterCasing.Normal;
            tb_Phone.Depth = 0;
            tb_Phone.Font = new Font("Poppins", 12F);
            tb_Phone.HideSelection = true;
            tb_Phone.Hint = "Number";
            tb_Phone.LeadingIcon = null;
            tb_Phone.Location = new Point(301, 285);
            tb_Phone.Margin = new Padding(3, 4, 3, 4);
            tb_Phone.MaxLength = 32767;
            tb_Phone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Phone.Name = "tb_Phone";
            tb_Phone.PasswordChar = '\0';
            tb_Phone.PrefixSuffixText = "+63";
            tb_Phone.ReadOnly = false;
            tb_Phone.RightToLeft = RightToLeft.No;
            tb_Phone.SelectedText = "";
            tb_Phone.SelectionLength = 0;
            tb_Phone.SelectionStart = 0;
            tb_Phone.ShortcutsEnabled = true;
            tb_Phone.Size = new Size(250, 48);
            tb_Phone.TabIndex = 25;
            tb_Phone.TabStop = false;
            tb_Phone.TextAlign = HorizontalAlignment.Left;
            tb_Phone.TrailingIcon = null;
            tb_Phone.UseSystemPasswordChar = false;
            // 
            // tb_Email
            // 
            tb_Email.AnimateReadOnly = false;
            tb_Email.AutoCompleteMode = AutoCompleteMode.None;
            tb_Email.AutoCompleteSource = AutoCompleteSource.None;
            tb_Email.BackgroundImageLayout = ImageLayout.None;
            tb_Email.CharacterCasing = CharacterCasing.Normal;
            tb_Email.Depth = 0;
            tb_Email.Font = new Font("Poppins", 12F);
            tb_Email.HideSelection = true;
            tb_Email.Hint = "Email";
            tb_Email.LeadingIcon = null;
            tb_Email.Location = new Point(34, 285);
            tb_Email.Margin = new Padding(3, 4, 3, 4);
            tb_Email.MaxLength = 32767;
            tb_Email.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Email.Name = "tb_Email";
            tb_Email.PasswordChar = '\0';
            tb_Email.ReadOnly = false;
            tb_Email.RightToLeft = RightToLeft.No;
            tb_Email.SelectedText = "";
            tb_Email.SelectionLength = 0;
            tb_Email.SelectionStart = 0;
            tb_Email.ShortcutsEnabled = true;
            tb_Email.Size = new Size(250, 48);
            tb_Email.TabIndex = 21;
            tb_Email.TabStop = false;
            tb_Email.TextAlign = HorizontalAlignment.Left;
            tb_Email.TrailingIcon = null;
            tb_Email.UseSystemPasswordChar = false;
            // 
            // tb_Lastname
            // 
            tb_Lastname.AnimateReadOnly = false;
            tb_Lastname.AutoCompleteMode = AutoCompleteMode.None;
            tb_Lastname.AutoCompleteSource = AutoCompleteSource.None;
            tb_Lastname.BackgroundImageLayout = ImageLayout.None;
            tb_Lastname.CharacterCasing = CharacterCasing.Normal;
            tb_Lastname.Depth = 0;
            tb_Lastname.Font = new Font("Poppins", 12F);
            tb_Lastname.HideSelection = true;
            tb_Lastname.Hint = "Lastname";
            tb_Lastname.LeadingIcon = null;
            tb_Lastname.Location = new Point(301, 101);
            tb_Lastname.Margin = new Padding(3, 4, 3, 4);
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
            tb_Lastname.Size = new Size(250, 48);
            tb_Lastname.TabIndex = 20;
            tb_Lastname.TabStop = false;
            tb_Lastname.TextAlign = HorizontalAlignment.Left;
            tb_Lastname.TrailingIcon = null;
            tb_Lastname.UseSystemPasswordChar = false;
            // 
            // tb_Firstname
            // 
            tb_Firstname.AnimateReadOnly = false;
            tb_Firstname.AutoCompleteMode = AutoCompleteMode.None;
            tb_Firstname.AutoCompleteSource = AutoCompleteSource.None;
            tb_Firstname.BackgroundImageLayout = ImageLayout.None;
            tb_Firstname.CharacterCasing = CharacterCasing.Normal;
            tb_Firstname.Depth = 0;
            tb_Firstname.Font = new Font("Poppins", 12F);
            tb_Firstname.HideSelection = true;
            tb_Firstname.Hint = "Firstname";
            tb_Firstname.LeadingIcon = null;
            tb_Firstname.Location = new Point(34, 101);
            tb_Firstname.Margin = new Padding(3, 4, 3, 4);
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
            tb_Firstname.Size = new Size(250, 48);
            tb_Firstname.TabIndex = 19;
            tb_Firstname.TabStop = false;
            tb_Firstname.TextAlign = HorizontalAlignment.Left;
            tb_Firstname.TrailingIcon = null;
            tb_Firstname.UseSystemPasswordChar = false;
            // 
            // dt_BirthDate
            // 
            dt_BirthDate.CalendarFont = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            dt_BirthDate.Font = new Font("Poppins", 12F);
            dt_BirthDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dt_BirthDate.Location = new Point(34, 208);
            dt_BirthDate.MinimumSize = new Size(0, 38);
            dt_BirthDate.Name = "dt_BirthDate";
            dt_BirthDate.Size = new Size(250, 38);
            dt_BirthDate.TabIndex = 27;
            dt_BirthDate.UseCustomFont = true;
            // 
            // poisonComboBox1
            // 
            poisonComboBox1.Font = new Font("Poppins", 12F);
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 32;
            poisonComboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            poisonComboBox1.Location = new Point(301, 208);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.Size = new Size(250, 38);
            poisonComboBox1.TabIndex = 30;
            poisonComboBox1.UseCustomFont = true;
            poisonComboBox1.UseSelectable = true;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Poppins", 12F);
            lbl_Name.Location = new Point(34, 69);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(105, 28);
            lbl_Name.TabIndex = 31;
            lbl_Name.Text = "User details";
            // 
            // lbl_bod
            // 
            lbl_bod.AutoSize = true;
            lbl_bod.Font = new Font("Poppins", 12F);
            lbl_bod.Location = new Point(34, 177);
            lbl_bod.Name = "lbl_bod";
            lbl_bod.Size = new Size(109, 28);
            lbl_bod.TabIndex = 32;
            lbl_bod.Text = "Date of Birth";
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Poppins", 12F);
            lbl_Gender.Location = new Point(301, 177);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(71, 28);
            lbl_Gender.TabIndex = 33;
            lbl_Gender.Text = "Gender";
            // 
            // btn_Next
            // 
            btn_Next.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Next.Depth = 0;
            btn_Next.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Next.HighEmphasis = true;
            btn_Next.Icon = null;
            btn_Next.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Next.Location = new Point(401, 486);
            btn_Next.Margin = new Padding(4, 6, 4, 6);
            btn_Next.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Next.Name = "btn_Next";
            btn_Next.NoAccentTextColor = Color.Empty;
            btn_Next.Size = new Size(150, 36);
            btn_Next.TabIndex = 34;
            btn_Next.Text = "Next";
            btn_Next.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Next.UseAccentColor = false;
            btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Confirm.Depth = 0;
            btn_Confirm.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Confirm.HighEmphasis = true;
            btn_Confirm.Icon = null;
            btn_Confirm.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Confirm.Location = new Point(709, 486);
            btn_Confirm.Margin = new Padding(4, 6, 4, 6);
            btn_Confirm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.NoAccentTextColor = Color.Empty;
            btn_Confirm.Size = new Size(150, 36);
            btn_Confirm.TabIndex = 35;
            btn_Confirm.Text = "Confirm";
            btn_Confirm.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Confirm.UseAccentColor = true;
            btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            btn_Back.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Back.Depth = 0;
            btn_Back.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.HighEmphasis = true;
            btn_Back.Icon = null;
            btn_Back.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Back.Location = new Point(574, 486);
            btn_Back.Margin = new Padding(4, 6, 4, 6);
            btn_Back.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Back.Name = "btn_Back";
            btn_Back.NoAccentTextColor = Color.Empty;
            btn_Back.Size = new Size(76, 36);
            btn_Back.TabIndex = 36;
            btn_Back.Text = "Back";
            btn_Back.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Back.UseAccentColor = false;
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(562, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 563);
            panel1.TabIndex = 37;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 245);
            Controls.Add(panel1);
            Controls.Add(btn_Back);
            Controls.Add(btn_Confirm);
            Controls.Add(btn_Next);
            Controls.Add(lbl_Gender);
            Controls.Add(lbl_bod);
            Controls.Add(lbl_Name);
            Controls.Add(poisonComboBox1);
            Controls.Add(dt_BirthDate);
            Controls.Add(tb_Address);
            Controls.Add(tb_Phone);
            Controls.Add(tb_Email);
            Controls.Add(tb_Lastname);
            Controls.Add(tb_Firstname);
            Font = new Font("Poppins", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserDetails";
            Size = new Size(863, 561);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Address;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Phone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Email;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Lastname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Firstname;
        private ReaLTaiizor.Controls.PoisonDateTime dt_BirthDate;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private Label lbl_Name;
        private Label lbl_bod;
        private Label lbl_Gender;
        private ReaLTaiizor.Controls.MaterialButton btn_Next;
        private ReaLTaiizor.Controls.MaterialButton btn_Confirm;
        private ReaLTaiizor.Controls.MaterialButton btn_Back;
        private Panel panel1;
    }
}
