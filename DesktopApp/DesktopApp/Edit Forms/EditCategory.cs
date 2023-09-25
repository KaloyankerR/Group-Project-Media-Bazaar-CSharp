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
using DAL;
using LL;

namespace DesktopApp
{
    public partial class EditCategory : Form
    {
        ICategoryManager categoryManager = new CategoryManager(new CategoryDAO());
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());

        private Category category { get; set; }

        public EditCategory(Category newCategory)
        {
            InitializeComponent();
            category = newCategory;
            LoadData();
        }

        public void LoadData()
        {
            EditCategoryNameTextBox.Text = category.CategoryName;
            EditDepartmentComboBox.DataSource = null;
            EditDepartmentComboBox.DataSource = departmentManager.GetAllDepartments();
        }

        private void SaveEditCategoryButton_Click(object sender, EventArgs e)
        {
            Department selectedDepartment = (Department)EditDepartmentComboBox.SelectedItem;

            category.CategoryName = EditDepartmentComboBox.Text;
            category.ParentDepartment = selectedDepartment;
            categoryManager.UpdateCategory(category);
        }
    }
}
