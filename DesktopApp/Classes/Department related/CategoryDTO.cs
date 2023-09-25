using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentDepartment { get; set; }

        public CategoryDTO(int categoryID, string categoryName, int parentDepartment)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            ParentDepartment = parentDepartment;
        }
        public CategoryDTO()
        {

        }
    }
}
