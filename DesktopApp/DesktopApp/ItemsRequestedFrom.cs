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
using DesktopApp.Info_Forms;
using LL;
using LL.Request_Related;

namespace DesktopApp
{
	public partial class ItemsRequestedFrom : Form
	{

		public Department _department;
		public Request _request;
		DepartmentManager DepartmentManager = new(new DepartmentDAO());
		ProductManager ProductManager = new(new ProductDAO());
		RequestManager requestManager = new(new RequestDAO());
		List<int> Quntities;
		List<Product> products;
		InverntoryRequestUserControl inventoryRequestUserControl;
		private int controlCounter = 0;
		public ItemsRequestedFrom(Department selectedDepartment, Request request)
		{
			InitializeComponent();
			_department = selectedDepartment;
			_request = request;
			for (int i = 0; i < ProductManager.GetAllProductsByDeparmentId(_department.DepartmentId).Count; i++)
			{
				inventoryRequestUserControl = new(_department, _request);
				flowLayoutPanel1.Controls.Add(inventoryRequestUserControl);
			}
			for (int i = 1; i < ProductManager.GetAllProductsByDeparmentId(_department.DepartmentId).Count; i++)
			{
				flowLayoutPanel1.Controls[i].Visible = false;
			}

		}

		private void AddMore_Click(object sender, EventArgs e)
		{
			controlCounter++;
			if (controlCounter < ProductManager.GetAllProductsByDeparmentId(_department.DepartmentId).Count)
			{
				flowLayoutPanel1.Controls[controlCounter].Visible = true;
			}
			else
			{
				MessageBox.Show("There are no more products in this department");
			}

		}

		private void Submit_Click(object sender, EventArgs e)
		{
			int ok = 1;
			Quntities = new List<int>();
			products = new List<Product>();
			foreach (Control control in flowLayoutPanel1.Controls)
			{
				if (control.Visible)
				{
					if (control is InverntoryRequestUserControl myusercontrol)
					{
						int quantity = myusercontrol.quantity;
						Product product = myusercontrol.Product;
						if (products.Any(p => p.ProductName == product.ProductName))
						{
							ok = 0;
							break;
						}

						products.Add(product);
						Quntities.Add(quantity);
					}


                }
            }
            if (ok == 0) MessageBox.Show("You cannot request the same product more than 1 time!");
            else
            {
                int index = -1;
                foreach (Product product in products)
                {
                    index++;
                    requestManager.AddItemToRequestByRequestId(_request.request_id, product.ProductID, Quntities[index], "Pending",null);

				}
				MessageBox.Show("Items added to request!");
				this.Close();
			}


		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}


