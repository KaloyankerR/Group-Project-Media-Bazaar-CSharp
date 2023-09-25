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
using Classes.Request_related;
using DAL;
using DAL.Request_related;
using DesktopApp.Create_Forms;
using DesktopApp.Edit_Forms;
using LL;
using LL.Request_Related;
using Microsoft.VisualBasic.ApplicationServices;

namespace DesktopApp.Info_Forms
{
	public partial class ProductInfo : UserControl
	{
		IProductManager productManager = new ProductManager(new ProductDAO());
		IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
		ICategoryManager categoryManager = new CategoryManager(new CategoryDAO());
		IRequestManager requestManager = new RequestManager(new RequestDAO());
		Classes.User User;
		List<Department> departments = new List<Department>();
		public ProductInfo(Classes.User _user)
		{
			InitializeComponent();
			dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProduct.AllowUserToAddRows = false;
			User = _user;
			if (User.UserType is UserType.Manager) departments.Add(User.Department);
			LoadAllProducts();

		}
		public void LoadAllProducts()
		{
			if (User.UserType is UserType.Manager)
			{
				ProductInfoDepartmentComboBox.DataSource = null;

				ProductInfoDepartmentComboBox.DataSource = departments;
				ProductInfoCategoryComboBox.DataSource = null;
				ProductInfoCategoryComboBox.DataSource = categoryManager.GetCategoryByDepartment(ProductInfoDepartmentComboBox.SelectedItem as Department);
				var selectedCategory = ProductInfoCategoryComboBox.SelectedItem as Category;
				var filteredProducts = productManager.GetProductsByCategory(selectedCategory);
				var department = ProductInfoDepartmentComboBox.SelectedItem as Department;

				DataTable dt = new DataTable();
				dt.Clear();
				dt.Columns.Add("ID", typeof(int));
				dt.Columns.Add("Name", typeof(string));
				dt.Columns.Add("Price", typeof(double));
				dt.Columns.Add("Quntity", typeof(int));
				dt.Columns.Add("Threshold", typeof(int));
				dt.Columns.Add("Unit", typeof(string));
				dt.Columns.Add("Category", typeof(string));
				dt.Columns.Add("Department", typeof(string));
				foreach (Product item in filteredProducts)
				{
					DataRow row = dt.NewRow();
					row["ID"] = item.ProductID;
					row["Name"] = item.ProductName;
					row["Price"] = item.ProductPrice;
					row["Quntity"] = item.ProductQuantity;
					row["Threshold"] = item.IteamThreshold;
					row["Unit"] = item.Unit.name;
					row["Category"] = item.SubCategory.CategoryName;
					row["Department"] = department.Name;
					dt.Rows.Add(row);
				}
				dgvProduct.DataSource = null;
				dgvProduct.DataSource = dt;
			}
			else
			{
				ProductInfoDepartmentComboBox.DataSource = null;
				ProductInfoCategoryComboBox.DataSource = null;
				ProductInfoDepartmentComboBox.DataSource = departmentManager.GetAllDepartments();
				ProductInfoCategoryComboBox.DataSource = categoryManager.GetCategoryByDepartment(ProductInfoDepartmentComboBox.SelectedItem as Department);
			}



		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			CreateProduct createProduct = new CreateProduct();
			createProduct.ShowDialog();
			LoadAllProducts();
		}

		private void EditProductButton_Click(object sender, EventArgs e)
		{

			if (dgvProduct.SelectedRows.Count > 0)
			{
				int productId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["ID"].Value);
				Product product = productManager.GetProductByID(productId);
				EditProduct editProduct = new EditProduct(product);
				editProduct.ShowDialog();
				LoadAllProducts();
			}

		}

