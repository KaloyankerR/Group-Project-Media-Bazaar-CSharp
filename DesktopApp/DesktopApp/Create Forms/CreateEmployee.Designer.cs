namespace DesktopApp
{
    partial class CreateEmployee
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
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DAOLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.CreateEmployeeBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.tbxHouseNr = new System.Windows.Forms.TextBox();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbxDepartment.Location = new System.Drawing.Point(107, 171);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(215, 21);
            this.cbxDepartment.TabIndex = 33;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxStreetName.Location = new System.Drawing.Point(452, 17);
            this.tbxStreetName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(215, 19);
            this.tbxStreetName.TabIndex = 32;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(107, 137);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(215, 19);
            this.dtpDateOfBirth.TabIndex = 18;
            // 
            // cbxUserType
            // 
            this.cbxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbxUserType.Location = new System.Drawing.Point(107, 206);
            this.cbxUserType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(215, 21);
            this.cbxUserType.TabIndex = 17;
            this.cbxUserType.SelectedIndexChanged += new System.EventHandler(this.cbxUserType_SelectedIndexChanged);
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepartmentLabel.Location = new System.Drawing.Point(12, 171);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(76, 13);
            this.DepartmentLabel.TabIndex = 30;
            this.DepartmentLabel.Text = "Department:";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdressLabel.Location = new System.Drawing.Point(354, 20);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(79, 13);
            this.AdressLabel.TabIndex = 29;
            this.AdressLabel.Text = "Street name:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.Location = new System.Drawing.Point(12, 209);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(65, 13);
            this.TypeLabel.TabIndex = 28;
            this.TypeLabel.Text = "User type:";
            // 
            // DAOLabel
            // 
            this.DAOLabel.AutoSize = true;
            this.DAOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DAOLabel.Location = new System.Drawing.Point(12, 142);
            this.DAOLabel.Name = "DAOLabel";
            this.DAOLabel.Size = new System.Drawing.Size(85, 13);
            this.DAOLabel.TabIndex = 27;
            this.DAOLabel.Text = "Date Of Birth:";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(12, 246);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(82, 34);
            this.createButton.TabIndex = 25;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPassword.Location = new System.Drawing.Point(107, 73);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(215, 19);
            this.tbxPassword.TabIndex = 24;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxLastName.Location = new System.Drawing.Point(107, 40);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(215, 19);
            this.tbxLastName.TabIndex = 22;
            // 
            // tbxFName
            // 
            this.tbxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFName.Location = new System.Drawing.Point(107, 14);
            this.tbxFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(215, 19);
            this.tbxFName.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(12, 79);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 13);
            this.passwordLabel.TabIndex = 23;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(12, 46);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(69, 13);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Last name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "First name:";
            // 
            // CreateEmployeeBackButton
            // 
            this.CreateEmployeeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateEmployeeBackButton.Location = new System.Drawing.Point(123, 246);
            this.CreateEmployeeBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateEmployeeBackButton.Name = "CreateEmployeeBackButton";
            this.CreateEmployeeBackButton.Size = new System.Drawing.Size(82, 34);
            this.CreateEmployeeBackButton.TabIndex = 34;
            this.CreateEmployeeBackButton.Text = "Cancel";
            this.CreateEmployeeBackButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeBackButton.Click += new System.EventHandler(this.CreateEmployeeBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "House number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "ZIP code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(354, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(354, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "BSN:";
            // 
            // tbxBSN
            // 
            this.tbxBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxBSN.Location = new System.Drawing.Point(107, 104);
            this.tbxBSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(215, 19);
            this.tbxBSN.TabIndex = 40;
            // 
            // tbxHouseNr
            // 
            this.tbxHouseNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxHouseNr.Location = new System.Drawing.Point(452, 46);
            this.tbxHouseNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxHouseNr.Name = "tbxHouseNr";
            this.tbxHouseNr.Size = new System.Drawing.Size(215, 19);
            this.tbxHouseNr.TabIndex = 41;
            // 
            // tbxZIP
            // 
            this.tbxZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxZIP.Location = new System.Drawing.Point(452, 76);
            this.tbxZIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.Size = new System.Drawing.Size(215, 19);
            this.tbxZIP.TabIndex = 42;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCity.Location = new System.Drawing.Point(452, 107);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(215, 19);
            this.tbxCity.TabIndex = 43;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCountry.Location = new System.Drawing.Point(452, 140);
            this.tbxCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(215, 19);
            this.tbxCountry.TabIndex = 44;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPhone.Location = new System.Drawing.Point(452, 173);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(215, 19);
            this.tbxPhone.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(354, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Phone number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(354, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Gender:";
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbxGender.Location = new System.Drawing.Point(452, 209);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(215, 21);
            this.cbxGender.TabIndex = 49;
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 291);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxCountry);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxZIP);
            this.Controls.Add(this.tbxHouseNr);
            this.Controls.Add(this.tbxBSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateEmployeeBackButton);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.tbxStreetName);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DAOLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(704, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(704, 330);
            this.Name = "CreateEmployee";
            this.Text = "CreateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbxDepartment;
        private TextBox tbxStreetName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbxUserType;
        private Label DepartmentLabel;
        private Label AdressLabel;
        private Label TypeLabel;
        private Label DAOLabel;
        private Button createButton;
        private TextBox tbxPassword;
        private TextBox tbxLastName;
        private TextBox tbxFName;
        private Label passwordLabel;
        private Label emailLabel;
        private Label nameLabel;
        private Button CreateEmployeeBackButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxBSN;
        private TextBox tbxHouseNr;
        private TextBox tbxZIP;
        private TextBox tbxCity;
        private TextBox tbxCountry;
        private TextBox tbxPhone;
        private Label label6;
        private Label label7;
        private ComboBox cbxGender;
    }
}