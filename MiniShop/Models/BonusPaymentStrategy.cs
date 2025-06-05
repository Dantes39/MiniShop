using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public class BonusPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(float amount, Client client)
        {
            if (client.BonusScore >= amount)
            {
                client.BonusScore -= amount;
                return true;
            }
            return false;
        }
    }
}
