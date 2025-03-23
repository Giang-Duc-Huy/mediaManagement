using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Manage_Media
{
    public partial class Staff : UserControl, IDisplayable
    {
        private List<AllStaff> staffList = new List<AllStaff>();
        private string filepath = "staff.json";
        public AllStaff CurrentStaff;

        public Staff()
        {
            InitializeComponent();
            LoadData();
            CurrentStaff = new AllStaff();
            LoadDgv();
        }

        public void LoadDgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = staffList;
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
                staffList = string.IsNullOrWhiteSpace(jsonData)
                    ? new List<AllStaff>()
                    : JsonConvert.DeserializeObject<List<AllStaff>>(jsonData) ?? new List<AllStaff>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffList = new List<AllStaff>(); // Nếu lỗi, khởi tạo danh sách mới
            }
        }

        private void SaveData()
        {
            try
            {
                File.WriteAllText(filepath, JsonConvert.SerializeObject(staffList, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            staffID_Txt.Text = string.Empty;
            name_Txt.Text = string.Empty;
            phone_Txt.Text = string.Empty;
            address_Txt.Text = string.Empty;
            pictureBox1.Image = null; // Xóa ảnh hiển thị
            CurrentStaff = new AllStaff();
        }

        [Serializable]
        public class AllStaff
        {
            public string StaffID { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string ImagePath { get; set; } // Thuộc tính lưu đường dẫn ảnh
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(staffID_Txt.Text) ||
                string.IsNullOrWhiteSpace(name_Txt.Text) ||
                string.IsNullOrWhiteSpace(phone_Txt.Text) ||
                string.IsNullOrWhiteSpace(address_Txt.Text))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentStaff = new AllStaff
            {
                StaffID = staffID_Txt.Text,
                Name = name_Txt.Text,
                Phone = phone_Txt.Text,
                Address = address_Txt.Text,
                ImagePath = CurrentStaff.ImagePath // Lưu đường dẫn ảnh
            };

            staffList.Add(CurrentStaff);
            SaveData();
            LoadDgv();
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idToUpdate = Convert.ToString(dataGridView1.SelectedRows[0].Cells["StaffID"].Value);
            AllStaff staffToUpdate = null;

            foreach (AllStaff staff in staffList)
            {
                if (staff.StaffID == idToUpdate)
                {
                    staffToUpdate = staff;
                    break;
                }
            }

            if (staffToUpdate != null)
            {
                staffToUpdate.Name = name_Txt.Text;
                staffToUpdate.Phone = phone_Txt.Text;
                staffToUpdate.Address = address_Txt.Text;
                staffToUpdate.ImagePath = CurrentStaff.ImagePath; // Cập nhật đường dẫn ảnh

                SaveData();
                LoadDgv();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idToDelete = Convert.ToString(dataGridView1.SelectedRows[0].Cells["StaffID"].Value);
            AllStaff staffToDelete = staffList.FirstOrDefault(staff => staff.StaffID == idToDelete);

            if (staffToDelete != null)
            {
                staffList.Remove(staffToDelete);
                SaveData();
                LoadDgv();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                staffID_Txt.Text = row.Cells["StaffID"].Value.ToString();
                name_Txt.Text = row.Cells["Name"].Value.ToString();
                phone_Txt.Text = row.Cells["Phone"].Value.ToString();
                address_Txt.Text = row.Cells["Address"].Value.ToString();

               
                string imagePath = row.Cells["ImagePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    CurrentStaff.ImagePath = imagePath; // Lưu đường dẫn ảnh vào CurrentStaff
                }
                else
                {
                    pictureBox1.Image = null;
                    CurrentStaff.ImagePath = null;
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn ảnh
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imagePath); // Hiển thị ảnh lên PictureBox
                CurrentStaff.ImagePath = imagePath; // Lưu đường dẫn ảnh vào CurrentStaff
            }
        }
    }
}