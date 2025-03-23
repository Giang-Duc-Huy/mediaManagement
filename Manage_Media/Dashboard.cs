using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Manage_Media
{
    public partial class Dashboard : UserControl
    {
        private string channelsFilePath = "channels.json";
        private string staffFilePath = "staff.json";

        public Dashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load channels data
            int totalChannels = 0;
            if (File.Exists(channelsFilePath))
            {
                string jsonData = File.ReadAllText(channelsFilePath);
                List <Channel.AllChannel> channels = JsonConvert.DeserializeObject<List<Channel.AllChannel>>(jsonData);
                totalChannels = channels?.Count ?? 0;
            }

            // Load staff data
            int totalStaff = 0;
            if (File.Exists(staffFilePath))
            {
                string jsonData = File.ReadAllText(staffFilePath);
                List<Staff> staff = JsonConvert.DeserializeObject<List<Staff>>(jsonData);
                totalStaff = staff?.Count ?? 0;
            }

            // Update UI
            label2.Text = totalChannels.ToString();
            label3.Text = totalStaff.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Channels: " + label2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Staff: " + label3.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Subscribers: " + label5.Text);
        }
    }
}
