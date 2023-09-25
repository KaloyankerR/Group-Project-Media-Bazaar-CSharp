using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace LL
{
    public interface IProductManager
    {
        bool CreateProduct(Product product);
        bool DeleteProduct(Product product);
        bool UpdateProduct(Product product);
        Product GetProductByID(int productID);
        List<Product>GetAllProducts();
        List<Product> GetProductsByCategory(Category category);

        Product GetProductByName(string name);
    }
}
