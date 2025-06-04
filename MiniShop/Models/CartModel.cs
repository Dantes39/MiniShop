using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiniShop.Models
{
    public class CartModel
    {
        private readonly List<CartItem> _items = new List<CartItem>();
        public float price = 0;
        public IReadOnlyList<CartItem> Items => _items;

        public void Add(Product product, int quantity, bool isWeighable = false, int weight = 0)
        {
            var item = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if ((item != null) && (item.Quantity >= quantity))
            {
                item.Quantity += quantity;
                item.Weight += weight;
            }
            else
                _items.Add(new CartItem(product, quantity, isWeighable, weight));
        }

        public void Remove(CartItem cartItem, int quantity)
        {
            if (cartItem != null)
                if (cartItem.Quantity >= quantity && !cartItem.IsWeighable)
                {
                    cartItem.Quantity -= quantity;
                }
                else
                {
                    _items.Remove(cartItem);
                }
        }

        public void UpdateUpTotalPrice(Product product, int quantity)
        {
            var cartItem = _items.FirstOrDefault(i => i.Product.Id == product.Id);
            if ((cartItem != null) && (cartItem.Quantity > 0))
                price += cartItem.Product.Price * quantity;
        }

        public void UpdateDownTotalPrice(CartItem cartItem, int quantity)
        {
            if ((cartItem != null && cartItem.Quantity >= quantity))
            price -= cartItem.Product.Price * quantity;
        }

        public void UpdateUpTotalPriceWeighable(float weightPrice)
        {
            price += weightPrice;
        }

        public void UpdateDownTotalPriceWeighable(float weightPrice)
        {
            price -= weightPrice;
        }
    }
}
