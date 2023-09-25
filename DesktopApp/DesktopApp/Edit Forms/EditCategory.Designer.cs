namespace DesktopApp
{
    partial class EditCategory
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
            this.EditDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.EditCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.EditDepartmentLabel = new System.Windows.Forms.Label();
            this.EditCategoryNameLabel = new System.Windows.Forms.Label();
            this.EditCategoryBackButton = new System.Windows.Forms.Button();
            this.SaveEditCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditDepartmentComboBox
            // 
            this.EditDepartmentComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditDepartmentComboBox.FormattingEnabled = true;
            this.EditDepartmentComboBox.Location = new System.Drawing.Point(96, 315);
            this.EditDepartmentComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditDepartmentComboBox.Name = "EditDepartmentComboBox";
            this.EditDepartmentComboBox.Size = new System.Drawing.Size(244, 33);
            this.EditDepartmentComboBox.TabIndex = 21;
            // 
            // EditCategoryNameTextBox
            // 
            this.EditCategoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditCategoryNameTextBox.Location = new System.Drawing.Point(96, 146);
            this.EditCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCategoryNameTextBox.Name = "EditCategoryNameTextBox";
            this.EditCategoryNameTextBox.Size = new System.Drawing.Size(244, 31);
            this.EditCategoryNameTextBox.TabIndex = 20;
            // 
            // EditDepartmentLabel
            // 
            this.EditDepartmentLabel.AutoSize = true;
            this.EditDepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditDepartmentLabel.Location = new System.Drawing.Point(146, 231);
            this.EditDepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditDepartmentLabel.Name = "EditDepartmentLabel";
            this.EditDepartmentLabel.Size = new System.Drawing.Size(137, 30);
            this.EditDepartmentLabel.TabIndex = 19;
            this.EditDepartmentLabel.Text = "Department:";
            // 
            // EditCategoryNameLabel
            // 
            this.EditCategoryNameLabel.AutoSize = true;
            this.EditCategoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditCategoryNameLabel.Location = new System.Drawing.Point(126, 79);
            this.EditCategoryNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditCategoryNameLabel.Name = "EditCategoryNameLabel";
            this.EditCategoryNameLabel.Size = new System.Drawing.Size(172, 30);
            this.EditCategoryNameLabel.TabIndex = 18;
            this.EditCategoryNameLabel.Text = "Category Name:";
            // 
            // EditCategoryBackButton
            // 
            this.EditCategoryBackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditCategoryBackButton.Location = new System.Drawing.Point(251, 392);
            this.EditCategoryBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCategoryBackButton.Name = "EditCategoryBackButton";
            this.EditCategoryBackButton.Size = new System.Drawing.Size(122, 60);
            this.EditCategoryBackButton.TabIndex = 23;
            this.EditCategoryBackButton.Text = "Back";
            this.EditCategoryBackButton.UseVisualStyleBackColor = true;
            // 
            // SaveEditCategoryButton
            // 
            this.SaveEditCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEditCategoryButton.Location = new System.Drawing.Point(58, 392);
            this.SaveEditCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveEditCategoryButton.Name = "SaveEditCategoryButton";
            this.SaveEditCategoryButton.Size = new System.Drawing.Size(122, 60);
            this.SaveEditCategoryButton.TabIndex = 22;
            this.SaveEditCategoryButton.Text = "Save";
            this.SaveEditCategoryButton.UseVisualStyleBackColor = true;
            this.SaveEditCategoryButton.Click += new System.EventHandler(this.SaveEditCategoryButton_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 518);
            this.Controls.Add(this.EditCategoryBackButton);
            this.Controls.Add(this.SaveEditCategoryButton);
            this.Controls.Add(this.EditDepartmentComboBox);
            this.Controls.Add(this.EditCategoryNameTextBox);
            this.Controls.Add(this.EditDepartmentLabel);
            this.Controls.Add(this.EditCategoryNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox EditDepartmentComboBox;
        private TextBox EditCategoryNameTextBox;
        private Label EditDepartmentLabel;
        private Label EditCategoryNameLabel;
        private Button EditCategoryBackButton;
        private Button SaveEditCategoryButton;
    }
}