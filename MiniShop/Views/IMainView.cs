using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MiniShop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MiniShop.Views
{
    public interface IMainView
    {
        event Action<Product> OnAddToCartClicked;
        event Action OnAddProductClicked;
        event Action<CartItem> OnRemoveFromCartClicked;
        event Action<string> OnSearchChanged;
        event Action<string> OnSortOptionChanged;
        void DisplayProducts(List<Product> products);
        void DisplayCart(List<CartItem> cartItems);
        void DisplayProductPhoto(string photoPath);
        void UpdateTotalPrice(float total);
        void ShowError(string message);
        void ShowSuccess(string message);
    }
}
