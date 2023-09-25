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
    public partial class EditDepartment : Form
    {
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        private Department Department;
        public EditDepartment(Department departmentToEdit)
        {
            InitializeComponent();
            this.Department = departmentToEdit;
            LoadData();
        }
        public void LoadData()
        {
            EditDepartmentNameTextBox.Text = Department.Name;
        }
        public void UpdateData()
        {
            Department.Name = EditDepartmentNameTextBox.Text;
        }

        private void EditDepartmentBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveEditDepartmentButton_Click(object sender, EventArgs e)
        {
            UpdateData();
            departmentManager.UpdateDepartment(Department);
            Close();
        }
    }
}
