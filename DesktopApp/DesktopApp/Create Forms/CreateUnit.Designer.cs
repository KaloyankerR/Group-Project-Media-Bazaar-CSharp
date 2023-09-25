namespace DesktopApp.Create_Forms
{
    partial class CreateUnit
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
            CreateUnitButton = new Button();
            UnitNameLabel = new Label();
            UnitNameTBX = new TextBox();
            CreateUnitBackButton = new Button();
            SuspendLayout();
            // 
            // CreateUnitButton
            // 
            CreateUnitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUnitButton.Location = new Point(42, 128);
            CreateUnitButton.Name = "CreateUnitButton";
            CreateUnitButton.Size = new Size(111, 67);
            CreateUnitButton.TabIndex = 0;
            CreateUnitButton.Text = "Create";
            CreateUnitButton.UseVisualStyleBackColor = true;
            CreateUnitButton.Click += CreateUnitButton_Click;
            // 
            // UnitNameLabel
            // 
            UnitNameLabel.AutoSize = true;
            UnitNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnitNameLabel.Location = new Point(42, 74);
            UnitNameLabel.Name = "UnitNameLabel";
            UnitNameLabel.Size = new Size(62, 23);
            UnitNameLabel.TabIndex = 1;
            UnitNameLabel.Text = "Name:";
            // 
            // UnitNameTBX
            // 
            UnitNameTBX.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnitNameTBX.Location = new Point(141, 71);
            UnitNameTBX.Name = "UnitNameTBX";
            UnitNameTBX.Size = new Size(169, 30);
            UnitNameTBX.TabIndex = 2;
            // 
            // CreateUnitBackButton
            // 
            CreateUnitBackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUnitBackButton.Location = new Point(199, 128);
            CreateUnitBackButton.Name = "CreateUnitBackButton";
            CreateUnitBackButton.Size = new Size(111, 67);
            CreateUnitBackButton.TabIndex = 3;
            CreateUnitBackButton.Text = "Back";
            CreateUnitBackButton.UseVisualStyleBackColor = true;
            CreateUnitBackButton.Click += CreateUnitBackButton_Click;
            // 
            // CreateUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 222);
            Controls.Add(CreateUnitBackButton);
            Controls.Add(UnitNameTBX);
            Controls.Add(UnitNameLabel);
            Controls.Add(CreateUnitButton);
            Name = "CreateUnit";
            Text = "CreateUnit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateUnitButton;
        private Label UnitNameLabel;
        private TextBox UnitNameTBX;
        private Button CreateUnitBackButton;
    }
}