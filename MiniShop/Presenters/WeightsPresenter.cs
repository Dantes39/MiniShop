using MiniShop.Models;
using MiniShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        public void PutInWeight(Product product, int quantity)
        {
            int totalWeight = _productRepository.CountWeights(product, quantity);
            _view.ShowWeight(totalWeight);

            /*
             * string flagProductRep = _productRepository.AddToCart(product, quantity);
             */
        }
    }
}
