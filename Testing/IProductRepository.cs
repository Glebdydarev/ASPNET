using System.Collections.Generic;
using Testing.Models;

namespace Testing.Controllers
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        void UpdateProduct(Product product);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        void InsertProduct(Product productToInsert);
        public void DeleteProduct(Product product);
    }

}