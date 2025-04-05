using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MiniShop.Utils
{
    public static class JsonStorageHelper<T>
    {
        public static List<T> Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public static void Save(string filePath, List<T> data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
