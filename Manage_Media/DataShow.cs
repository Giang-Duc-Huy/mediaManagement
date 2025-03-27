using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Manage_Media.Channel;

namespace Manage_Media
{
    public partial class DataShow : Form
    {
        private string channelsFilePath = "channels.json";
        private string staffFilePath = "staff.json";
        private List<Channel.AllChannel> channels = new List<Channel.AllChannel>();
        private List<Staff.AllStaff> staff = new List<Staff.AllStaff>();
        public DataShow(string type)
        {
            InitializeComponent();
            LoadData1();
            LoadDgv(type);
        }
        private void LoadDgv(string type)
        {
            dataGridView1.DataSource = null;
            if (type == "channel")
            {
                dataGridView1.DataSource = channels;
            }
            if (type == "staff")
            {
                dataGridView1.DataSource = staff;
            }
            
            if (type == "upcoming")
                {
                    DateTime now = DateTime.Now;
                    List<Channel.AllChannel> channel1 = new List<Channel.AllChannel>();

                    foreach (Channel.AllChannel channel in channels)
                    {
                        if (channel.Schedule >= now) // So sánh trực tiếp vì Schedule đã là DateTime
                        {
                            channel1.Add(channel);
                        }
                    }

                    dataGridView1.DataSource = channel1;
                }
            
            if (type == "shown")
            {
                DateTime now = DateTime.Now;
                List<Channel.AllChannel> channel1 = new List<Channel.AllChannel>();

                foreach (Channel.AllChannel channel in channels)
                {
                    if (channel.Schedule < now) // So sánh trực tiếp vì Schedule đã là DateTime
                    {
                        channel1.Add(channel);
                    }
                }

                dataGridView1.DataSource = channel1;
            }
        }
        private void LoadData1()
        {
            try
            {
                // Load channels data
                if (File.Exists(channelsFilePath))
                {
                    string jsonData = File.ReadAllText(channelsFilePath);
                    channels = JsonConvert.DeserializeObject<List<Channel.AllChannel>>(jsonData) ?? new List<Channel.AllChannel>();
                }
                if (File.Exists(staffFilePath))
                {
                    string jsonData = File.ReadAllText(staffFilePath);
                    staff = JsonConvert.DeserializeObject<List<Staff.AllStaff>>(jsonData) ?? new List<Staff.AllStaff>();
                }

            }
            catch 
            {
                Notify.ShowMessage("Lỗi tải dữ liêu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
