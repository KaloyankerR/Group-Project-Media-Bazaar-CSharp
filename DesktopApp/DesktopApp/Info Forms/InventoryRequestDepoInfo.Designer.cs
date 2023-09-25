namespace DesktopApp.Info_Forms
{
	partial class InventoryRequestDepoInfo
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
			PartiallyAcceptButton = new Button();
			DeclineButton = new Button();
			AcceptButton = new Button();
			IteamsRequesteDGV = new DataGridView();
			RefreshButton = new Button();
			((System.ComponentModel.ISupportInitialize)IteamsRequesteDGV).BeginInit();
			SuspendLayout();
			// 
			// PartiallyAcceptButton
			// 
			PartiallyAcceptButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			PartiallyAcceptButton.Location = new Point(489, 569);
			PartiallyAcceptButton.Name = "PartiallyAcceptButton";
			PartiallyAcceptButton.Size = new Size(195, 61);
			PartiallyAcceptButton.TabIndex = 7;
			PartiallyAcceptButton.Text = "Partially Accept";
			PartiallyAcceptButton.UseVisualStyleBackColor = true;
			PartiallyAcceptButton.Click += PartiallyAcceptButton_Click;
			// 
			// DeclineButton
			// 
			DeclineButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			DeclineButton.Location = new Point(268, 569);
			DeclineButton.Name = "DeclineButton";
			DeclineButton.Size = new Size(195, 61);
			DeclineButton.TabIndex = 6;
			DeclineButton.Text = "Decline";
			DeclineButton.UseVisualStyleBackColor = true;
			DeclineButton.Click += DeclineButton_Click;
			// 
			// AcceptButton
			// 
			AcceptButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			AcceptButton.Location = new Point(48, 569);
			AcceptButton.Name = "AcceptButton";
			AcceptButton.Size = new Size(195, 61);
			AcceptButton.TabIndex = 5;
			AcceptButton.Text = "Accept";
			AcceptButton.UseVisualStyleBackColor = true;
			AcceptButton.Click += AcceptButton_Click;
			// 
			// IteamsRequesteDGV
			// 
			IteamsRequesteDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			IteamsRequesteDGV.Location = new Point(50, 119);
			IteamsRequesteDGV.Name = "IteamsRequesteDGV";
			IteamsRequesteDGV.RowHeadersWidth = 51;
			IteamsRequesteDGV.RowTemplate.Height = 29;
			IteamsRequesteDGV.Size = new Size(1300, 443);
			IteamsRequesteDGV.TabIndex = 4;
			// 
			// RefreshButton
			// 
			RefreshButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			RefreshButton.Location = new Point(1155, 569);
			RefreshButton.Name = "RefreshButton";
			RefreshButton.Size = new Size(195, 61);
			RefreshButton.TabIndex = 8;
			RefreshButton.Text = "Refresh";
			RefreshButton.UseVisualStyleBackColor = true;
			RefreshButton.Click += RefreshButton_Click;
			// 
			// InventoryRequestDepoInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(RefreshButton);
			Controls.Add(PartiallyAcceptButton);
			Controls.Add(DeclineButton);
			Controls.Add(AcceptButton);
			Controls.Add(IteamsRequesteDGV);
			Name = "InventoryRequestDepoInfo";
			Size = new Size(1400, 653);
			((System.ComponentModel.ISupportInitialize)IteamsRequesteDGV).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button PartiallyAcceptButton;
		private Button DeclineButton;
		private Button AcceptButton;
		private DataGridView IteamsRequesteDGV;
		private Button RefreshButton;
	}
}
