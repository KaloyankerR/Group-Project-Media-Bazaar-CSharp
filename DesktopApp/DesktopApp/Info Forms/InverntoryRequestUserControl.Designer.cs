namespace DesktopApp.Info_Forms
{
    partial class InverntoryRequestUserControl
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
            label1 = new Label();
            numQuantity = new NumericUpDown();
            cbProduct = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-114, 217);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 6;
            label1.Text = "Product:";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numQuantity.Location = new Point(606, 50);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(199, 30);
            numQuantity.TabIndex = 15;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantityValueChanged;
            // 
            // cbProduct
            // 
            cbProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(176, 47);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(200, 31);
            cbProduct.TabIndex = 14;
            cbProduct.SelectedIndexChanged += cbProductIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(450, 50);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 12;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 50);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 11;
            label4.Text = "Product:";
            // 
            // InverntoryRequestUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numQuantity);
            Controls.Add(cbProduct);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "InverntoryRequestUserControl";
            Size = new Size(889, 136);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private NumericUpDown numQuantity;
        private ComboBox cbProduct;
        private Label label3;
        private Label label4;
    }
}
