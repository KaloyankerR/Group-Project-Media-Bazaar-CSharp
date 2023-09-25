namespace DesktopApp.Edit_Forms
{
    partial class EditEmployee
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
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.tbxHouseNr = new System.Windows.Forms.TextBox();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditEmployeeBackButton = new System.Windows.Forms.Button();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DAOLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbxGender.Location = new System.Drawing.Point(646, 335);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(305, 28);
            this.cbxGender.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(506, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(506, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Phone number:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPhone.Location = new System.Drawing.Point(646, 275);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(305, 25);
            this.tbxPhone.TabIndex = 76;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCountry.Location = new System.Drawing.Point(646, 220);
            this.tbxCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(305, 25);
            this.tbxCountry.TabIndex = 75;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCity.Location = new System.Drawing.Point(646, 165);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(305, 25);
            this.tbxCity.TabIndex = 74;
            // 
            // tbxZIP
            // 
            this.tbxZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxZIP.Location = new System.Drawing.Point(646, 114);
            this.tbxZIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.Size = new System.Drawing.Size(305, 25);
            this.tbxZIP.TabIndex = 73;
            // 
            // tbxHouseNr
            // 
            this.tbxHouseNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxHouseNr.Location = new System.Drawing.Point(646, 64);
            this.tbxHouseNr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxHouseNr.Name = "tbxHouseNr";
            this.tbxHouseNr.Size = new System.Drawing.Size(305, 25);
            this.tbxHouseNr.TabIndex = 72;
            // 
            // tbxBSN
            // 
            this.tbxBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxBSN.Location = new System.Drawing.Point(153, 160);
            this.tbxBSN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(305, 25);
            this.tbxBSN.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "BSN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(506, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(506, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "ZIP code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(506, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "House number:";
            // 
            // EditEmployeeBackButton
            // 
            this.EditEmployeeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditEmployeeBackButton.Location = new System.Drawing.Point(176, 397);
            this.EditEmployeeBackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditEmployeeBackButton.Name = "EditEmployeeBackButton";
            this.EditEmployeeBackButton.Size = new System.Drawing.Size(117, 57);
            this.EditEmployeeBackButton.TabIndex = 65;
            this.EditEmployeeBackButton.Text = "Cancel";
            this.EditEmployeeBackButton.UseVisualStyleBackColor = true;
            this.EditEmployeeBackButton.Click += new System.EventHandler(this.EditEmployeeBackButton_Click);
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbxDepartment.Location = new System.Drawing.Point(153, 272);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(305, 28);
            this.cbxDepartment.TabIndex = 64;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxStreetName.Location = new System.Drawing.Point(646, 15);
            this.tbxStreetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(305, 25);
            this.tbxStreetName.TabIndex = 63;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(153, 215);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(305, 25);
            this.dtpDateOfBirth.TabIndex = 53;
            // 
            // cbxUserType
            // 
            this.cbxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbxUserType.Location = new System.Drawing.Point(153, 330);
            this.cbxUserType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(305, 28);
            this.cbxUserType.TabIndex = 52;
            this.cbxUserType.SelectedIndexChanged += new System.EventHandler(this.cbxUserType_SelectedIndexChanged);
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepartmentLabel.Location = new System.Drawing.Point(17, 272);
            this.DepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(109, 20);
            this.DepartmentLabel.TabIndex = 62;
            this.DepartmentLabel.Text = "Department:";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdressLabel.Location = new System.Drawing.Point(506, 20);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(113, 20);
            this.AdressLabel.TabIndex = 61;
            this.AdressLabel.Text = "Street name:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.Location = new System.Drawing.Point(17, 335);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(91, 20);
            this.TypeLabel.TabIndex = 60;
            this.TypeLabel.Text = "User type:";
            // 
            // DAOLabel
            // 
            this.DAOLabel.AutoSize = true;
            this.DAOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DAOLabel.Location = new System.Drawing.Point(17, 224);
            this.DAOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DAOLabel.Name = "DAOLabel";
            this.DAOLabel.Size = new System.Drawing.Size(120, 20);
            this.DAOLabel.TabIndex = 59;
            this.DAOLabel.Text = "Date Of Birth:";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(17, 397);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 57);
            this.editButton.TabIndex = 58;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPassword.Location = new System.Drawing.Point(153, 109);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(305, 25);
            this.tbxPassword.TabIndex = 57;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxLastName.Location = new System.Drawing.Point(153, 54);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(305, 25);
            this.tbxLastName.TabIndex = 55;
            // 
            // tbxFName
            // 
            this.tbxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFName.Location = new System.Drawing.Point(153, 10);
            this.tbxFName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(305, 25);
            this.tbxFName.TabIndex = 51;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(17, 119);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 20);
            this.passwordLabel.TabIndex = 56;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(17, 64);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(98, 20);
            this.emailLabel.TabIndex = 54;
            this.emailLabel.Text = "Last name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(17, 20);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 20);
            this.nameLabel.TabIndex = 50;
            this.nameLabel.Text = "First name:";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 467);
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
            this.Controls.Add(this.EditEmployeeBackButton);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.tbxStreetName);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DAOLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxGender;
        private Label label7;
        private Label label6;
        private TextBox tbxPhone;
        private TextBox tbxCountry;
        private TextBox tbxCity;
        private TextBox tbxZIP;
        private TextBox tbxHouseNr;
        private TextBox tbxBSN;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button EditEmployeeBackButton;
        private ComboBox cbxDepartment;
        private TextBox tbxStreetName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbxUserType;
        private Label DepartmentLabel;
        private Label AdressLabel;
        private Label TypeLabel;
        private Label DAOLabel;
        private Button editButton;
        private TextBox tbxPassword;
        private TextBox tbxLastName;
        private TextBox tbxFName;
        private Label passwordLabel;
        private Label emailLabel;
        private Label nameLabel;
    }
}