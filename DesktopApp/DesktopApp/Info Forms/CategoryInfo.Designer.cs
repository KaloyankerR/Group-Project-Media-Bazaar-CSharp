namespace DesktopApp.Info_Forms
{
	partial class CategoryInfo
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
			DepartmentInfoComboBox = new ComboBox();
			label12 = new Label();
			ShowAllCategoryButton = new Button();
			DeleteCategoryButton = new Button();
			EditCategoryButton = new Button();
			CreateCategoryButon = new Button();
			dgvCategory = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
			SuspendLayout();
			// 
			// DepartmentInfoComboBox
			// 
			DepartmentInfoComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DepartmentInfoComboBox.FormattingEnabled = true;
			DepartmentInfoComboBox.Location = new Point(242, 17);
			DepartmentInfoComboBox.Name = "DepartmentInfoComboBox";
			DepartmentInfoComboBox.Size = new Size(183, 26);
			DepartmentInfoComboBox.TabIndex = 8;
			DepartmentInfoComboBox.SelectedIndexChanged += DepartmentInfoComboBox_SelectedIndexChanged;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label12.Location = new Point(50, 16);
			label12.Name = "label12";
			label12.Size = new Size(141, 18);
			label12.TabIndex = 7;
			label12.Text = "Department name";
			// 
			// ShowAllCategoryButton
			// 
			ShowAllCategoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ShowAllCategoryButton.Location = new Point(1155, 569);
			ShowAllCategoryButton.Name = "ShowAllCategoryButton";
			ShowAllCategoryButton.Size = new Size(195, 61);
			ShowAllCategoryButton.TabIndex = 18;
			ShowAllCategoryButton.Text = "Show All Category";
			ShowAllCategoryButton.UseVisualStyleBackColor = true;
			ShowAllCategoryButton.Click += ShowAllCategoryButton_Click_1;
			// 
			// DeleteCategoryButton
			// 
			DeleteCategoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteCategoryButton.Location = new Point(489, 569);
			DeleteCategoryButton.Name = "DeleteCategoryButton";
			DeleteCategoryButton.Size = new Size(195, 61);
			DeleteCategoryButton.TabIndex = 17;
			DeleteCategoryButton.Text = "Delete ";
			DeleteCategoryButton.UseVisualStyleBackColor = true;
			DeleteCategoryButton.Click += DeleteCategoryButton_Click_1;
			// 
			// EditCategoryButton
			// 
			EditCategoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			EditCategoryButton.Location = new Point(268, 569);
			EditCategoryButton.Name = "EditCategoryButton";
			EditCategoryButton.Size = new Size(195, 61);
			EditCategoryButton.TabIndex = 16;
			EditCategoryButton.Text = "Edit ";
			EditCategoryButton.UseVisualStyleBackColor = true;
			EditCategoryButton.Click += EditCategoryButton_Click;
			// 
			// CreateCategoryButon
			// 
			CreateCategoryButon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			CreateCategoryButon.Location = new Point(48, 569);
			CreateCategoryButon.Name = "CreateCategoryButon";
			CreateCategoryButon.Size = new Size(195, 61);
			CreateCategoryButon.TabIndex = 19;
			CreateCategoryButon.Text = "Create";
			CreateCategoryButon.UseVisualStyleBackColor = true;
			CreateCategoryButon.Click += CreateCategoryButon_Click_1;
			// 
			// dgvCategory
			// 
			dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategory.Location = new Point(50, 119);
			dgvCategory.Name = "dgvCategory";
			dgvCategory.RowHeadersWidth = 51;
			dgvCategory.RowTemplate.Height = 29;
			dgvCategory.Size = new Size(1300, 443);
			dgvCategory.TabIndex = 20;
			// 
			// CategoryInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvCategory);
			Controls.Add(CreateCategoryButon);
			Controls.Add(ShowAllCategoryButton);
			Controls.Add(DeleteCategoryButton);
			Controls.Add(EditCategoryButton);
			Controls.Add(DepartmentInfoComboBox);
			Controls.Add(label12);
			Name = "CategoryInfo";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox DepartmentInfoComboBox;
		private Label label12;
		private Button ShowAllCategoryButton;
		private Button DeleteCategoryButton;
		private Button EditCategoryButton;
		private Button CreateCategoryButon;
		private DataGridView dgvCategory;
	}
}