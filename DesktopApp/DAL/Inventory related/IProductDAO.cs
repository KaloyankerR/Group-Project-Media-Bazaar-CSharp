using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace DAL
{
    public interface IProductDAO
    {
        bool CreateProduct(Product product);
        bool DeleteProduct(Product product);
        bool UpdateProduct(Product product);
        ProductDTO GetProductByID(int productID);
        List<ProductDTO> GetAllProducts();
        List<ProductDTO> GetAllProductsByDepartmentId(int id);
        List<ProductDTO> GetProductsByCategory(Category category);
        ProductDTO GetProductByName(string name);
    }
}
