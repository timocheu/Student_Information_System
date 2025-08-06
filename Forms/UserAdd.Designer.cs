namespace Student_Information_System.Forms
{
    partial class UserAdd
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
            hope_UserAdd = new ReaLTaiizor.Forms.HopeForm();
            pnl_LineDesign = new Panel();
            btn_Back = new ReaLTaiizor.Controls.MaterialButton();
            btn_Confirm = new ReaLTaiizor.Controls.MaterialButton();
            btn_Next = new ReaLTaiizor.Controls.MaterialButton();
            lbl_Gender = new Label();
            lbl_bod = new Label();
            lbl_Name = new Label();
            poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            dt_BirthDate = new ReaLTaiizor.Controls.PoisonDateTime();
            tb_Address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Phone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Email = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Lastname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Firstname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_UserLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_UserPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_UserLogin = new Label();
            pnl_TeacherEnabled = new Panel();
            tb_Specialization = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Department = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pnl_UserDetails = new Student_Information_System.UI.SPanel();
            pnl_UserLogin = new Student_Information_System.UI.SPanel();
            pnl_TeacherEnabled.SuspendLayout();
            pnl_UserDetails.SuspendLayout();
            pnl_UserLogin.SuspendLayout();
            SuspendLayout();
            // 
            // hope_UserAdd
            // 
            hope_UserAdd.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_UserAdd.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_UserAdd.ControlBoxColorN = Color.White;
            hope_UserAdd.Dock = DockStyle.Top;
            hope_UserAdd.Font = new Font("Poppins", 14.25F);
            hope_UserAdd.ForeColor = Color.FromArgb(242, 246, 252);
            hope_UserAdd.Image = Properties.Resources.FormIcon;
            hope_UserAdd.Location = new Point(0, 0);
            hope_UserAdd.Margin = new Padding(3, 4, 3, 4);
            hope_UserAdd.Name = "hope_UserAdd";
            hope_UserAdd.Size = new Size(1014, 40);
            hope_UserAdd.TabIndex = 1;
            hope_UserAdd.Text = "Add";
            hope_UserAdd.ThemeColor = Color.DarkRed;
            // 
            // pnl_LineDesign
            // 
            pnl_LineDesign.BackColor = Color.FromArgb(64, 64, 64);
            pnl_LineDesign.Location = new Point(657, 47);
            pnl_LineDesign.Margin = new Padding(3, 4, 3, 4);
            pnl_LineDesign.Name = "pnl_LineDesign";
            pnl_LineDesign.Size = new Size(6, 800);
            pnl_LineDesign.TabIndex = 51;
            // 
            // btn_Back
            // 
            btn_Back.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Back.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Back.Depth = 0;
            btn_Back.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.HighEmphasis = true;
            btn_Back.Icon = null;
            btn_Back.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Back.Location = new Point(25, 281);
            btn_Back.Margin = new Padding(5, 8, 5, 8);
            btn_Back.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Back.Name = "btn_Back";
            btn_Back.NoAccentTextColor = Color.Empty;
            btn_Back.Size = new Size(64, 36);
            btn_Back.TabIndex = 50;
            btn_Back.Text = "Back";
            btn_Back.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Back.UseAccentColor = false;
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Confirm.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Confirm.Depth = 0;
            btn_Confirm.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Confirm.HighEmphasis = true;
            btn_Confirm.Icon = null;
            btn_Confirm.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Confirm.Location = new Point(213, 281);
            btn_Confirm.Margin = new Padding(5, 8, 5, 8);
            btn_Confirm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.NoAccentTextColor = Color.Empty;
            btn_Confirm.Size = new Size(86, 36);
            btn_Confirm.TabIndex = 49;
            btn_Confirm.Text = "Confirm";
            btn_Confirm.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Confirm.UseAccentColor = true;
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_Next
            // 
            btn_Next.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Next.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Next.Depth = 0;
            btn_Next.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Next.HighEmphasis = true;
            btn_Next.Icon = null;
            btn_Next.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Next.Location = new Point(554, 649);
            btn_Next.Margin = new Padding(5, 8, 5, 8);
            btn_Next.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Next.Name = "btn_Next";
            btn_Next.NoAccentTextColor = Color.Empty;
            btn_Next.Size = new Size(64, 36);
            btn_Next.TabIndex = 48;
            btn_Next.Text = "Next";
            btn_Next.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Next.UseAccentColor = false;
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.BackColor = Color.White;
            lbl_Gender.Font = new Font("Poppins", 12F);
            lbl_Gender.Location = new Point(342, 200);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(89, 36);
            lbl_Gender.TabIndex = 47;
            lbl_Gender.Text = "Gender";
            // 
            // lbl_bod
            // 
            lbl_bod.AutoSize = true;
            lbl_bod.BackColor = Color.White;
            lbl_bod.Font = new Font("Poppins", 12F);
            lbl_bod.Location = new Point(37, 200);
            lbl_bod.Name = "lbl_bod";
            lbl_bod.Size = new Size(136, 36);
            lbl_bod.TabIndex = 46;
            lbl_bod.Text = "Date of Birth";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.BackColor = Color.White;
            lbl_Name.Font = new Font("Poppins", 12F);
            lbl_Name.Location = new Point(37, 56);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(130, 36);
            lbl_Name.TabIndex = 45;
            lbl_Name.Text = "User details";
            // 
            // poisonComboBox1
            // 
            poisonComboBox1.DisplayMember = "Male";
            poisonComboBox1.Font = new Font("Poppins", 12F);
            poisonComboBox1.FormattingEnabled = true;
            poisonComboBox1.ItemHeight = 40;
            poisonComboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            poisonComboBox1.Location = new Point(342, 241);
            poisonComboBox1.Margin = new Padding(3, 4, 3, 4);
            poisonComboBox1.Name = "poisonComboBox1";
            poisonComboBox1.Size = new Size(285, 46);
            poisonComboBox1.TabIndex = 44;
            poisonComboBox1.UseCustomFont = true;
            poisonComboBox1.UseSelectable = true;
            // 
            // dt_BirthDate
            // 
            dt_BirthDate.CalendarFont = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            dt_BirthDate.Font = new Font("Poppins", 12F);
            dt_BirthDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dt_BirthDate.Format = DateTimePickerFormat.Custom;
            dt_BirthDate.Location = new Point(37, 241);
            dt_BirthDate.Margin = new Padding(3, 4, 3, 4);
            dt_BirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dt_BirthDate.MinimumSize = new Size(0, 46);
            dt_BirthDate.Name = "dt_BirthDate";
            dt_BirthDate.RightToLeft = RightToLeft.Yes;
            dt_BirthDate.RightToLeftLayout = true;
            dt_BirthDate.Size = new Size(285, 46);
            dt_BirthDate.TabIndex = 43;
            dt_BirthDate.UseCustomFont = true;
            dt_BirthDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            tb_Address.Location = new Point(37, 433);
            tb_Address.Margin = new Padding(3, 5, 3, 5);
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
            tb_Address.Size = new Size(591, 48);
            tb_Address.TabIndex = 42;
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
            tb_Phone.Location = new Point(342, 328);
            tb_Phone.Margin = new Padding(3, 5, 3, 5);
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
            tb_Phone.Size = new Size(286, 48);
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
            tb_Email.Location = new Point(37, 328);
            tb_Email.Margin = new Padding(3, 5, 3, 5);
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
            tb_Email.Size = new Size(286, 48);
            tb_Email.TabIndex = 40;
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
            tb_Lastname.Location = new Point(342, 99);
            tb_Lastname.Margin = new Padding(3, 5, 3, 5);
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
            tb_Lastname.Size = new Size(286, 48);
            tb_Lastname.TabIndex = 39;
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
            tb_Firstname.Location = new Point(37, 99);
            tb_Firstname.Margin = new Padding(3, 5, 3, 5);
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
            tb_Firstname.Size = new Size(286, 48);
            tb_Firstname.TabIndex = 38;
            tb_Firstname.TabStop = false;
            tb_Firstname.TextAlign = HorizontalAlignment.Left;
            tb_Firstname.TrailingIcon = null;
            tb_Firstname.UseSystemPasswordChar = false;
            // 
            // tb_UserLogin
            // 
            tb_UserLogin.AnimateReadOnly = false;
            tb_UserLogin.AutoCompleteMode = AutoCompleteMode.None;
            tb_UserLogin.AutoCompleteSource = AutoCompleteSource.None;
            tb_UserLogin.BackgroundImageLayout = ImageLayout.None;
            tb_UserLogin.CharacterCasing = CharacterCasing.Normal;
            tb_UserLogin.Depth = 0;
            tb_UserLogin.Enabled = false;
            tb_UserLogin.Font = new Font("Poppins", 12F);
            tb_UserLogin.HideSelection = true;
            tb_UserLogin.Hint = "User-ID";
            tb_UserLogin.LeadingIcon = null;
            tb_UserLogin.Location = new Point(25, 85);
            tb_UserLogin.Margin = new Padding(3, 5, 3, 5);
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
            tb_UserLogin.Size = new Size(286, 48);
            tb_UserLogin.TabIndex = 52;
            tb_UserLogin.TabStop = false;
            tb_UserLogin.TextAlign = HorizontalAlignment.Left;
            tb_UserLogin.TrailingIcon = null;
            tb_UserLogin.UseSystemPasswordChar = false;
            // 
            // tb_UserPassword
            // 
            tb_UserPassword.AnimateReadOnly = false;
            tb_UserPassword.AutoCompleteMode = AutoCompleteMode.None;
            tb_UserPassword.AutoCompleteSource = AutoCompleteSource.None;
            tb_UserPassword.BackgroundImageLayout = ImageLayout.None;
            tb_UserPassword.CharacterCasing = CharacterCasing.Normal;
            tb_UserPassword.Depth = 0;
            tb_UserPassword.Font = new Font("Poppins", 12F);
            tb_UserPassword.HideSelection = true;
            tb_UserPassword.Hint = "Password";
            tb_UserPassword.LeadingIcon = null;
            tb_UserPassword.Location = new Point(25, 187);
            tb_UserPassword.Margin = new Padding(3, 5, 3, 5);
            tb_UserPassword.MaxLength = 32767;
            tb_UserPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_UserPassword.Name = "tb_UserPassword";
            tb_UserPassword.PasswordChar = '\0';
            tb_UserPassword.PrefixSuffixText = null;
            tb_UserPassword.ReadOnly = false;
            tb_UserPassword.RightToLeft = RightToLeft.No;
            tb_UserPassword.SelectedText = "";
            tb_UserPassword.SelectionLength = 0;
            tb_UserPassword.SelectionStart = 0;
            tb_UserPassword.ShortcutsEnabled = true;
            tb_UserPassword.Size = new Size(286, 48);
            tb_UserPassword.TabIndex = 53;
            tb_UserPassword.TabStop = false;
            tb_UserPassword.TextAlign = HorizontalAlignment.Left;
            tb_UserPassword.TrailingIcon = null;
            tb_UserPassword.UseSystemPasswordChar = false;
            // 
            // lbl_UserLogin
            // 
            lbl_UserLogin.AutoSize = true;
            lbl_UserLogin.BackColor = Color.White;
            lbl_UserLogin.Font = new Font("Poppins", 12F);
            lbl_UserLogin.Location = new Point(25, 43);
            lbl_UserLogin.Name = "lbl_UserLogin";
            lbl_UserLogin.Size = new Size(117, 36);
            lbl_UserLogin.TabIndex = 54;
            lbl_UserLogin.Text = "User Login";
            // 
            // pnl_TeacherEnabled
            // 
            pnl_TeacherEnabled.BackColor = Color.White;
            pnl_TeacherEnabled.Controls.Add(tb_Specialization);
            pnl_TeacherEnabled.Controls.Add(tb_Department);
            pnl_TeacherEnabled.Enabled = false;
            pnl_TeacherEnabled.Location = new Point(37, 527);
            pnl_TeacherEnabled.Margin = new Padding(3, 4, 3, 4);
            pnl_TeacherEnabled.Name = "pnl_TeacherEnabled";
            pnl_TeacherEnabled.Size = new Size(326, 191);
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
            tb_Specialization.Location = new Point(0, 107);
            tb_Specialization.Margin = new Padding(3, 5, 3, 5);
            tb_Specialization.MaxLength = 32767;
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
            tb_Specialization.Size = new Size(286, 48);
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
            tb_Department.Location = new Point(0, 20);
            tb_Department.Margin = new Padding(3, 5, 3, 5);
            tb_Department.MaxLength = 32767;
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
            tb_Department.Size = new Size(286, 48);
            tb_Department.TabIndex = 42;
            tb_Department.TabStop = false;
            tb_Department.TextAlign = HorizontalAlignment.Left;
            tb_Department.TrailingIcon = null;
            tb_Department.UseSystemPasswordChar = false;
            // 
            // pnl_UserDetails
            // 
            pnl_UserDetails.BackgroundFillColor = Color.White;
            pnl_UserDetails.BorderColor = Color.White;
            pnl_UserDetails.Controls.Add(tb_Lastname);
            pnl_UserDetails.Controls.Add(pnl_TeacherEnabled);
            pnl_UserDetails.Controls.Add(tb_Firstname);
            pnl_UserDetails.Controls.Add(dt_BirthDate);
            pnl_UserDetails.Controls.Add(poisonComboBox1);
            pnl_UserDetails.Controls.Add(btn_Next);
            pnl_UserDetails.Controls.Add(lbl_Name);
            pnl_UserDetails.Controls.Add(lbl_bod);
            pnl_UserDetails.Controls.Add(tb_Address);
            pnl_UserDetails.Controls.Add(lbl_Gender);
            pnl_UserDetails.Controls.Add(tb_Phone);
            pnl_UserDetails.Controls.Add(tb_Email);
            pnl_UserDetails.Location = new Point(2, 61);
            pnl_UserDetails.Margin = new Padding(3, 4, 3, 4);
            pnl_UserDetails.Name = "pnl_UserDetails";
            pnl_UserDetails.Size = new Size(651, 756);
            pnl_UserDetails.TabIndex = 55;
            // 
            // pnl_UserLogin
            // 
            pnl_UserLogin.BackgroundFillColor = Color.White;
            pnl_UserLogin.BorderColor = Color.White;
            pnl_UserLogin.Controls.Add(tb_UserLogin);
            pnl_UserLogin.Controls.Add(lbl_UserLogin);
            pnl_UserLogin.Controls.Add(tb_UserPassword);
            pnl_UserLogin.Controls.Add(btn_Confirm);
            pnl_UserLogin.Controls.Add(btn_Back);
            pnl_UserLogin.Location = new Point(670, 64);
            pnl_UserLogin.Margin = new Padding(3, 4, 3, 4);
            pnl_UserLogin.Name = "pnl_UserLogin";
            pnl_UserLogin.Size = new Size(330, 364);
            pnl_UserLogin.TabIndex = 56;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 245);
            ClientSize = new Size(1014, 815);
            Controls.Add(pnl_UserLogin);
            Controls.Add(pnl_UserDetails);
            Controls.Add(hope_UserAdd);
            Controls.Add(pnl_LineDesign);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2194, 1387);
            MinimumSize = new Size(190, 40);
            Name = "UserAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAdd";
            pnl_TeacherEnabled.ResumeLayout(false);
            pnl_UserDetails.ResumeLayout(false);
            pnl_UserDetails.PerformLayout();
            pnl_UserLogin.ResumeLayout(false);
            pnl_UserLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_UserAdd;
        private Panel pnl_LineDesign;
        private ReaLTaiizor.Controls.MaterialButton btn_Back;
        private ReaLTaiizor.Controls.MaterialButton btn_Confirm;
        private ReaLTaiizor.Controls.MaterialButton btn_Next;
        private Label lbl_Gender;
        private Label lbl_bod;
        private Label lbl_Name;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private ReaLTaiizor.Controls.PoisonDateTime dt_BirthDate;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Address;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Phone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Email;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Lastname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Firstname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_UserLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_UserPassword;
        private Label lbl_UserLogin;
        private Panel pnl_TeacherEnabled;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Specialization;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Department;
        private UI.SPanel pnl_UserDetails;
        private UI.SPanel pnl_UserLogin;
    }
}
