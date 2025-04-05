using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MiniShop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MiniShop.Views
{
    public partial class MainForm : Form, IMainView
    {
        public event Action<int> OnAddToCartClicked;
        public event Action OnAddProductClicked;
        public event Action<int> OnRemoveFromCartClicked;
        public event Action<string> OnSearchChanged;
        public event Action<string> OnSortOptionChanged;

        public MainForm()
        {
            InitializeComponent();
            comboBoxSort.Items.AddRange(new string[]
            {
                "Название",
                "Цена",
                "Срок годности"
            });

            comboBoxSort.SelectedIndex = 0;

            WireUpEvents();
        }

        private void WireUpEvents()
        {
            listBoxProducts.SelectedIndexChanged += (s, e) =>
            {
                if (listBoxProducts.SelectedItem is Product product)
                {
                    DisplayProductPhoto(product.PhotoPath);
                }
            };
            buttonAddToCart.Click += (s, e) =>
            {
                if (listBoxProducts.SelectedItem is Product product)
                {
                    OnAddToCartClicked?.Invoke(product.Id);
                }
            };
            buttonAddProduct.Click += (s, e) => OnAddProductClicked?.Invoke();
            buttonRemoveFromCart.Click += (s, e) =>
            {
                if (listBoxCart.SelectedItem is CartItem item)
                {
                    OnRemoveFromCartClicked?.Invoke(item.Product.Id);
                }
            };
            textBoxSearch.TextChanged += (s, e) => OnSearchChanged?.Invoke(textBoxSearch.Text);
            comboBoxSort.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxSort.SelectedItem != null)
                    OnSortOptionChanged?.Invoke(comboBoxSort.SelectedItem.ToString());
            };
        }

        public void DisplayProducts(List<Product> products)
        {
            listBoxProducts.DataSource = null;
            listBoxProducts.DataSource = products;
            listBoxProducts.DisplayMember = "DisplayInfo";
        }

        public void DisplayCart(List<CartItem> cartItems)
        {
            listBoxCart.DataSource = null;
            listBoxCart.DataSource = cartItems;
            listBoxCart.DisplayMember = "DisplayInfo";
        }

        public void DisplayProductPhoto(string photoPath)
        {
            pictureBoxProductPhoto.ImageLocation = photoPath;
        }

        public void UpdateTotalPrice(decimal total)
        {
            labelTotalPrice.Text = $"Итого: {total}₽";
        }
    }
}
