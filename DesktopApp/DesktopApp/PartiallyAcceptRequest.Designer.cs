namespace DesktopApp
{
    partial class PartiallyAcceptRequest
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
            numericUpDown1 = new NumericUpDown();
            SubmitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(153, 47);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(291, 30);
            numericUpDown1.TabIndex = 1;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.Location = new Point(493, 47);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(131, 30);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PartiallyAcceptRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 134);
            Controls.Add(SubmitButton);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "PartiallyAcceptRequest";
            Text = "PartiallyAcceptRequest";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button SubmitButton;
    }
}