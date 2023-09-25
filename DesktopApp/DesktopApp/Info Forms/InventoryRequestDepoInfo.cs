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
using Classes.Inventory_related;
using Classes.Request_related;
using DAL;
using DAL.Inventory_related;
using DAL.Request_related;
using LL;
using LL.Inventory_related;
using LL.Request_Related;

namespace DesktopApp.Info_Forms
{
	public partial class InventoryRequestDepoInfo : UserControl
	{
		RequestManager requestManager = new(new RequestDAO());
		ProductManager productManager = new(new ProductDAO());
		public InventoryRequestDepoInfo()
		{
			InitializeComponent();
			IteamsRequesteDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			IteamsRequesteDGV.AllowUserToAddRows = false;
			LoadAllRequests();
		}
		//public void LoadAllRequests()
		//{
		//    List<Request> requests = requestManager.GetAllRequestedItem();

		//    DataTable dt = new DataTable();
		//    dt.Clear();
		//    dt.Columns.Add("ID", typeof(int));
		//    dt.Columns.Add("Department", typeof(string));
		//    //dt.Columns.Add("Status", typeof(string));
		//    dt.Columns.Add("Product", typeof(string));
		//    dt.Columns.Add("Quantity", typeof(int));
		//    dt.Columns.Add("Date", typeof(DateOnly));
		//    foreach (Request request in requests)
		//    {
		//        if(request.status=="Pending")
		//        {
		//            List<Product> products = requestManager.GetAllProductsByRequestId(request.request_id);
		//            foreach (Product product in products)
		//            {
		//                DataRow row = dt.NewRow();
		//                row["ID"] = request.request_id;
		//                row["Department"] = request.department.Name;
		//                //row["Status"] = request.status;
		//                Product product1 = new Product();
		//                product1 = productManager.GetProductByID(product.ProductID);
		//                row["Product"] = product1.ProductName;
		//                row["Quantity"] = requestManager.GetQuantityByRequestAndProdactId(request.request_id, product.ProductID);
		//                row["Date"] = request.date;
		//                dt.Rows.Add(row);
		//            }
		//        }

		//    }
		//    IteamsRequesteDGV.DataSource = null;
		//    IteamsRequesteDGV.DataSource = dt;
		//}
		public void LoadAllRequests()
		{
			IteamsRequesteDGV.DataSource = null;
			IteamsRequesteDGV.DataSource = requestManager.GetPendingRequests();

		}
		private void AcceptButton_Click(object sender, EventArgs e)
		{
			IProductDAO productDAO = new ProductDAO();
			DepartmentManager departmentManager = new(new DepartmentDAO());
			CategoryManager categoryManager = new(new CategoryDAO());
			UnitManager unitManager = new(new UnitDAO());
			string product_name = Convert.ToString(IteamsRequesteDGV.SelectedRows[0].Cells["Product"].Value);
			Product product = productManager.GetProductByName(product_name);
			ProductDTO productDTO = productDAO.GetProductByID(product.ProductID);
			Department? department = departmentManager.GetDepartmentById(productDTO.Department);
			Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
			Unit unit = unitManager.GetUnitById(productDTO.Unit);
			int quantity = Convert.ToInt32(IteamsRequesteDGV.SelectedRows[0].Cells["Quantity"].Value);
			Product newProduct = new(product.ProductID, product.ProductName, product.ProductPrice, product.ProductQuantity + quantity, unit, category, department);
			productManager.UpdateProduct(newProduct);
			int request_id = Convert.ToInt32(IteamsRequesteDGV.SelectedRows[0].Cells["ID"].Value);
			Request request = requestManager.GetRequestById(request_id);
			request.status = "Accepted";
			requestManager.UpdateRequest(request, newProduct,string.Empty);
			LoadAllRequests();
		}

		private void DeclineButton_Click(object sender, EventArgs e)
		{
			int request_id = Convert.ToInt32(IteamsRequesteDGV.SelectedRows[0].Cells["ID"].Value);
			string product_name = Convert.ToString(IteamsRequesteDGV.SelectedRows[0].Cells["Product"].Value);
			Product product = productManager.GetProductByName(product_name);
			Request request = requestManager.GetRequestById(request_id);
			request.status = "Declined";
			MessageForm messageForm = new MessageForm(request.status);
			messageForm.ShowDialog();
			messageForm.Close();
			requestManager.UpdateRequest(request, product, messageForm.message);
			LoadAllRequests();
		}

		private void PartiallyAcceptButton_Click(object sender, EventArgs e)
		{
			int request_id = Convert.ToInt32(IteamsRequesteDGV.SelectedRows[0].Cells["ID"].Value);
			Request request = requestManager.GetRequestById(request_id);
			string product_name = Convert.ToString(IteamsRequesteDGV.SelectedRows[0].Cells["Product"].Value);
			Product product = productManager.GetProductByName(product_name);
			int quantity = Convert.ToInt32(IteamsRequesteDGV.SelectedRows[0].Cells["Quantity"].Value);
			PartiallyAcceptRequest partiallyAcceptRequest = new PartiallyAcceptRequest(request, product, quantity);
			partiallyAcceptRequest.ShowDialog();
			partiallyAcceptRequest.Close();
			request.status = "Partially accepted";
            MessageForm messageForm = new MessageForm(request.status);
            messageForm.ShowDialog();
            messageForm.Close();
            requestManager.UpdateRequest(request, product, messageForm.message);
			LoadAllRequests();
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			LoadAllRequests();
		}
	}
}
