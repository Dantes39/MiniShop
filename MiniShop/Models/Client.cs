using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public class Client : IClient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public float BonusScore { get; set; } = 100;
        public float CashAmount { get; set; } = 0;
        public float CardMoney { get; set; } = 0;


        public Client()
        {
            ID = 0;
            Name = string.Empty;
            Surname = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            Password = string.Empty;
        }

        public Client(int id, string name, string surname, string phone, string address, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Address = address;
            Password = password;
        }
    }
}
