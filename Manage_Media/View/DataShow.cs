﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DataShow(string type, string id)
        {
            InitializeComponent();
            LoadData1();
            LoadDgv(type, id);
        }
        private void LoadDgv(string type, string id)
        {
            dataGridView1.DataSource = null;
            if (type == "channel")
            {
                label1.Text = id;
                dataGridView1.DataSource = channels;
                dataGridView1.Columns["ID"].DisplayIndex = 0; 
                dataGridView1.Columns["Name"].DisplayIndex = 1; 
            }
            if (type == "staff")
            {
                label1.Text = id;
                dataGridView1.DataSource = staff;
                dataGridView1.Columns["ID"].DisplayIndex = 0;
                dataGridView1.Columns["Name"].DisplayIndex = 1;
            }
            
            if (type == "upcoming")
                {
                    label1.Text = id;
                    DateTime now = DateTime.Now;
                    List<Channel.AllChannel> channel1 = new List<Channel.AllChannel>();

                    foreach (Channel.AllChannel channel in channels)
                    {
                        if (channel.Schedule >= now) 
                        {
                            channel1.Add(channel);
                        }
                    }

                    dataGridView1.DataSource = channel1;
                dataGridView1.Columns["ID"].DisplayIndex = 0; 
                dataGridView1.Columns["Name"].DisplayIndex = 1; 
            }
            
            if (type == "shown")
            {
                label1.Text = id;
                DateTime now = DateTime.Now;
                List<Channel.AllChannel> channel1 = new List<Channel.AllChannel>();

                foreach (Channel.AllChannel channel in channels)
                {
                    if (channel.Schedule < now) 
                    {
                        channel1.Add(channel);
                    }
                }

                dataGridView1.DataSource = channel1;
                dataGridView1.Columns["ID"].DisplayIndex = 0; 
                dataGridView1.Columns["Name"].DisplayIndex = 1; 
            }
        }
        private void LoadData1()
        {
            try
            {
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
