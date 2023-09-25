namespace DesktopApp.Edit_Forms
{
    partial class EditUnit
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
            EditUnitBackButton = new Button();
            EditUnitNameTBX = new TextBox();
            UnitNameLabel = new Label();
            SaveEditUnitButton = new Button();
            SuspendLayout();
            // 
            // EditUnitBackButton
            // 
            EditUnitBackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditUnitBackButton.Location = new Point(195, 106);
            EditUnitBackButton.Name = "EditUnitBackButton";
            EditUnitBackButton.Size = new Size(111, 67);
            EditUnitBackButton.TabIndex = 7;
            EditUnitBackButton.Text = "Back";
            EditUnitBackButton.UseVisualStyleBackColor = true;
            EditUnitBackButton.Click += EditUnitBackButton_Click;
            // 
            // EditUnitNameTBX
            // 
            EditUnitNameTBX.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditUnitNameTBX.Location = new Point(137, 49);
            EditUnitNameTBX.Name = "EditUnitNameTBX";
            EditUnitNameTBX.Size = new Size(169, 30);
            EditUnitNameTBX.TabIndex = 6;
            // 
            // UnitNameLabel
            // 
            UnitNameLabel.AutoSize = true;
            UnitNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnitNameLabel.Location = new Point(38, 52);
            UnitNameLabel.Name = "UnitNameLabel";
            UnitNameLabel.Size = new Size(62, 23);
            UnitNameLabel.TabIndex = 5;
            UnitNameLabel.Text = "Name:";
            // 
            // SaveEditUnitButton
            // 
            SaveEditUnitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SaveEditUnitButton.Location = new Point(38, 106);
            SaveEditUnitButton.Name = "SaveEditUnitButton";
            SaveEditUnitButton.Size = new Size(111, 67);
            SaveEditUnitButton.TabIndex = 4;
            SaveEditUnitButton.Text = "Save";
            SaveEditUnitButton.UseVisualStyleBackColor = true;
            SaveEditUnitButton.Click += SaveEditUnitButton_Click;
            // 
            // EditUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 222);
            Controls.Add(EditUnitBackButton);
            Controls.Add(EditUnitNameTBX);
            Controls.Add(UnitNameLabel);
            Controls.Add(SaveEditUnitButton);
            Name = "EditUnit";
            Text = "EditUnit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditUnitBackButton;
        private TextBox EditUnitNameTBX;
        private Label UnitNameLabel;
        private Button SaveEditUnitButton;
    }
}