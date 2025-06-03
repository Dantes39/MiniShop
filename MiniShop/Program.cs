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

            var dataModel = new DataModel();
            LoginForm loginForm = new LoginForm(dataModel);
            var repository = new ProductRepository();
            var cartModel = new CartModel();

            var mainForm = new MainForm(loginForm.IsAdmin, loginForm.LoggedInClient, dataModel);
            var presenter = new MainPresenter(mainForm, repository, cartModel);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(mainForm);
            }
           
        }
    }
}
