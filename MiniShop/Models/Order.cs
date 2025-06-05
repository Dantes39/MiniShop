using System;
using System.Collections.Generic;

namespace MiniShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Client Client { get; set; }
        public List<CartItem> Items { get; set; }
        public Dictionary<string, float> PaymentMethods { get; set; }

        public Order()
        {
            Items = new List<CartItem>();
            PaymentMethods = new Dictionary<string, float>();
        }
    }
}