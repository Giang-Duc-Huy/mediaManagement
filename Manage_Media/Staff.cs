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
        public static event Action DataChanged;
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

        public void LoadData()
        {
            // Sử dụng Invoke nếu cần thiết để tránh cross-thread issues
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(LoadData));
                return;
            }

            try
            {
                // Kiểm tra và tạo file nếu không tồn tại
                if (!File.Exists(filepath))
                {
                    File.WriteAllText(filepath, "[]");
                    staffList = new List<AllStaff>();
                    return;
                }

                // Đọc file với FileStream để tránh locking issues
                using (var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var streamReader = new StreamReader(fileStream))
                {
                    string jsonData = streamReader.ReadToEnd();

                    // Deserialize dữ liệu
                    staffList = string.IsNullOrWhiteSpace(jsonData)
                        ? new List<AllStaff>()
                        : JsonConvert.DeserializeObject<List<AllStaff>>(jsonData) ?? new List<AllStaff>();
                }
            }
            catch (JsonException jsonEx)
            {
                string errorMsg = $"Lỗi định dạng JSON: {jsonEx.Message}\nFile sẽ được tạo lại.";
                MessageBox.Show(errorMsg, "Lỗi JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.WriteAllText(filepath, "[]");
                staffList = new List<AllStaff>();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Lỗi truy cập file: {ioEx.Message}", "Lỗi IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Kích hoạt sự kiện dữ liệu thay đổi
                DataChanged?.Invoke();
            }

        }

        public void SaveData()
        {
            try
            {
                File.WriteAllText(filepath, JsonConvert.SerializeObject(staffList, Formatting.Indented));
                DataChanged?.Invoke();
            }
            catch (Exception ex)
            {
                Notify.ShowMessage("Lỗi tải dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearFields()
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
                Notify.ShowMessage("Cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Notify.ShowMessage("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Notify.ShowMessage("Vui lòng chọn một nhân viên để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Notify.ShowMessage("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                Notify.ShowMessage("Không tìm thấy nhân viên để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Notify.ShowMessage("Vui lòng chọn một nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idToDelete = Convert.ToString(dataGridView1.SelectedRows[0].Cells["StaffID"].Value);
            AllStaff staffToDelete = staffList.FirstOrDefault(staff => staff.StaffID == idToDelete);

            if (staffToDelete != null)
            {
                staffList.Remove(staffToDelete);
                SaveData();
                LoadDgv();
                Notify.ShowMessage("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                Notify.ShowMessage("Không tìm thấy nhân viên để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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