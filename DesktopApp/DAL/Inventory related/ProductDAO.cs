using System.Data;
using System.Data.SqlClient;
using Classes;


namespace DAL
{
    public class ProductDAO: Repository, IProductDAO
    {
        public bool CreateProduct(Product product)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Product( product_name,price,quantity,iteam_threshold,category_id,product_unit,department_id) VALUES(@product_name,@price,@quantity,@iteam_threshold,@category,@product_unit,@department)", conn);
                cmd.Parameters.AddWithValue("@product_name",product.ProductName);
                cmd.Parameters.AddWithValue("@price",product.ProductPrice);
                cmd.Parameters.AddWithValue("@quantity",product.ProductQuantity);
                cmd.Parameters.AddWithValue("@iteam_threshold",product.IteamThreshold);
                cmd.Parameters.AddWithValue("@category",product.SubCategory.CategoryID);
                cmd.Parameters.AddWithValue("@product_unit",product.Unit.unitID);
                cmd.Parameters.AddWithValue("@department", product.Department.DepartmentId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteProduct(Product product)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Product SET department_id=@department_id,category_id=@category WHERE product_id=@product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", product.ProductID);
                cmd.Parameters.AddWithValue("@department_id",1008);
                cmd.Parameters.AddWithValue("@category",1008);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateProduct(Product product) 
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Product SET product_name=@product_name,price=@price,quantity=@quantity,iteam_threshold=@iteam_threshold,category_id=@category,product_unit=@product_unit,department_id=@department WHERE product_id=@product_id ", conn);
                cmd.Parameters.AddWithValue("@product_name", product.ProductName);
                cmd.Parameters.AddWithValue("@price", product.ProductPrice);
                cmd.Parameters.AddWithValue("@quantity", product.ProductQuantity);
                cmd.Parameters.AddWithValue("@iteam_threshold", product.IteamThreshold);
                cmd.Parameters.AddWithValue("@category", product.SubCategory.CategoryID);
                cmd.Parameters.AddWithValue("@product_unit", product.Unit.unitID);
                cmd.Parameters.AddWithValue("@department", product.Department.DepartmentId);
                cmd.Parameters.AddWithValue("@product_id", product.ProductID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public ProductDTO GetProductByID(int productID) 
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", productID);
                SqlDataReader reader = cmd.ExecuteReader();
                ProductDTO product= new ();
                while (reader.Read())
                {
                    product.ProductID = reader.GetInt32("product_id");
                    product.ProductName = reader.GetString("product_name");
                    product.ProductPrice= reader.GetDouble("price");
                    product.ProductQuantity = reader.GetInt32("quantity");
                    if (reader.GetInt32("iteam_threshold") == null)
                    {
                        product.IteamThreshold = 0;
                    }
                    else
                    {
                        product.IteamThreshold = reader.GetInt32("iteam_threshold");
                    }
                    product.SubCategory = reader.GetInt32("category_id");
                    product.Unit = reader.GetInt32("product_unit");
                    product.Department =reader.GetInt32("department_id");
                }

                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<ProductDTO> GetAllProducts() 
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<ProductDTO>products= new List<ProductDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product",conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    ProductDTO product = new ProductDTO();
                    product.ProductID = reader.GetInt32("product_id");
                    product.ProductName = reader.GetString("product_name");
                    product.ProductPrice = reader.GetDouble("price");
                    product.ProductQuantity = reader.GetInt32("quantity");
                    if(reader.GetInt32("iteam_threshold")==null)
                        {
                        product.IteamThreshold = 0;
                    }
                    else
                    {
                        product.IteamThreshold = reader.GetInt32("iteam_threshold");
                    }
                    
                    product.SubCategory = reader.GetInt32("category_id");
                    product.Unit = reader.GetInt32("product_unit");
                    product.Department = reader.GetInt32("department_id");
                    products.Add(product);
                }
                return products;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public List<ProductDTO> GetAllProductsByDepartmentId(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<ProductDTO> products = new List<ProductDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE department_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductDTO product = new ProductDTO();
                    product.ProductID = reader.GetInt32("product_id");
                    product.ProductName = reader.GetString("product_name");
                    product.ProductPrice = reader.GetDouble("price");
                    product.ProductQuantity = reader.GetInt32("quantity");
                    if (reader.GetInt32("iteam_threshold") == null)
                    {
                        product.IteamThreshold = 0;
                    }
                    else
                    {
                        product.IteamThreshold = reader.GetInt32("iteam_threshold");
                    }

                    product.SubCategory = reader.GetInt32("category_id");
                    product.Unit = reader.GetInt32("product_unit");
                    product.Department = reader.GetInt32("department_id");
                    products.Add(product);
                }
                return products;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public List<ProductDTO> GetProductsByCategory(Category category)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<ProductDTO> products = new List<ProductDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE category_id=@category_id", conn);
                cmd.Parameters.AddWithValue("@category_id", category.CategoryID);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ProductDTO product = new ProductDTO();
                    product.ProductID = reader.GetInt32("product_id");
                    product.ProductName = reader.GetString("product_name");
                    product.ProductPrice = reader.GetDouble("price");
                    product.ProductQuantity = reader.GetInt32("quantity");
                    product.IteamThreshold = reader.GetInt32("iteam_threshold");
                    product.Unit = reader.GetInt32("product_unit");
                    products.Add(product);
                }
                return products;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public ProductDTO GetProductByName(string name)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE product_name=@product_name", conn);
                cmd.Parameters.AddWithValue("@product_name", name);
                SqlDataReader reader = cmd.ExecuteReader();
                ProductDTO product = new ProductDTO();
                if (reader.Read())
                {
                    
                    product.ProductID = reader.GetInt32("product_id");
                    product.ProductName = reader.GetString("product_name");
                    product.ProductPrice = reader.GetDouble("price");
                    product.ProductQuantity = reader.GetInt32("quantity");
                    product.IteamThreshold = reader.GetInt32("iteam_threshold");
                    product.Unit = reader.GetInt32("product_unit");
                }
                return product;
            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}
