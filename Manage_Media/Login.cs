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
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Login_TxtBox.Text == "" || Password_TxtBox.Text == "")
            {
                Notify.ShowMessage("Cần điền username và password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Main m = new Main();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
        }
    }
}
