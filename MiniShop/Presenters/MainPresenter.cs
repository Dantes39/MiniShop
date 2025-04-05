using System;
using System.Collections.Generic;
using System.Linq;
using MiniShop.Models;
using MiniShop.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MiniShop.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IProductRepository _productRepository;
        private readonly CartModel _cartModel;
        private List<Product> _allProducts;

        public MainPresenter(IMainView view, IProductRepository productRepository, CartModel cartModel)
        {
            _view = view;
            _productRepository = productRepository;
            _cartModel = cartModel;
            _view.OnAddToCartClicked += AddToCart;
            _view.OnAddToCartClicked += UpdateUpTotalPrice;
            _view.OnAddProductClicked += OpenAddProduct;
            _view.OnRemoveFromCartClicked += UpdateDownTotalPrice;
            _view.OnRemoveFromCartClicked += RemoveFromCart;
            _view.OnSearchChanged += SearchProducts;
            _view.OnSortOptionChanged += SortProducts;
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
            _view.DisplayCart(_cartModel.Items.ToList());;
        }

        private void AddToCart(int productId)
        {
            var product = _allProducts.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                _cartModel.Add(product);
                _view.DisplayCart(_cartModel.Items.ToList());;
            }
        }

        private void RemoveFromCart(int productId)
        {
            _cartModel.Remove(productId);
            _view.DisplayCart(_cartModel.Items.ToList());;
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

        private void UpdateUpTotalPrice(int productId)
        {
            var product = _allProducts.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                _cartModel.UpdateUpTotalPrice(productId);
                _view.UpdateTotalPrice(_cartModel.price);
            }
        }

        private void UpdateDownTotalPrice(int productId)
        {
            var product = _allProducts.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                _cartModel.UpdateDownTotalPrice(productId);
                _view.UpdateTotalPrice(_cartModel.price);
            }
        }
    }
}
