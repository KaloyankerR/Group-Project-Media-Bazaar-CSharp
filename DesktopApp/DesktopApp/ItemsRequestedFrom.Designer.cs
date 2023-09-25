namespace DesktopApp
{
	partial class ItemsRequestedFrom
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
			flowLayoutPanel1 = new FlowLayoutPanel();
			AddMore = new Button();
			Submit = new Button();
			BackButton = new Button();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.Location = new Point(2, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1230, 390);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// AddMore
			// 
			AddMore.Location = new Point(70, 423);
			AddMore.Name = "AddMore";
			AddMore.Size = new Size(286, 54);
			AddMore.TabIndex = 1;
			AddMore.Text = "Add More";
			AddMore.UseVisualStyleBackColor = true;
			AddMore.Click += AddMore_Click;
			// 
			// Submit
			// 
			Submit.Location = new Point(492, 423);
			Submit.Name = "Submit";
			Submit.Size = new Size(286, 54);
			Submit.TabIndex = 2;
			Submit.Text = "Submit";
			Submit.UseVisualStyleBackColor = true;
			Submit.Click += Submit_Click;
			// 
			// BackButton
			// 
			BackButton.Location = new Point(884, 423);
			BackButton.Name = "BackButton";
			BackButton.Size = new Size(286, 54);
			BackButton.TabIndex = 3;
			BackButton.Text = "Back";
			BackButton.UseVisualStyleBackColor = true;
			BackButton.Click += BackButton_Click;
			// 
			// ItemsRequestedFrom
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1230, 489);
			Controls.Add(BackButton);
			Controls.Add(Submit);
			Controls.Add(AddMore);
			Controls.Add(flowLayoutPanel1);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Name = "ItemsRequestedFrom";
			Text = "ItemsRequestedFrom";
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Button AddMore;
		private Button Submit;
		private Button BackButton;
	}
}