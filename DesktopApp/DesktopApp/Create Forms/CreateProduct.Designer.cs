namespace DesktopApp.Create_Forms
{
    partial class CreateProduct
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
            CategoryProductComboBox = new ComboBox();
            CategoryLabel = new Label();
            QuantityProductNumericUpDown = new NumericUpDown();
            IteamPriceNumericUpDown = new NumericUpDown();
            IteamDepartmentComboBox = new ComboBox();
            IteamNameTextBox = new TextBox();
            CreateProductButton = new Button();
            ProductQuantityLabel = new Label();
            PriceProductLabel = new Label();
            DepartmentProductComboBox = new Label();
            IteamNameLabel = new Label();
            CreateProductBackButton = new Button();
            ProductUnit = new Label();
            UnitComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)QuantityProductNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IteamPriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // CategoryProductComboBox
            // 
            CategoryProductComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryProductComboBox.FormattingEnabled = true;
            CategoryProductComboBox.Location = new Point(175, 182);
            CategoryProductComboBox.Name = "CategoryProductComboBox";
            CategoryProductComboBox.Size = new Size(183, 26);
            CategoryProductComboBox.TabIndex = 21;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(47, 182);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(81, 18);
            CategoryLabel.TabIndex = 20;
            CategoryLabel.Text = "Category:";
            // 
            // QuantityProductNumericUpDown
            // 
            QuantityProductNumericUpDown.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityProductNumericUpDown.Location = new Point(138, 333);
            QuantityProductNumericUpDown.Name = "QuantityProductNumericUpDown";
            QuantityProductNumericUpDown.Size = new Size(220, 24);
            QuantityProductNumericUpDown.TabIndex = 11;
            // 
            // IteamPriceNumericUpDown
            // 
            IteamPriceNumericUpDown.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamPriceNumericUpDown.Location = new Point(115, 238);
            IteamPriceNumericUpDown.Name = "IteamPriceNumericUpDown";
            IteamPriceNumericUpDown.Size = new Size(243, 24);
            IteamPriceNumericUpDown.TabIndex = 15;
            // 
            // IteamDepartmentComboBox
            // 
            IteamDepartmentComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamDepartmentComboBox.FormattingEnabled = true;
            IteamDepartmentComboBox.Location = new Point(175, 120);
            IteamDepartmentComboBox.Name = "IteamDepartmentComboBox";
            IteamDepartmentComboBox.Size = new Size(183, 26);
            IteamDepartmentComboBox.TabIndex = 12;
            // 
            // IteamNameTextBox
            // 
            IteamNameTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamNameTextBox.Location = new Point(175, 61);
            IteamNameTextBox.Name = "IteamNameTextBox";
            IteamNameTextBox.Size = new Size(183, 24);
            IteamNameTextBox.TabIndex = 13;
            // 
            // CreateProductButton
            // 
            CreateProductButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateProductButton.Location = new Point(47, 379);
            CreateProductButton.Name = "CreateProductButton";
            CreateProductButton.Size = new Size(119, 68);
            CreateProductButton.TabIndex = 19;
            CreateProductButton.Text = "Create";
            CreateProductButton.UseVisualStyleBackColor = true;
            CreateProductButton.Click += CreateProductButton_Click;
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductQuantityLabel.Location = new Point(47, 332);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(75, 18);
            ProductQuantityLabel.TabIndex = 18;
            ProductQuantityLabel.Text = "Quantity:";
            // 
            // PriceProductLabel
            // 
            PriceProductLabel.AutoSize = true;
            PriceProductLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriceProductLabel.Location = new Point(47, 237);
            PriceProductLabel.Name = "PriceProductLabel";
            PriceProductLabel.Size = new Size(52, 18);
            PriceProductLabel.TabIndex = 17;
            PriceProductLabel.Text = "Price:";
            // 
            // DepartmentProductComboBox
            // 
            DepartmentProductComboBox.AutoSize = true;
            DepartmentProductComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DepartmentProductComboBox.Location = new Point(47, 120);
            DepartmentProductComboBox.Name = "DepartmentProductComboBox";
            DepartmentProductComboBox.Size = new Size(109, 18);
            DepartmentProductComboBox.TabIndex = 16;
            DepartmentProductComboBox.Text = "Deapartment:";
            // 
            // IteamNameLabel
            // 
            IteamNameLabel.AutoSize = true;
            IteamNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IteamNameLabel.Location = new Point(47, 66);
            IteamNameLabel.Name = "IteamNameLabel";
            IteamNameLabel.Size = new Size(103, 18);
            IteamNameLabel.TabIndex = 14;
            IteamNameLabel.Text = "Iteam Name:";
            // 
            // CreateProductBackButton
            // 
            CreateProductBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateProductBackButton.Location = new Point(230, 379);
            CreateProductBackButton.Name = "CreateProductBackButton";
            CreateProductBackButton.Size = new Size(110, 68);
            CreateProductBackButton.TabIndex = 22;
            CreateProductBackButton.Text = "Back";
            CreateProductBackButton.UseVisualStyleBackColor = true;
            CreateProductBackButton.Click += CreateProductBackButton_Click;
            // 
            // ProductUnit
            // 
            ProductUnit.AutoSize = true;
            ProductUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductUnit.Location = new Point(47, 291);
            ProductUnit.Name = "ProductUnit";
            ProductUnit.Size = new Size(47, 20);
            ProductUnit.TabIndex = 23;
            ProductUnit.Text = " Unit:";
            // 
            // UnitComboBox
            // 
            UnitComboBox.FormattingEnabled = true;
            UnitComboBox.Location = new Point(115, 288);
            UnitComboBox.Name = "UnitComboBox";
            UnitComboBox.Size = new Size(243, 28);
            UnitComboBox.TabIndex = 24;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 485);
            Controls.Add(UnitComboBox);
            Controls.Add(ProductUnit);
            Controls.Add(CreateProductBackButton);
            Controls.Add(CategoryProductComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(QuantityProductNumericUpDown);
            Controls.Add(IteamPriceNumericUpDown);
            Controls.Add(IteamDepartmentComboBox);
            Controls.Add(IteamNameTextBox);
            Controls.Add(CreateProductButton);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(PriceProductLabel);
            Controls.Add(DepartmentProductComboBox);
            Controls.Add(IteamNameLabel);
            Name = "CreateProduct";
            Text = "CreateProduct";
            ((System.ComponentModel.ISupportInitialize)QuantityProductNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)IteamPriceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryProductComboBox;
        private Label CategoryLabel;
        private NumericUpDown QuantityProductNumericUpDown;
        private NumericUpDown IteamPriceNumericUpDown;
        private ComboBox IteamDepartmentComboBox;
        private TextBox IteamNameTextBox;
        private Button CreateProductButton;
        private Label ProductQuantityLabel;
        private Label PriceProductLabel;
        private Label DepartmentProductComboBox;
        private Label IteamNameLabel;
        private Button CreateProductBackButton;
        private Label ProductUnit;
        private ComboBox UnitComboBox;
    }
}