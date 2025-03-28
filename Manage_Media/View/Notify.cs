using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Media
{
    public partial class Notify : Form
    {
        public Notify(string title, string message, MessageBoxButtons button, MessageBoxIcon icon)
        {
            InitializeComponent();
            notify_Lb.Text = title;
            message_Lb.Text = message;
            //message_Lb.TextAlign = ContentAlignment.MiddleCenter;
            //message_Lb.Dock = DockStyle.Fill;
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    pictureBox1.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Warning:
                    pictureBox1.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case MessageBoxIcon.Error:
                    pictureBox1.Image = SystemIcons.Error.ToBitmap();
                    break;
                case MessageBoxIcon.Question:
                    pictureBox1.Image = SystemIcons.Question.ToBitmap();
                    break;
                default:
                    pictureBox1.Image = SystemIcons.Application.ToBitmap();
                    break;
            }
            AddButtons(button);
        }
        private void AddButtons(MessageBoxButtons button)
        {
            button1.Visible = false;
            Exit.Visible = false;

            if (button == MessageBoxButtons.OK)
            {
                button1.Visible = true;
                Exit.Visible = false;
            }
            if (button == MessageBoxButtons.OKCancel)
            {
                button1.Visible = true;
                Exit.Visible = true;
            }
        }
        private void X_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public static DialogResult ShowMessage(string title, string message, MessageBoxButtons button, MessageBoxIcon icon)
        {
            Notify notify = new Notify(title, message, button, icon);
            return notify.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
