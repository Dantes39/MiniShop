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
        private readonly string _productsFilePath;
        private List<Product> _products;
        private List<int> productsWeights = new List<int>();
        public int totalWeight = 0;
        public int totalWeightAmount = 0;

        public ProductRepository()
        {
            string basePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", ".."));
            _productsFilePath = Path.Combine(basePath, "Data", "products.json");

            if (File.Exists(_productsFilePath))
            {
                var json = File.ReadAllText(_productsFilePath);
                _products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
            else
            {
                _products = new List<Product>();
            }
        }

        public ProductRepository(List<Product> products)
        {
            _products = products ?? new List<Product>();
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
            File.WriteAllText(_productsFilePath, json);
        }

        public string AddToCart(Product product, int quantity)
        {
            if (product != null)
            {
                if (product.Quantity >= quantity)
                {
                    product.Quantity -= quantity;
                    return "Продукт добавлен в корзину!";
                }
                else if (product.Quantity < quantity)
                {
                    return $"В магазине {product.Name} остался в количестве {product.Quantity}!!!";
                }
                else if (product.Quantity == 0)
                {
                    return "Продукт закончился!";
                }
            }
            return "Продукт не существует";
        }

        public string RemoveFromCart(CartItem cartItem, int quantity)
        {
            var product = _products.FirstOrDefault(i => i.Id == cartItem.Product.Id);
            if (cartItem != null)
            {
                if ((cartItem.Quantity >= quantity) && !cartItem.IsWeighable)
                {
                    product.Quantity += quantity;
                    return "Продукт удален из корзины!";
                }
                else if (cartItem.IsWeighable)
                {
                    product.Quantity += cartItem.Quantity;
                    return "Продукт удален из корзины!";
                }
                else if (cartItem.Quantity == 0)
                {
                    return "Продукт вернулся на склад!";
                }
            }
            return "Продукт не существует";
        }

        public int CountWeights(Product product, int weightsQuantity)
        {
            Random random = new Random();
            if (totalWeightAmount > product.Quantity - weightsQuantity) return -1;
            for (int i = 0; i < weightsQuantity; i++)
            {
                int realProductWeight = random.Next(product.Weight[0], product.Weight[1]);
                productsWeights.Add(realProductWeight);
                totalWeight += realProductWeight;
            }
            totalWeightAmount += weightsQuantity;
            return totalWeight;
        }

        public float CountWeightsPrice(Product product, int totalWeight)
        {
            float totalPrice = product.Price * ((float)totalWeight / 1000);
            return totalPrice;
        }

        public int PutOutFromWeights(Product product, int weightsQuantity)
        {
            if (totalWeightAmount >= weightsQuantity)
            {
                int lenWeights = productsWeights.Count();
                for (int i = 1; i <= weightsQuantity; i++)
                {
                    int weightNow = productsWeights[lenWeights - i];
                    totalWeight -= weightNow;
                    totalWeightAmount--;
                    productsWeights.RemoveAt(lenWeights - i);
                }
                return totalWeight;
            }
            else return -1;
        }

        public void CleanWeigths()
        {
            productsWeights = new List<int>();
            totalWeight = 0;
            totalWeightAmount = 0;
        }
    }
}
