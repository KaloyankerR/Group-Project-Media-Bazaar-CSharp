namespace DesktopApp
{
    partial class EditDepartment
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
            EditDepartmentBackButton = new Button();
            SaveEditDepartmentButton = new Button();
            EditDepartmentNameTextBox = new TextBox();
            NameDepLabel = new Label();
            SuspendLayout();
            // 
            // EditDepartmentBackButton
            // 
            EditDepartmentBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditDepartmentBackButton.Location = new Point(184, 226);
            EditDepartmentBackButton.Name = "EditDepartmentBackButton";
            EditDepartmentBackButton.Size = new Size(98, 48);
            EditDepartmentBackButton.TabIndex = 19;
            EditDepartmentBackButton.Text = "Back";
            EditDepartmentBackButton.UseVisualStyleBackColor = true;
            EditDepartmentBackButton.Click += EditDepartmentBackButton_Click;
            // 
            // SaveEditDepartmentButton
            // 
            SaveEditDepartmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveEditDepartmentButton.Location = new Point(29, 226);
            SaveEditDepartmentButton.Name = "SaveEditDepartmentButton";
            SaveEditDepartmentButton.Size = new Size(98, 48);
            SaveEditDepartmentButton.TabIndex = 18;
            SaveEditDepartmentButton.Text = "Save";
            SaveEditDepartmentButton.UseVisualStyleBackColor = true;
            SaveEditDepartmentButton.Click += SaveEditDepartmentButton_Click;
            // 
            // EditDepartmentNameTextBox
            // 
            EditDepartmentNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditDepartmentNameTextBox.Location = new Point(59, 112);
            EditDepartmentNameTextBox.Name = "EditDepartmentNameTextBox";
            EditDepartmentNameTextBox.Size = new Size(196, 27);
            EditDepartmentNameTextBox.TabIndex = 15;
            // 
            // NameDepLabel
            // 
            NameDepLabel.AutoSize = true;
            NameDepLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameDepLabel.Location = new Point(84, 57);
            NameDepLabel.Name = "NameDepLabel";
            NameDepLabel.Size = new Size(144, 20);
            NameDepLabel.TabIndex = 17;
            NameDepLabel.Text = "Department Name:";
            // 
            // EditDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 325);
            Controls.Add(EditDepartmentBackButton);
            Controls.Add(SaveEditDepartmentButton);
            Controls.Add(EditDepartmentNameTextBox);
            Controls.Add(NameDepLabel);
            Name = "EditDepartment";
            Text = "EditDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditDepartmentBackButton;
        private Button SaveEditDepartmentButton;
        private TextBox EditDepartmentNameTextBox;
        private Label NameDepLabel;
    }
}