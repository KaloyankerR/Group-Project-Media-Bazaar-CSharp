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
    public partial class CreateDepartment : Form
    {
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        public CreateDepartment()
        {
            InitializeComponent();
        }

       
        private void CreateDeaprtmentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DepartmentNameTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
            }
            else
            {
                string departmentName = DepartmentNameTextBox.Text;

                DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);

                bool createDepartment = departmentManager.CreateDepartment(new Department(0, departmentName, dateOnly));

                if (createDepartment)
                {
                    MessageBox.Show("Department Created");
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
        }

        private void CreateDepartmentBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
