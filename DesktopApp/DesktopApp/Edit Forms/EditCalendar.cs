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
using User = Classes.User;

namespace DesktopApp.Edit_Forms
{
	public partial class EditCalendar : Form
	{
		IShiftManager shiftManager = new ShiftManager(new ShiftDAO());
		IUserManager userManager = new UserManager(new UserDAO());

		public DateOnly Date;
		public int time;
		public string name;
		List<User> employees = new List<User>();
		List<User> users = new List<User>();
		public EditCalendar(DateOnly date, int type, string NameDepartment, int NumberEmployee)
		{
			Date = date;
			time = type;
			name = NameDepartment;
			InitializeComponent();
			numEmployees.Value = NumberEmployee;
			loadDate(Date, time);
			loadEmployees(Date, time);

		}


		private void loadDate(DateOnly date, int type)
		{
			string nameofshift = "";
			if (type == 0) nameofshift = "Morning";
			else if (type == 1) nameofshift = "Day";
			else if (type == 2) nameofshift = "Evening";

			string Date = date.ToString("dd/MM/yyyy") + " " + nameofshift;
			tbshiftname.Text = Date;
		}

		private void loadEmployees(DateOnly date, int type)
		{
			employees = userManager.GetAllUsers();
			List<Shift> shifts = shiftManager.GetScheduleByShiftTypeAndDate(date, type, name);
			List<User> users1 = new List<User>();
			foreach (User user in employees)
			{
				if (user.Department.Name == name)
				{
					int index = 0;
					int index1 = 0;
					if (shiftManager.CheckEmployeeOnShift(date, (int)ShiftType.Morning, user.UserID)) index++;

					if (shiftManager.CheckEmployeeOnShift(date, (int)ShiftType.Afternoon, user.UserID)) index++;

					if (shiftManager.CheckEmployeeOnShift(date, (int)ShiftType.Night, user.UserID)) index++;

					if (shiftManager.CheckEmployeeOnShift(date, type, user.UserID)) index1++;

					if (user.UserType == UserType.Employee && index < 1)
						lbavemployees.Items.Add(user);
					else if (user.UserType == UserType.Employee && index1 == 0 && index <= 3)
					{
						users1.Add(user);
					}
					else if (user.UserType == UserType.Employee && index1 == 1)
					{
						if (shifts == null)
						{
							shifts = new List<Shift>();

						}

						lbscheduled.Items.Add(user);
						users.Add(user);

					}

				}
			}
			if (cboxEmployee.Checked)
			{
				if (users.Count > 0)
				{
					lbavemployees.Items.Add("");
				}
				foreach (User user in users1)
				{
					lbavemployees.Items.Add(user);
				}
			}
			else
			{
				foreach (User user in users1)
				{
					lbavemployees.Items.Remove(user);
				}
				if (users.Count > 0)
				{
					lbavemployees.Items.Remove("");
				}

			}


		}

		private void btncancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
            if (lbscheduled.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the employee you wish to move!");
                return;
            }
            else
            {
                int selectedIndex = lbscheduled.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < lbscheduled.Items.Count)
                {
                    lbavemployees.Items.Add(lbscheduled.SelectedItem.ToString());
                    lbscheduled.Items.RemoveAt(selectedIndex);

                    if (selectedIndex >= 0 && selectedIndex < users.Count)
                    {
                        users.RemoveAt(selectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selection index!");
                }
            }
        }

		private void btnRight_Click(object sender, EventArgs e)
		{
            if (lbavemployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the employee you wish to move!");
                return;
            }
            else
            {
                int selectedIndex = lbavemployees.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < lbavemployees.Items.Count)
                {
                    lbscheduled.Items.Add(lbavemployees.SelectedItem.ToString());
                    lbavemployees.Items.RemoveAt(selectedIndex);
                }
                else
                {
                    MessageBox.Show("Invalid selection index!");
                }
            }
        }



		private void btnsave_Click(object sender, EventArgs e)
		{
			List<string> selectedEmployees = new List<string>();



            foreach (var item in lbscheduled.Items)
            {
                if (item is string)
                {
                    selectedEmployees.Add(item.ToString());
                }
                else if (item is User)
                {
                    User user = (User)item;
                    selectedEmployees.Add(user.FirstName + " " + user.LastName);
                }
            }

            List<int> scheduled = new List<int>();
			foreach (string employee in selectedEmployees)
			{
				User selected = new User();
				string aux = employee;
				int employeeid = employees.Find(selected => selected.FirstName + " " + selected.LastName == aux).UserID;
				scheduled.Add(employeeid);
			}

			if (scheduled.Count <= numEmployees.Value)
			{

				if (shiftManager.GetScheduleByShiftTypeAndDate(Date, time, name) == null)
				{
					bool resultcreate = shiftManager.CreateShift(Date, time, scheduled, Convert.ToInt32(numEmployees.Value));
					if (resultcreate)
					{
						MessageBox.Show("Success");
						this.Close();

					}
					else
					{
						MessageBox.Show("Shift creation failed");
					}
				}
				else
				{


					bool result = shiftManager.UpdateShift(Date, time, scheduled, Convert.ToInt32(numEmployees.Value)); //uploads new rooster

					if (result)
					{

						MessageBox.Show("Success");
						this.Close();
						lbscheduled.Items.Clear();
					}
					else
					{
						MessageBox.Show("Shift update failed");
					}
				}
			}
			else
			{
				MessageBox.Show("Shift is already full!");
			}
		}

		private void cboxEmployee_CheckedChanged(object sender, EventArgs e)
		{
			lbscheduled.Items.Clear();
			lbavemployees.Items.Clear();
			loadEmployees(Date, time);
		}

		private void lbavemployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbemployeeinfo.Text = string.Empty;
			User user = new();
			if (lbavemployees.SelectedItem != null)
			{
				string selectedEmployee = lbavemployees.SelectedItem.ToString();
				string[] nameParts = selectedEmployee.Split(' ');

				user.FirstName = nameParts[0];
				user.LastName = nameParts[1];
				user.UserID = userManager.GetUserIdByFirstNameAndLastName(user.FirstName, user.LastName);
				user = userManager.GetUserByID(user.UserID);
				tbemployeeinfo.Text = "Email - " + user.Email + Environment.NewLine;

			}
		}

		private void lbscheduled_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbemployeeinfo.Text = string.Empty;
			User user = new();
			if (lbscheduled.SelectedItem != null)
			{
				string selectedEmployee = lbscheduled.SelectedItem.ToString();
				string[] nameParts = selectedEmployee.Split(' ');
				user.FirstName = nameParts[0];
				user.LastName = nameParts[1];
				user.UserID = userManager.GetUserIdByFirstNameAndLastName(user.FirstName, user.LastName);
				user = userManager.GetUserByID(user.UserID);
				tbemployeeinfo.Text = "Email - " + user.Email + Environment.NewLine;
			}



		}
	}
}
