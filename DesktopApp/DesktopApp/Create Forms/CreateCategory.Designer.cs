namespace DesktopApp
{
    partial class CreateCategory
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
            CategoryNameLabel = new Label();
            DepartmentLabel = new Label();
            CreateCategoryBackButton = new Button();
            CreateCategotyButton = new Button();
            CategoryNameTextBox = new TextBox();
            DepartmentManagerComboBox = new ComboBox();
            SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            CategoryNameLabel.AutoSize = true;
            CategoryNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryNameLabel.Location = new Point(92, 78);
            CategoryNameLabel.Name = "CategoryNameLabel";
            CategoryNameLabel.Size = new Size(141, 23);
            CategoryNameLabel.TabIndex = 0;
            CategoryNameLabel.Text = "Category Name:";
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DepartmentLabel.Location = new Point(108, 200);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(113, 23);
            DepartmentLabel.TabIndex = 1;
            DepartmentLabel.Text = "Department:";
            // 
            // CreateCategoryBackButton
            // 
            CreateCategoryBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateCategoryBackButton.Location = new Point(195, 356);
            CreateCategoryBackButton.Name = "CreateCategoryBackButton";
            CreateCategoryBackButton.Size = new Size(98, 48);
            CreateCategoryBackButton.TabIndex = 15;
            CreateCategoryBackButton.Text = "Back";
            CreateCategoryBackButton.UseVisualStyleBackColor = true;
            CreateCategoryBackButton.Click += CreateCategoryBackButton_Click;
            // 
            // CreateCategotyButton
            // 
            CreateCategotyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateCategotyButton.Location = new Point(40, 356);
            CreateCategotyButton.Name = "CreateCategotyButton";
            CreateCategotyButton.Size = new Size(98, 48);
            CreateCategotyButton.TabIndex = 14;
            CreateCategotyButton.Text = "Create";
            CreateCategotyButton.UseVisualStyleBackColor = true;
            CreateCategotyButton.Click += CreateCategotyButton_Click;
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryNameTextBox.Location = new Point(68, 132);
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(196, 27);
            CategoryNameTextBox.TabIndex = 16;
            // 
            // DepartmentManagerComboBox
            // 
            DepartmentManagerComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DepartmentManagerComboBox.FormattingEnabled = true;
            DepartmentManagerComboBox.Location = new Point(68, 267);
            DepartmentManagerComboBox.Name = "DepartmentManagerComboBox";
            DepartmentManagerComboBox.Size = new Size(196, 28);
            DepartmentManagerComboBox.TabIndex = 17;
            // 
            // CreateCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 460);
            Controls.Add(DepartmentManagerComboBox);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(CreateCategoryBackButton);
            Controls.Add(CreateCategotyButton);
            Controls.Add(DepartmentLabel);
            Controls.Add(CategoryNameLabel);
            Name = "CreateCategory";
            Text = "CreateCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoryNameLabel;
        private Label DepartmentLabel;
        private Button CreateCategoryBackButton;
        private Button CreateCategotyButton;
        private TextBox CategoryNameTextBox;
        private ComboBox DepartmentManagerComboBox;
    }
}