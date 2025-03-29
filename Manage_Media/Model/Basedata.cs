using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Media
{
    public class Basedata
    {
        [JsonProperty(Order = 1)]
        public string ID { get; set; }
        [JsonProperty(Order = 2)]
        public string Name { get; set; }


        public virtual void SaveToJson<T>(string filePath, List<T> items)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(items, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual List<T> LoadFromJson<T>(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<T>>(jsonData) ?? new List<T>();
                }
                return new List<T>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
        }

        public virtual string GetInfo()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
