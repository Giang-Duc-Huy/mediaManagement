using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static Manage_Media.Channel;

namespace Manage_Media
{
    public interface IDisplayable
    {
        void LoadDgv();
    }
    public partial class Channel : UserControl, IDisplayable
    {
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
            category_Cbb.Items.Add("Environment");
            category_Cbb.Items.Add("Politic");
            category_Cbb.Items.Add("Unemployment");
            category_Cbb.Items.Add("Weather");
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
        private void SaveData()
        {
            try
            {
                File.WriteAllText(filepath, JsonConvert.SerializeObject(channels, Formatting.Indented));
            }
            catch (Exception ex)
            {
                Notify.ShowMessage("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    File.WriteAllText(filepath, "[]"); // Tạo file mới nếu không tồn tại
                }

                string jsonData = File.ReadAllText(filepath);
                channels = string.IsNullOrWhiteSpace(jsonData)
                    ? new List<AllChannel>()
                    : JsonConvert.DeserializeObject<List<AllChannel>>(jsonData) ?? new List<AllChannel>();
            }
            catch (Exception ex)
            {
                Notify.ShowMessage("Lỗi khi tải dữ liệu JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                channels = new List<AllChannel>(); // Nếu lỗi, khởi tạo danh sách mới
            }
        }

        [Serializable]
        public class AllChannel
        {
            private string id;
            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private string producer;
            public string Producer
            {
                get { return producer; }
                set { producer = value; }
            }
            private int duration;
            public int Duration
            {
                get { return duration; }
                set { duration = value; }
            }
            private string category;
            public string Category
            {
                get { return category; }
                set { category = value; }
            }
            private DateTime schedule;
            public DateTime Schedule
            {
                get { return schedule; }
                set { schedule = value; }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(channelID_Txt.Text) ||
                string.IsNullOrWhiteSpace(name_Txt.Text) ||
                string.IsNullOrWhiteSpace(producer_Txt.Text) ||
                category_Cbb.SelectedIndex == -1)
            {
                Notify.ShowMessage("Cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra Duration có hợp lệ không
            if (!int.TryParse(duration_Txt.Text, out int duration) || duration <= 0)
            {
                Notify.ShowMessage("Duration phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gán dữ liệu vào CurrentChannel
            CurrentChannel = new AllChannel
            {
                ID = channelID_Txt.Text,
                Name = name_Txt.Text,
                Producer = producer_Txt.Text,
                Duration = duration,
                Category = category_Cbb.SelectedItem.ToString(),
                Schedule = schedule_Dtp.Value
            };

            // Thêm vào danh sách
            channels.Add(CurrentChannel);
            SaveData();
            LoadDgv();
            Notify.ShowMessage("Thêm kênh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }
        public void LoadDgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = channels;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Notify.ShowMessage("Vui lòng chọn một kênh để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Notify.ShowMessage("Vui lòng chọn một kênh để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idToDelete = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ID"].Value);

            DialogResult result = Notify.ShowMessage("Bạn có chắc chắn muốn xóa kênh này?", "Thông báo",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Tìm và xóa kênh không dùng Lambda
                for (int i = 0; i < channels.Count; i++)
                {
                    if (channels[i].ID == idToDelete)
                    {
                        channels.RemoveAt(i);
                        break; // Dừng ngay sau khi xóa
                    }
                }

                SaveData(); // Lưu lại dữ liệu sau khi xóa
                LoadDgv();  // Cập nhật DataGridView

                Notify.ShowMessage("Xóa kênh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
