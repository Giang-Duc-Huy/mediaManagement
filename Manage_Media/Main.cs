using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Media
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            staff1.Visible = false;
            channel1.Visible = false;
        }
        private void panel1_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            staff1.Visible = false;
            channel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Channel_Button_Click(object sender, EventArgs e)
        {
            channel1.Visible = true;
            staff1.Visible = false;
            dashboard1.Visible = false;
        }

        private void channel1_Load(object sender, EventArgs e)
        {

        }

        private void Staff_Button_Click(object sender, EventArgs e)
        {
            staff1.Visible = true;
            channel1.Visible = false;
            dashboard1.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
