namespace DesktopApp
{
	partial class EmployeeeInfo
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
			DeleteEmployeeButton = new Button();
			EditEmployeeButton = new Button();
			ShowAllEmployeeButton = new Button();
			label1 = new Label();
			cbxDepartment = new ComboBox();
			btnCreate = new Button();
			dgvUser = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
			SuspendLayout();
			// 
			// DeleteEmployeeButton
			// 
			DeleteEmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteEmployeeButton.Location = new Point(489, 569);
			DeleteEmployeeButton.Name = "DeleteEmployeeButton";
			DeleteEmployeeButton.Size = new Size(195, 61);
			DeleteEmployeeButton.TabIndex = 11;
			DeleteEmployeeButton.Text = "Delete ";
			DeleteEmployeeButton.UseVisualStyleBackColor = true;
			DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
			// 
			// EditEmployeeButton
			// 
			EditEmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			EditEmployeeButton.Location = new Point(268, 569);
			EditEmployeeButton.Name = "EditEmployeeButton";
			EditEmployeeButton.Size = new Size(195, 61);
			EditEmployeeButton.TabIndex = 10;
			EditEmployeeButton.Text = "Edit ";
			EditEmployeeButton.UseVisualStyleBackColor = true;
			EditEmployeeButton.Click += EditEmployeeButton_Click;
			// 
			// ShowAllEmployeeButton
			// 
			ShowAllEmployeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ShowAllEmployeeButton.Location = new Point(1155, 569);
			ShowAllEmployeeButton.Name = "ShowAllEmployeeButton";
			ShowAllEmployeeButton.Size = new Size(195, 61);
			ShowAllEmployeeButton.TabIndex = 12;
			ShowAllEmployeeButton.Text = "Show All ";
			ShowAllEmployeeButton.UseVisualStyleBackColor = true;
			ShowAllEmployeeButton.Click += ShowAllEmployeeButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(50, 16);
			label1.Name = "label1";
			label1.Size = new Size(106, 20);
			label1.TabIndex = 13;
			label1.Text = "Departament:";
			// 
			// cbxDepartment
			// 
			cbxDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			cbxDepartment.FormattingEnabled = true;
			cbxDepartment.Location = new Point(242, 17);
			cbxDepartment.Name = "cbxDepartment";
			cbxDepartment.Size = new Size(183, 28);
			cbxDepartment.TabIndex = 14;
			cbxDepartment.SelectedIndexChanged += cbxDepartment_SelectedIndexChanged;
			// 
			// btnCreate
			// 
			btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCreate.Location = new Point(48, 569);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(195, 61);
			btnCreate.TabIndex = 16;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// dgvUser
			// 
			dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUser.Location = new Point(50, 119);
			dgvUser.Margin = new Padding(3, 4, 3, 4);
			dgvUser.Name = "dgvUser";
			dgvUser.RowHeadersWidth = 62;
			dgvUser.RowTemplate.Height = 25;
			dgvUser.Size = new Size(1300, 443);
			dgvUser.TabIndex = 17;
			dgvUser.DataError += dgvUser_DataError;
			// 
			// EmployeeeInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvUser);
			Controls.Add(btnCreate);
			Controls.Add(cbxDepartment);
			Controls.Add(label1);
			Controls.Add(ShowAllEmployeeButton);
			Controls.Add(DeleteEmployeeButton);
			Controls.Add(EditEmployeeButton);
			Name = "EmployeeeInfo";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button DeleteEmployeeButton;
		private Button EditEmployeeButton;
		private Button ShowAllEmployeeButton;
		private Label label1;
		private ComboBox cbxDepartment;
		private Button btnCreate;
		private DataGridView dgvUser;
	}
}