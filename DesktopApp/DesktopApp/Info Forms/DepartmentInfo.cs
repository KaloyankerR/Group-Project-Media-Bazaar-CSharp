using Classes;
using DAL;
using LL;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class DepartmentInfo : UserControl
	{
		IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
		public DepartmentInfo()
		{
			InitializeComponent();
			dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDepartment.AllowUserToAddRows = false;
			Load();
		}
		private void Load()
		{

			dgvDepartment.DataSource = null;
			//dgvDepartment.DataSource = departmentManager.GetAllDepartments();
			List<Department> list = departmentManager.GetAllDepartments();
			DataTable dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Department Name", typeof(string));
			dt.Columns.Add("Creation Date", typeof(DateOnly));
			foreach (Department department in list)
			{
				DataRow row = dt.NewRow();
				row["ID"] = department.DepartmentId;
				row["Department Name"] = department.Name;
				row["Creation Date"] = department.CreationDate;
				dt.Rows.Add(row);
			}
			dgvDepartment.DataSource = dt;
		}

		private void ShowAllDepartmentsButton_Click(object sender, EventArgs e)
		{

			dgvDepartment.DataSource = null;
			dgvDepartment.DataSource = departmentManager.GetAllDepartments();

		}

		private void EditDepartmentButton_Click(object sender, EventArgs e)
		{


			if (dgvDepartment.SelectedRows != null)
			{
                int departmentId = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["ID"].Value);
                if (departmentId == 1008)
                {
                    MessageBox.Show("You can not edit the General department! Choose another one!");
                }
				else
				{
                    departmentId = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["ID"].Value);
                    Department department = departmentManager.GetDepartmentById(departmentId);
                    EditDepartment editDepartment = new EditDepartment(department);
                    editDepartment.ShowDialog();
                }
                
			}
		}

		private void DeleteDepartmentButton_Click(object sender, EventArgs e)
		{
			if (dgvDepartment.SelectedRows != null)
			{
                int departmentId = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["ID"].Value);
                if (departmentId==1008)
				{
					MessageBox.Show("You can not delete the General department! Choose another one!");
				}
				else
				{
                    DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this Department?", "Delete Department", MessageBoxButtons.YesNo);
                    if (deletePrompt == DialogResult.Yes)
                    {
                        departmentId = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["ID"].Value);
                        Department department = departmentManager.GetDepartmentById(departmentId);
                        bool resultUser = departmentManager.DeleteDepartment(department);
                        if (resultUser)
                        {
                            MessageBox.Show("Department deleted");

                        }
                        else
                        {
                            MessageBox.Show("Department not deleted");
                        }
                    }
                }
				

			}
			Load();
		}

		private void CreateDepartmentButton_Click(object sender, EventArgs e)
		{
			CreateDepartment createDepartment = new CreateDepartment();
			createDepartment.ShowDialog();
			Load();
		}

		private void DepartmentInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
