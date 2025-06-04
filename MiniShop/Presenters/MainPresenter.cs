using System;
using System.Collections.Generic;
using System.Linq;
using MiniShop.Models;
using MiniShop.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MiniShop.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly ProductRepository _productRepository;
        private readonly CartModel _cartModel;
        private List<Product> _allProducts;

        public MainPresenter(IMainView view, ProductRepository productRepository, CartModel cartModel)
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

        private void AddToCart(Product product)
        {
            string flagProductRep = _productRepository.AddToCart(product);
            if (flagProductRep == "Продукт добавлен в корзину!")
            {
                _cartModel.Add(product);
                _view.DisplayProducts(_allProducts);
                _view.DisplayCart(_cartModel.Items.ToList());
            }
            else _view.ShowError(flagProductRep);
        }

        private void RemoveFromCart(CartItem cartItem)
        {
            string flagProductRep = _productRepository.RemoveFromCart(cartItem);
            if (flagProductRep == "Продукт удален из корзины!")
            {
                _cartModel.Remove(cartItem);
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

        private void UpdateUpTotalPrice(Product product)
        {
            if (product != null)
            {
                _cartModel.UpdateUpTotalPrice(product);
                _view.UpdateTotalPrice(_cartModel.price);
            }
        }

        private void UpdateDownTotalPrice(CartItem cartItem)
        {
            if (cartItem != null)
            {
                _cartModel.UpdateDownTotalPrice(cartItem);
                _view.UpdateTotalPrice(_cartModel.price);
            }
        }
    }
}
