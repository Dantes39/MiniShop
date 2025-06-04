using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MiniShop.Models
{
    public class DataModel
    {
        private readonly string _clientsFilePath = "Data/clients.json";
        private readonly string _ordersFilePath = "Data/orders.json";
        private List<Client> _clients;

        public DataModel()
        {
            string basePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", ".."));
            _clientsFilePath = Path.Combine(basePath, "Data", "clients.json");

            if (File.Exists(_clientsFilePath))
            {
                var json = File.ReadAllText(_clientsFilePath);
                _clients = JsonSerializer.Deserialize<List<Client>>(json) ?? new List<Client>();
            }
            else
            {
                _clients = new List<Client>();
            }

        }

        public List<Client> Clients => _clients;


        public void SaveData()
        {
            try
            {
                var clientJson = JsonSerializer.Serialize(_clients, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_clientsFilePath, clientJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
