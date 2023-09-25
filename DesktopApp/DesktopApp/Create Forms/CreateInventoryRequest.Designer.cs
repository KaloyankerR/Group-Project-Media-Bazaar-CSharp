namespace DesktopApp.Create_Forms
{
    partial class CreateInventoryRequest
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
            label2 = new Label();
            QuantityNumericUpDown1 = new NumericUpDown();
            ProductCBX = new ComboBox();
            AddMoreButton = new Button();
            SubmitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 73);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Choose:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 146);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 1;
            label2.Text = "Quantity:";
            // 
            // QuantityNumericUpDown1
            // 
            QuantityNumericUpDown1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityNumericUpDown1.Location = new Point(194, 139);
            QuantityNumericUpDown1.Name = "QuantityNumericUpDown1";
            QuantityNumericUpDown1.Size = new Size(265, 30);
            QuantityNumericUpDown1.TabIndex = 2;
            // 
            // ProductCBX
            // 
            ProductCBX.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ProductCBX.FormattingEnabled = true;
            ProductCBX.Location = new Point(194, 70);
            ProductCBX.Name = "ProductCBX";
            ProductCBX.Size = new Size(265, 31);
            ProductCBX.TabIndex = 3;
            // 
            // AddMoreButton
            // 
            AddMoreButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddMoreButton.Location = new Point(85, 209);
            AddMoreButton.Name = "AddMoreButton";
            AddMoreButton.Size = new Size(146, 55);
            AddMoreButton.TabIndex = 4;
            AddMoreButton.Text = "Add More";
            AddMoreButton.UseVisualStyleBackColor = true;
            AddMoreButton.Click += AddMoreButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.Location = new Point(313, 209);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(146, 55);
            SubmitButton.TabIndex = 6;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CreateInventoryRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 314);
            Controls.Add(SubmitButton);
            Controls.Add(AddMoreButton);
            Controls.Add(ProductCBX);
            Controls.Add(QuantityNumericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateInventoryRequest";
            Text = "Inventory Request";
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown QuantityNumericUpDown1;
        private ComboBox ProductCBX;
        private Button AddMoreButton;
        private Button SubmitButton;
    }
}