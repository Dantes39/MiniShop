using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public interface IClient
    {
        int ID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        string Password { get; set; }
    }
}
