using System;

namespace MiniShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PhotoPath { get; set; }
        public string DisplayInfo => $"{Name} — {Price}₽ × {Quantity}";

    }
}
