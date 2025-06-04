using MiniShop.Models;
using MiniShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Presenters
{
    internal class WeightsPresenter
    {
        private readonly WeightsForm _view;
        private readonly ProductRepository _productRepository;
        private readonly CartModel _cartModel;
        private List<Product> _allProducts;

        public WeightsPresenter(WeightsForm view, ProductRepository productRepository, CartModel cartModel)
        {
            _view = view;
            _productRepository = productRepository;
            _cartModel = cartModel;
            _view.OnButtonMakeWeightClicked += PutInWeight;
            _view.OnButtonPutOutProductClicked += PutOutWeight;
            _view.OnButtonAddToCartClicked += WeightsToCart;
        }
        public void PutInWeight(Product product, int quantity)
        {
            int totalWeight = _productRepository.CountWeights(product, quantity);
            float totalPrice;
            if (totalWeight == -1) _view.ShowError("Количество товаров ограничено!");
            else
            {
                totalPrice = _productRepository.CountWeightsPrice(product, totalWeight);
                _view.ShowWeight(totalWeight);
                _view.ShowTotalAmount(_productRepository.totalWeightAmount);
                _view.ShowTotalPrice(totalPrice);
            }
        }

        public void PutOutWeight(Product product, int quantity)
        {
            int totalWeight = _productRepository.PutOutFromWeights(product, quantity);
            float totalPrice;
            if (totalWeight == -1) _view.ShowError("На весах меньше продуктов, чем требуется!");
            else
            {
                totalPrice = _productRepository.CountWeightsPrice(product, totalWeight);
                _view.ShowWeight(totalWeight);
                _view.ShowTotalAmount(_productRepository.totalWeightAmount);
                _view.ShowTotalPrice(totalPrice);
            }
        }
        
        public void WeightsToCart(Product product)
        {
            int totalWeight = _productRepository.totalWeight;
            int totalWeightAmount = _productRepository.totalWeightAmount;

            string flagProductRep = _productRepository.AddToCart(product, totalWeightAmount);
            
            if (flagProductRep == "Продукт добавлен в корзину!")
            {
                _cartModel.Add(product, totalWeightAmount, true, totalWeight);
                _view.Close();
            }
        }
    }
}
