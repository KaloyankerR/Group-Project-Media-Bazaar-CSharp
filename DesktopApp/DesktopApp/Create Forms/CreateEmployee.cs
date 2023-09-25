using DAL;
using LL;
using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LL.User_related;

namespace DesktopApp
{
    public partial class CreateEmployee : Form
    {

        IUserManager userManager = new UserManager(new UserDAO());
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        
        public CreateEmployee()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        public void LoadComboBoxes() 
        {
            cbxGender.DataSource = null;
            cbxGender.DataSource = Enum.GetValues(typeof(Gender));
			
            cbxUserType.DataSource = null;
            cbxUserType.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFName.Text) || string.IsNullOrEmpty(tbxLastName.Text) || string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrEmpty(tbxBSN.Text) || string.IsNullOrEmpty(tbxStreetName.Text) || string.IsNullOrEmpty(tbxHouseNr.Text) || string.IsNullOrEmpty(tbxZIP.Text) || string.IsNullOrEmpty(tbxCity.Text) || string.IsNullOrEmpty(tbxCountry.Text) || string.IsNullOrEmpty(tbxPhone.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
                return;
            }
            else
            {
                string streetName = tbxStreetName.Text;
                string houseNumber = tbxHouseNr.Text;
                string zip = tbxZIP.Text;
                string city = tbxCity.Text;
                string country = tbxCountry.Text;


                string fName = tbxFName.Text;
                string lName = tbxLastName.Text;
                string password = tbxPassword.Text;
                string phone = tbxPhone.Text;
                //int bsn = Convert.ToInt32(tbxBSN.Text);
                Department? department = cbxDepartment.SelectedItem as Department;
                DateOnly dateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
                UserType userType = (UserType)cbxUserType.SelectedItem;
                Gender gender = (Gender)cbxGender.SelectedItem;

				bool isNumeric = int.TryParse(tbxBSN.Text, out int bsn);
                if (isNumeric)
                {
					int i = 1;
					string email = fName.Substring(0, 1).ToUpper() + lName.ToUpper() + 0 + i + "@mediabazaar.nl";
					do
					{
						if (i >= 10)
						{
							email = fName.Substring(0, 1).ToUpper() + lName.ToUpper() + i + "@mediabazaar.nl";
						}
						else
						{
							email = fName.Substring(0, 1).ToUpper() + lName.ToUpper() + "0" + i + "@mediabazaar.nl";
						}
						i++;
					} while (userManager.UserExistsByEmail(email));

					if (zip.Length <= 6)
					{
						bool createUser = userManager.CreateUser(new User(0, email, password, fName, lName, dateOfBirth, null, phone, gender, bsn, userType, department), new Address(0, streetName, houseNumber, zip, city, country));
						if (createUser)
						{
							MessageBox.Show("User created!");
							Close();
						}
						else
						{
							MessageBox.Show("Something went wrong!");
						}
					}
					else
					{
						MessageBox.Show("ZIP code must be only 6 characters long!");
					}
				}
				else
				{
					MessageBox.Show("BSN must be only numbers");
				}
			}
        }

        private void CreateEmployeeBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUserType.SelectedItem is UserType selectedType && selectedType != UserType.Employee)
            {
                cbxDepartment.DataSource = null;
                cbxDepartment.Enabled = false;
            }
            else
            {
                cbxDepartment.Enabled = true;
                cbxDepartment.DataSource = departmentManager.GetAllDepartments();
				cbxDepartment.DisplayMember = "Name";
			}
        }
    }
}

