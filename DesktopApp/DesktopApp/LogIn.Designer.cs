namespace DesktopApp
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.TitleLogInForm = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.EmailTBX = new System.Windows.Forms.TextBox();
			this.PasswordTBX = new System.Windows.Forms.TextBox();
			this.LogInButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TitleLogInForm
			// 
			this.TitleLogInForm.AutoSize = true;
			this.TitleLogInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TitleLogInForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.TitleLogInForm.Location = new System.Drawing.Point(326, 59);
			this.TitleLogInForm.Name = "TitleLogInForm";
			this.TitleLogInForm.Size = new System.Drawing.Size(92, 26);
			this.TitleLogInForm.TabIndex = 0;
			this.TitleLogInForm.Text = "LOG IN";
			this.TitleLogInForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EmailLabel.Location = new System.Drawing.Point(68, 158);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(80, 26);
			this.EmailLabel.TabIndex = 1;
			this.EmailLabel.Text = "Email:";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(20, 236);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(123, 26);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "Password:";
			// 
			// EmailTBX
			// 
			this.EmailTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EmailTBX.Location = new System.Drawing.Point(199, 158);
			this.EmailTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EmailTBX.Name = "EmailTBX";
			this.EmailTBX.Size = new System.Drawing.Size(434, 32);
			this.EmailTBX.TabIndex = 3;
			this.EmailTBX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTBX_KeyDown);
			// 
			// PasswordTBX
			// 
			this.PasswordTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.PasswordTBX.Location = new System.Drawing.Point(199, 236);
			this.PasswordTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PasswordTBX.Name = "PasswordTBX";
			this.PasswordTBX.PasswordChar = '*';
			this.PasswordTBX.Size = new System.Drawing.Size(434, 32);
			this.PasswordTBX.TabIndex = 4;
			this.PasswordTBX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTBX_KeyDown_1);
			// 
			// LogInButton
			// 
			this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LogInButton.Location = new System.Drawing.Point(222, 302);
			this.LogInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(369, 72);
			this.LogInButton.TabIndex = 5;
			this.LogInButton.Text = "LOG IN";
			this.LogInButton.UseVisualStyleBackColor = true;
			this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 492);
			this.Controls.Add(this.LogInButton);
			this.Controls.Add(this.PasswordTBX);
			this.Controls.Add(this.EmailTBX);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.TitleLogInForm);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LogIn";
			this.Text = "Log In";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label TitleLogInForm;
        private Label EmailLabel;
        private Label PasswordLabel;
        private TextBox EmailTBX;
        private TextBox PasswordTBX;
        private Button LogInButton;
       
       
    }
}