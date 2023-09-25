namespace DesktopApp.Info_Forms
{
	partial class UnitInfo
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvUnit = new DataGridView();
			CreateButton = new Button();
			ShowAllUnitButton = new Button();
			DeleteUnitButton = new Button();
			EditUnitButton = new Button();
			((System.ComponentModel.ISupportInitialize)dgvUnit).BeginInit();
			SuspendLayout();
			// 
			// dgvUnit
			// 
			dgvUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUnit.Location = new Point(50, 119);
			dgvUnit.Name = "dgvUnit";
			dgvUnit.RowHeadersWidth = 51;
			dgvUnit.RowTemplate.Height = 29;
			dgvUnit.Size = new Size(1300, 443);
			dgvUnit.TabIndex = 31;
			// 
			// CreateButton
			// 
			CreateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			CreateButton.Location = new Point(48, 569);
			CreateButton.Margin = new Padding(3, 4, 3, 4);
			CreateButton.Name = "CreateButton";
			CreateButton.Size = new Size(195, 61);
			CreateButton.TabIndex = 30;
			CreateButton.Text = "Create";
			CreateButton.UseVisualStyleBackColor = true;
			CreateButton.Click += CreateButton_Click;
			// 
			// ShowAllUnitButton
			// 
			ShowAllUnitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ShowAllUnitButton.Location = new Point(1155, 569);
			ShowAllUnitButton.Margin = new Padding(3, 4, 3, 4);
			ShowAllUnitButton.Name = "ShowAllUnitButton";
			ShowAllUnitButton.Size = new Size(195, 61);
			ShowAllUnitButton.TabIndex = 29;
			ShowAllUnitButton.Text = "Show All ";
			ShowAllUnitButton.UseVisualStyleBackColor = true;
			ShowAllUnitButton.Click += ShowAllUnitButton_Click;
			// 
			// DeleteUnitButton
			// 
			DeleteUnitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteUnitButton.Location = new Point(489, 569);
			DeleteUnitButton.Margin = new Padding(3, 4, 3, 4);
			DeleteUnitButton.Name = "DeleteUnitButton";
			DeleteUnitButton.Size = new Size(195, 61);
			DeleteUnitButton.TabIndex = 28;
			DeleteUnitButton.Text = "Delete ";
			DeleteUnitButton.UseVisualStyleBackColor = true;
			DeleteUnitButton.Click += DeleteUnitButton_Click;
			// 
			// EditUnitButton
			// 
			EditUnitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			EditUnitButton.Location = new Point(268, 569);
			EditUnitButton.Margin = new Padding(3, 4, 3, 4);
			EditUnitButton.Name = "EditUnitButton";
			EditUnitButton.Size = new Size(195, 61);
			EditUnitButton.TabIndex = 27;
			EditUnitButton.Text = "Edit ";
			EditUnitButton.UseVisualStyleBackColor = true;
			EditUnitButton.Click += EditUnitButton_Click;
			// 
			// UnitInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvUnit);
			Controls.Add(CreateButton);
			Controls.Add(ShowAllUnitButton);
			Controls.Add(DeleteUnitButton);
			Controls.Add(EditUnitButton);
			Name = "UnitInfo";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)dgvUnit).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvUnit;
		private Button CreateButton;
		private Button ShowAllUnitButton;
		private Button DeleteUnitButton;
		private Button EditUnitButton;
	}
}
