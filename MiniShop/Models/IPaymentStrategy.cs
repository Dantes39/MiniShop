using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    internal interface IPaymentStrategy
    {
        bool Pay(float amount, Client client);
    }
}
