namespace DesktopApp
{
	partial class DepartmentInfo
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
			ShowAllDepartmentsButton = new Button();
			DeleteDepartmentButton = new Button();
			EditDepartmentButton = new Button();
			CreateDepartmentButton = new Button();
			dgvDepartment = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
			SuspendLayout();
			// 
			// ShowAllDepartmentsButton
			// 
			ShowAllDepartmentsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ShowAllDepartmentsButton.Location = new Point(1153, 569);
			ShowAllDepartmentsButton.Margin = new Padding(3, 4, 3, 4);
			ShowAllDepartmentsButton.Name = "ShowAllDepartmentsButton";
			ShowAllDepartmentsButton.Size = new Size(195, 61);
			ShowAllDepartmentsButton.TabIndex = 15;
			ShowAllDepartmentsButton.Text = "Show All ";
			ShowAllDepartmentsButton.UseVisualStyleBackColor = true;
			ShowAllDepartmentsButton.Click += ShowAllDepartmentsButton_Click;
			// 
			// DeleteDepartmentButton
			// 
			DeleteDepartmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteDepartmentButton.Location = new Point(489, 569);
			DeleteDepartmentButton.Margin = new Padding(3, 4, 3, 4);
			DeleteDepartmentButton.Name = "DeleteDepartmentButton";
			DeleteDepartmentButton.Size = new Size(195, 61);
			DeleteDepartmentButton.TabIndex = 14;
			DeleteDepartmentButton.Text = "Delete ";
			DeleteDepartmentButton.UseVisualStyleBackColor = true;
			DeleteDepartmentButton.Click += DeleteDepartmentButton_Click;
			// 
			// EditDepartmentButton
			// 
			EditDepartmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			EditDepartmentButton.Location = new Point(268, 569);
			EditDepartmentButton.Margin = new Padding(3, 4, 3, 4);
			EditDepartmentButton.Name = "EditDepartmentButton";
			EditDepartmentButton.Size = new Size(195, 61);
			EditDepartmentButton.TabIndex = 13;
			EditDepartmentButton.Text = "Edit ";
			EditDepartmentButton.UseVisualStyleBackColor = true;
			EditDepartmentButton.Click += EditDepartmentButton_Click;
			// 
			// CreateDepartmentButton
			// 
			CreateDepartmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			CreateDepartmentButton.Location = new Point(48, 569);
			CreateDepartmentButton.Margin = new Padding(3, 4, 3, 4);
			CreateDepartmentButton.Name = "CreateDepartmentButton";
			CreateDepartmentButton.Size = new Size(195, 61);
			CreateDepartmentButton.TabIndex = 16;
			CreateDepartmentButton.Text = "Create";
			CreateDepartmentButton.UseVisualStyleBackColor = true;
			CreateDepartmentButton.Click += CreateDepartmentButton_Click;
			// 
			// dgvDepartment
			// 
			dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDepartment.Location = new Point(50, 119);
			dgvDepartment.Name = "dgvDepartment";
			dgvDepartment.RowHeadersWidth = 51;
			dgvDepartment.RowTemplate.Height = 29;
			dgvDepartment.Size = new Size(1300, 443);
			dgvDepartment.TabIndex = 17;
			// 
			// DepartmentInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvDepartment);
			Controls.Add(CreateDepartmentButton);
			Controls.Add(ShowAllDepartmentsButton);
			Controls.Add(DeleteDepartmentButton);
			Controls.Add(EditDepartmentButton);
			Name = "DepartmentInfo";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button ShowAllDepartmentsButton;
		private Button DeleteDepartmentButton;
		private Button EditDepartmentButton;
		private Button CreateDepartmentButton;
		private DataGridView dgvDepartment;
	}
}