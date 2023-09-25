namespace DesktopApp.Edit_Forms
{
	partial class EditCalendar
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
			label1 = new Label();
			tbemployeeinfo = new TextBox();
			btncancel = new Button();
			lblschem = new Label();
			lblavem = new Label();
			btnsave = new Button();
			btnsendtoav = new Button();
			btnsendtosch = new Button();
			lbscheduled = new ListBox();
			lbavemployees = new ListBox();
			tbshiftname = new TextBox();
			label2 = new Label();
			numEmployees = new NumericUpDown();
			cboxEmployee = new CheckBox();
			((System.ComponentModel.ISupportInitialize)numEmployees).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(435, 252);
			label1.Margin = new Padding(1, 0, 1, 0);
			label1.Name = "label1";
			label1.Size = new Size(114, 20);
			label1.TabIndex = 27;
			label1.Text = "Employee Info:";
			// 
			// tbemployeeinfo
			// 
			tbemployeeinfo.BackColor = Color.Honeydew;
			tbemployeeinfo.Location = new Point(358, 282);
			tbemployeeinfo.Margin = new Padding(1);
			tbemployeeinfo.Multiline = true;
			tbemployeeinfo.Name = "tbemployeeinfo";
			tbemployeeinfo.ReadOnly = true;
			tbemployeeinfo.Size = new Size(286, 163);
			tbemployeeinfo.TabIndex = 26;
			// 
			// btncancel
			// 
			btncancel.Location = new Point(678, 462);
			btncancel.Margin = new Padding(1);
			btncancel.Name = "btncancel";
			btncancel.Size = new Size(101, 29);
			btncancel.TabIndex = 25;
			btncancel.Text = "Cancel";
			btncancel.UseVisualStyleBackColor = true;
			btncancel.Click += btncancel_Click;
			// 
			// lblschem
			// 
			lblschem.AutoSize = true;
			lblschem.Location = new Point(668, 68);
			lblschem.Margin = new Padding(1, 0, 1, 0);
			lblschem.Name = "lblschem";
			lblschem.Size = new Size(165, 20);
			lblschem.TabIndex = 24;
			lblschem.Text = "Scheduled Employeed:";
			// 
			// lblavem
			// 
			lblavem.AutoSize = true;
			lblavem.Location = new Point(112, 68);
			lblavem.Margin = new Padding(1, 0, 1, 0);
			lblavem.Name = "lblavem";
			lblavem.Size = new Size(156, 20);
			lblavem.TabIndex = 23;
			lblavem.Text = "Available Employees:";
			// 
			// btnsave
			// 
			btnsave.Location = new Point(795, 462);
			btnsave.Margin = new Padding(1);
			btnsave.Name = "btnsave";
			btnsave.Size = new Size(101, 29);
			btnsave.TabIndex = 22;
			btnsave.Text = "Save";
			btnsave.UseVisualStyleBackColor = true;
			btnsave.Click += btnsave_Click;
			// 
			// btnsendtoav
			// 
			btnsendtoav.BackgroundImageLayout = ImageLayout.Zoom;
			btnsendtoav.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnsendtoav.Location = new Point(464, 184);
			btnsendtoav.Margin = new Padding(1);
			btnsendtoav.Name = "btnsendtoav";
			btnsendtoav.Size = new Size(72, 67);
			btnsendtoav.TabIndex = 4;
			btnsendtoav.Text = "<---";
			btnsendtoav.UseVisualStyleBackColor = true;
			btnsendtoav.Click += btnLeft_Click;
			// 
			// btnsendtosch
			// 
			btnsendtosch.BackgroundImageLayout = ImageLayout.Zoom;
			btnsendtosch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnsendtosch.Location = new Point(464, 101);
			btnsendtosch.Margin = new Padding(1);
			btnsendtosch.Name = "btnsendtosch";
			btnsendtosch.Size = new Size(72, 67);
			btnsendtosch.TabIndex = 20;
			btnsendtosch.Text = "--->";
			btnsendtosch.UseVisualStyleBackColor = true;
			btnsendtosch.Click += btnRight_Click;
			// 
			// lbscheduled
			// 
			lbscheduled.FormattingEnabled = true;
			lbscheduled.ItemHeight = 20;
			lbscheduled.Location = new Point(668, 101);
			lbscheduled.Margin = new Padding(1);
			lbscheduled.Name = "lbscheduled";
			lbscheduled.Size = new Size(230, 344);
			lbscheduled.TabIndex = 19;
			lbscheduled.SelectedIndexChanged += lbscheduled_SelectedIndexChanged;
			// 
			// lbavemployees
			// 
			lbavemployees.FormattingEnabled = true;
			lbavemployees.ItemHeight = 20;
			lbavemployees.Location = new Point(112, 101);
			lbavemployees.Margin = new Padding(1);
			lbavemployees.Name = "lbavemployees";
			lbavemployees.Size = new Size(216, 344);
			lbavemployees.TabIndex = 18;
			lbavemployees.SelectedIndexChanged += lbavemployees_SelectedIndexChanged;
			// 
			// tbshiftname
			// 
			tbshiftname.BackColor = Color.NavajoWhite;
			tbshiftname.Location = new Point(295, 7);
			tbshiftname.Margin = new Padding(1);
			tbshiftname.Name = "tbshiftname";
			tbshiftname.ReadOnly = true;
			tbshiftname.Size = new Size(389, 27);
			tbshiftname.TabIndex = 17;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(688, 27);
			label2.Name = "label2";
			label2.Size = new Size(167, 20);
			label2.TabIndex = 30;
			label2.Text = "Change max employee";
			// 
			// numEmployees
			// 
			numEmployees.Location = new Point(876, 25);
			numEmployees.Name = "numEmployees";
			numEmployees.Size = new Size(64, 27);
			numEmployees.TabIndex = 31;
			// 
			// cboxEmployee
			// 
			cboxEmployee.AutoSize = true;
			cboxEmployee.Location = new Point(55, 27);
			cboxEmployee.Name = "cboxEmployee";
			cboxEmployee.Size = new Size(161, 24);
			cboxEmployee.TabIndex = 32;
			cboxEmployee.Text = "Show all employee";
			cboxEmployee.UseVisualStyleBackColor = true;
			cboxEmployee.CheckedChanged += cboxEmployee_CheckedChanged;
			// 
			// EditCalendar
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1020, 538);
			Controls.Add(cboxEmployee);
			Controls.Add(numEmployees);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbemployeeinfo);
			Controls.Add(btncancel);
			Controls.Add(lblschem);
			Controls.Add(lblavem);
			Controls.Add(btnsave);
			Controls.Add(btnsendtosch);
			Controls.Add(lbscheduled);
			Controls.Add(lbavemployees);
			Controls.Add(tbshiftname);
			Controls.Add(btnsendtoav);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Name = "EditCalendar";
			Text = "EditCalendar";
			((System.ComponentModel.ISupportInitialize)numEmployees).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private TextBox tbemployeeinfo;
		private Button btncancel;
		private Label lblschem;
		private Label lblavem;
		private Button btnsave;
		private Button btnsendtoav;
		private Button btnsendtosch;
		private ListBox lbscheduled;
		private ListBox lbavemployees;
		private TextBox tbshiftname;
		private Label label2;
		private NumericUpDown numEmployees;
		private CheckBox cboxEmployee;
	}
}