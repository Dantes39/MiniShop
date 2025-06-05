using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MiniShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public bool IsWeighable { get; set; }
        public int[] Weight { get; set; } = new int[2];
        public DateTime ExpiryDate { get; set; }
        public string PhotoPath { get; set; }
        public string DisplayInfo => $"{Name} — {Price}₽ × {Quantity}";

        public Product(int id, string name, float price, int quantity, bool isWeighable,
            int[] weight, DateTime expiryDate, string photoPath) 
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
            IsWeighable = isWeighable;
            Weight = weight;
            ExpiryDate = expiryDate;
            PhotoPath = photoPath;
        }

        public Product() 
        {
            Id = 0;
            Name = string.Empty;
            Price = 0;
            Quantity = 0;
            Weight = new int[2] {0, 0};
            IsWeighable = false;
            ExpiryDate = DateTime.MinValue;
            PhotoPath = string.Empty;
        }
    }
}
