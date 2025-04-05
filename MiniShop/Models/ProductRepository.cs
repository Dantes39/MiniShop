using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MiniShop.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _filePath = "Data/products.json";
        private List<Product> _products;

        public ProductRepository()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
            else
            {
                _products = new List<Product>();
            }
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Quantity = product.Quantity;
                existing.ExpiryDate = product.ExpiryDate;
                existing.PhotoPath = product.PhotoPath;
            }
        }

        public void Delete(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
                _products.Remove(product);
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
