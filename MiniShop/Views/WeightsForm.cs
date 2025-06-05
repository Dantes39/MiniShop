using MiniShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Views

{
    public partial class WeightsForm : Form
    {
        public int WeightsQuantity => (int)numericUpDownQuantityProduct.Value;
        public event Action<Product, int> OnButtonMakeWeightClicked;
        public event Action<Product, int> OnButtonPutOutProductClicked;
        public event Action<Product> OnButtonAddToCartClicked;
        private Product SelectedProduct;
        public WeightsForm(Product product)
        {
            this.SelectedProduct = product;
            InitializeComponent();
            ShowProduct(this.SelectedProduct);
            WireUpEvents();
        }


        public void ShowWeight(float weight)
        {
            labelWeight.Text = weight.ToString();
        }

        public void ShowTotalAmount(int totalAmount)
        {
            labelTotalAmount.Text = totalAmount.ToString();
        }

        public void ShowTotalPrice(float totalPrice) 
        {
            labelPrice.Text = totalPrice.ToString();
        }

        public void ShowProduct(Product product)
        {
            labelProduct.Text = product.Name;
            pictureBoxProduct.ImageLocation = product.PhotoPath;
        }

        public void WireUpEvents()
        {
            buttonMakeWeight.Click += (s, e) =>
            {
                OnButtonMakeWeightClicked?.Invoke(this.SelectedProduct, this.WeightsQuantity);
            };

            buttonPutOutProduct.Click += (s, e) =>
            {
                OnButtonPutOutProductClicked?.Invoke(this.SelectedProduct, this.WeightsQuantity);
            };

            buttonAddToCart.Click += (s, e) =>
            {
                OnButtonAddToCartClicked?.Invoke(this.SelectedProduct);
            };
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
