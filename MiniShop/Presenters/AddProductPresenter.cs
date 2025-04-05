using MiniShop.Models;
using MiniShop.Views;

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
            var product = new Product
            {
                Name = _view.ProductTitle,
                Price = _view.ProductPrice,
                Quantity = _view.ProductQuantity,
                ExpiryDate = _view.ProductExpiration,
                PhotoPath = _view.ProductPhotoPath
            };
            _productRepository.Add(product);
            _productRepository.Save();
            _view.CloseView();
        }
    }
}
