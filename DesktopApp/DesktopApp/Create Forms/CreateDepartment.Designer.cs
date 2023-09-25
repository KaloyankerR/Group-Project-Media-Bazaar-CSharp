namespace DesktopApp
{
    partial class CreateDepartment
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
            CreateDeaprtmentButton = new Button();
            DepartmentNameTextBox = new TextBox();
            NameDepLabel = new Label();
            CreateDepartmentBackButton = new Button();
            SuspendLayout();
            // 
            // CreateDeaprtmentButton
            // 
            CreateDeaprtmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateDeaprtmentButton.Location = new Point(37, 200);
            CreateDeaprtmentButton.Name = "CreateDeaprtmentButton";
            CreateDeaprtmentButton.Size = new Size(98, 48);
            CreateDeaprtmentButton.TabIndex = 12;
            CreateDeaprtmentButton.Text = "Create";
            CreateDeaprtmentButton.UseVisualStyleBackColor = true;
            CreateDeaprtmentButton.Click += CreateDeaprtmentButton_Click;
            // 
            // DepartmentNameTextBox
            // 
            DepartmentNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DepartmentNameTextBox.Location = new Point(63, 115);
            DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            DepartmentNameTextBox.Size = new Size(196, 27);
            DepartmentNameTextBox.TabIndex = 9;
            // 
            // NameDepLabel
            // 
            NameDepLabel.AutoSize = true;
            NameDepLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameDepLabel.Location = new Point(88, 60);
            NameDepLabel.Name = "NameDepLabel";
            NameDepLabel.Size = new Size(144, 20);
            NameDepLabel.TabIndex = 11;
            NameDepLabel.Text = "Department Name:";
            // 
            // CreateDepartmentBackButton
            // 
            CreateDepartmentBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateDepartmentBackButton.Location = new Point(192, 200);
            CreateDepartmentBackButton.Name = "CreateDepartmentBackButton";
            CreateDepartmentBackButton.Size = new Size(98, 48);
            CreateDepartmentBackButton.TabIndex = 13;
            CreateDepartmentBackButton.Text = "Back";
            CreateDepartmentBackButton.UseVisualStyleBackColor = true;
            CreateDepartmentBackButton.Click += CreateDepartmentBackButton_Click;
            // 
            // CreateDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 281);
            Controls.Add(CreateDepartmentBackButton);
            Controls.Add(CreateDeaprtmentButton);
            Controls.Add(DepartmentNameTextBox);
            Controls.Add(NameDepLabel);
            Name = "CreateDepartment";
            Text = "CreateDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateDeaprtmentButton;
        private TextBox DepartmentNameTextBox;
        private Label NameDepLabel;
        private Button CreateDepartmentBackButton;
    }
}