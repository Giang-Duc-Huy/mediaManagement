using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Manage_Media
{
    public interface IDisplayable
    {
        void LoadDgv();
        void SaveData();
        void ClearFields();
    }

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

    public partial class Channel : UserControl, IDisplayable
    {
        public static event Action DataChanged;
        private List<AllChannel> channels = new List<AllChannel>();
        private string filepath = "channels.json";
        public AllChannel CurrentChannel;

        public Channel()
        {
            InitializeComponent();
            LoadData();
            CurrentChannel = new AllChannel();
            LoadDgv();
            LoadCbb();
        }

        public void LoadCbb()
        {
            category_Cbb.Items.AddRange(new string[]
            {
                "Chính trị", "Giải trí", "Hoạt hình", "Môi trường",
                "Nấu ăn & Ẩm thực", "Khoa học & Khám phá",
                "Thời trang & Phong cách sống", "Thời sự & Tin tức",
                "Thời tiết"
            });
        }

        public void ClearFields()
        {
            channelID_Txt.Text = string.Empty;
            name_Txt.Text = string.Empty;
            producer_Txt.Text = string.Empty;
            duration_Txt.Text = string.Empty;
            category_Cbb.SelectedIndex = -1;
            schedule_Dtp.Value = DateTime.Now;
            CurrentChannel = new AllChannel();
        }

        private bool IsDuplicateID(string newID)
        {
            return channels.Exists(ch => ch.ID == newID);
        }

        public void SaveData()
        {
            try
            {
                if (channels.Count > 0)
                {
                    channels[0].SaveToJson(filepath, channels);
                }
                else
                {
                    new AllChannel().SaveToJson(filepath, channels);
                }

                DataChanged?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            try
            {
                channels = new AllChannel().LoadFromJson<AllChannel>(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                channels = new List<AllChannel>();
            }
        }

        [Serializable]
        public class AllChannel : Basedata
        {
            [JsonProperty(Order = 4)]
            private string producer;
            public string Producer { get { return producer; } set {producer = value; } }
            [JsonProperty(Order = 5)]
            private int duration;
            public int Duration { get { return duration; } set{ duration = value; } }
            [JsonProperty(Order = 6)]
            private string category;
            public string Category { get { return category; } set { category = value; } }
            [JsonProperty(Order = 7)]
            private DateTime schedule;
            public DateTime Schedule { get { return schedule; } set { schedule = value; } }

            public override string GetInfo()
            {
                return $"{base.GetInfo()}, Producer: {Producer}, Category: {Category}, Duration: {Duration} minutes";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = channelID_Txt.Text;
            string name = name_Txt.Text;
            string category = category_Cbb.SelectedItem?.ToString();
            string producer = producer_Txt.Text;
            DateTime schedule = schedule_Dtp.Value;

            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(producer) ||
                string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(duration_Txt.Text, out int duration) || duration <= 0)
            {
                MessageBox.Show("Duration phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            addChannel(id, name, duration, producer, category, schedule);
        }

        private void addChannel(string id, string name, int duration, string producer, string category, DateTime schedule)
        {
            if (IsDuplicateID(id))
            {
                MessageBox.Show("ID đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AllChannel newChannel = new AllChannel
            {
                ID = id,
                Name = name,
                Duration = duration,
                Producer = producer,
                Category = category,
                Schedule = schedule
            };

            channels.Add(newChannel);
            SaveData();
            LoadDgv();
            MessageBox.Show("Thêm bản tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        public void LoadDgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = channels;
            dataGridView1.Columns["ID"].DisplayIndex = 0; 
            dataGridView1.Columns["Name"].DisplayIndex = 1; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Notify.ShowMessage("Vui lòng chọn một bản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idToDelete = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ID"].Value);

            // Duyệt danh sách và xóa phần tử có ID trùng khớp
            for (int i = 0; i < channels.Count; i++)
            {
                if (channels[i].ID == idToDelete)
                {
                    channels.RemoveAt(i);
                    break; // Vì ID là duy nhất nên chỉ cần xóa một lần rồi dừng vòng lặp
                }
            }

            SaveData();
            LoadDgv();
           Notify.ShowMessage("Xóa bản tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Notify.ShowMessage("Vui lòng chọn một bản để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idToUpdate = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            AllChannel channelToUpdate = null;

            foreach (AllChannel ch in channels)
            {
                if (ch.ID == idToUpdate)
                {
                    channelToUpdate = ch;
                    break;
                }
            }

            if (channelToUpdate != null)
            {
                channelToUpdate.Name = name_Txt.Text;
                channelToUpdate.Producer = producer_Txt.Text;

                int duration;
                if (int.TryParse(duration_Txt.Text, out duration) && duration > 0)
                {
                    channelToUpdate.Duration = duration;
                }
                else
                {
                    Notify.ShowMessage("Duration phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                channelToUpdate.Category = Convert.ToString(category_Cbb.SelectedItem);
                channelToUpdate.Schedule = schedule_Dtp.Value;

                SaveData();
                LoadDgv();
                Notify.ShowMessage("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                Notify.ShowMessage("Không tìm thấy kênh để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
