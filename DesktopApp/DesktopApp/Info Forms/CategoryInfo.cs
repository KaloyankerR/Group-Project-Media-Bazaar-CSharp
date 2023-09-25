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

namespace DesktopApp.Info_Forms
{
	public partial class CategoryInfo : UserControl
	{
		ICategoryManager categoryManager = new CategoryManager(new CategoryDAO());
		IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
		Classes.User User;
		List<Department> departments = new List<Department>();
		public CategoryInfo(Classes.User _user)
		{
			InitializeComponent();
			dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCategory.AllowUserToAddRows = false;
			User = _user;
			Load();
		}

		private void Load()
		{
			if (User.UserType is UserType.Manager)
			{
				departments.Add(User.Department);
				DepartmentInfoComboBox.DataSource = null;
				DepartmentInfoComboBox.DataSource = departments;
			}
			else
			{
				DepartmentInfoComboBox.DataSource = null;
				DepartmentInfoComboBox.DataSource = departmentManager.GetAllDepartments();
			}

			//dgvCategory.DataSource = categoryManager.GetAllCategories();
		}
		private void EditCategoryButton_Click(object sender, EventArgs e)
		{
			if (dgvCategory.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvCategory.SelectedRows[0];

				int categoryId = Convert.ToInt32(row.Cells["ID"].Value);
				Category category = categoryManager.GetCategoryByID(categoryId);

				EditCategory editCategory = new EditCategory(category);
				editCategory.ShowDialog();
			}
			else
			{
				MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void ShowAllCategoryButton_Click_1(object sender, EventArgs e)
		{
			DepartmentInfoComboBox.DataSource = departmentManager.GetAllDepartments();
			dgvCategory.DataSource = categoryManager.GetAllCategories();
		}

		private void DeleteCategoryButton_Click_1(object sender, EventArgs e)
		{
			if (dgvCategory.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvCategory.SelectedRows[0];

				int categoryId = Convert.ToInt32(row.Cells["ID"].Value);
				//string categoryName = row.Cells["CategoryName"].Value.ToString();
				//int departmentId = Convert.ToInt32(row.Cells["DepartmentId"].Value);
				//string departmentName = row.Cells["DepartmentName"].Value.ToString();

				//Department department = new Department();
				//department.DepartmentId = departmentId;
				//department.Name = departmentName;

				Category category = categoryManager.GetCategoryByID(categoryId);

				DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					if (categoryManager.DeleteCategory(category))
					{
						MessageBox.Show("Category deleted successfully.", "Success");
						dgvCategory.DataSource = categoryManager.GetAllCategories();
					}
					else
					{
						MessageBox.Show("Failed to delete category.", "Error");
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a row to delete.", "Error");
			}
			Load();
		}

		private void CreateCategoryButon_Click_1(object sender, EventArgs e)
		{
			CreateCategory createCategory = new CreateCategory();
			createCategory.ShowDialog();
			Load();
		}
		private void DepartmentInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedDepartment = DepartmentInfoComboBox.SelectedItem as Department;
			if (selectedDepartment != null)
			{
				var filteredCategory = categoryManager.GetCategoryByDepartment(selectedDepartment);
				DataTable dt = new DataTable();
				dt.Clear();
				dt.Columns.Add("ID", typeof(int));
				dt.Columns.Add("Name", typeof(string));
				dt.Columns.Add("Department", typeof(string));
				foreach (Category c in filteredCategory)
				{
					DataRow row = dt.NewRow();
					row["ID"] = c.CategoryID;
					row["Name"] = c.CategoryName;
					row["Department"] = c.ParentDepartment.Name;
					dt.Rows.Add(row);
				}
				dgvCategory.DataSource = null;
				dgvCategory.DataSource = dt;
			}
		}
	}
}
