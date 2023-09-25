using Classes;
using DAL;
using DesktopApp.Edit_Forms;
using LL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
	public partial class EmployeeeInfo : UserControl
	{
		IUserManager userManager = new UserManager(new UserDAO());
		IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());

		public EmployeeeInfo()
		{
			InitializeComponent();
			dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUser.AllowUserToAddRows = false;
			LoadAllUsers();
		}

		public void LoadAllUsers()
		{
			cbxDepartment.DataSource = null;
			cbxDepartment.DataSource = departmentManager.GetAllDepartments();
			//dvg.D
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			CreateEmployee createEmployee = new();
			createEmployee.ShowDialog();
			LoadAllUsers();
		}

		private void ShowAllEmployeeButton_Click(object sender, EventArgs e)
		{
			var filteredUsers = userManager.GetAllUsers();
			DataTable dt = new DataTable();
			dt.Clear();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("First Name", typeof(string));
			dt.Columns.Add("Last Name", typeof(string));
			dt.Columns.Add("Email", typeof(string));
			dt.Columns.Add("Date Of Birth", typeof(DateOnly));
			dt.Columns.Add("Phone", typeof(string));
			dt.Columns.Add("BSN", typeof(string));
			dt.Columns.Add("User Type", typeof(UserType));
			dt.Columns.Add("Department", typeof(string));
			foreach (User user in filteredUsers)
			{
				DataRow row = dt.NewRow();
				row["ID"] = user.UserID;
				row["First Name"] = user.FirstName;
				row["Last Name"] = user.LastName;
				row["Email"] = user.Email;
				row["Date Of Birth"] = user.DateOfBirth;
				row["Phone"] = user.PhoneNumber;
				row["BSN"] = user.BSN;
				row["User Type"] = user.UserType;
				row["Department"] = user.Department.Name;
				dt.Rows.Add(row);
			}
			dgvUser.DataSource = null;
			dgvUser.DataSource = dt;
		}

		private void DeleteEmployeeButton_Click(object sender, EventArgs e)
		{
			if (dgvUser.SelectedRows != null)
			{
				DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this User?", "Delete User", MessageBoxButtons.YesNo);
				if (deletePrompt == DialogResult.Yes)
				{
					int userID = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["ID"].Value);
					User user = userManager.GetUserByID(userID);
					if (user.UserType == UserType.Manager)
					{
						if (user.Department == null)
						{
							bool resultUser = userManager.DeleteUser(user, user.Address);
							if (resultUser)
							{
								MessageBox.Show("User deleted");
								LoadAllUsers();
							}
							else
							{
								MessageBox.Show("User not deleted");
							}
						}
						else
						{
							MessageBox.Show("User must be first removed from the departent where he is manager!");
						}
					}
					else
					{
						bool resultUser = userManager.DeleteUser(user, user.Address);
						if (resultUser)
						{
							MessageBox.Show("User deleted");
							LoadAllUsers();
						}
						else
						{
							MessageBox.Show("User not deleted");
						}
					}

				}
				else
				{
					MessageBox.Show("User not deleted");
				}
			}
			else
			{
				MessageBox.Show("Please select a user");
			}

		}

		private void EditEmployeeButton_Click(object sender, EventArgs e)
		{
			if (dgvUser.SelectedRows != null)
			{
				int userID = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["ID"].Value);
				User user = userManager.GetUserByID(userID);

				EditEmployee editEmployee = new EditEmployee(user);
				editEmployee.ShowDialog();
				LoadAllUsers();
			}

		}

		private void dgvUser_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			e.Cancel = true;
		}

		private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedDepartment = cbxDepartment.SelectedItem as Department;
			if (selectedDepartment != null)
			{
				var filteredUsers = userManager.GetUsersByDepartment(selectedDepartment);
				DataTable dt = new DataTable();
				dt.Clear();
				dt.Columns.Add("ID", typeof(int));
				dt.Columns.Add("First Name", typeof(string));
				dt.Columns.Add("Last Name", typeof(string));
				dt.Columns.Add("Email", typeof(string));
				dt.Columns.Add("Date Of Birth", typeof(DateOnly));
				dt.Columns.Add("Phone", typeof(string));
				dt.Columns.Add("BSN", typeof(string));
				dt.Columns.Add("User Type", typeof(UserType));
				dt.Columns.Add("Department", typeof(string));
				foreach (User user in filteredUsers)
				{
					DataRow row = dt.NewRow();
					row["ID"] = user.UserID;
					row["First Name"] = user.FirstName;
					row["Last Name"] = user.LastName;
					row["Email"] = user.Email;
					row["Date Of Birth"] = user.DateOfBirth;
					row["Phone"] = user.PhoneNumber;
					row["BSN"] = user.BSN;
					row["User Type"] = user.UserType;
					row["Department"] = user.Department.Name;
					dt.Rows.Add(row);
				}
				dgvUser.DataSource = null;
				dgvUser.DataSource = dt;
			}
		}
	}
}
