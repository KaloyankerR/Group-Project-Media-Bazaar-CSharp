namespace DesktopApp.Edit_Forms
{
    partial class EditProduct
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
            CategoryIteamComboBox = new ComboBox();
            EditCategoryProductLabel = new Label();
            QuantityIteamNumericUpDown = new NumericUpDown();
            IteamPriceNumericUpDown = new NumericUpDown();
            IteamDepartmentComboBox = new ComboBox();
            IteamNameTextBox = new TextBox();
            EditQuantityProductLabel = new Label();
            EditPriceProductLabel = new Label();
            EditProductDepartmentLabel = new Label();
            EditProductNameLabel = new Label();
            EditProductBackButton = new Button();
            SaveEditProductButton = new Button();
            ProductUnit = new Label();
            UnitComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)QuantityIteamNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IteamPriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // CategoryIteamComboBox
            // 
            CategoryIteamComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryIteamComboBox.FormattingEnabled = true;
            CategoryIteamComboBox.Location = new Point(169, 184);
            CategoryIteamComboBox.Name = "CategoryIteamComboBox";
            CategoryIteamComboBox.Size = new Size(183, 26);
            CategoryIteamComboBox.TabIndex = 32;
            // 
            // EditCategoryProductLabel
            // 
            EditCategoryProductLabel.AutoSize = true;
            EditCategoryProductLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditCategoryProductLabel.Location = new Point(41, 184);
            EditCategoryProductLabel.Name = "EditCategoryProductLabel";
            EditCategoryProductLabel.Size = new Size(81, 18);
            EditCategoryProductLabel.TabIndex = 31;
            EditCategoryProductLabel.Text = "Category:";
            // 
            // QuantityIteamNumericUpDown
            // 
            QuantityIteamNumericUpDown.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityIteamNumericUpDown.Location = new Point(132, 334);
            QuantityIteamNumericUpDown.Name = "QuantityIteamNumericUpDown";
            QuantityIteamNumericUpDown.Size = new Size(220, 24);
            QuantityIteamNumericUpDown.TabIndex = 22;
            // 
            // IteamPriceNumericUpDown
            // 
            IteamPriceNumericUpDown.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamPriceNumericUpDown.Location = new Point(109, 240);
            IteamPriceNumericUpDown.Name = "IteamPriceNumericUpDown";
            IteamPriceNumericUpDown.Size = new Size(243, 24);
            IteamPriceNumericUpDown.TabIndex = 26;
            // 
            // IteamDepartmentComboBox
            // 
            IteamDepartmentComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamDepartmentComboBox.FormattingEnabled = true;
            IteamDepartmentComboBox.Location = new Point(169, 122);
            IteamDepartmentComboBox.Name = "IteamDepartmentComboBox";
            IteamDepartmentComboBox.Size = new Size(183, 26);
            IteamDepartmentComboBox.TabIndex = 23;
            // 
            // IteamNameTextBox
            // 
            IteamNameTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamNameTextBox.Location = new Point(169, 63);
            IteamNameTextBox.Name = "IteamNameTextBox";
            IteamNameTextBox.Size = new Size(183, 24);
            IteamNameTextBox.TabIndex = 24;
            // 
            // EditQuantityProductLabel
            // 
            EditQuantityProductLabel.AutoSize = true;
            EditQuantityProductLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditQuantityProductLabel.Location = new Point(41, 333);
            EditQuantityProductLabel.Name = "EditQuantityProductLabel";
            EditQuantityProductLabel.Size = new Size(75, 18);
            EditQuantityProductLabel.TabIndex = 29;
            EditQuantityProductLabel.Text = "Quantity:";
            // 
            // EditPriceProductLabel
            // 
            EditPriceProductLabel.AutoSize = true;
            EditPriceProductLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditPriceProductLabel.Location = new Point(41, 239);
            EditPriceProductLabel.Name = "EditPriceProductLabel";
            EditPriceProductLabel.Size = new Size(52, 18);
            EditPriceProductLabel.TabIndex = 28;
            EditPriceProductLabel.Text = "Price:";
            // 
            // EditProductDepartmentLabel
            // 
            EditProductDepartmentLabel.AutoSize = true;
            EditProductDepartmentLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditProductDepartmentLabel.Location = new Point(41, 122);
            EditProductDepartmentLabel.Name = "EditProductDepartmentLabel";
            EditProductDepartmentLabel.Size = new Size(109, 18);
            EditProductDepartmentLabel.TabIndex = 27;
            EditProductDepartmentLabel.Text = "Deapartment:";
            // 
            // EditProductNameLabel
            // 
            EditProductNameLabel.AutoSize = true;
            EditProductNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditProductNameLabel.Location = new Point(41, 68);
            EditProductNameLabel.Name = "EditProductNameLabel";
            EditProductNameLabel.Size = new Size(103, 18);
            EditProductNameLabel.TabIndex = 25;
            EditProductNameLabel.Text = "Iteam Name:";
            // 
            // EditProductBackButton
            // 
            EditProductBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditProductBackButton.Location = new Point(207, 393);
            EditProductBackButton.Name = "EditProductBackButton";
            EditProductBackButton.Size = new Size(98, 48);
            EditProductBackButton.TabIndex = 34;
            EditProductBackButton.Text = "Back";
            EditProductBackButton.UseVisualStyleBackColor = true;
            EditProductBackButton.Click += EditProductBackButton_Click;
            // 
            // SaveEditProductButton
            // 
            SaveEditProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveEditProductButton.Location = new Point(52, 393);
            SaveEditProductButton.Name = "SaveEditProductButton";
            SaveEditProductButton.Size = new Size(98, 48);
            SaveEditProductButton.TabIndex = 33;
            SaveEditProductButton.Text = "Save";
            SaveEditProductButton.UseVisualStyleBackColor = true;
            SaveEditProductButton.Click += SaveEditProductButton_Click;
            // 
            // ProductUnit
            // 
            ProductUnit.AutoSize = true;
            ProductUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductUnit.Location = new Point(41, 285);
            ProductUnit.Name = "ProductUnit";
            ProductUnit.Size = new Size(47, 20);
            ProductUnit.TabIndex = 35;
            ProductUnit.Text = " Unit:";
            // 
            // UnitComboBox
            // 
            UnitComboBox.FormattingEnabled = true;
            UnitComboBox.Location = new Point(109, 282);
            UnitComboBox.Name = "UnitComboBox";
            UnitComboBox.Size = new Size(243, 28);
            UnitComboBox.TabIndex = 36;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 490);
            Controls.Add(UnitComboBox);
            Controls.Add(ProductUnit);
            Controls.Add(EditProductBackButton);
            Controls.Add(SaveEditProductButton);
            Controls.Add(CategoryIteamComboBox);
            Controls.Add(EditCategoryProductLabel);
            Controls.Add(QuantityIteamNumericUpDown);
            Controls.Add(IteamPriceNumericUpDown);
            Controls.Add(IteamDepartmentComboBox);
            Controls.Add(IteamNameTextBox);
            Controls.Add(EditQuantityProductLabel);
            Controls.Add(EditPriceProductLabel);
            Controls.Add(EditProductDepartmentLabel);
            Controls.Add(EditProductNameLabel);
            Name = "EditProduct";
            Text = "EditProduct";
            ((System.ComponentModel.ISupportInitialize)QuantityIteamNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)IteamPriceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryIteamComboBox;
        private Label EditCategoryProductLabel;
        private NumericUpDown QuantityIteamNumericUpDown;
        private NumericUpDown IteamPriceNumericUpDown;
        private ComboBox IteamDepartmentComboBox;
        private TextBox IteamNameTextBox;
        private Label EditQuantityProductLabel;
        private Label EditPriceProductLabel;
        private Label EditProductDepartmentLabel;
        private Label EditProductNameLabel;
        private Button EditProductBackButton;
        private Button SaveEditProductButton;
        private Label ProductUnit;
        private ComboBox UnitComboBox;
    }
}