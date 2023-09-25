using Classes;
//using Classes.Department_related;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class CategoryDAO : Repository, ICategoryDAO
    {
        public bool CreateCategory(Category category)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Category]( department_id, name) VALUES( @department_id, @name)", conn);
                //cmd.Parameters.AddWithValue("@category_id", category.CategoryID);
                cmd.Parameters.AddWithValue("@department_id",category.ParentDepartment.DepartmentId);
                cmd.Parameters.AddWithValue("@name", category.CategoryName);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        public bool DeleteCategory(Category category)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Category WHERE category=@name", conn);
                cmd.Parameters.AddWithValue("@name", category.CategoryName);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public List<CategoryDTO> GetAllCategories()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<CategoryDTO> categories = new List<CategoryDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Category", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CategoryDTO category = new CategoryDTO();
                    category.CategoryID = reader.GetInt32("category_id");
                    category.CategoryName = reader.GetString("name");
                    category.ParentDepartment = reader.GetInt32("department_id");
                    categories.Add(category);
                }
                return categories;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
        public bool UpdateCategory(Category category)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Category SET departmnet_id=@department_id,name=@name WHERE category_id=@category_id ", conn);
                cmd.Parameters.AddWithValue("@category_id", category.CategoryID);
                cmd.Parameters.AddWithValue("@department_id", category.ParentDepartment);
                cmd.Parameters.AddWithValue("@name", category.CategoryName);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public CategoryDTO GetCategoryByID(int? id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Category WHERE @category_id=category_id", conn);
                cmd.Parameters.AddWithValue("@category_id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                CategoryDTO category = new CategoryDTO();
                while (reader.Read())
                {
                    category.CategoryID = reader.GetInt32("category_id");
                    category.CategoryName = reader.GetString("name");
                    category.ParentDepartment = reader.GetInt32("department_id");
                }

                return category;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<CategoryDTO> GetCategoryByDepartment(Department department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<CategoryDTO> categories = new List<CategoryDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Category WHERE department_id = @department_id", conn);
                cmd.Parameters.AddWithValue("@department_id", department.DepartmentId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CategoryDTO category = new CategoryDTO();
                    category.CategoryID = reader.GetInt32("category_id");
                    category.CategoryName = reader.GetString("name");
                    category.ParentDepartment = reader.GetInt32("department_id");
                    categories.Add(category);
                }
                return categories;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
    }
}
