using Classes;
using DAL;
using LL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Edit_Forms
{
    public partial class EditEmployee : Form
    {
        IUserManager userManager = new UserManager(new UserDAO());
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        private User user;

        public EditEmployee(User userToEdit)
        {
            InitializeComponent();
            LoadComboBoxes();
            user = userToEdit;
			LoadData();
		}

        public void LoadComboBoxes()
        {
            cbxGender.DataSource = null;
            cbxGender.DataSource = Enum.GetValues(typeof(Gender));
            cbxUserType.DataSource = null;
            cbxUserType.DataSource = Enum.GetValues(typeof(UserType));
            cbxDepartment.DataSource = null;
            cbxDepartment.DataSource = departmentManager.GetAllDepartments();
        }

        public void LoadData()
        {
            tbxFName.Text = user.FirstName;
            tbxLastName.Text = user.LastName;
            tbxPassword.Text = user.Password;
            tbxBSN.Text = user.BSN.ToString();
            dtpDateOfBirth.Text = user.DateOfBirth.ToString();
            cbxDepartment.Text = user.Department.Name;
            cbxUserType.Text = user.UserType.ToString();
            tbxStreetName.Text = user.Address.StreetName;
            tbxHouseNr.Text = user.Address.HouseNumber;
            tbxZIP.Text = user.Address.ZIPCode;
            tbxCity.Text = user.Address.City;
            tbxCountry.Text = user.Address.Country;
            tbxPhone.Text = user.PhoneNumber;
            cbxGender.Text = user.Gender.ToString();
        }

        private void UpdateData()
        {
            user.FirstName = tbxFName.Text;
            user.LastName = tbxLastName.Text;
            user.Password = tbxPassword.Text;
            user.BSN = int.Parse(tbxBSN.Text);
            user.DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
            user.Department = (Department)cbxDepartment.SelectedItem;
            user.UserType = (UserType)cbxUserType.SelectedItem;
            user.Address.StreetName = tbxStreetName.Text;
            user.Address.HouseNumber = tbxHouseNr.Text;
            user.Address.ZIPCode = tbxZIP.Text;
            user.Address.City = tbxCity.Text;
            user.Address.Country = tbxCountry.Text;
            user.PhoneNumber = tbxPhone.Text;
            user.Gender = (Gender)cbxGender.SelectedItem;
        }

        private void EditEmployeeBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UpdateData();

            userManager.UpdateUser(user, user.Address);

            Close();
        }

        private void cbxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUserType.SelectedItem is UserType selectedType && selectedType == UserType.Manager)
            {
                cbxDepartment.DataSource = null;
                cbxDepartment.Enabled = false;
            }
            else
            {
                cbxDepartment.Enabled = true;
                cbxDepartment.DataSource = departmentManager.GetAllDepartments();
            }
        }

    }
}
