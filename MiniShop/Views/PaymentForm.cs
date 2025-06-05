using System;
using System.Windows.Forms;
using MiniShop.Presenters;

namespace MiniShop.Views
{
    public partial class PaymentForm : Form, IPaymentView
    {
        public event Action OnPayClicked;
        public event Action OnCancelClicked;
        public event Action OnCashMaxClicked;
        public event Action OnCardMaxClicked;
        public event Action OnBonusMaxClicked;

        public PaymentForm()
        {
            InitializeComponent();
            buttonPay.Click += (s, e) => OnPayClicked?.Invoke();
            buttonCancel.Click += (s, e) => OnCancelClicked?.Invoke();
            buttonCashMax.Click += (s, e) => OnCashMaxClicked?.Invoke();
            buttonCardMax.Click += (s, e) => OnCardMaxClicked?.Invoke();
            buttonBonusMax.Click += (s, e) => OnBonusMaxClicked?.Invoke();
        }

        public void SetTotalAmount(float totalAmount)
        {
            labelTotalAmount.Text = $"Сумма к оплате: {totalAmount}₽";
        }

        public void SetBalances(float cash, float card, float bonus)
        {
            labelCashBalance.Text = $"Баланс: {cash}₽";
            labelCardBalance.Text = $"Баланс: {card}₽";
            labelBonusBalance.Text = $"Баланс: {bonus}";
        }

        public void SetRemainingAmount(float remaining)
        {
            labelRemaining.Text = $"Остаток: {remaining}₽";
        }

        public string GetCashAmount()
        {
            return textBoxCashAmount.Text;
        }

        public string GetCardAmount()
        {
            return textBoxCardAmount.Text;
        }

        public string GetBonusAmount()
        {
            return textBoxBonusAmount.Text;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CloseForm(DialogResult result)
        {
            this.DialogResult = result;
            this.Close();
        }
    }
}