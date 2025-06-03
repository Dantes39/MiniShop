using System.Collections.Generic;

namespace MiniShop.Models
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(List<Product> newProducts);
        void Delete(Product product);
        void Save();
    }
}
