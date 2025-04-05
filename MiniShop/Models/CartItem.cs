namespace MiniShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public string DisplayInfo => $"{Product.Name} — {Product.Price}₽ × {Quantity}";
    }
}
