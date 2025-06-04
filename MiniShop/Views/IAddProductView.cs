using System;

namespace MiniShop.Views
{
    public interface IAddProductView
    {
        event Action OnSaveProductClicked;
        string ProductTitle { get; }
        float ProductPrice { get; }
        int ProductQuantity { get; }
        DateTime ProductExpiration { get; }
        string ProductPhotoPath { get; }
        bool IsWeighable { get; }
        int[] Weight { get; }
        void CloseView();
    }
}
