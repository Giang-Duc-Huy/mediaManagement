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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

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
                Notify.ShowMessage("Cần điền đủ chỗ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Main m = new Main();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
        }
        private void Check_Pass_CheckedChanged(object sender, EventArgs e)
        {
            Password_TxtBox.PasswordChar = Check_Pass.Checked ? '\0' : '*';
            //if (Check_Pass.Checked)
            //{
            //    Password_TxtBox.UseSystemPasswordChar = false;
            //}
            //else
            //{
            //    Password_TxtBox.UseSystemPasswordChar = true;
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
