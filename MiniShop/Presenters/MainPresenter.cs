using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MiniShop.Models;
using MiniShop.Views;

namespace MiniShop.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly ProductRepository _productRepository;
        private readonly CartModel _cartModel;
        private readonly OrderRepository _orderRepository;
        private List<Product> _allProducts;
        private readonly Client loggedInClient;

        public MainPresenter(IMainView view, ProductRepository productRepository, CartModel cartModel, Client loggedInClient)
        {
            _view = view;
            _productRepository = productRepository;
            _cartModel = cartModel;
            _orderRepository = new OrderRepository();
            this.loggedInClient = loggedInClient;
            _view.OnAddToCartClicked += AddToCart;
            _view.OnAddToCartClicked += UpdateUpTotalPrice;
            _view.OnAddProductClicked += OpenAddProduct;
            _view.OnRemoveFromCartClicked += UpdateDownTotalPrice;
            _view.OnRemoveFromCartClicked += RemoveFromCart;
            _view.OnSearchChanged += SearchProducts;
            _view.OnSortOptionChanged += SortProducts;
            _view.OnPaymentClicked += HandlePayment;
            LoadProducts();
            UpdateView();
        }

        private void LoadProducts()
        {
            _allProducts = _productRepository.GetAll();
        }

        private void UpdateView()
        {
            LoadProducts();
            _view.DisplayProducts(_allProducts);
            _view.DisplayCart(_cartModel.Items.ToList());
            _view.UpdateTotalPrice(_cartModel.price);
        }

        private void AddToCart(Product product, int quantity)
        {
            if (!product.IsWeighable)
            {
                string flagProductRep = _productRepository.AddToCart(product, quantity);
                if (flagProductRep == "Продукт добавлен в корзину!")
                {
                    _cartModel.Add(product, quantity);
                    _view.DisplayProducts(_allProducts);
                    _view.DisplayCart(_cartModel.Items.ToList());
                }
                else _view.ShowError(flagProductRep);
            }
            else
            {
                _view.ShowError("Данный товар необходимо взвесить!");
                OpenWeightsForm(product);
            }
        }

        private void RemoveFromCart(CartItem cartItem, int quantity)
        {
            string flagProductRep = _productRepository.RemoveFromCart(cartItem, quantity);
            if (flagProductRep == "Продукт удален из корзины!")
            {
                _cartModel.Remove(cartItem, quantity);
                _view.DisplayProducts(_allProducts);
                _view.DisplayCart(_cartModel.Items.ToList());
            }
            else _view.ShowError(flagProductRep);
        }

        private void OpenAddProduct()
        {
            var addProductForm = new Views.AddProductForm();
            var addProductPresenter = new AddProductPresenter(addProductForm, _productRepository);
            addProductForm.ShowDialog();
            LoadProducts();
            UpdateView();
        }

        private void SearchProducts(string searchText)
        {
            var filtered = _allProducts.Where(p => p.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            _view.DisplayProducts(filtered);
        }

        private void SortProducts(string sortOption)
        {
            List<Product> sorted;
            switch (sortOption)
            {
                case "Название":
                    sorted = _allProducts.OrderBy(p => p.Name).ToList();
                    break;
                case "Цена":
                    sorted = _allProducts.OrderBy(p => p.Price).ToList();
                    break;
                case "Срок годности":
                    sorted = _allProducts.OrderBy(p => p.ExpiryDate).ToList();
                    break;
                default:
                    sorted = _allProducts;
                    break;
            }
            _view.DisplayProducts(sorted);
        }

        private void UpdateUpTotalPrice(Product product, int quantity)
        {
            if (product != null && !product.IsWeighable)
            {
                _cartModel.UpdateUpTotalPrice(product, quantity);
                _view.UpdateTotalPrice(_cartModel.price);
            }
        }

        private void UpdateDownTotalPrice(CartItem cartItem, int quantity)
        {
            if (cartItem != null && !cartItem.IsWeighable)
            {
                _cartModel.UpdateDownTotalPrice(cartItem, quantity);
            }
            else if (cartItem.IsWeighable)
            {
                var product = _productRepository.GetAll().FirstOrDefault(i => i.Id == cartItem.Product.Id);
                var weightPrice = _productRepository.CountWeightsPrice(product, cartItem.Weight);
                _cartModel.UpdateDownTotalPriceWeighable(weightPrice);
            }
            _view.UpdateTotalPrice(_cartModel.price);
        }

        private void OpenWeightsForm(Product product)
        {
            var weightsForm = new Views.WeightsForm(product);
            var weightsPresenter = new WeightsPresenter(weightsForm, _productRepository, _cartModel);
            DialogResult result = weightsForm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                _view.DisplayProducts(_allProducts);
                _view.DisplayCart(_cartModel.Items.ToList());
                _productRepository.CleanWeigths();
                _view.UpdateTotalPrice(_cartModel.price);
            }
        }

        private void HandlePayment()
        {
            if (_cartModel.Items.Count == 0)
            {
                _view.ShowError("Корзина пуста. Добавьте товары для оплаты.");
                return;
            }

            if (loggedInClient == null)
            {
                _view.ShowError("Оплата доступна только для клиентов.");
                return;
            }

            var paymentForm = new PaymentForm();
            var paymentPresenter = new PaymentPresenter(paymentForm, _cartModel.price, loggedInClient, _cartModel, _orderRepository, _productRepository);
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                _cartModel.Clear();
                _cartModel.price = 0;
                UpdateView();
                _view.ShowSuccess("Оплата прошла успешно!");
            }
        }
    }
}