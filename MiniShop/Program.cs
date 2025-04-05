using System;
using System.Windows.Forms;
using MiniShop.Views;
using MiniShop.Models;
using MiniShop.Presenters;

namespace MiniShop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();                     // View
            var repository = new ProductRepository();          // Model
            var cartModel = new CartModel();                   // Корзина

            var presenter = new MainPresenter(mainForm, repository, cartModel); // Презентер
            Application.Run(mainForm);
        }
    }
}
