using Classes;
//using Classes.Department_related;

namespace DAL
{
    public interface ICategoryDAO
    {
        public bool CreateCategory(Category category);
        public bool DeleteCategory(Category category);
        public List<CategoryDTO> GetAllCategories();
        public bool UpdateCategory(Category category);
        public CategoryDTO GetCategoryByID(int? id);
        List<CategoryDTO> GetCategoryByDepartment(Department department);

    }
}
