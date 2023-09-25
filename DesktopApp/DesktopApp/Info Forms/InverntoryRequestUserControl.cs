using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Request_related;
using Classes;
using DAL.Request_related;
using DAL;
using LL.Request_Related;
using LL;

namespace DesktopApp.Info_Forms
{
    public partial class InverntoryRequestUserControl : UserControl
    {
        public Department _department;
        public Request _request;
        DepartmentManager DepartmentManager = new(new DepartmentDAO());
        ProductManager ProductManager = new(new ProductDAO());
        RequestManager requestManager = new(new RequestDAO());
        public int quantity;
        public Product Product;
        public InverntoryRequestUserControl(Department selectedDepartment, Request request)
        {
            InitializeComponent();
            _department = selectedDepartment;
            _request = request;
            cbProduct.DataSource = ProductManager.GetAllProductsByDeparmentId(selectedDepartment.DepartmentId);

        }

        private void cbProductIndexChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(numQuantity.Value);
            Product = cbProduct.SelectedItem as Product;
        }

        private void numQuantityValueChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(numQuantity.Value);
            Product = cbProduct.SelectedItem as Product;
        }
    }
}
