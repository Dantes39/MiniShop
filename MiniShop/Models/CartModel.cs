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

        public void Add(Product product)
        {
            var item = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if ((item != null) && (item.Quantity < product.Quantity))
                item.Quantity++;
            else if ((item != null) && (item.Quantity >= product.Quantity))
                MessageBox.Show($"Выбрано максимальное количество товара {product.Name}");
            else
                _items.Add(new CartItem { Product = product, Quantity = 1 });
        }

        public void Remove(CartItem cartItem)
        {
            if (cartItem != null)
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity -= 1;
                }
                else
                {
                    _items.Remove(cartItem);
                }
        }

        public void UpdateUpTotalPrice(Product product)
        {
            var cartItem = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if ((cartItem != null) && (cartItem.Quantity < cartItem.Product.Quantity))
                price += cartItem.Product.Price;
        }

        public void UpdateDownTotalPrice(CartItem cartItem)
        {
            price -= cartItem.Product.Price;
        }
    }
}
