using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MiniShop.Models;
using MiniShop.Views;

namespace MiniShop.Presenters
{
    public class PaymentPresenter
    {
        private readonly IPaymentView _view;
        private readonly Client _client;
        private readonly float _totalAmount;
        private readonly CartModel _cartModel;
        private readonly OrderRepository _orderRepository;
        private readonly ProductRepository _productRepository;
        private float _remainingAmount;
        private readonly float _maxBonusAmount;
        private readonly IPaymentStrategy _cashStrategy;
        private readonly IPaymentStrategy _cardStrategy;
        private readonly IPaymentStrategy _bonusStrategy;
        private float _paidCash;
        private float _paidCard;
        private float _paidBonus;

        public PaymentPresenter(IPaymentView view, float totalAmount, Client client, CartModel cartModel, OrderRepository orderRepository, ProductRepository productRepository)
        {
            _view = view;
            _client = client;
            _totalAmount = totalAmount;
            _cartModel = cartModel;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _remainingAmount = totalAmount;
            _maxBonusAmount = totalAmount * 0.5f;
            _cashStrategy = new CashPaymentStrategy();
            _cardStrategy = new CardPaymentStrategy();
            _bonusStrategy = new BonusPaymentStrategy();
            _paidCash = 0;
            _paidCard = 0;
            _paidBonus = 0;

            _view.OnPayClicked += HandlePay;
            _view.OnCancelClicked += HandleCancel;
            _view.OnCashMaxClicked += HandleCashMax;
            _view.OnCardMaxClicked += HandleCardMax;
            _view.OnBonusMaxClicked += HandleBonusMax;

            InitializeView();
        }

        private void InitializeView()
        {
            _view.SetTotalAmount(_totalAmount);
            _view.SetBalances(_client.CashAmount, _client.CardMoney, _client.BonusScore);
            _view.SetRemainingAmount(_remainingAmount);
        }

        private void HandleCashMax()
        {
            float maxCash = Math.Min(_client.CashAmount, _remainingAmount);
            _view.SetCashAmount(maxCash.ToString());
        }

        private void HandleCardMax()
        {
            float maxCard = Math.Min(_client.CardMoney, _remainingAmount);
            _view.SetCardAmount(maxCard.ToString());
        }

        private void HandleBonusMax()
        {
            float maxBonus = Math.Min(_client.BonusScore, _maxBonusAmount);
            maxBonus = Math.Min(maxBonus, _remainingAmount);
            _view.SetBonusAmount(maxBonus.ToString());
        }

        public void HandlePay()
        {
            float cashAmount = 0, cardAmount = 0, bonusAmount = 0;
            bool parseSuccess = true;

            if (!float.TryParse(_view.GetCashAmount(), out cashAmount) || cashAmount < 0)
            {
                _view.ShowError("Введите корректную сумму для наличных.");
                parseSuccess = false;
            }
            if (parseSuccess && (!float.TryParse(_view.GetCardAmount(), out cardAmount) || cardAmount < 0))
            {
                _view.ShowError("Введите корректную сумму для карты.");
                parseSuccess = false;
            }
            if (parseSuccess && (!float.TryParse(_view.GetBonusAmount(), out bonusAmount) || bonusAmount < 0))
            {
                _view.ShowError("Введите корректную сумму для бонусов.");
                parseSuccess = false;
            }

            if (!parseSuccess) return;

            float totalInput = cashAmount + cardAmount + bonusAmount;

            if (totalInput == 0)
            {
                _view.ShowError("Укажите сумму для оплаты хотя бы одним способом.");
                return;
            }

            if (bonusAmount > _maxBonusAmount)
            {
                _view.ShowError($"Бонусами можно оплатить не более 50% от суммы ({_maxBonusAmount}₽).");
                return;
            }

            float adjustedCash = cashAmount;
            float adjustedCard = cardAmount;
            if (totalInput > _remainingAmount)
            {
                adjustedCash = Math.Min(cashAmount, _remainingAmount);
                float remainingAfterCash = _remainingAmount - adjustedCash;
                adjustedCard = Math.Min(cardAmount, remainingAfterCash);
                bonusAmount = Math.Min(bonusAmount, remainingAfterCash - adjustedCard);
            }

            if (adjustedCash > 0 && !_cashStrategy.Pay(adjustedCash, _client))
            {
                _view.ShowError("Недостаточно наличных для оплаты.");
                return;
            }
            if (adjustedCard > 0 && !_cardStrategy.Pay(adjustedCard, _client))
            {
                _view.ShowError("Недостаточно средств на карте для оплаты.");
                return;
            }
            if (bonusAmount > 0 && !_bonusStrategy.Pay(bonusAmount, _client))
            {
                _view.ShowError("Недостаточно бонусов для оплаты.");
                return;
            }

            _paidCash += adjustedCash;
            _paidCard += adjustedCard;
            _paidBonus += bonusAmount;

            _remainingAmount -= (adjustedCash + adjustedCard + bonusAmount);
            _view.SetRemainingAmount(_remainingAmount);
            _view.SetBalances(_client.CashAmount, _client.CardMoney, _client.BonusScore);

            if (_remainingAmount <= 0)
            {
                var order = new Order
                {
                    Client = _client,
                    Items = new List<CartItem>(_cartModel.Items),
                    PaymentMethods = new Dictionary<string, float>()
                };
                if (_paidCash > 0) order.PaymentMethods.Add("Cash", _paidCash);
                if (_paidCard > 0) order.PaymentMethods.Add("Card", _paidCard);
                if (_paidBonus > 0) order.PaymentMethods.Add("Bonus", _paidBonus);

                _orderRepository.SaveOrder(order);

                _view.ShowSuccess("Оплата прошла успешно!");
                _view.CloseForm(DialogResult.OK);
                _productRepository.Save();
            }
        }

        private void HandleCancel()
        {
            _view.CloseForm(DialogResult.Cancel);
        }
    }
}