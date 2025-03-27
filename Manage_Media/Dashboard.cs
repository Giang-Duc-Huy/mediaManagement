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
            var (upcoming, released, total) = CalculateChannelStatus();

            if (total > 0)
            {
                // Tính phần trăm
                int upcomingPercentage = (int)((upcoming * 100f) / total);
                int releasedPercentage = (int)((released * 100f) / total);

                // Cập nhật UI - sử dụng Invoke nếu cần thiết
                if (circularProgressBar1.InvokeRequired || circularProgressBar2.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate {
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
                    this.Invoke((MethodInvoker)delegate {
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

            List<string> uniqueCategories = channels
                .Select(c => c.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

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
                    channels = JsonConvert.DeserializeObject<List<Channel.AllChannel>>(jsonData) ?? new List<Channel.AllChannel>();
                    label2.Text = channels.Count.ToString();

                    // Cập nhật ComboBox thể loại
                    UpdateCategoryFilterComboBox();
                    UpdateProgressBars();

                    // Cập nhật DataGridView ngay lập tức
                    if (dataGridView1.InvokeRequired)
                    {
                        dataGridView1.Invoke(new Action(() =>
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
                    staff = JsonConvert.DeserializeObject<List<Staff.AllStaff>>(jsonData) ?? new List<Staff.AllStaff>();
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
                dataGridView1.Invoke(new Action(() =>
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
                var filteredData = channels.AsEnumerable();

                // Lọc theo tìm kiếm
                if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
                {
                    filteredData = filteredData.Where(c =>
                        c.Name.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase) ||
                        c.Category.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase) ||
                        c.Schedule.ToString("dd/MM/yyyy").Contains(searchTextBox.Text));
                }

                // Lọc theo thể loại
                if (categoryFilterComboBox.SelectedIndex > 0)
                {
                    string selectedCategory = categoryFilterComboBox.SelectedItem.ToString();
                    filteredData = filteredData.Where(c => c.Category == selectedCategory);
                }

                // Lọc theo ngày
                if (dayComboBox.SelectedIndex > 0 && int.TryParse(dayComboBox.SelectedItem.ToString(), out int day))
                {
                    filteredData = filteredData.Where(c => c.Schedule.Day == day);
                }

                // Lọc theo tháng
                if (monthComboBox.SelectedIndex > 0 && int.TryParse(monthComboBox.SelectedItem.ToString(), out int month))
                {
                    filteredData = filteredData.Where(c => c.Schedule.Month == month);
                }

                // Lọc theo năm
                if (yearComboBox.SelectedIndex > 0 && int.TryParse(yearComboBox.SelectedItem.ToString(), out int year))
                {
                    filteredData = filteredData.Where(c => c.Schedule.Year == year);
                }

                FilterApplied?.Invoke(this, filteredData.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi áp dụng bộ lọc: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
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
            DataShow dts = new DataShow("channel");
            dts.ShowDialog();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("staff");
            dts.ShowDialog();

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("upcoming");
            dts.ShowDialog();
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {
            DataShow dts = new DataShow("shown");
            dts.ShowDialog();
        }
    }
}
