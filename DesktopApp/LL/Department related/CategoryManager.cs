using Classes;
using DAL;

namespace LL
{
    public class CategoryManager : ICategoryManager
    {
         ICategoryDAO categoryDAO;

        public CategoryManager(ICategoryDAO categoryDAO)
        {
            this.categoryDAO = categoryDAO;
        }

        public bool CreateCategory (Category category)
        {
            try
            {
                if (categoryDAO.CreateCategory(category))
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCategory (Category category)
        {
            try
            {
                if (categoryDAO.DeleteCategory(category))
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex) 
            { 
                return false; 
            }
        }
        public List<Category> GetAllCategories ()
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            CategoryManager categoryManager=new(new CategoryDAO()); 
            //Category category;
            List<Category> categories = new List<Category>();

            foreach (CategoryDTO categoryDTO in categoryDAO.GetAllCategories())
            {
                Category category = categoryManager.GetCategoryByID(categoryDTO.CategoryID);
                categories.Add(category);
            }
            return categories; 
        }
        public bool UpdateCategory (Category category)
        {
            try
            {
                if (categoryDAO.UpdateCategory(category))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Category GetCategoryByID (int id) 
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            Category category;
            CategoryDTO categoryDTO =categoryDAO.GetCategoryByID (id);
            Department department = departmentManager.GetDepartmentById(categoryDTO.ParentDepartment);
            category = new Category(categoryDTO.CategoryID,categoryDTO.CategoryName,department);
            return category;
        }

        public List<Category> GetCategoryByDepartment(Department department)
        {
            List<Category> categories = new List<Category>();
            foreach (CategoryDTO categoryDTO in categoryDAO.GetCategoryByDepartment(department))
            {
                Category category = new(categoryDTO.CategoryID, categoryDTO.CategoryName, department);
                categories.Add(category);
            }
            return categories;
        }
    }
}
