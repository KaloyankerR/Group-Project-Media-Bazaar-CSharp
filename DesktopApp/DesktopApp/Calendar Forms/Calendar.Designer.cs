namespace DesktopApp
{
    partial class Calendar
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
            btnrefresh = new Button();
            lblendofday = new Label();
            lblevening = new Label();
            lblday = new Label();
            lblmorn = new Label();
            lblsun = new Label();
            lblsat = new Label();
            lblfri = new Label();
            lblthu = new Label();
            lblwed = new Label();
            lbltuesday = new Label();
            lblmonday = new Label();
            btnnext = new Button();
            btnprev = new Button();
            shiftweekpanel = new FlowLayoutPanel();
            pictureLoading = new PictureBox();
            tbweek = new TextBox();
            btnBack = new Button();
            label1 = new Label();
            cbDepartments = new ComboBox();
            btnCurrentWeek = new Button();
            DataMonday = new Label();
            DataTuesday = new Label();
            DataWednesday = new Label();
            DataThursday = new Label();
            DataFriday = new Label();
            DataSaturday = new Label();
            DataSunday = new Label();
            GenerateScheduleButton = new Button();
            DeleteCurrentSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLoading).BeginInit();
            SuspendLayout();
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.Location = new Point(209, 520);
            btnrefresh.Margin = new Padding(1);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(101, 29);
            btnrefresh.TabIndex = 30;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // lblendofday
            // 
            lblendofday.AutoSize = true;
            lblendofday.Location = new Point(11, 466);
            lblendofday.Margin = new Padding(1, 0, 1, 0);
            lblendofday.Name = "lblendofday";
            lblendofday.Size = new Size(49, 20);
            lblendofday.TabIndex = 29;
            lblendofday.Text = "20:00";
            // 
            // lblevening
            // 
            lblevening.AutoSize = true;
            lblevening.Location = new Point(11, 342);
            lblevening.Margin = new Padding(1, 0, 1, 0);
            lblevening.Name = "lblevening";
            lblevening.Size = new Size(49, 20);
            lblevening.TabIndex = 28;
            lblevening.Text = "16:00";
            // 
            // lblday
            // 
            lblday.AutoSize = true;
            lblday.Location = new Point(11, 221);
            lblday.Margin = new Padding(1, 0, 1, 0);
            lblday.Name = "lblday";
            lblday.Size = new Size(49, 20);
            lblday.TabIndex = 27;
            lblday.Text = "12:00";
            // 
            // lblmorn
            // 
            lblmorn.AutoSize = true;
            lblmorn.Location = new Point(11, 119);
            lblmorn.Margin = new Padding(1, 0, 1, 0);
            lblmorn.Name = "lblmorn";
            lblmorn.Size = new Size(49, 20);
            lblmorn.TabIndex = 26;
            lblmorn.Text = "08:00";
            // 
            // lblsun
            // 
            lblsun.AutoSize = true;
            lblsun.Location = new Point(1103, 53);
            lblsun.Margin = new Padding(1, 0, 1, 0);
            lblsun.Name = "lblsun";
            lblsun.Size = new Size(60, 20);
            lblsun.TabIndex = 25;
            lblsun.Text = "Sunday";
            // 
            // lblsat
            // 
            lblsat.AutoSize = true;
            lblsat.Location = new Point(936, 53);
            lblsat.Margin = new Padding(1, 0, 1, 0);
            lblsat.Name = "lblsat";
            lblsat.Size = new Size(71, 20);
            lblsat.TabIndex = 24;
            lblsat.Text = "Saturday";
            // 
            // lblfri
            // 
            lblfri.AutoSize = true;
            lblfri.Location = new Point(777, 53);
            lblfri.Margin = new Padding(1, 0, 1, 0);
            lblfri.Name = "lblfri";
            lblfri.Size = new Size(52, 20);
            lblfri.TabIndex = 23;
            lblfri.Text = "Friday";
            // 
            // lblthu
            // 
            lblthu.AutoSize = true;
            lblthu.Location = new Point(613, 53);
            lblthu.Margin = new Padding(1, 0, 1, 0);
            lblthu.Name = "lblthu";
            lblthu.Size = new Size(74, 20);
            lblthu.TabIndex = 22;
            lblthu.Text = "Thursday";
            // 
            // lblwed
            // 
            lblwed.AutoSize = true;
            lblwed.Location = new Point(444, 53);
            lblwed.Margin = new Padding(1, 0, 1, 0);
            lblwed.Name = "lblwed";
            lblwed.Size = new Size(90, 20);
            lblwed.TabIndex = 21;
            lblwed.Text = "Wednesday";
            // 
            // lbltuesday
            // 
            lbltuesday.AutoSize = true;
            lbltuesday.Location = new Point(294, 53);
            lbltuesday.Margin = new Padding(1, 0, 1, 0);
            lbltuesday.Name = "lbltuesday";
            lbltuesday.Size = new Size(66, 20);
            lbltuesday.TabIndex = 20;
            lbltuesday.Text = "Tuesday";
            // 
            // lblmonday
            // 
            lblmonday.AutoSize = true;
            lblmonday.Location = new Point(119, 53);
            lblmonday.Margin = new Padding(1, 0, 1, 0);
            lblmonday.Name = "lblmonday";
            lblmonday.Size = new Size(66, 20);
            lblmonday.TabIndex = 19;
            lblmonday.Text = "Monday";
            // 
            // btnnext
            // 
            btnnext.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnnext.Location = new Point(1167, 520);
            btnnext.Margin = new Padding(1);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(101, 29);
            btnnext.TabIndex = 18;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnprev
            // 
            btnprev.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnprev.Location = new Point(901, 520);
            btnprev.Margin = new Padding(1);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(101, 29);
            btnprev.TabIndex = 15;
            btnprev.Text = "Previous";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += btnprev_Click;
            // 
            // shiftweekpanel
            // 
            shiftweekpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            shiftweekpanel.FlowDirection = FlowDirection.TopDown;
            shiftweekpanel.Location = new Point(76, 119);
            shiftweekpanel.Margin = new Padding(1);
            shiftweekpanel.Name = "shiftweekpanel";
            shiftweekpanel.Size = new Size(1192, 389);
            shiftweekpanel.TabIndex = 17;
            // 
            // pictureLoading
            // 
            pictureLoading.Image = Properties.Resources.Loading;
            pictureLoading.Location = new Point(532, 201);
            pictureLoading.Name = "pictureLoading";
            pictureLoading.Size = new Size(200, 202);
            pictureLoading.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureLoading.TabIndex = 44;
            pictureLoading.TabStop = false;
            // 
            // tbweek
            // 
            tbweek.BackColor = Color.FromArgb(255, 224, 192);
            tbweek.Location = new Point(459, 10);
            tbweek.Margin = new Padding(1);
            tbweek.Name = "tbweek";
            tbweek.ReadOnly = true;
            tbweek.Size = new Size(319, 27);
            tbweek.TabIndex = 16;
            tbweek.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(88, 520);
            btnBack.Margin = new Padding(1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 29);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(936, 17);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 32;
            label1.Text = "Departments:";
            // 
            // cbDepartments
            // 
            cbDepartments.BackColor = SystemColors.Window;
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(1063, 14);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(204, 28);
            cbDepartments.TabIndex = 33;
            // 
            // btnCurrentWeek
            // 
            btnCurrentWeek.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCurrentWeek.Location = new Point(1026, 520);
            btnCurrentWeek.Margin = new Padding(1);
            btnCurrentWeek.Name = "btnCurrentWeek";
            btnCurrentWeek.Size = new Size(126, 29);
            btnCurrentWeek.TabIndex = 34;
            btnCurrentWeek.Text = "Current week";
            btnCurrentWeek.UseVisualStyleBackColor = true;
            btnCurrentWeek.Click += btnCurrentWeek_Click;
            // 
            // DataMonday
            // 
            DataMonday.AutoSize = true;
            DataMonday.Location = new Point(112, 86);
            DataMonday.Name = "DataMonday";
            DataMonday.Size = new Size(51, 20);
            DataMonday.TabIndex = 35;
            DataMonday.Text = "label2";
            // 
            // DataTuesday
            // 
            DataTuesday.AutoSize = true;
            DataTuesday.Location = new Point(288, 86);
            DataTuesday.Name = "DataTuesday";
            DataTuesday.Size = new Size(51, 20);
            DataTuesday.TabIndex = 36;
            DataTuesday.Text = "label3";
            // 
            // DataWednesday
            // 
            DataWednesday.AutoSize = true;
            DataWednesday.Location = new Point(444, 86);
            DataWednesday.Name = "DataWednesday";
            DataWednesday.Size = new Size(51, 20);
            DataWednesday.TabIndex = 37;
            DataWednesday.Text = "label4";
            // 
            // DataThursday
            // 
            DataThursday.AutoSize = true;
            DataThursday.Location = new Point(613, 86);
            DataThursday.Name = "DataThursday";
            DataThursday.Size = new Size(51, 20);
            DataThursday.TabIndex = 38;
            DataThursday.Text = "label5";
            // 
            // DataFriday
            // 
            DataFriday.AutoSize = true;
            DataFriday.Location = new Point(766, 86);
            DataFriday.Name = "DataFriday";
            DataFriday.Size = new Size(51, 20);
            DataFriday.TabIndex = 39;
            DataFriday.Text = "label6";
            // 
            // DataSaturday
            // 
            DataSaturday.AutoSize = true;
            DataSaturday.Location = new Point(936, 86);
            DataSaturday.Name = "DataSaturday";
            DataSaturday.Size = new Size(51, 20);
            DataSaturday.TabIndex = 40;
            DataSaturday.Text = "label7";
            // 
            // DataSunday
            // 
            DataSunday.AutoSize = true;
            DataSunday.Location = new Point(1103, 86);
            DataSunday.Name = "DataSunday";
            DataSunday.Size = new Size(51, 20);
            DataSunday.TabIndex = 41;
            DataSunday.Text = "label8";
            // 
            // GenerateScheduleButton
            // 
            GenerateScheduleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GenerateScheduleButton.Location = new Point(344, 520);
            GenerateScheduleButton.Margin = new Padding(1);
            GenerateScheduleButton.Name = "GenerateScheduleButton";
            GenerateScheduleButton.Size = new Size(210, 29);
            GenerateScheduleButton.TabIndex = 42;
            GenerateScheduleButton.Text = "Auto Generate Schedule";
            GenerateScheduleButton.UseVisualStyleBackColor = true;
            GenerateScheduleButton.Click += GenerateScheduleButton_Click;
            // 
            // DeleteCurrentSchedule
            // 
            DeleteCurrentSchedule.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteCurrentSchedule.Location = new Point(590, 520);
            DeleteCurrentSchedule.Margin = new Padding(1);
            DeleteCurrentSchedule.Name = "DeleteCurrentSchedule";
            DeleteCurrentSchedule.Size = new Size(210, 29);
            DeleteCurrentSchedule.TabIndex = 43;
            DeleteCurrentSchedule.Text = "Delete Current Schedule";
            DeleteCurrentSchedule.UseVisualStyleBackColor = true;
            DeleteCurrentSchedule.Click += DeleteCurrentSchedule_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 578);
            Controls.Add(pictureLoading);
            Controls.Add(DeleteCurrentSchedule);
            Controls.Add(GenerateScheduleButton);
            Controls.Add(DataSunday);
            Controls.Add(DataSaturday);
            Controls.Add(DataFriday);
            Controls.Add(DataThursday);
            Controls.Add(DataWednesday);
            Controls.Add(DataTuesday);
            Controls.Add(DataMonday);
            Controls.Add(btnCurrentWeek);
            Controls.Add(cbDepartments);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnrefresh);
            Controls.Add(lblendofday);
            Controls.Add(lblevening);
            Controls.Add(lblday);
            Controls.Add(lblmorn);
            Controls.Add(lblsun);
            Controls.Add(lblsat);
            Controls.Add(lblfri);
            Controls.Add(lblthu);
            Controls.Add(lblwed);
            Controls.Add(lbltuesday);
            Controls.Add(lblmonday);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(tbweek);
            Controls.Add(shiftweekpanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Calendar";
            Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)pictureLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnrefresh;
        private Label lblendofday;
        private Label lblevening;
        private Label lblday;
        private Label lblmorn;
        private Label lblsun;
        private Label lblsat;
        private Label lblfri;
        private Label lblthu;
        private Label lblwed;
        private Label lbltuesday;
        private Label lblmonday;
        private Button btnnext;
        private Button btnprev;
        public FlowLayoutPanel shiftweekpanel;
        private TextBox tbweek;
        private Button btnBack;
        private Info_Forms.CalendarInfo calendarInfo1;
        private Info_Forms.CalendarInfo calendarInfo2;
        private Info_Forms.CalendarInfo calendarInfo3;
        private Label label1;
        private ComboBox cbDepartments;
        private Button btnCurrentWeek;
        private Label DataMonday;
        private Label DataTuesday;
        private Label DataWednesday;
        private Label DataThursday;
        private Label DataFriday;
        private Label DataSaturday;
        private Label DataSunday;
        private Button GenerateScheduleButton;
        private Button DeleteCurrentSchedule;
        private PictureBox pictureLoading;
    }
}