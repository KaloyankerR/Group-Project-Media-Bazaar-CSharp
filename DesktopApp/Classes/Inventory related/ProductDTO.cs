using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public int IteamThreshold { get; set; }
        public int Unit { get; set; }
        public int SubCategory { get; set; }
        public int Department { get; set; }


        public ProductDTO(int ProductID, string ProductName, double ProductPrice, int ProductQuantity,int Unit, int SubCategory, int Department)
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
        public ProductDTO() { }
    }
}
