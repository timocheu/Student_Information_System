namespace Student_Information_System.Forms
{
    partial class UpdateCredentials
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
            hope_UpdateCredentials = new ReaLTaiizor.Forms.HopeForm();
            pnl_UserDetails = new Student_Information_System.UI.SPanel();
            tb_Program = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_UpdateUserDetail = new ReaLTaiizor.Controls.MaterialButton();
            tb_Lastname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pnl_TeacherEnabled = new Panel();
            tb_Specialization = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Department = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Firstname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dt_BirthDate = new ReaLTaiizor.Controls.PoisonDateTime();
            cb_Gender = new ReaLTaiizor.Controls.PoisonComboBox();
            lbl_Name = new Label();
            lbl_bod = new Label();
            tb_Address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_Gender = new Label();
            tb_Phone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Email = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pnl_UserLogin = new Student_Information_System.UI.SPanel();
            tb_UserPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_UserLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_UserLogin = new Label();
            btn_UpdateUserLogin = new ReaLTaiizor.Controls.MaterialButton();
            pnl_UserDetails.SuspendLayout();
            pnl_TeacherEnabled.SuspendLayout();
            pnl_UserLogin.SuspendLayout();
            SuspendLayout();
            // 
            // hope_UpdateCredentials
            // 
            hope_UpdateCredentials.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_UpdateCredentials.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_UpdateCredentials.ControlBoxColorN = Color.White;
            hope_UpdateCredentials.Dock = DockStyle.Top;
            hope_UpdateCredentials.Font = new Font("Poppins", 14.25F);
            hope_UpdateCredentials.ForeColor = Color.FromArgb(242, 246, 252);
            hope_UpdateCredentials.Image = Properties.Resources.FormIcon;
            hope_UpdateCredentials.Location = new Point(0, 0);
            hope_UpdateCredentials.MaximizeBox = false;
            hope_UpdateCredentials.Name = "hope_UpdateCredentials";
            hope_UpdateCredentials.Size = new Size(900, 40);
            hope_UpdateCredentials.TabIndex = 2;
            hope_UpdateCredentials.Text = "Update Credentials";
            hope_UpdateCredentials.ThemeColor = Color.DarkRed;
            // 
            // pnl_UserDetails
            // 
            pnl_UserDetails.BackColor = Color.Transparent;
            pnl_UserDetails.BackgroundFillColor = Color.White;
            pnl_UserDetails.BorderColor = Color.White;
            pnl_UserDetails.Controls.Add(tb_Program);
            pnl_UserDetails.Controls.Add(btn_UpdateUserDetail);
            pnl_UserDetails.Controls.Add(tb_Lastname);
            pnl_UserDetails.Controls.Add(pnl_TeacherEnabled);
            pnl_UserDetails.Controls.Add(tb_Firstname);
            pnl_UserDetails.Controls.Add(dt_BirthDate);
            pnl_UserDetails.Controls.Add(cb_Gender);
            pnl_UserDetails.Controls.Add(lbl_Name);
            pnl_UserDetails.Controls.Add(lbl_bod);
            pnl_UserDetails.Controls.Add(tb_Address);
            pnl_UserDetails.Controls.Add(lbl_Gender);
            pnl_UserDetails.Controls.Add(tb_Phone);
            pnl_UserDetails.Controls.Add(tb_Email);
            pnl_UserDetails.Location = new Point(12, 60);
            pnl_UserDetails.Name = "pnl_UserDetails";
            pnl_UserDetails.Size = new Size(570, 567);
            pnl_UserDetails.TabIndex = 56;
            // 
            // tb_Program
            // 
            tb_Program.AnimateReadOnly = false;
            tb_Program.AutoCompleteMode = AutoCompleteMode.None;
            tb_Program.AutoCompleteSource = AutoCompleteSource.None;
            tb_Program.BackgroundImageLayout = ImageLayout.None;
            tb_Program.CharacterCasing = CharacterCasing.Normal;
            tb_Program.Depth = 0;
            tb_Program.Font = new Font("Poppins", 12F);
            tb_Program.HideSelection = true;
            tb_Program.Hint = "Program";
            tb_Program.LeadingIcon = null;
            tb_Program.Location = new Point(300, 410);
            tb_Program.Margin = new Padding(3, 4, 3, 4);
            tb_Program.MaxLength = 50;
            tb_Program.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Program.Name = "tb_Program";
            tb_Program.PasswordChar = '\0';
            tb_Program.PrefixSuffixText = null;
            tb_Program.ReadOnly = false;
            tb_Program.RightToLeft = RightToLeft.No;
            tb_Program.SelectedText = "";
            tb_Program.SelectionLength = 0;
            tb_Program.SelectionStart = 0;
            tb_Program.ShortcutsEnabled = true;
            tb_Program.Size = new Size(250, 48);
            tb_Program.TabIndex = 58;
            tb_Program.TabStop = false;
            tb_Program.TextAlign = HorizontalAlignment.Left;
            tb_Program.TrailingIcon = null;
            tb_Program.UseSystemPasswordChar = false;
            tb_Program.Visible = false;
            // 
            // btn_UpdateUserDetail
            // 
            btn_UpdateUserDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_UpdateUserDetail.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_UpdateUserDetail.Depth = 0;
            btn_UpdateUserDetail.Font = new Font("Poppins", 9F);
            btn_UpdateUserDetail.HighEmphasis = true;
            btn_UpdateUserDetail.Icon = null;
            btn_UpdateUserDetail.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_UpdateUserDetail.Location = new Point(472, 502);
            btn_UpdateUserDetail.Margin = new Padding(4, 6, 4, 6);
            btn_UpdateUserDetail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_UpdateUserDetail.Name = "btn_UpdateUserDetail";
            btn_UpdateUserDetail.NoAccentTextColor = Color.Empty;
            btn_UpdateUserDetail.Size = new Size(77, 36);
            btn_UpdateUserDetail.TabIndex = 57;
            btn_UpdateUserDetail.Text = "Update";
            btn_UpdateUserDetail.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_UpdateUserDetail.UseAccentColor = true;
            btn_UpdateUserDetail.UseVisualStyleBackColor = true;
            btn_UpdateUserDetail.Click += btn_UpdateUserDetail_Click;
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
            tb_Lastname.Location = new Point(299, 74);
            tb_Lastname.Margin = new Padding(3, 4, 3, 4);
            tb_Lastname.MaxLength = 45;
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
            tb_Lastname.TabIndex = 39;
            tb_Lastname.TabStop = false;
            tb_Lastname.TextAlign = HorizontalAlignment.Left;
            tb_Lastname.TrailingIcon = null;
            tb_Lastname.UseSystemPasswordChar = false;
            // 
            // pnl_TeacherEnabled
            // 
            pnl_TeacherEnabled.BackColor = Color.White;
            pnl_TeacherEnabled.Controls.Add(tb_Specialization);
            pnl_TeacherEnabled.Controls.Add(tb_Department);
            pnl_TeacherEnabled.Enabled = false;
            pnl_TeacherEnabled.Location = new Point(32, 395);
            pnl_TeacherEnabled.Name = "pnl_TeacherEnabled";
            pnl_TeacherEnabled.Size = new Size(262, 143);
            pnl_TeacherEnabled.TabIndex = 56;
            pnl_TeacherEnabled.Visible = false;
            // 
            // tb_Specialization
            // 
            tb_Specialization.AnimateReadOnly = false;
            tb_Specialization.AutoCompleteMode = AutoCompleteMode.None;
            tb_Specialization.AutoCompleteSource = AutoCompleteSource.None;
            tb_Specialization.BackgroundImageLayout = ImageLayout.None;
            tb_Specialization.CharacterCasing = CharacterCasing.Normal;
            tb_Specialization.Depth = 0;
            tb_Specialization.Font = new Font("Poppins", 12F);
            tb_Specialization.HideSelection = true;
            tb_Specialization.Hint = "Specialization";
            tb_Specialization.LeadingIcon = null;
            tb_Specialization.Location = new Point(0, 80);
            tb_Specialization.Margin = new Padding(3, 4, 3, 4);
            tb_Specialization.MaxLength = 50;
            tb_Specialization.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Specialization.Name = "tb_Specialization";
            tb_Specialization.PasswordChar = '\0';
            tb_Specialization.PrefixSuffixText = "+63";
            tb_Specialization.ReadOnly = false;
            tb_Specialization.RightToLeft = RightToLeft.No;
            tb_Specialization.SelectedText = "";
            tb_Specialization.SelectionLength = 0;
            tb_Specialization.SelectionStart = 0;
            tb_Specialization.ShortcutsEnabled = true;
            tb_Specialization.Size = new Size(250, 48);
            tb_Specialization.TabIndex = 43;
            tb_Specialization.TabStop = false;
            tb_Specialization.TextAlign = HorizontalAlignment.Left;
            tb_Specialization.TrailingIcon = null;
            tb_Specialization.UseSystemPasswordChar = false;
            // 
            // tb_Department
            // 
            tb_Department.AnimateReadOnly = false;
            tb_Department.AutoCompleteMode = AutoCompleteMode.None;
            tb_Department.AutoCompleteSource = AutoCompleteSource.None;
            tb_Department.BackgroundImageLayout = ImageLayout.None;
            tb_Department.CharacterCasing = CharacterCasing.Normal;
            tb_Department.Depth = 0;
            tb_Department.Font = new Font("Poppins", 12F);
            tb_Department.HideSelection = true;
            tb_Department.Hint = "Department";
            tb_Department.LeadingIcon = null;
            tb_Department.Location = new Point(0, 15);
            tb_Department.Margin = new Padding(3, 4, 3, 4);
            tb_Department.MaxLength = 50;
            tb_Department.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Department.Name = "tb_Department";
            tb_Department.PasswordChar = '\0';
            tb_Department.PrefixSuffixText = null;
            tb_Department.ReadOnly = false;
            tb_Department.RightToLeft = RightToLeft.No;
            tb_Department.SelectedText = "";
            tb_Department.SelectionLength = 0;
            tb_Department.SelectionStart = 0;
            tb_Department.ShortcutsEnabled = true;
            tb_Department.Size = new Size(250, 48);
            tb_Department.TabIndex = 42;
            tb_Department.TabStop = false;
            tb_Department.TextAlign = HorizontalAlignment.Left;
            tb_Department.TrailingIcon = null;
            tb_Department.UseSystemPasswordChar = false;
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
            tb_Firstname.Location = new Point(32, 74);
            tb_Firstname.Margin = new Padding(3, 4, 3, 4);
            tb_Firstname.MaxLength = 45;
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
            tb_Firstname.TabIndex = 38;
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
            dt_BirthDate.Format = DateTimePickerFormat.Custom;
            dt_BirthDate.Location = new Point(32, 181);
            dt_BirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dt_BirthDate.MinimumSize = new Size(0, 38);
            dt_BirthDate.Name = "dt_BirthDate";
            dt_BirthDate.RightToLeft = RightToLeft.No;
            dt_BirthDate.Size = new Size(250, 38);
            dt_BirthDate.TabIndex = 43;
            dt_BirthDate.UseCustomFont = true;
            dt_BirthDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cb_Gender
            // 
            cb_Gender.DisplayMember = "Male";
            cb_Gender.Font = new Font("Poppins", 12F);
            cb_Gender.FormattingEnabled = true;
            cb_Gender.ItemHeight = 32;
            cb_Gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cb_Gender.Location = new Point(299, 181);
            cb_Gender.Name = "cb_Gender";
            cb_Gender.PromptText = "Male";
            cb_Gender.Size = new Size(250, 38);
            cb_Gender.TabIndex = 44;
            cb_Gender.Text = "Male";
            cb_Gender.UseCustomFont = true;
            cb_Gender.UseSelectable = true;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.BackColor = Color.White;
            lbl_Name.Font = new Font("Poppins", 12F);
            lbl_Name.Location = new Point(32, 42);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(105, 28);
            lbl_Name.TabIndex = 45;
            lbl_Name.Text = "User details";
            // 
            // lbl_bod
            // 
            lbl_bod.AutoSize = true;
            lbl_bod.BackColor = Color.White;
            lbl_bod.Font = new Font("Poppins", 12F);
            lbl_bod.Location = new Point(32, 150);
            lbl_bod.Name = "lbl_bod";
            lbl_bod.Size = new Size(109, 28);
            lbl_bod.TabIndex = 46;
            lbl_bod.Text = "Date of Birth";
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
            tb_Address.Location = new Point(32, 325);
            tb_Address.Margin = new Padding(3, 4, 3, 4);
            tb_Address.MaxLength = 100;
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
            tb_Address.TabIndex = 42;
            tb_Address.TabStop = false;
            tb_Address.TextAlign = HorizontalAlignment.Left;
            tb_Address.TrailingIcon = null;
            tb_Address.UseSystemPasswordChar = false;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.BackColor = Color.White;
            lbl_Gender.Font = new Font("Poppins", 12F);
            lbl_Gender.Location = new Point(299, 150);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(71, 28);
            lbl_Gender.TabIndex = 47;
            lbl_Gender.Text = "Gender";
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
            tb_Phone.Location = new Point(299, 246);
            tb_Phone.Margin = new Padding(3, 4, 3, 4);
            tb_Phone.MaxLength = 45;
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
            tb_Phone.TabIndex = 41;
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
            tb_Email.Location = new Point(32, 246);
            tb_Email.Margin = new Padding(3, 4, 3, 4);
            tb_Email.MaxLength = 45;
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
            tb_Email.Size = new Size(250, 48);
            tb_Email.TabIndex = 40;
            tb_Email.TabStop = false;
            tb_Email.TextAlign = HorizontalAlignment.Left;
            tb_Email.TrailingIcon = null;
            tb_Email.UseSystemPasswordChar = false;
            // 
            // pnl_UserLogin
            // 
            pnl_UserLogin.BackColor = Color.Transparent;
            pnl_UserLogin.BackgroundFillColor = Color.White;
            pnl_UserLogin.BorderColor = Color.White;
            pnl_UserLogin.Controls.Add(tb_UserPassword);
            pnl_UserLogin.Controls.Add(tb_UserLogin);
            pnl_UserLogin.Controls.Add(lbl_UserLogin);
            pnl_UserLogin.Controls.Add(btn_UpdateUserLogin);
            pnl_UserLogin.Location = new Point(599, 60);
            pnl_UserLogin.Name = "pnl_UserLogin";
            pnl_UserLogin.Size = new Size(289, 273);
            pnl_UserLogin.TabIndex = 57;
            // 
            // tb_UserPassword
            // 
            tb_UserPassword.AnimateReadOnly = false;
            tb_UserPassword.AutoCompleteMode = AutoCompleteMode.None;
            tb_UserPassword.AutoCompleteSource = AutoCompleteSource.None;
            tb_UserPassword.BackgroundImageLayout = ImageLayout.None;
            tb_UserPassword.CharacterCasing = CharacterCasing.Normal;
            tb_UserPassword.Depth = 0;
            tb_UserPassword.Font = new Font("Poppins", 15.75F);
            tb_UserPassword.HideSelection = true;
            tb_UserPassword.Hint = "Password";
            tb_UserPassword.LeadingIcon = Properties.Resources.padlock;
            tb_UserPassword.Location = new Point(22, 128);
            tb_UserPassword.MaxLength = 50;
            tb_UserPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_UserPassword.Name = "tb_UserPassword";
            tb_UserPassword.PasswordChar = '●';
            tb_UserPassword.PrefixSuffixText = null;
            tb_UserPassword.ReadOnly = false;
            tb_UserPassword.RightToLeft = RightToLeft.No;
            tb_UserPassword.SelectedText = "";
            tb_UserPassword.SelectionLength = 0;
            tb_UserPassword.SelectionStart = 0;
            tb_UserPassword.ShortcutsEnabled = true;
            tb_UserPassword.Size = new Size(250, 48);
            tb_UserPassword.TabIndex = 55;
            tb_UserPassword.TabStop = false;
            tb_UserPassword.TextAlign = HorizontalAlignment.Left;
            tb_UserPassword.TrailingIcon = Properties.Resources.eye;
            tb_UserPassword.UseSystemPasswordChar = true;
            // 
            // tb_UserLogin
            // 
            tb_UserLogin.AnimateReadOnly = false;
            tb_UserLogin.AutoCompleteMode = AutoCompleteMode.None;
            tb_UserLogin.AutoCompleteSource = AutoCompleteSource.None;
            tb_UserLogin.BackgroundImageLayout = ImageLayout.None;
            tb_UserLogin.CharacterCasing = CharacterCasing.Normal;
            tb_UserLogin.Depth = 0;
            tb_UserLogin.Font = new Font("Poppins", 12F);
            tb_UserLogin.HideSelection = true;
            tb_UserLogin.Hint = "User-ID";
            tb_UserLogin.LeadingIcon = null;
            tb_UserLogin.Location = new Point(22, 64);
            tb_UserLogin.Margin = new Padding(3, 4, 3, 4);
            tb_UserLogin.MaxLength = 32767;
            tb_UserLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_UserLogin.Name = "tb_UserLogin";
            tb_UserLogin.PasswordChar = '\0';
            tb_UserLogin.PrefixSuffixText = null;
            tb_UserLogin.ReadOnly = false;
            tb_UserLogin.RightToLeft = RightToLeft.No;
            tb_UserLogin.SelectedText = "";
            tb_UserLogin.SelectionLength = 0;
            tb_UserLogin.SelectionStart = 0;
            tb_UserLogin.ShortcutsEnabled = true;
            tb_UserLogin.Size = new Size(250, 48);
            tb_UserLogin.TabIndex = 52;
            tb_UserLogin.TabStop = false;
            tb_UserLogin.TextAlign = HorizontalAlignment.Left;
            tb_UserLogin.TrailingIcon = null;
            tb_UserLogin.UseSystemPasswordChar = false;
            // 
            // lbl_UserLogin
            // 
            lbl_UserLogin.AutoSize = true;
            lbl_UserLogin.BackColor = Color.White;
            lbl_UserLogin.Font = new Font("Poppins", 12F);
            lbl_UserLogin.Location = new Point(22, 32);
            lbl_UserLogin.Name = "lbl_UserLogin";
            lbl_UserLogin.Size = new Size(93, 28);
            lbl_UserLogin.TabIndex = 54;
            lbl_UserLogin.Text = "User Login";
            // 
            // btn_UpdateUserLogin
            // 
            btn_UpdateUserLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_UpdateUserLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_UpdateUserLogin.Depth = 0;
            btn_UpdateUserLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UpdateUserLogin.HighEmphasis = true;
            btn_UpdateUserLogin.Icon = null;
            btn_UpdateUserLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_UpdateUserLogin.Location = new Point(186, 211);
            btn_UpdateUserLogin.Margin = new Padding(4, 6, 4, 6);
            btn_UpdateUserLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_UpdateUserLogin.Name = "btn_UpdateUserLogin";
            btn_UpdateUserLogin.NoAccentTextColor = Color.Empty;
            btn_UpdateUserLogin.Size = new Size(77, 36);
            btn_UpdateUserLogin.TabIndex = 49;
            btn_UpdateUserLogin.Text = "Update";
            btn_UpdateUserLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_UpdateUserLogin.UseAccentColor = true;
            btn_UpdateUserLogin.UseVisualStyleBackColor = true;
            btn_UpdateUserLogin.Click += btn_UpdateUserLogin_Click;
            // 
            // UpdateCredentials
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(pnl_UserLogin);
            Controls.Add(pnl_UserDetails);
            Controls.Add(hope_UpdateCredentials);
            Font = new Font("Poppins", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(190, 40);
            Name = "UpdateCredentials";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCredentials";
            pnl_UserDetails.ResumeLayout(false);
            pnl_UserDetails.PerformLayout();
            pnl_TeacherEnabled.ResumeLayout(false);
            pnl_UserLogin.ResumeLayout(false);
            pnl_UserLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_UpdateCredentials;
        private UI.SPanel pnl_UserDetails;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Lastname;
        private Panel pnl_TeacherEnabled;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Specialization;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Department;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Firstname;
        private ReaLTaiizor.Controls.PoisonDateTime dt_BirthDate;
        private ReaLTaiizor.Controls.PoisonComboBox cb_Gender;
        private ReaLTaiizor.Controls.MaterialButton btn_Next;
        private Label lbl_Name;
        private Label lbl_bod;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Address;
        private Label lbl_Gender;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Phone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Email;
        private UI.SPanel pnl_UserLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_UserPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_UserLogin;
        private Label lbl_UserLogin;
        private ReaLTaiizor.Controls.MaterialButton btn_UpdateUserLogin;
        private ReaLTaiizor.Controls.MaterialButton btn_UpdateUserDetail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Program;
    }
}