using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Views
{
    public interface IPaymentView
    {
        void SetTotalAmount(float totalAmount);
        void SetBalances(float cash, float card, float bonus);
        void SetRemainingAmount(float remaining);
        string GetCashAmount();
        string GetCardAmount();
        string GetBonusAmount();
        void SetCashAmount(string amount);
        void SetCardAmount(string amount);
        void SetBonusAmount(string amount);
        void ShowError(string message);
        void ShowSuccess(string message);
        void CloseForm(DialogResult result);
        event Action OnPayClicked;
        event Action OnCancelClicked;
        event Action OnCashMaxClicked;
        event Action OnCardMaxClicked;
        event Action OnBonusMaxClicked;
    }
}
