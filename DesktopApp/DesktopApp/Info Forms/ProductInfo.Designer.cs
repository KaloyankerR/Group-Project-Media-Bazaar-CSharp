namespace DesktopApp.Info_Forms
{
	partial class ProductInfo
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
			ProductInfoDepartmentComboBox = new ComboBox();
			label1 = new Label();
			ShowAllProductButton = new Button();
			DeleteProductButton = new Button();
			EditProductButton = new Button();
			ProductInfoCategoryComboBox = new ComboBox();
			label2 = new Label();
			CreateButton = new Button();
			dgvProduct = new DataGridView();
			RequestProductButton = new Button();
			RefershButton = new Button();
			((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
			SuspendLayout();
			// 
			// ProductInfoDepartmentComboBox
			// 
			ProductInfoDepartmentComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ProductInfoDepartmentComboBox.FormattingEnabled = true;
			ProductInfoDepartmentComboBox.Location = new Point(242, 17);
			ProductInfoDepartmentComboBox.Margin = new Padding(3, 4, 3, 4);
			ProductInfoDepartmentComboBox.Name = "ProductInfoDepartmentComboBox";
			ProductInfoDepartmentComboBox.Size = new Size(183, 28);
			ProductInfoDepartmentComboBox.TabIndex = 21;
			ProductInfoDepartmentComboBox.SelectedIndexChanged += ProductInfoDepartmentComboBox_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(50, 16);
			label1.Name = "label1";
			label1.Size = new Size(106, 20);
			label1.TabIndex = 20;
			label1.Text = "Departament:";
			// 
			// ShowAllProductButton
			// 
			ShowAllProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ShowAllProductButton.Location = new Point(1155, 569);
			ShowAllProductButton.Margin = new Padding(3, 4, 3, 4);
			ShowAllProductButton.Name = "ShowAllProductButton";
			ShowAllProductButton.Size = new Size(195, 61);
			ShowAllProductButton.TabIndex = 19;
			ShowAllProductButton.Text = "Show All ";
			ShowAllProductButton.UseVisualStyleBackColor = true;
			ShowAllProductButton.Click += ShowAllProductButton_Click;
			// 
			// DeleteProductButton
			// 
			DeleteProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DeleteProductButton.Location = new Point(489, 569);
			DeleteProductButton.Margin = new Padding(3, 4, 3, 4);
			DeleteProductButton.Name = "DeleteProductButton";
			DeleteProductButton.Size = new Size(195, 61);
			DeleteProductButton.TabIndex = 18;
			DeleteProductButton.Text = "Delete ";
			DeleteProductButton.UseVisualStyleBackColor = true;
			DeleteProductButton.Click += DeleteProductButton_Click;
			// 
			// EditProductButton
			// 
			EditProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			EditProductButton.Location = new Point(268, 569);
			EditProductButton.Margin = new Padding(3, 4, 3, 4);
			EditProductButton.Name = "EditProductButton";
			EditProductButton.Size = new Size(195, 61);
			EditProductButton.TabIndex = 17;
			EditProductButton.Text = "Edit ";
			EditProductButton.UseVisualStyleBackColor = true;
			EditProductButton.Click += EditProductButton_Click;
			// 
			// ProductInfoCategoryComboBox
			// 
			ProductInfoCategoryComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ProductInfoCategoryComboBox.FormattingEnabled = true;
			ProductInfoCategoryComboBox.Location = new Point(242, 80);
			ProductInfoCategoryComboBox.Margin = new Padding(3, 4, 3, 4);
			ProductInfoCategoryComboBox.Name = "ProductInfoCategoryComboBox";
			ProductInfoCategoryComboBox.Size = new Size(183, 28);
			ProductInfoCategoryComboBox.TabIndex = 24;
			ProductInfoCategoryComboBox.SelectedIndexChanged += ProductInfoCategoryComboBox_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(50, 68);
			label2.Name = "label2";
			label2.Size = new Size(77, 20);
			label2.TabIndex = 23;
			label2.Text = "Category:";
			// 
			// CreateButton
			// 
			CreateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			CreateButton.Location = new Point(50, 569);
			CreateButton.Margin = new Padding(3, 4, 3, 4);
			CreateButton.Name = "CreateButton";
			CreateButton.Size = new Size(195, 61);
			CreateButton.TabIndex = 25;
			CreateButton.Text = "Create";
			CreateButton.UseVisualStyleBackColor = true;
			CreateButton.Click += CreateButton_Click;
			// 
			// dgvProduct
			// 
			dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProduct.Location = new Point(50, 119);
			dgvProduct.Name = "dgvProduct";
			dgvProduct.RowHeadersWidth = 51;
			dgvProduct.RowTemplate.Height = 29;
			dgvProduct.Size = new Size(1300, 443);
			dgvProduct.TabIndex = 26;
			// 
			// RequestProductButton
			// 
			RequestProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			RequestProductButton.Location = new Point(713, 569);
			RequestProductButton.Name = "RequestProductButton";
			RequestProductButton.Size = new Size(195, 61);
			RequestProductButton.TabIndex = 27;
			RequestProductButton.Text = "Request";
			RequestProductButton.UseVisualStyleBackColor = true;
			RequestProductButton.Click += RequestProductButton_Click;
			// 
			// RefershButton
			// 
			RefershButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			RefershButton.Location = new Point(935, 569);
			RefershButton.Margin = new Padding(3, 4, 3, 4);
			RefershButton.Name = "RefershButton";
			RefershButton.Size = new Size(195, 61);
			RefershButton.TabIndex = 28;
			RefershButton.Text = "Refresh";
			RefershButton.UseVisualStyleBackColor = true;
			RefershButton.Click += RefershButton_Click;
			// 
			// ProductInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(RefershButton);
			Controls.Add(RequestProductButton);
			Controls.Add(dgvProduct);
			Controls.Add(CreateButton);
			Controls.Add(ProductInfoCategoryComboBox);
			Controls.Add(label2);
			Controls.Add(ProductInfoDepartmentComboBox);
			Controls.Add(label1);
			Controls.Add(ShowAllProductButton);
			Controls.Add(DeleteProductButton);
			Controls.Add(EditProductButton);
			Name = "ProductInfo";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox ProductInfoDepartmentComboBox;
		private Label label1;
		private Button ShowAllProductButton;
		private Button DeleteProductButton;
		private Button EditProductButton;
		private ComboBox ProductInfoCategoryComboBox;
		private Label label2;
		private Button CreateButton;
		private DataGridView dgvProduct;
		private Button RequestProductButton;
		private Button RefershButton;
	}
}