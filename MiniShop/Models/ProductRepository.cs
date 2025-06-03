using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using MiniShop.Models;

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

        public void Update(List<Product> newProducts)
        {
            _products = newProducts;
        }

        public void Delete(Product product)
        {
            if (product != null)
                _products.Remove(product);
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public string AddToCart(Product product)
        {
            if (product != null)
            {
                if (product.Quantity > 0)
                {
                    product.Quantity -= 1;
                    return "Продукт добавлен в корзину!";
                }
                else if (product.Quantity == 0)
                {
                    return "Продукт закончился!";
                }
            }
            return "Продукт не существует";
        }

        public string RemoveFromCart(CartItem cartItem)
        {
            var product = _products.FirstOrDefault(i => i.Id == cartItem.Product.Id);
            if (cartItem != null)
            {
                if (cartItem.Quantity > 0)
                {
                    product.Quantity += 1;
                    return "Продукт удален из корзины!";
                }
                else if (cartItem.Quantity == 0)
                {
                    return "Продукт вернулся на склад!";
                }
            }
            return "Продукт не существует";
        }
    }
}
