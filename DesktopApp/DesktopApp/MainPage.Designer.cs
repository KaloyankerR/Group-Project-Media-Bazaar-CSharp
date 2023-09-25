namespace DesktopApp
{
	partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			btnCalendar = new Button();
			btnDepartment = new Button();
			btnInventory = new Button();
			btnEmployee = new Button();
			btnLogOut = new Button();
			pictureBox1 = new PictureBox();
			formsPanel = new Panel();
			CategoryBtn = new Button();
			ProductUnitButton = new Button();
			DepoInventoryRequestButton = new Button();
			ManagerHistoryRequest = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnCalendar
			// 
			btnCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCalendar.Location = new Point(151, 0);
			btnCalendar.Name = "btnCalendar";
			btnCalendar.Size = new Size(138, 101);
			btnCalendar.TabIndex = 1;
			btnCalendar.Text = "Calendar";
			btnCalendar.UseVisualStyleBackColor = true;
			btnCalendar.Click += btnCalendar_Click;
			// 
			// btnDepartment
			// 
			btnDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnDepartment.Location = new Point(290, 0);
			btnDepartment.Name = "btnDepartment";
			btnDepartment.Size = new Size(138, 101);
			btnDepartment.TabIndex = 2;
			btnDepartment.Text = "Department";
			btnDepartment.UseVisualStyleBackColor = true;
			btnDepartment.Click += btnDepartment_Click;
			// 
			// btnInventory
			// 
			btnInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnInventory.Location = new Point(428, 0);
			btnInventory.Name = "btnInventory";
			btnInventory.Size = new Size(138, 101);
			btnInventory.TabIndex = 3;
			btnInventory.Text = "Inventory";
			btnInventory.UseVisualStyleBackColor = true;
			btnInventory.Click += btnInventory_Click;
			// 
			// btnEmployee
			// 
			btnEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEmployee.Location = new Point(1123, 0);
			btnEmployee.Name = "btnEmployee";
			btnEmployee.Size = new Size(138, 101);
			btnEmployee.TabIndex = 4;
			btnEmployee.Text = "Employees";
			btnEmployee.UseVisualStyleBackColor = true;
			btnEmployee.Click += btnEmployee_Click;
			// 
			// btnLogOut
			// 
			btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogOut.Location = new Point(1262, 0);
			btnLogOut.Name = "btnLogOut";
			btnLogOut.Size = new Size(138, 101);
			btnLogOut.TabIndex = 5;
			btnLogOut.Text = "Log Out";
			btnLogOut.UseVisualStyleBackColor = true;
			btnLogOut.Click += btnLogOut_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(150, 101);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// formsPanel
			// 
			formsPanel.Location = new Point(0, 108);
			formsPanel.Margin = new Padding(3, 4, 3, 4);
			formsPanel.Name = "formsPanel";
			formsPanel.Size = new Size(1400, 653);
			formsPanel.TabIndex = 7;
			// 
			// CategoryBtn
			// 
			CategoryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			CategoryBtn.Location = new Point(845, 0);
			CategoryBtn.Name = "CategoryBtn";
			CategoryBtn.Size = new Size(138, 101);
			CategoryBtn.TabIndex = 8;
			CategoryBtn.Text = "Category";
			CategoryBtn.UseVisualStyleBackColor = true;
			CategoryBtn.Click += CategoryBtn_Click;
			// 
			// ProductUnitButton
			// 
			ProductUnitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ProductUnitButton.Location = new Point(984, 0);
			ProductUnitButton.Name = "ProductUnitButton";
			ProductUnitButton.Size = new Size(138, 101);
			ProductUnitButton.TabIndex = 9;
			ProductUnitButton.Text = "Product Unit ";
			ProductUnitButton.UseVisualStyleBackColor = true;
			ProductUnitButton.Click += ProductUnitButton_Click;
			// 
			// DepoInventoryRequestButton
			// 
			DepoInventoryRequestButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			DepoInventoryRequestButton.Location = new Point(567, 0);
			DepoInventoryRequestButton.Name = "DepoInventoryRequestButton";
			DepoInventoryRequestButton.Size = new Size(138, 101);
			DepoInventoryRequestButton.TabIndex = 5;
			DepoInventoryRequestButton.Text = "DepoWorker Inventory Request";
			DepoInventoryRequestButton.UseVisualStyleBackColor = true;
			DepoInventoryRequestButton.Click += DepoInventoryRequestButton_Click;
			// 
			// ManagerHistoryRequest
			// 
			ManagerHistoryRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ManagerHistoryRequest.Location = new Point(706, 0);
			ManagerHistoryRequest.Name = "ManagerHistoryRequest";
			ManagerHistoryRequest.Size = new Size(138, 101);
			ManagerHistoryRequest.TabIndex = 10;
			ManagerHistoryRequest.Text = "Manager History Request";
			ManagerHistoryRequest.UseVisualStyleBackColor = true;
			ManagerHistoryRequest.Click += ManagerHistoryRequest_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1402, 756);
			Controls.Add(ManagerHistoryRequest);
			Controls.Add(DepoInventoryRequestButton);
			Controls.Add(ProductUnitButton);
			Controls.Add(CategoryBtn);
			Controls.Add(formsPanel);
			Controls.Add(pictureBox1);
			Controls.Add(btnLogOut);
			Controls.Add(btnEmployee);
			Controls.Add(btnInventory);
			Controls.Add(btnDepartment);
			Controls.Add(btnCalendar);
			Name = "MainPage";
			Text = "Main Form";
			FormClosed += MainPage_FormClosed;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button btnCalendar;
		private Button btnDepartment;
		private Button btnInventory;
		private Button btnEmployee;
		private Button btnLogOut;
		private PictureBox pictureBox1;
		private Panel formsPanel;
		private Button CategoryBtn;
		private Button ProductUnitButton;
		private Button DepoInventoryRequestButton;
		private Button ManagerHistoryRequest;
	}
}