using Classes;
using Classes.Inventory_related;
using DAL;
using DAL.Inventory_related;
using LL.Inventory_related;

namespace LL
{
    public class ProductManager: IProductManager
    {
        IProductDAO productDAO;
        ICategoryDAO categoryDAO;
        IDepartmentDAO departmentDAO;
        

        public ProductManager(IProductDAO productDAO)
        {
            this.productDAO = productDAO;
        }
        
            

        public bool CreateProduct(Product product)
        {
            try
            {
                if (productDAO.CreateProduct(product))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception) 
            {
                return false;
            }
        }
        public bool DeleteProduct(Product product)
        {
            try
            {
                if(productDAO.DeleteProduct(product))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception) 
            {
                return false;
            }
        }
        public bool UpdateProduct(Product product)
        {
            try
            {
                if(productDAO.UpdateProduct(product)) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Product GetProductByID(int id)
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            CategoryManager categoryManager = new(new CategoryDAO());
            UnitManager unitManager=new(new UnitDAO());
            Product product;
            ProductDTO productDTO=productDAO.GetProductByID(id);
            Department? department = departmentManager.GetDepartmentById(productDTO.Department);
            Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
            Unit unit=unitManager.GetUnitById(productDTO.Unit);
            product = new Product(productDTO.ProductID, productDTO.ProductName, productDTO.ProductPrice, productDTO.ProductQuantity, unit, category, department);
            return product;
        }
        public List<Product> GetAllProducts()
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            CategoryManager categoryManager = new(new CategoryDAO());
            UnitManager unitManager = new(new UnitDAO());
            Product product;
            List<Product> products = new List<Product>();
            foreach(ProductDTO productDTO in productDAO.GetAllProducts())
            {
                Department? department = departmentManager.GetDepartmentById(productDTO.Department);
                Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
                Unit unit = unitManager.GetUnitById(productDTO.Unit);
                product = new Product(productDTO.ProductID,productDTO.ProductName,productDTO.ProductPrice,productDTO.ProductQuantity,unit,category,department);
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetAllProductsByDeparmentId(int id)
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            CategoryManager categoryManager = new(new CategoryDAO());
            UnitManager unitManager = new(new UnitDAO());
            Product product;
            List<Product> products = new List<Product>();
            foreach (ProductDTO productDTO in productDAO.GetAllProductsByDepartmentId(id))
            {
                Department? department = departmentManager.GetDepartmentById(productDTO.Department);
                Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
                Unit unit = unitManager.GetUnitById(productDTO.Unit);
                product = new Product(productDTO.ProductID, productDTO.ProductName, productDTO.ProductPrice, productDTO.ProductQuantity, unit, category, department);
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetProductsByCategory(Category category)
        {
            UnitManager unitManager = new(new UnitDAO());
            Product product;
            List<Product> products = new List<Product>();
            foreach (ProductDTO productDTO in productDAO.GetProductsByCategory(category))
            {
                Unit unit = unitManager.GetUnitById(productDTO.Unit);
                product = new Product(productDTO.ProductID, productDTO.ProductName, productDTO.ProductPrice, productDTO.ProductQuantity, unit, category);
                products.Add(product);
            }
            return products;
        }

        public Product GetProductByName(string name)
        {
            ProductDTO productDTO = productDAO.GetProductByName(name);
            Product product;
            DepartmentManager departmentManager = new(new DepartmentDAO());
            CategoryManager categoryManager = new(new CategoryDAO());
            UnitManager unitManager = new(new UnitDAO());
            Department? department = departmentManager.GetDepartmentById(productDTO.Department);
            Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
            Unit unit = unitManager.GetUnitById(productDTO.Unit);
            product = new Product(productDTO.ProductID, productDTO.ProductName, productDTO.ProductPrice, productDTO.ProductQuantity, unit, category, department);
            return product;
        }
    }
}
