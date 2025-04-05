using System;

namespace MiniShop.Views
{
    public interface IAddProductView
    {
        event Action OnSaveProductClicked;
        string ProductTitle { get; }
        decimal ProductPrice { get; }
        int ProductQuantity { get; }
        DateTime ProductExpiration { get; }
        string ProductPhotoPath { get; }
        void CloseView();
    }
}
