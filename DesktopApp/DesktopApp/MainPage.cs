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
using DesktopApp.Info_Forms;
using LL;
using Microsoft.VisualBasic.ApplicationServices;

namespace DesktopApp
{
	public partial class MainPage : Form
	{
		UserControl lastPage;
		EmployeeeInfo employeesFrom;
		DepartmentInfo departmentForm;
		ProductInfo productForm;
		Calendar calendarForm;
		CategoryInfo categoryForm;
		UnitInfo unitForm;
		ManagerHistoryRequest historyRequest;
		InventoryRequestDepoInfo inventoryRequestDepoInfo;


        public MainPage(Classes.User user)
        {
           lastPage = new UserControl();
            employeesFrom = new EmployeeeInfo();
            departmentForm = new DepartmentInfo();
            productForm = new ProductInfo(user);
            calendarForm = new Calendar();
            categoryForm = new CategoryInfo(user);
            unitForm = new UnitInfo();
            historyRequest = new(user);
            inventoryRequestDepoInfo = new InventoryRequestDepoInfo();

			InitializeComponent();
			LoadUserControls();

			switch (user.UserType)
			{
				case UserType.HR:
					btnDepartment.Hide();
					btnInventory.Hide();
					btnCalendar.Hide();
					DepoInventoryRequestButton.Hide();
					CategoryBtn.Location = new Point(151, 0);
					ProductUnitButton.Location = new Point(290, 0);
					btnEmployee.Location = new Point(428, 0);
					btnLogOut.Location = new Point(1262, 0);
					this.Text = Convert.ToString(UserType.HR);
					break;
				case UserType.Manager:
					btnEmployee.Hide();
					DepoInventoryRequestButton.Hide();
					btnCalendar.Location = new Point(151, 0);
					btnDepartment.Location = new Point(290, 0);
					btnInventory.Location = new Point(428, 0);
					CategoryBtn.Location = new Point(567, 0);
					ProductUnitButton.Location = new Point(706, 0);
					btnLogOut.Location = new Point(1262, 0);
					this.Text = Convert.ToString(UserType.Manager);
					break;
				case UserType.Employee:
					btnCalendar.Hide();
					btnDepartment.Hide();
					btnInventory.Hide();
					DepoInventoryRequestButton.Hide();
					CategoryBtn.Location = new Point(151, 0);
					ProductUnitButton.Location = new Point(290, 0);
					btnEmployee.Hide();
					btnLogOut.Location = new Point(1262, 0);
					this.Text = Convert.ToString(UserType.Employee);
					break;
				case UserType.Admin:
					this.Text = Convert.ToString(UserType.Admin);
					break;
				case UserType.DepoWorker:
					this.Text = Convert.ToString(UserType.DepoWorker);
					btnCalendar.Hide();
					btnDepartment.Hide();
					btnInventory.Hide();
					CategoryBtn.Hide();
					ProductUnitButton.Hide();
					btnEmployee.Hide();
					DepoInventoryRequestButton.Location = new Point(151, 0);
					btnLogOut.Location = new Point(1262, 0);
					break;
			}
		}

		public void LoadUserControls()
		{
			formsPanel.Controls.Clear();
			formsPanel.Controls.Add(employeesFrom);
			employeesFrom.Hide();
			formsPanel.Controls.Add(departmentForm);
			departmentForm.Hide();
			formsPanel.Controls.Add(productForm);
			productForm.Hide();
			formsPanel.Controls.Add(categoryForm);
			categoryForm.Hide();
			formsPanel.Controls.Add(unitForm);
			unitForm.Hide();
			formsPanel.Controls.Add(inventoryRequestDepoInfo);
			inventoryRequestDepoInfo.Hide();
			formsPanel.Controls.Add(historyRequest);
			historyRequest.Hide();
		}

		private void ShowPage(UserControl page)
		{
			lastPage.Hide();
			page.Show();
			lastPage = page;
		}
		private void ResetButtonStyles()
		{

			btnCalendar.BackColor = Color.White;
			btnDepartment.BackColor = Color.White;
			btnInventory.BackColor = Color.White;
			btnEmployee.BackColor = Color.White;
			CategoryBtn.BackColor = Color.White;
			ProductUnitButton.BackColor = Color.White;
			DepoInventoryRequestButton.BackColor = Color.White;
			ManagerHistoryRequest.BackColor = Color.White;
		}

		private void btnCalendar_Click(object sender, EventArgs e)
		{
			ResetButtonStyles();

			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
			calendarForm.ShowDialog();

		}

		private void btnDepartment_Click(object sender, EventArgs e)
		{
			ShowPage(departmentForm);
			ResetButtonStyles();

			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}

		private void btnInventory_Click(object sender, EventArgs e)
		{
			ShowPage(productForm);
			ResetButtonStyles();


			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}

		private void btnEmployee_Click(object sender, EventArgs e)
		{
			ShowPage(employeesFrom);
			ResetButtonStyles();


			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			LogIn logIn = new();
			logIn.Show();
			Hide();
		}

		private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void CategoryBtn_Click(object sender, EventArgs e)
		{
			ShowPage(categoryForm);
			ResetButtonStyles();


			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}

		private void ProductUnitButton_Click(object sender, EventArgs e)
		{
			ShowPage(unitForm);
			ResetButtonStyles();


			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}


		private void DepoInventoryRequestButton_Click(object sender, EventArgs e)
		{
			ShowPage(inventoryRequestDepoInfo);
			ResetButtonStyles();


			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}

		private void ManagerHistoryRequest_Click(object sender, EventArgs e)
		{
			ShowPage(historyRequest);
			ResetButtonStyles();
			Button clickedButton = (Button)sender;
			clickedButton.BackColor = Color.LightGray;
		}
	}
}
