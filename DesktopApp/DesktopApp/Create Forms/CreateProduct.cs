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

namespace DesktopApp.Create_Forms
{
    public partial class CreateProduct : Form
    {
        IProductManager productManager = new ProductManager(new ProductDAO());
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        ICategoryManager categoryManager = new CategoryManager(new CategoryDAO());
        IUnitManager unitManager=new UnitManager(new UnitDAO());
        public CreateProduct()
        {
            InitializeComponent();
            LoadComboBoxes();
        }
        public void LoadComboBoxes()
        {
            IteamDepartmentComboBox.DataSource = null;
            IteamDepartmentComboBox.DataSource = departmentManager.GetAllDepartments();
            CategoryProductComboBox.DataSource = null;
            CategoryProductComboBox.DataSource = categoryManager.GetAllCategories();
            UnitComboBox.DataSource = null;
            UnitComboBox.DataSource=unitManager.GetAllUnits();
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IteamNameTextBox.Text) || string.IsNullOrEmpty(IteamDepartmentComboBox.Text) || string.IsNullOrEmpty(CategoryProductComboBox.Text) || string.IsNullOrEmpty(IteamPriceNumericUpDown.Text) || string.IsNullOrEmpty(QuantityProductNumericUpDown.Text!))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
                return;
            }
            else
            {
                string productName = IteamNameTextBox.Text;

                Department department = IteamDepartmentComboBox.SelectedItem as Department;
                Category category = CategoryProductComboBox.SelectedItem as Category;
                Unit unit=UnitComboBox.SelectedItem as Unit;
                int price = Convert.ToInt32(IteamPriceNumericUpDown.Value);
                int quantity = Convert.ToInt32(QuantityProductNumericUpDown.Value);

                bool createProduct = productManager.CreateProduct(new Product(0, productName, price, quantity, unit, category, department));
                if (createProduct)
                {
                    MessageBox.Show("Product created!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
        }

        private void CreateProductBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
