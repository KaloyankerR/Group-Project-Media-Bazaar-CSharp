using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Classes.Inventory_related;
using DAL;
using DAL.Inventory_related;
using LL;
using LL.Inventory_related;

namespace DesktopApp.Edit_Forms
{
    public partial class EditProduct : Form
    {
        IProductManager productManager = new ProductManager(new ProductDAO());
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        ICategoryManager categoryManager = new CategoryManager(new CategoryDAO());
        IUnitManager unitManager = new UnitManager(new UnitDAO());
        private Product product;
        public EditProduct(Product productToEdit)
        {
            InitializeComponent();
            product = productToEdit;
            LoadComboBoxes();
            LoadData();
        }
        public void LoadComboBoxes()
        {
            IteamDepartmentComboBox.DataSource = null;
            IteamDepartmentComboBox.DataSource = departmentManager.GetAllDepartments();
            CategoryIteamComboBox.DataSource = null;
            CategoryIteamComboBox.DataSource = categoryManager.GetAllCategories();
            UnitComboBox.DataSource = null;
            UnitComboBox.DataSource = unitManager.GetAllUnits();

        }
        public void LoadData()
        {
            IteamNameTextBox.Text = product.ProductName;
            IteamDepartmentComboBox.Text = product.Department.Name;
            CategoryIteamComboBox.Text = product.SubCategory.CategoryName;
            IteamPriceNumericUpDown.Text = product.ProductPrice.ToString();
            UnitComboBox.Text = product.Unit.name.ToString();
            QuantityIteamNumericUpDown.Text = product.ProductQuantity.ToString();
        }
        private void UpdateData()
        {
            product.ProductName = IteamNameTextBox.Text;
            product.Department.Name = IteamDepartmentComboBox.Text;
            product.SubCategory.CategoryName = CategoryIteamComboBox.Text;
            product.ProductPrice = Convert.ToInt32(IteamPriceNumericUpDown.Text);
            product.Unit = (Unit)UnitComboBox.SelectedItem;
            product.ProductQuantity = (int)QuantityIteamNumericUpDown.Value;
        }

        private void SaveEditProductButton_Click(object sender, EventArgs e)
        {
            UpdateData();
            productManager.UpdateProduct(product);
            Close();
        }

        private void EditProductBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


