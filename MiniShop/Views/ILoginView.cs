using MiniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Views
{
    internal interface ILoginView
    {
        string Phone { get; }
        string Password { get; }
        string NameClient { get; }
        string SurnameClient { get; }
        bool IsRegisterChecked { get; }
        void ShowError(string message);
        void ShowSuccess(string message);
        void CloseForm(DialogResult result);
        bool IsAdmin { get; set; }
        Client LoggedInClient { get; set; }
    }
}
