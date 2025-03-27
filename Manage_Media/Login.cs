using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Manage_Media
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Password_TxtBox.PasswordChar = '*';
        }

        private List<Account> LoadAccounts()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "account.json");
                if (!File.Exists(filePath))
                {
                    // Nếu file không tồn tại, tạo mới với danh sách rỗng
                    File.WriteAllText(filePath, "{\"Accounts\": []}");
                }

                string jsonData = File.ReadAllText(filePath);

                // Đọc dữ liệu JSON từ file
                AccountData accountData = JsonSerializer.Deserialize<AccountData>(jsonData);

                if (accountData == null || accountData.Accounts == null)
                {
                    return new List<Account>();
                }

                return accountData.Accounts;
            }
            catch (Exception ex)
            {
                Notify.ShowMessage($"Lỗi khi đọc file account.json: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Account>();
            }
        }


        private bool CheckLogin(string username, string password)
        {
            List<Account> accounts = LoadAccounts();
            foreach (Account acc in accounts)
            {
                if (acc.AccountName == username && acc.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string username = Login_TxtBox.Text.Trim();
            string password = Password_TxtBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Notify.ShowMessage("Cần điền username và password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckLogin(username, password))
            {
                Notify.ShowMessage("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main m = new Main();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else
            {
                Notify.ShowMessage("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = Notify.ShowMessage("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void Check_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Pass.Checked)
            {
                Password_TxtBox.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
        }
    }

    public class Account
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
    }

    public class AccountData
    {
        public List<Account> Accounts { get; set; }
    }
}
