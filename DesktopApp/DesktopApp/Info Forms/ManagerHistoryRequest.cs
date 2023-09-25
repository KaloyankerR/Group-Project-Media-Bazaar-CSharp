using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Classes;
using Classes.Request_related;
using DAL;
using DAL.Request_related;
using LL;
using LL.Request_Related;

namespace DesktopApp.Info_Forms
{
	public partial class ManagerHistoryRequest : UserControl
	{
		User user = new();
		RequestManager RequestManager = new(new RequestDAO());
		List<Request> requests = new List<Request>();
		public ManagerHistoryRequest(User _user)
		{
			InitializeComponent();
			user = _user;
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.Columns.Add("id", "Id");
			dataGridView1.Columns.Add("department", "Department");
			dataGridView1.Columns.Add("product", "Product");
			dataGridView1.Columns.Add("quantity", "Quantity");
			dataGridView1.Columns.Add("date", "Date");
			dataGridView1.Columns.Add("status", "Status");
			dataGridView1.Columns.Add("message", "Message");
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.AllowUserToAddRows = false;
			Load();
		}

		private void Load()
		{
			requests = RequestManager.GetAllRequests();
			foreach (Request request in requests)
			{
				dataGridView1.Rows.Add(request.request_id, request.department, request.product, request.quantity, request.date, request.status, request.message);
			}
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			ManagerHistoryRequestComboBox.SelectedIndex = 0;
		}

		private void ManagerHistoryRequestComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			switch (ManagerHistoryRequestComboBox.SelectedIndex)
			{
				case 0:
					foreach (Request r in requests)
					{
						dataGridView1.Rows.Add(r.request_id, r.department, r.product, r.quantity, r.date, r.status, r.message);
					}
					break;
				case 1:
					foreach (Request r in requests)
					{
						if (r.status == "Accepted")
							dataGridView1.Rows.Add(r.request_id, r.department, r.product, r.quantity, r.date, r.status, r.message);
					}
					break;
				case 2:
					foreach (Request r in requests)
					{
						if (r.status == "Declined")
							dataGridView1.Rows.Add(r.request_id, r.department, r.product, r.quantity, r.date, r.status, r.message);
					}
					break;
				case 3:
					foreach (Request r in requests)
					{
						if (r.status == "Partially accepted")
							dataGridView1.Rows.Add(r.request_id, r.department, r.product, r.quantity, r.date, r.status, r.message);
					}
					break;
				case 4:
					foreach (Request r in requests)
					{
						if (r.status == "Pending")
							dataGridView1.Rows.Add(r.request_id, r.department, r.product, r.quantity, r.date, r.status, r.message);
					}
					break;
			}
		}
	}
}
