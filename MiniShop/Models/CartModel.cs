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

        public void Remove(int productId)
        {
            var item = _items.FirstOrDefault(i => i.Product.Id == productId);
            if (item != null)
                if (item.Quantity > 1)
                {
                    item.Quantity -= 1;
                }
                else
                {
                    _items.Remove(item);
                }
        }

        public void UpdateUpTotalPrice(int productId)
        {
            var item = _items.FirstOrDefault(i => i.Product.Id == productId);
            if ((item != null) && (item.Quantity < item.Product.Quantity))
                price += item.Product.Price;
        }

        public void UpdateDownTotalPrice(int productId)
        {
            var item = _items.FirstOrDefault(i => i.Product.Id == productId);
            price -= item.Product.Price;
        }

    }
}
