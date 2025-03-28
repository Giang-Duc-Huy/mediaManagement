using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static Manage_Media.Channel;

namespace Manage_Media
{
    public partial class Dashboard : UserControl
    {
        private DateTime lastUpdateTime = DateTime.MinValue;
        public delegate void FilterAppliedEventHandler(object sender, List<Channel.AllChannel> filteredData);
        public event FilterAppliedEventHandler FilterApplied;
        private string channelsFilePath = "channels.json";
        private string staffFilePath = "staff.json";
        private List<Channel.AllChannel> channels = new List<Channel.AllChannel>();
        private List<Staff.AllStaff> staff = new List<Staff.AllStaff>();
        private System.Windows.Forms.Timer refreshTimer;

        public Dashboard()
        {
            InitializeComponent();
            InitializeTimer();
            // Đăng ký sự kiện trước khi khởi tạo dữ liệu
            this.FilterApplied += OnFilterApplied;

            // Thứ tự khởi tạo quan trọng
            InitializeDateFilters();
            LoadData();
            LoadData1();
            InitializeDataGridView();

            // Đăng ký sự kiện cho các control
            WireUpEvents();
            UpdateProgressBars();
        }
        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 2000; // Cập nhật mỗi giây
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            DateTime channelsLastWrite = File.GetLastWriteTime(channelsFilePath);
            DateTime staffLastWrite = File.GetLastWriteTime(staffFilePath);
            DateTime maxLastWrite = new[] { channelsLastWrite, staffLastWrite }.Max();

