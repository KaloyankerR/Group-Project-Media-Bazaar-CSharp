using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Inventory_related;

namespace Classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public int IteamThreshold { get; set; }
        public Unit Unit { get; set; }
        public Category SubCategory { get; set; }
        public Department Department { get; set; } 


        public Product(int ProductID, string ProductName, double ProductPrice, int ProductQuantity, Unit Unit, Category SubCategory, Department Department)
        {
            this.ProductID=ProductID;
            this.ProductName=ProductName;
            this.ProductPrice=ProductPrice;
            this.ProductQuantity=ProductQuantity;
            this.IteamThreshold=0;
            this.Unit=Unit;
            this.SubCategory=SubCategory;
            this.Department = Department;    
        }
        public Product(int ProductID, string ProductName, double ProductPrice, int ProductQuantity, Unit Unit, Category SubCategory)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductQuantity = ProductQuantity;
            this.IteamThreshold = 0;
            this.Unit = Unit;
            this.SubCategory = SubCategory;
            this.Department = Department;
        }
        public Product() { }
        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
