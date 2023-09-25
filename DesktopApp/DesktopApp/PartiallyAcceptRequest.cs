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
using DAL.Request_related;
using DAL;
using LL;
using LL.Request_Related;
using Classes;
using Classes.Inventory_related;
using LL.Inventory_related;
using DAL.Inventory_related;

namespace DesktopApp
{
    public partial class PartiallyAcceptRequest : Form
    {
        public Request _request;
        public Product _product;
        int _quantity;
        ProductManager productManager = new(new ProductDAO());
        RequestManager requestManager = new(new RequestDAO());
        public PartiallyAcceptRequest(Request request,Product product,int quantity)
        {
            InitializeComponent();
            _request = request;
            _product = product;
            _quantity = quantity;
            label1.Text = _product.ProductName;
            numericUpDown1.Text=_quantity.ToString();    
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(numericUpDown1.Value)>_quantity)
            {
                MessageBox.Show("You cannot give more products than you have been asked!");
            }
            else 
            {
                if(Convert.ToInt32(numericUpDown1.Value)<=0)
                {
                    MessageBox.Show("You cannot give 0 or less products!");
                }
                else
                {
                    IProductDAO productDAO = new ProductDAO();
                    DepartmentManager departmentManager = new(new DepartmentDAO());
                    CategoryManager categoryManager = new(new CategoryDAO());
                    UnitManager unitManager = new(new UnitDAO());
                    int newquantity= Convert.ToInt32(numericUpDown1.Value);
                    ProductDTO productDTO = productDAO.GetProductByID(_product.ProductID);
                    Department? department = departmentManager.GetDepartmentById(productDTO.Department);
                    Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
                    Unit unit = unitManager.GetUnitById(productDTO.Unit);
                    Product newproduct = new Product(_product.ProductID,_product.ProductName,_product.ProductPrice,_product.ProductQuantity+newquantity,unit,category,department);
                    productManager.UpdateProduct(newproduct);
                    this.Close();
                }
            }
            
        }
    }
}
