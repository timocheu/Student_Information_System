namespace Student_Information_System.Forms
{
    partial class CourseAdd
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            hope_CourseAdd = new ReaLTaiizor.Forms.HopeForm();
            pnl_UserDetails = new Student_Information_System.UI.SPanel();
            btn_Back = new ReaLTaiizor.Controls.MaterialButton();
            btn_ConfirmAdd = new ReaLTaiizor.Controls.MaterialButton();
            lbl_Assign = new Label();
            dgv_Teachers = new ReaLTaiizor.Controls.PoisonDataGridView();
            tb_CourseDepartment = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_CourseDescription = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cb_Credits = new ReaLTaiizor.Controls.PoisonComboBox();
            btn_UpdateUserDetail = new ReaLTaiizor.Controls.MaterialButton();
            tb_CourseCode = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_CourseName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_Name = new Label();
            lbl_CourseCredits = new Label();
            pnl_UserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).BeginInit();
            SuspendLayout();
            // 
            // hope_CourseAdd
            // 
            hope_CourseAdd.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hope_CourseAdd.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hope_CourseAdd.ControlBoxColorN = Color.White;
            hope_CourseAdd.Dock = DockStyle.Top;
            hope_CourseAdd.Font = new Font("Poppins", 14.25F);
            hope_CourseAdd.ForeColor = Color.FromArgb(242, 246, 252);
            hope_CourseAdd.Image = Properties.Resources.FormIcon;
            hope_CourseAdd.Location = new Point(0, 0);
            hope_CourseAdd.MaximizeBox = false;
            hope_CourseAdd.Name = "hope_CourseAdd";
            hope_CourseAdd.Size = new Size(800, 40);
            hope_CourseAdd.TabIndex = 3;
            hope_CourseAdd.Text = "Add Course";
            hope_CourseAdd.ThemeColor = Color.Chocolate;
            // 
            // pnl_UserDetails
            // 
            pnl_UserDetails.BackColor = Color.Transparent;
            pnl_UserDetails.BackgroundFillColor = Color.White;
            pnl_UserDetails.BorderColor = Color.White;
            pnl_UserDetails.Controls.Add(btn_Back);
            pnl_UserDetails.Controls.Add(btn_ConfirmAdd);
            pnl_UserDetails.Controls.Add(lbl_Assign);
            pnl_UserDetails.Controls.Add(dgv_Teachers);
            pnl_UserDetails.Controls.Add(tb_CourseDepartment);
            pnl_UserDetails.Controls.Add(tb_CourseDescription);
            pnl_UserDetails.Controls.Add(cb_Credits);
            pnl_UserDetails.Controls.Add(btn_UpdateUserDetail);
            pnl_UserDetails.Controls.Add(tb_CourseCode);
            pnl_UserDetails.Controls.Add(tb_CourseName);
            pnl_UserDetails.Controls.Add(lbl_Name);
            pnl_UserDetails.Controls.Add(lbl_CourseCredits);
            pnl_UserDetails.Location = new Point(28, 58);
            pnl_UserDetails.Name = "pnl_UserDetails";
            pnl_UserDetails.Size = new Size(745, 480);
            pnl_UserDetails.TabIndex = 57;
            // 
            // btn_Back
            // 
            btn_Back.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Back.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_Back.Depth = 0;
            btn_Back.Font = new Font("Poppins", 9F);
            btn_Back.HighEmphasis = true;
            btn_Back.Icon = null;
            btn_Back.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Back.Location = new Point(32, 417);
            btn_Back.Margin = new Padding(4, 6, 4, 6);
            btn_Back.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Back.Name = "btn_Back";
            btn_Back.NoAccentTextColor = Color.Empty;
            btn_Back.Size = new Size(64, 36);
            btn_Back.TabIndex = 69;
            btn_Back.Text = "Back";
            btn_Back.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Back.UseAccentColor = false;
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_ConfirmAdd
            // 
            btn_ConfirmAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ConfirmAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_ConfirmAdd.Depth = 0;
            btn_ConfirmAdd.Font = new Font("Poppins", 9F);
            btn_ConfirmAdd.HighEmphasis = true;
            btn_ConfirmAdd.Icon = null;
            btn_ConfirmAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_ConfirmAdd.Location = new Point(631, 417);
            btn_ConfirmAdd.Margin = new Padding(4, 6, 4, 6);
            btn_ConfirmAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_ConfirmAdd.Name = "btn_ConfirmAdd";
            btn_ConfirmAdd.NoAccentTextColor = Color.Empty;
            btn_ConfirmAdd.Size = new Size(86, 36);
            btn_ConfirmAdd.TabIndex = 68;
            btn_ConfirmAdd.Text = "Confirm";
            btn_ConfirmAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ConfirmAdd.UseAccentColor = true;
            btn_ConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // lbl_Assign
            // 
            lbl_Assign.AutoSize = true;
            lbl_Assign.Font = new Font("Poppins", 14F);
            lbl_Assign.Location = new Point(299, 121);
            lbl_Assign.Name = "lbl_Assign";
            lbl_Assign.Size = new Size(178, 34);
            lbl_Assign.TabIndex = 67;
            lbl_Assign.Text = "Assign Instructor:";
            // 
            // dgv_Teachers
            // 
            dgv_Teachers.AllowUserToAddRows = false;
            dgv_Teachers.AllowUserToDeleteRows = false;
            dgv_Teachers.AllowUserToResizeColumns = false;
            dgv_Teachers.AllowUserToResizeRows = false;
            dgv_Teachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Teachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Teachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_Teachers.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_Teachers.BorderStyle = BorderStyle.None;
            dgv_Teachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Teachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Teachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(54, 57, 64);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Teachers.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Teachers.EnableHeadersVisualStyles = false;
            dgv_Teachers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_Teachers.GridColor = Color.Black;
            dgv_Teachers.Location = new Point(299, 159);
            dgv_Teachers.Name = "dgv_Teachers";
            dgv_Teachers.ReadOnly = true;
            dgv_Teachers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Teachers.RowHeadersVisible = false;
            dgv_Teachers.RowHeadersWidth = 20;
            dgv_Teachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Teachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teachers.Size = new Size(418, 242);
            dgv_Teachers.TabIndex = 66;
            dgv_Teachers.UseCustomBackColor = true;
            dgv_Teachers.UseCustomForeColor = true;
            dgv_Teachers.UseStyleColors = true;
            // 
            // tb_CourseDepartment
            // 
            tb_CourseDepartment.AnimateReadOnly = false;
            tb_CourseDepartment.AutoCompleteMode = AutoCompleteMode.None;
            tb_CourseDepartment.AutoCompleteSource = AutoCompleteSource.None;
            tb_CourseDepartment.BackgroundImageLayout = ImageLayout.None;
            tb_CourseDepartment.CharacterCasing = CharacterCasing.Normal;
            tb_CourseDepartment.Depth = 0;
            tb_CourseDepartment.Enabled = false;
            tb_CourseDepartment.Font = new Font("Poppins", 12F);
            tb_CourseDepartment.HideSelection = true;
            tb_CourseDepartment.Hint = "Course Department";
            tb_CourseDepartment.LeadingIcon = null;
            tb_CourseDepartment.Location = new Point(32, 198);
            tb_CourseDepartment.Margin = new Padding(3, 4, 3, 4);
            tb_CourseDepartment.MaxLength = 100;
            tb_CourseDepartment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_CourseDepartment.Name = "tb_CourseDepartment";
            tb_CourseDepartment.PasswordChar = '\0';
            tb_CourseDepartment.PrefixSuffixText = null;
            tb_CourseDepartment.ReadOnly = false;
            tb_CourseDepartment.RightToLeft = RightToLeft.No;
            tb_CourseDepartment.SelectedText = "";
            tb_CourseDepartment.SelectionLength = 0;
            tb_CourseDepartment.SelectionStart = 0;
            tb_CourseDepartment.ShortcutsEnabled = true;
            tb_CourseDepartment.Size = new Size(250, 48);
            tb_CourseDepartment.TabIndex = 65;
            tb_CourseDepartment.TabStop = false;
            tb_CourseDepartment.TextAlign = HorizontalAlignment.Left;
            tb_CourseDepartment.TrailingIcon = null;
            tb_CourseDepartment.UseSystemPasswordChar = false;
            // 
            // tb_CourseDescription
            // 
            tb_CourseDescription.AnimateReadOnly = false;
            tb_CourseDescription.BackgroundImageLayout = ImageLayout.None;
            tb_CourseDescription.CharacterCasing = CharacterCasing.Normal;
            tb_CourseDescription.Depth = 0;
            tb_CourseDescription.HideSelection = true;
            tb_CourseDescription.Hint = "Course Description";
            tb_CourseDescription.Location = new Point(32, 263);
            tb_CourseDescription.MaxLength = 250;
            tb_CourseDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_CourseDescription.Name = "tb_CourseDescription";
            tb_CourseDescription.PasswordChar = '\0';
            tb_CourseDescription.ReadOnly = false;
            tb_CourseDescription.ScrollBars = ScrollBars.None;
            tb_CourseDescription.SelectedText = "";
            tb_CourseDescription.SelectionLength = 0;
            tb_CourseDescription.SelectionStart = 0;
            tb_CourseDescription.ShortcutsEnabled = true;
            tb_CourseDescription.Size = new Size(250, 138);
            tb_CourseDescription.TabIndex = 64;
            tb_CourseDescription.TabStop = false;
            tb_CourseDescription.TextAlign = HorizontalAlignment.Left;
            tb_CourseDescription.UseSystemPasswordChar = false;
            // 
            // cb_Credits
            // 
            cb_Credits.DisplayMember = "Male";
            cb_Credits.Font = new Font("Poppins", 12F);
            cb_Credits.FormattingEnabled = true;
            cb_Credits.ItemHeight = 32;
            cb_Credits.Items.AddRange(new object[] { "1", "2", "3" });
            cb_Credits.Location = new Point(471, 70);
            cb_Credits.Name = "cb_Credits";
            cb_Credits.PromptText = "1";
            cb_Credits.Size = new Size(56, 38);
            cb_Credits.TabIndex = 61;
            cb_Credits.Text = "1";
            cb_Credits.UseCustomFont = true;
            cb_Credits.UseSelectable = true;
            // 
            // btn_UpdateUserDetail
            // 
            btn_UpdateUserDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_UpdateUserDetail.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btn_UpdateUserDetail.Depth = 0;
            btn_UpdateUserDetail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // 
            // tb_CourseCode
            // 
            tb_CourseCode.AnimateReadOnly = false;
            tb_CourseCode.AutoCompleteMode = AutoCompleteMode.None;
            tb_CourseCode.AutoCompleteSource = AutoCompleteSource.None;
            tb_CourseCode.BackgroundImageLayout = ImageLayout.None;
            tb_CourseCode.CharacterCasing = CharacterCasing.Normal;
            tb_CourseCode.Depth = 0;
            tb_CourseCode.Font = new Font("Poppins", 12F);
            tb_CourseCode.HideSelection = true;
            tb_CourseCode.Hint = "Course Code";
            tb_CourseCode.LeadingIcon = null;
            tb_CourseCode.Location = new Point(32, 133);
            tb_CourseCode.Margin = new Padding(3, 4, 3, 4);
            tb_CourseCode.MaxLength = 100;
            tb_CourseCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_CourseCode.Name = "tb_CourseCode";
            tb_CourseCode.PasswordChar = '\0';
            tb_CourseCode.PrefixSuffixText = null;
            tb_CourseCode.ReadOnly = false;
            tb_CourseCode.RightToLeft = RightToLeft.No;
            tb_CourseCode.SelectedText = "";
            tb_CourseCode.SelectionLength = 0;
            tb_CourseCode.SelectionStart = 0;
            tb_CourseCode.ShortcutsEnabled = true;
            tb_CourseCode.Size = new Size(250, 48);
            tb_CourseCode.TabIndex = 39;
            tb_CourseCode.TabStop = false;
            tb_CourseCode.TextAlign = HorizontalAlignment.Left;
            tb_CourseCode.TrailingIcon = null;
            tb_CourseCode.UseSystemPasswordChar = false;
            // 
            // tb_CourseName
            // 
            tb_CourseName.AnimateReadOnly = false;
            tb_CourseName.AutoCompleteMode = AutoCompleteMode.None;
            tb_CourseName.AutoCompleteSource = AutoCompleteSource.None;
            tb_CourseName.BackgroundImageLayout = ImageLayout.None;
            tb_CourseName.CharacterCasing = CharacterCasing.Normal;
            tb_CourseName.Depth = 0;
            tb_CourseName.Font = new Font("Poppins", 12F);
            tb_CourseName.HideSelection = true;
            tb_CourseName.Hint = "Course Name";
            tb_CourseName.LeadingIcon = null;
            tb_CourseName.Location = new Point(32, 70);
            tb_CourseName.Margin = new Padding(3, 4, 3, 4);
            tb_CourseName.MaxLength = 100;
            tb_CourseName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_CourseName.Name = "tb_CourseName";
            tb_CourseName.PasswordChar = '\0';
            tb_CourseName.PrefixSuffixText = null;
            tb_CourseName.ReadOnly = false;
            tb_CourseName.RightToLeft = RightToLeft.No;
            tb_CourseName.SelectedText = "";
            tb_CourseName.SelectionLength = 0;
            tb_CourseName.SelectionStart = 0;
            tb_CourseName.ShortcutsEnabled = true;
            tb_CourseName.Size = new Size(250, 48);
            tb_CourseName.TabIndex = 38;
            tb_CourseName.TabStop = false;
            tb_CourseName.TextAlign = HorizontalAlignment.Left;
            tb_CourseName.TrailingIcon = null;
            tb_CourseName.UseSystemPasswordChar = false;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.BackColor = Color.White;
            lbl_Name.Font = new Font("Poppins", 16F);
            lbl_Name.Location = new Point(32, 27);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(174, 39);
            lbl_Name.TabIndex = 45;
            lbl_Name.Text = "Course details";
            // 
            // lbl_CourseCredits
            // 
            lbl_CourseCredits.AutoSize = true;
            lbl_CourseCredits.Font = new Font("Poppins", 14F);
            lbl_CourseCredits.Location = new Point(299, 74);
            lbl_CourseCredits.Name = "lbl_CourseCredits";
            lbl_CourseCredits.Size = new Size(166, 34);
            lbl_CourseCredits.TabIndex = 62;
            lbl_CourseCredits.Text = "Course Credits: ";
            // 
            // CourseAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(pnl_UserDetails);
            Controls.Add(hope_CourseAdd);
            Font = new Font("Poppins", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1525);
            MinimumSize = new Size(190, 40);
            Name = "CourseAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseAdd";
            pnl_UserDetails.ResumeLayout(false);
            pnl_UserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hope_CourseAdd;
        private UI.SPanel pnl_UserDetails;
        private ReaLTaiizor.Controls.MaterialButton btn_UpdateUserDetail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_CourseCode;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_CourseName;
        private Label lbl_Name;
        private ReaLTaiizor.Controls.PoisonComboBox cb_Credits;
        private Label lbl_CourseCredits;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit tb_CourseDescription;
        private Label lbl_Assign;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_Teachers;
        private ReaLTaiizor.Controls.MaterialButton btn_ConfirmAdd;
        private ReaLTaiizor.Controls.MaterialButton btn_Back;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_CourseDepartment;
    }
}