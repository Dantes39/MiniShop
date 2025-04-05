using System.Collections.Generic;

namespace MiniShop.Models
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        void Save();
    }
}
