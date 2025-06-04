namespace MiniShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public bool IsWeighable { get; set; }
        public int Weight { get; set; }

        public string DisplayInfo => $"{Product.Name} — {Product.Price}₽ × {Quantity} × {Weight}";

        public CartItem(Product product, int quantity) 
        {
            Product = product;
            Quantity = quantity;
            IsWeighable = false;
            Weight = 0;
        }
        public CartItem(Product product, int quantity, bool isWeighable, int weight) 
        {
            Product = product;
            Quantity = quantity;
            IsWeighable = isWeighable;
            Weight = weight;
        }
    }
}