		private void DeleteProductButton_Click(object sender, EventArgs e)
		{
			if (dgvProduct.SelectedRows.Count > 0)
			{
				DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo);
				if (deletePrompt == DialogResult.Yes)
				{
					int productId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["ID"].Value);
					Product product = productManager.GetProductByID(productId);
					bool resultUser = productManager.DeleteProduct(product);
					if (resultUser)
					{
						MessageBox.Show("Produt deleted");
						LoadAllProducts();
					}
					else
					{
						MessageBox.Show("Product not deleted");
					}
				}
			}
			LoadAllProducts();
		}

		private void ShowAllProductButton_Click(object sender, EventArgs e)
		{
			LoadAllProducts();
			ProductInfoDepartmentComboBox.Text = string.Empty;
			ProductInfoCategoryComboBox.Text = string.Empty;
			DataTable dt = new DataTable();
			dt.Clear();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("Price", typeof(double));
			dt.Columns.Add("Quntity", typeof(int));
			dt.Columns.Add("Threshold", typeof(int));
			dt.Columns.Add("Unit", typeof(string));
			dt.Columns.Add("Category", typeof(string));
			dt.Columns.Add("Department", typeof(string));
			foreach (Product item in productManager.GetAllProducts())
			{
				DataRow row = dt.NewRow();
				row["ID"] = item.ProductID;
				row["Name"] = item.ProductName;
				row["Price"] = item.ProductPrice;
				row["Quntity"] = item.ProductQuantity;
				row["Threshold"] = item.IteamThreshold;
				row["Unit"] = item.Unit.name;
				row["Category"] = item.SubCategory.CategoryName;
				row["Department"] = item.Department.Name;
				dt.Rows.Add(row);

			}
			dgvProduct.DataSource = null;
			dgvProduct.DataSource = dt;
		}

		private void ProductInfoDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedDepartment = ProductInfoDepartmentComboBox.SelectedItem as Department;
			if (selectedDepartment != null)
			{
				var filteredCategories = categoryManager.GetCategoryByDepartment(selectedDepartment);
				ProductInfoCategoryComboBox.DataSource = null;
				ProductInfoCategoryComboBox.DataSource = filteredCategories;
			}
		}

		private void ProductInfoCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedCategory = ProductInfoCategoryComboBox.SelectedItem as Category;
			if (selectedCategory != null)
			{
				if (User.UserType is UserType.Manager)
				{
					dgvProduct.DataSource = null;
					var filteredProducts = productManager.GetProductsByCategory(selectedCategory);
					var department = ProductInfoDepartmentComboBox.SelectedItem as Department;

					DataTable dt = new DataTable();
					dt.Clear();
					dt.Columns.Add("ID", typeof(int));
					dt.Columns.Add("Name", typeof(string));
					dt.Columns.Add("Price", typeof(double));
					dt.Columns.Add("Quntity", typeof(int));
					dt.Columns.Add("Threshold", typeof(int));
					dt.Columns.Add("Unit", typeof(string));
					dt.Columns.Add("Category", typeof(string));
					dt.Columns.Add("Department", typeof(string));
					foreach (Product item in filteredProducts)
					{
						DataRow row = dt.NewRow();
						row["ID"] = item.ProductID;
						row["Name"] = item.ProductName;
						row["Price"] = item.ProductPrice;
						row["Quntity"] = item.ProductQuantity;
						row["Threshold"] = item.IteamThreshold;
						row["Unit"] = item.Unit.name;
						row["Category"] = item.SubCategory.CategoryName;
						row["Department"] = department.Name;
						dt.Rows.Add(row);
					}
					dgvProduct.DataSource = null;
					dgvProduct.DataSource = dt;
				}
				else
				{
					var filteredProducts = productManager.GetProductsByCategory(selectedCategory);
					var department = ProductInfoDepartmentComboBox.SelectedItem as Department;

					DataTable dt = new DataTable();
					dt.Clear();
					dt.Columns.Add("ID", typeof(int));
					dt.Columns.Add("Name", typeof(string));
					dt.Columns.Add("Price", typeof(double));
					dt.Columns.Add("Quntity", typeof(int));
					dt.Columns.Add("Threshold", typeof(int));
					dt.Columns.Add("Unit", typeof(string));
					dt.Columns.Add("Category", typeof(string));
					dt.Columns.Add("Department", typeof(string));
					foreach (Product item in filteredProducts)
					{
						DataRow row = dt.NewRow();
						row["ID"] = item.ProductID;
						row["Name"] = item.ProductName;
						row["Price"] = item.ProductPrice;
						row["Quntity"] = item.ProductQuantity;
						row["Threshold"] = item.IteamThreshold;
						row["Unit"] = item.Unit.name;
						row["Category"] = item.SubCategory.CategoryName;
						row["Department"] = department.Name;
						dt.Rows.Add(row);
					}
					dgvProduct.DataSource = null;
					dgvProduct.DataSource = dt;
				}

			}
		}

		private void RequestProductButton_Click(object sender, EventArgs e)
		{
			var department = ProductInfoDepartmentComboBox.SelectedItem as Department;
			requestManager.CreateRequest(new Request(0, department, "Pending", DateOnly.FromDateTime(DateTime.Now),null));
			Request request = requestManager.GetLastRequestByDepartmentId(department);
			ItemsRequestedFrom itemsRequestedFrom = new ItemsRequestedFrom(department, request);
			itemsRequestedFrom.ShowDialog();
		}

		private void RefershButton_Click(object sender, EventArgs e)
		{
			LoadAllProducts();
		}
	}
}

