using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MiniShop.Models
{
    public class OrderRepository
    {
        private readonly string _filePath;

        public OrderRepository()
        {
            string basePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", ".."));
            _filePath = Path.Combine(basePath, "Data", "orders.json");

            // Убедимся, что папка Data существует
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
        }

        public void SaveOrder(Order order)
        {
            try
            {
                int maxOrderId = 0;

                // Если файл существует, определяем максимальный OrderId
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    var orders = JsonSerializer.Deserialize<List<Order>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<Order>();
                    maxOrderId = orders.Count > 0 ? orders.Max(o => o.OrderId) : 0;
                }

                // Присваиваем новый OrderId и дату
                order.OrderId = maxOrderId + 1;
                order.OrderDate = DateTime.Now;

                // Читаем существующие заказы или создаем новый список
                List<Order> ordersToSave;
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    ordersToSave = JsonSerializer.Deserialize<List<Order>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<Order>();
                }
                else
                {
                    ordersToSave = new List<Order>();
                }

                ordersToSave.Add(order);

                // Сохраняем обновленный список заказов
                string newJson = JsonSerializer.Serialize(ordersToSave, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, newJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}