using MiniShop.Models;
using MiniShop.Views;
using System.Xml.Linq;

namespace MiniShop.Presenters
{
    public class AddProductPresenter
    {
        private readonly IAddProductView _view;
        private readonly IProductRepository _productRepository;

        public AddProductPresenter(IAddProductView view, IProductRepository productRepository)
        {
            _view = view;
            _productRepository = productRepository;
            _view.OnSaveProductClicked += SaveProduct;
        }

        private void SaveProduct()
        {
            var product = new Product(
                0,
                _view.ProductTitle,
                _view.ProductPrice,
                _view.ProductQuantity,
                _view.IsWeighable,
                _view.Weight,
                _view.ProductExpiration,
                _view.ProductPhotoPath);
            
            _productRepository.Add(product);
            _productRepository.Save();
            _view.CloseView();
        }
    }
}
