namespace DesktopApp.Info_Forms
{
    partial class CalendarInfo
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
            components = new System.ComponentModel.Container();
            tbscheduledcount = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // tbscheduledcount
            // 
            tbscheduledcount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbscheduledcount.Location = new Point(18, 38);
            tbscheduledcount.Margin = new Padding(1);
            tbscheduledcount.Name = "tbscheduledcount";
            tbscheduledcount.ReadOnly = true;
            tbscheduledcount.Size = new Size(106, 34);
            tbscheduledcount.TabIndex = 1;
            tbscheduledcount.TextAlign = HorizontalAlignment.Center;
            // 
            // CalendarInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tbscheduledcount);
            Name = "CalendarInfo";
            Size = new Size(141, 111);
            DoubleClick += CalendarInfo_OnDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private TextBox tbscheduledcount;
        private ToolTip toolTip1;
    }
}
