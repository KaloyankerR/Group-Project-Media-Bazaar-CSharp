namespace DesktopApp.Info_Forms
{
	partial class ManagerHistoryRequest
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
			dataGridView1 = new DataGridView();
			RefreshButton = new Button();
			ManagerHistoryRequestComboBox = new ComboBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToOrderColumns = true;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(50, 119);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1300, 443);
			dataGridView1.TabIndex = 0;
			// 
			// RefreshButton
			// 
			RefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			RefreshButton.Location = new Point(602, 569);
			RefreshButton.Name = "RefreshButton";
			RefreshButton.Size = new Size(195, 61);
			RefreshButton.TabIndex = 1;
			RefreshButton.Text = "Refresh";
			RefreshButton.UseVisualStyleBackColor = true;
			RefreshButton.Click += RefreshButton_Click;
			// 
			// ManagerHistoryRequestComboBox
			// 
			ManagerHistoryRequestComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ManagerHistoryRequestComboBox.FormattingEnabled = true;
			ManagerHistoryRequestComboBox.Items.AddRange(new object[] { "All", "Accepted", "Declined", "Partially Accepted", "Pending" });
			ManagerHistoryRequestComboBox.Location = new Point(242, 17);
			ManagerHistoryRequestComboBox.Margin = new Padding(3, 4, 3, 4);
			ManagerHistoryRequestComboBox.Name = "ManagerHistoryRequestComboBox";
			ManagerHistoryRequestComboBox.Size = new Size(183, 28);
			ManagerHistoryRequestComboBox.TabIndex = 23;
			ManagerHistoryRequestComboBox.SelectedIndexChanged += ManagerHistoryRequestComboBox_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(50, 16);
			label1.Name = "label1";
			label1.Size = new Size(57, 20);
			label1.TabIndex = 22;
			label1.Text = "Status:";
			// 
			// ManagerHistoryRequest
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(ManagerHistoryRequestComboBox);
			Controls.Add(label1);
			Controls.Add(RefreshButton);
			Controls.Add(dataGridView1);
			Name = "ManagerHistoryRequest";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button RefreshButton;
		private ComboBox ManagerHistoryRequestComboBox;
		private Label label1;
	}
}
