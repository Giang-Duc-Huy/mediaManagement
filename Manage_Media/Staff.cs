using Newtonsoft.Json;
using System.Text.RegularExpressions;

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
            InitializeGenderComboBox();
            LoadData();
            CurrentStaff = new AllStaff();
            LoadDgv();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitializeGenderComboBox()
        {
            genderComboBox.SelectedIndex = 0;
        }

        public void LoadDgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = staffList;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void LoadData()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(LoadData));
                return;
            }

            try
            {
                if (!File.Exists(filepath))
                {
                    File.WriteAllText(filepath, "[]");
                    staffList = new List<AllStaff>();
                    return;
                }

                using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string jsonData = streamReader.ReadToEnd();

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
            genderComboBox.SelectedIndex = 0;
            pictureBox1.Image = null;
            CurrentStaff = new AllStaff();
        }

        [Serializable]
        public class AllStaff
        {
            public string StaffID { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Gender { get; set; }
            public string ImagePath { get; set; }
        }

        private bool ValidateInputs(bool isUpdating = false)
        {
            if (string.IsNullOrWhiteSpace(staffID_Txt.Text))
            {
                Notify.ShowMessage("Mã nhân viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!isUpdating || (isUpdating && staffID_Txt.Text != CurrentStaff.StaffID))
            {
                if (staffList.Any(s => s.StaffID == staffID_Txt.Text))
                {
                    Notify.ShowMessage("Mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(name_Txt.Text))
            {
                Notify.ShowMessage("Tên nhân viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string phonePattern = @"^(0|\+84)(\d{9,10})$";
            if (!Regex.IsMatch(phone_Txt.Text, phonePattern))
            {
                Notify.ShowMessage("Số điện thoại không hợp lệ. Phải bắt đầu bằng 0 hoặc +84 và có 9-10 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(address_Txt.Text))
            {
                Notify.ShowMessage("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            CurrentStaff = new AllStaff
            {
                StaffID = staffID_Txt.Text,
                Name = name_Txt.Text,
                Phone = phone_Txt.Text,
                Address = address_Txt.Text,
                Gender = genderComboBox.SelectedItem.ToString(),
                ImagePath = CurrentStaff.ImagePath
            };

            staffList.Add(CurrentStaff);
            SaveData();
            LoadDgv();
            Notify.ShowMessage("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && CurrentStaff == null)
            {
                Notify.ShowMessage("Vui lòng chọn một nhân viên để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(true)) return;

            AllStaff staffToUpdate = staffList.FirstOrDefault(staff => staff.StaffID == CurrentStaff.StaffID);

            if (staffToUpdate != null)
            {
                bool staffIdChanged = staffID_Txt.Text != CurrentStaff.StaffID;

                staffToUpdate.Name = name_Txt.Text;
                staffToUpdate.Phone = phone_Txt.Text;
                staffToUpdate.Address = address_Txt.Text;
                staffToUpdate.Gender = genderComboBox.SelectedItem.ToString();
                staffToUpdate.ImagePath = CurrentStaff.ImagePath;

                if (staffIdChanged)
                {
                    staffToUpdate.StaffID = staffID_Txt.Text;
                }

                SaveData();
                LoadDgv();

                if (staffIdChanged)
                {
                    CurrentStaff.StaffID = staffID_Txt.Text;
                }

                Notify.ShowMessage("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    staffList.Remove(staffToDelete);
                    SaveData();
                    LoadDgv();
                    Notify.ShowMessage("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
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

                CurrentStaff = new AllStaff
                {
                    StaffID = row.Cells["StaffID"].Value.ToString(),
                    Name = row.Cells["Name"].Value.ToString(),
                    Phone = row.Cells["Phone"].Value.ToString(),
                    Address = row.Cells["Address"].Value.ToString(),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    ImagePath = row.Cells["ImagePath"].Value?.ToString()
                };

                staffID_Txt.Text = CurrentStaff.StaffID;
                name_Txt.Text = CurrentStaff.Name;
                phone_Txt.Text = CurrentStaff.Phone;
                address_Txt.Text = CurrentStaff.Address;

                if (!string.IsNullOrEmpty(CurrentStaff.Gender))
                {
                    genderComboBox.SelectedItem = CurrentStaff.Gender;
                }
                else
                {
                    genderComboBox.SelectedIndex = 0;
                }

                if (!string.IsNullOrEmpty(CurrentStaff.ImagePath) && File.Exists(CurrentStaff.ImagePath))
                {
                    pictureBox1.Image = Image.FromFile(CurrentStaff.ImagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    CurrentStaff.ImagePath = imagePath;
                }
                catch (Exception ex)
                {
                    Notify.ShowMessage($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void phone_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '+' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}