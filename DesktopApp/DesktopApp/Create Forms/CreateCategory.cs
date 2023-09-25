using Classes;
using DAL;
using LL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class CreateCategory : Form
    {
        ICategoryManager categoryManager = new CategoryManager(new CategoryDAO());
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        public CreateCategory()
        {
            InitializeComponent();
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            DepartmentManagerComboBox.DataSource = departmentManager.GetAllDepartments();
        }
        private void CreateCategotyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryNameTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
            }
            else
            {
                string categoryName = CategoryNameTextBox.Text;

                //DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);

                Department? department = DepartmentManagerComboBox.SelectedItem as Department;

                bool createDepartment = categoryManager.CreateCategory(new Category(0, categoryName, department));

                if (createDepartment)
                {
                    MessageBox.Show("Category Created");
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
        }

        private void CreateCategoryBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
