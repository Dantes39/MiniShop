using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public class CardPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(float amount, Client client)
        {
            if (client.CardMoney >= amount)
            {
                client.CardMoney -= amount;
                return true;
            }
            return false;
        }
    }
}
