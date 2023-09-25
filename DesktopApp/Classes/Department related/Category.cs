using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Department ParentDepartment { get; set; }

        public Category (int categoryID, string categoryName, Department? parentDepartment)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            ParentDepartment = parentDepartment;    
        }
        public Category()
        {

        }
        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
