using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiniShop.Models
{
    public class CartModel
    {
        private readonly List<CartItem> _items = new List<CartItem>();
        public decimal price = 0;
        public IReadOnlyList<CartItem> Items => _items;

        public void Add(Product product, int quantity)
        {
            var item = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if ((item != null) && (item.Quantity >= quantity))
                item.Quantity += quantity;
            else
                _items.Add(new CartItem(product, quantity));
        }

        public void Remove(CartItem cartItem, int quantity)
        {
            if (cartItem != null)
                if (cartItem.Quantity >= quantity)
                {
                    cartItem.Quantity -= quantity;
                }
                else
                {
                    _items.Remove(cartItem);
                }
        }

        public void UpdateUpTotalPrice(Product product)
        {
            var cartItem = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if ((cartItem != null) && (cartItem.Quantity > 0))
                price += cartItem.Product.Price;
        }

        public void UpdateDownTotalPrice(CartItem cartItem)
        {
            price -= cartItem.Product.Price;
        }
    }
}
