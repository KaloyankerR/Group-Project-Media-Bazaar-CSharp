using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface ICategoryManager
    {
        public bool CreateCategory (Category category);
        public bool DeleteCategory (Category category);
        public List<Category> GetAllCategories ();
        public bool UpdateCategory (Category category);
        public Category GetCategoryByID (int id);
        List<Category> GetCategoryByDepartment(Department department);
    }
}
