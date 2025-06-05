using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MiniShop.Models;

namespace MiniShop.Views
{
    public partial class MainForm : Form, IMainView
    {
        private bool isAdmin;
        private Client loggedInClient;
        private DataModel dataModel;
        private int productQuantity => (int)numericUpDownProductQuantity.Value;
        public event Action<Product, int> OnAddToCartClicked;
        public event Action OnAddProductClicked;
        public event Action<CartItem, int> OnRemoveFromCartClicked;
        public event Action<string> OnSearchChanged;
        public event Action<string> OnSortOptionChanged;
        public event Action OnPaymentClicked;

        public MainForm(bool isAdmin, Client loggedInClient, DataModel dataModel)
        {
            this.isAdmin = isAdmin;
            this.loggedInClient = loggedInClient;
            this.dataModel = dataModel;

            InitializeComponent();

            if (isAdmin)
            {
                buttonAddProduct.Visible = true;
            }

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
                    OnAddToCartClicked?.Invoke(product, this.productQuantity);
                }
            };
            buttonAddProduct.Click += (s, e) => OnAddProductClicked?.Invoke();
            buttonRemoveFromCart.Click += (s, e) =>
            {
                if (listBoxCart.SelectedItem is CartItem item)
                {
                    OnRemoveFromCartClicked?.Invoke(item, this.productQuantity);
                }
            };
            textBoxSearch.TextChanged += (s, e) => OnSearchChanged?.Invoke(textBoxSearch.Text);
            comboBoxSort.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxSort.SelectedItem != null)
                    OnSortOptionChanged?.Invoke(comboBoxSort.SelectedItem.ToString());
            };
            buttonPayment.Click += (s, e) => OnPaymentClicked?.Invoke();
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

        public void UpdateTotalPrice(float total)
        {
            labelTotalPrice.Text = $"Итого: {total}₽";
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            dataModel.SaveData();
        }

        public void ProcessPayment()
        {

        }
    }
}