            if (maxLastWrite > lastUpdateTime)
            {
                ReloadData();
                UpdateProgressBars();
                lastUpdateTime = maxLastWrite;
            }
        }
        private (int upcomingCount, int releasedCount, int totalCount) CalculateChannelStatus()
        {
            DateTime currentTime = DateTime.Now;
            int total = channels.Count;
            int upcoming = channels.Count(c => c.Schedule > currentTime);
            int released = total - upcoming;

            return (upcoming, released, total);
        }
        private void UpdateProgressBars()
        {
            
            (int upcoming, int released, int total) = CalculateChannelStatus();

            if (total > 0)
            {
                // Tính phần trăm
                int upcomingPercentage = (int)((upcoming * 100f) / total);
                int releasedPercentage = (int)((released * 100f) / total);

                // Cập nhật UI - sử dụng Invoke nếu cần thiết
                if (circularProgressBar1.InvokeRequired || circularProgressBar2.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateProgressBarValues(upcomingPercentage, releasedPercentage, upcoming, released);
                    });
                }
                else
                {
                    UpdateProgressBarValues(upcomingPercentage, releasedPercentage, upcoming, released);
                }
            }
            else
            {
                // Nếu không có kênh nào, đặt giá trị về 0
                if (circularProgressBar1.InvokeRequired || circularProgressBar2.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        circularProgressBar1.Progress = 0;
                        circularProgressBar2.Progress = 0;
                        circularProgressBar1.Text = "0%";
                        circularProgressBar2.Text = "0%";
                    });
                }
                else
                {
                    circularProgressBar1.Progress = 0;
                    circularProgressBar2.Progress = 0;
                    circularProgressBar1.Text = "0%";
                    circularProgressBar2.Text = "0%";
                }
            }
        }

        private void UpdateProgressBarValues(int upcomingPercentage, int releasedPercentage, int upcomingCount, int releasedCount)
        {
            // Cập nhật cho CircularProgressBar1 (Upcoming)
            circularProgressBar1.Progress = upcomingPercentage;
            circularProgressBar1.Text = $"{upcomingPercentage}%";
            // Removed ToolTipText as it does not exist in CircularProgressBar
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(circularProgressBar1, $"{upcomingCount} Upcoming");

            // Cập nhật cho CircularProgressBar2 (Released)
            circularProgressBar2.Progress = releasedPercentage;
            circularProgressBar2.Text = $"{releasedPercentage}%";
            // Removed ToolTipText as it does not exist in CircularProgressBar
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(circularProgressBar2, $"{releasedCount} Released");
        }

        private void WireUpEvents()
        {
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            categoryFilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            dayComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            yearComboBox.SelectedIndexChanged += yearComboBox_SelectedIndexChanged;
            //filterButton.Click += FilterButton_Click;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = channels; // Hiển thị toàn bộ dữ liệu ban đầu
        }

        private void InitializeDateFilters()
        {
            // ComboBox ngày
            dayComboBox.Items.Add("Tất cả");
            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i.ToString("00"));
            }
            dayComboBox.SelectedIndex = 0;

            // ComboBox tháng
            monthComboBox.Items.Add("Tất cả");
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i.ToString("00"));
            }
            monthComboBox.SelectedIndex = 0;

            // ComboBox năm
            int currentYear = DateTime.Now.Year;
            yearComboBox.Items.Add("Tất cả");
            for (int i = currentYear - 5; i <= currentYear + 5; i++)
            {
                yearComboBox.Items.Add(i.ToString());
            }
            yearComboBox.SelectedIndex = yearComboBox.Items.IndexOf(currentYear.ToString());
        }
        public void ReloadData()
        {
            LoadData(); // Cập nhật số lượng channels và staff
            LoadData1(); // Tải lại dữ liệu và cập nhật DataGridView
            ApplyFilters(); // Áp dụng lại các bộ lọc hiện tại
        }
        private void UpdateCategoryFilterComboBox()
        {
            categoryFilterComboBox.Items.Clear();
            categoryFilterComboBox.Items.Add("Tất cả thể loại");

            List<string> uniqueCategories = new List<string>();

            // Lấy danh mục duy nhất
            foreach (AllChannel channel in channels)
            {
                if (!uniqueCategories.Contains(channel.Category))
                {
                    uniqueCategories.Add(channel.Category);
                }
            }

            // Sắp xếp danh sách danh mục
            for (int i = 0; i < uniqueCategories.Count - 1; i++)
            {
                for (int j = i + 1; j < uniqueCategories.Count; j++)
                {
                    if (string.Compare(uniqueCategories[i], uniqueCategories[j], StringComparison.Ordinal) > 0)
                    {
                        string temp = uniqueCategories[i];
                        uniqueCategories[i] = uniqueCategories[j];
                        uniqueCategories[j] = temp;
                    }
                }
            }

            // Thêm danh mục vào ComboBox
            foreach (string category in uniqueCategories)
            {
                categoryFilterComboBox.Items.Add(category);
            }

            // Giữ nguyên lựa chọn hiện tại nếu có
            if (categoryFilterComboBox.SelectedIndex < 0)
            {
                categoryFilterComboBox.SelectedIndex = 0;
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

                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        List<Channel.AllChannel> tempChannels = JsonConvert.DeserializeObject<List<Channel.AllChannel>>(jsonData);
                        if (tempChannels != null)
                        {
                            channels = tempChannels;
                        }
                        else
                        {
                            channels = new List<Channel.AllChannel>();
                        }
                    }
                    else
                    {
                        channels = new List<Channel.AllChannel>();
                    }

                    label2.Text = channels.Count.ToString();

                    // Cập nhật ComboBox thể loại
                    UpdateCategoryFilterComboBox();
                    UpdateProgressBars();

                    // Cập nhật DataGridView ngay lập tức
                    if (dataGridView1.InvokeRequired)
                    {
                        dataGridView1.Invoke(new MethodInvoker(delegate
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = channels;
                        }));
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = channels;
                    }
                }

                // Load staff data
                if (File.Exists(staffFilePath))
                {
                    string jsonData = File.ReadAllText(staffFilePath);

                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        List<Staff.AllStaff> tempStaff = JsonConvert.DeserializeObject<List<Staff.AllStaff>>(jsonData);
                        if (tempStaff != null)
                        {
                            staff = tempStaff;
                        }
                        else
                        {
                            staff = new List<Staff.AllStaff>();
                        }
                    }
                    else
                    {
                        staff = new List<Staff.AllStaff>();
                    }

                    label3.Text = staff.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnFilterApplied(object sender, List<Channel.AllChannel> filteredData)
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new MethodInvoker(delegate
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filteredData;
                }));
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredData;
            }
        }


        private void ApplyFilters()
        {
            try
            {
                List<Channel.AllChannel> filteredData = new List<Channel.AllChannel>();

                // Duyệt qua danh sách gốc
                foreach (Channel.AllChannel channel in channels)
                {
                    bool matchesSearch = true;
                    bool matchesCategory = true;
                    bool matchesDay = true;
                    bool matchesMonth = true;
                    bool matchesYear = true;

                    // Lọc theo tìm kiếm
                    if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
                    {
                        string searchText = searchTextBox.Text.ToLower();
                        string channelName = channel.Name.ToLower();
                        string channelCategory = channel.Category.ToLower();
                        string scheduleDate = channel.Schedule.ToString("dd/MM/yyyy");

                        if (!channelName.Contains(searchText) &&
                            !channelCategory.Contains(searchText) &&
                            !scheduleDate.Contains(searchText))
                        {
                            matchesSearch = false;
                        }
                    }

                    // Lọc theo thể loại
                    if (categoryFilterComboBox.SelectedIndex > 0)
                    {
                        string selectedCategory = categoryFilterComboBox.SelectedItem.ToString();
                        if (channel.Category != selectedCategory)
                        {
                            matchesCategory = false;
                        }
                    }

                    // Lọc theo ngày
                    if (dayComboBox.SelectedIndex > 0)
                    {
                        int day;
                        if (int.TryParse(dayComboBox.SelectedItem.ToString(), out day))
                        {
                            if (channel.Schedule.Day != day)
                            {
                                matchesDay = false;
                            }
                        }
                    }

                    // Lọc theo tháng
                    if (monthComboBox.SelectedIndex > 0)
                    {
                        int month;
                        if (int.TryParse(monthComboBox.SelectedItem.ToString(), out month))
                        {
                            if (channel.Schedule.Month != month)
                            {
                                matchesMonth = false;
                            }
                        }
                    }

                    // Lọc theo năm
                    if (yearComboBox.SelectedIndex > 0)
                    {
                        int year;
                        if (int.TryParse(yearComboBox.SelectedItem.ToString(), out year))
                        {
                            if (channel.Schedule.Year != year)
                            {
                                matchesYear = false;
                            }
                        }
                    }

                    // Nếu thỏa mãn tất cả điều kiện lọc, thêm vào danh sách kết quả
                    if (matchesSearch && matchesCategory && matchesDay && matchesMonth && matchesYear)
                    {
                        filteredData.Add(channel);
                    }
                }

                // Kích hoạt sự kiện với dữ liệu lọc được
                if (FilterApplied != null)
                {
                    FilterApplied(this, filteredData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi áp dụng bộ lọc: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        //private void FilterButton_Click(object sender, EventArgs e) => ApplyFilters();

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDaysComboBox();
            ApplyFilters();
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDaysComboBox();
            ApplyFilters();
        }

        private void UpdateDaysComboBox()
        {
            try
            {
                if (monthComboBox.SelectedIndex > 0 && yearComboBox.SelectedIndex > 0)
                {
                    int month = int.Parse(monthComboBox.SelectedItem.ToString());
                    int year = int.Parse(yearComboBox.SelectedItem.ToString());
                    int daysInMonth = DateTime.DaysInMonth(year, month);

                    string currentDay = dayComboBox.SelectedItem?.ToString();
                    dayComboBox.Items.Clear();

                    dayComboBox.Items.Add("Tất cả");
                    for (int i = 1; i <= daysInMonth; i++)
                    {
                        dayComboBox.Items.Add(i.ToString("00"));
                    }

                    dayComboBox.SelectedIndex = currentDay != null && dayComboBox.Items.Contains(currentDay)
                        ? dayComboBox.Items.IndexOf(currentDay)
                        : 0;
                }
            }
            catch
            {
                dayComboBox.SelectedIndex = 0;
            }
        }
        private void LoadData()

        {
            int totalChannels = 0;
            int totalStaff = 0;

            // Load channels data
            if (File.Exists(channelsFilePath))

            {
                try
                {
                    string jsonData = File.ReadAllText(channelsFilePath);
                    List<Channel.AllChannel> channels = JsonConvert.DeserializeObject<List<Channel.AllChannel>>(jsonData);
                    totalChannels = channels?.Count ?? 0;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error loading channels: " + ex.Message);
                }
            }

            // Load staff data
            if (File.Exists(staffFilePath))
            {
                try
                {
                    string jsonData = File.ReadAllText(staffFilePath);
                    List<Staff.AllStaff> staff = JsonConvert.DeserializeObject<List<Staff.AllStaff>>(jsonData);
                    totalStaff = staff?.Count ?? 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading staff: " + ex.Message);
                }

            }
            // Update UI
            if (label2.InvokeRequired || label3.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate {
                    label2.Text = totalChannels.ToString();
                    label3.Text = totalStaff.ToString();
                });
            }
            else
            {
                label2.Text = totalChannels.ToString();
                label3.Text = totalStaff.ToString();
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {
            Notify.ShowMessage("Số lượng kênh: " + label2.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Notify.ShowMessage("Số lượng nhân viên: " + label3.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("channel", "Tổng số kênh");
            dts.ShowDialog();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("staff", "Tổng số nhân viên");
            dts.ShowDialog();

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("upcoming", "Tổng số kênh sắp chiếu");
            dts.ShowDialog();
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("shown", "Tổng số kênh đã chiếu");
            dts.ShowDialog();
        }
    }
}
