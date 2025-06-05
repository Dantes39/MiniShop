using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(float amount, Client client)
        {
            if (client.CashAmount >= amount)
            {
                client.CashAmount -= amount;
                return true;
            }
            return false;
        }
    }
}
