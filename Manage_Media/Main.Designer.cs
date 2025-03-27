using System.Windows.Forms;

namespace Manage_Media
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Logout_Button = new Button();
            pictureBox1 = new PictureBox();
            Dashboard_Button = new Button();
            Staff_Button = new Button();
            Channel_Button = new Button();
            pictureBox3 = new PictureBox();
            dashboard1 = new Dashboard();
            channel1 = new Channel();
            staff1 = new Staff();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(97, 30);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 0;
            label1.Text = "Channel Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 87);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(Logout_Button);
            panel2.Controls.Add(Channel_Button);
            panel2.Controls.Add(Staff_Button);
            panel2.Controls.Add(Dashboard_Button);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 80);
            panel2.TabIndex = 3;
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.FromArgb(47, 47, 47);
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Logout_Button.FlatAppearance.BorderSize = 2;
            Logout_Button.FlatAppearance.CheckedBackColor = Color.White;
            Logout_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = SystemColors.ButtonHighlight;
            Logout_Button.Image = (Image)resources.GetObject("Logout_Button.Image");
            Logout_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Logout_Button.Location = new Point(725, 10);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(223, 58);
            Logout_Button.TabIndex = 5;
            Logout_Button.Text = "Log out";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOrange;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 72);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
      
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.BackColor = Color.FromArgb(47, 47, 47);
            Dashboard_Button.Cursor = Cursors.Hand;
            Dashboard_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Dashboard_Button.FlatAppearance.BorderSize = 2;
            Dashboard_Button.FlatAppearance.CheckedBackColor = Color.White;
            Dashboard_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard_Button.ForeColor = SystemColors.ButtonHighlight;
            Dashboard_Button.Image = (Image)resources.GetObject("Dashboard_Button.Image");
            Dashboard_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_Button.Location = new Point(487, 10);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Size = new Size(223, 58);
            Dashboard_Button.TabIndex = 2;
            Dashboard_Button.Text = "Dashboard";
            Dashboard_Button.UseVisualStyleBackColor = false;
            Dashboard_Button.Click += Dashboard_Button_Click;
            // 
            // Staff_Button
            // 
            Staff_Button.BackColor = Color.FromArgb(47, 47, 47);
            Staff_Button.Cursor = Cursors.Hand;
            Staff_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Staff_Button.FlatAppearance.BorderSize = 2;
            Staff_Button.FlatAppearance.CheckedBackColor = Color.White;
            Staff_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Staff_Button.FlatStyle = FlatStyle.Flat;
            Staff_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Staff_Button.ForeColor = SystemColors.ButtonHighlight;
            Staff_Button.Image = (Image)resources.GetObject("Staff_Button.Image");
            Staff_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Staff_Button.Location = new Point(249, 10);
            Staff_Button.Name = "Staff_Button";
            Staff_Button.Size = new Size(223, 58);
            Staff_Button.TabIndex = 1;
            Staff_Button.Text = "Staff";
            Staff_Button.UseVisualStyleBackColor = false;
            Staff_Button.Click += Staff_Button_Click;
            // 
            // Channel_Button
            // 
            Channel_Button.BackColor = Color.FromArgb(47, 47, 47);
            Channel_Button.Cursor = Cursors.Hand;
            Channel_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Channel_Button.FlatAppearance.BorderSize = 2;
            Channel_Button.FlatAppearance.CheckedBackColor = Color.White;
            Channel_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Channel_Button.FlatStyle = FlatStyle.Flat;
            Channel_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Channel_Button.ForeColor = Color.White;
            Channel_Button.Image = (Image)resources.GetObject("Channel_Button.Image");
            Channel_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Channel_Button.Location = new Point(11, 10);
            Channel_Button.Name = "Channel_Button";
            Channel_Button.Size = new Size(223, 58);
            Channel_Button.TabIndex = 0;
            Channel_Button.Text = "Channel";
            Channel_Button.UseVisualStyleBackColor = true;
            Channel_Button.Click += Channel_Button_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(0, 155);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(962, 644);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(32, 32, 32);
            dashboard1.Location = new Point(0, 155);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(962, 644);
            dashboard1.TabIndex = 5;
            // 
            // channel1
            // 
            channel1.BackColor = Color.FromArgb(32, 32, 32);
            channel1.Location = new Point(0, 155);
            channel1.Name = "channel1";
            channel1.Size = new Size(962, 644);
            channel1.TabIndex = 6;
            // 
            // staff1
            // 
            staff1.BackColor = Color.FromArgb(32, 32, 32);
            staff1.ForeColor = Color.Black;
            staff1.Location = new Point(0, 155);
            staff1.Name = "staff1";
            staff1.Size = new Size(962, 644);
            staff1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(961, 799);
            Controls.Add(staff1);
            Controls.Add(panel2);
            Controls.Add(channel1);
            Controls.Add(dashboard1);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button Staff_Button;
        private Button Dashboard_Button;
        private PictureBox pictureBox1;
        private Button Logout_Button;
        private PictureBox pictureBox3;
        private Button Channel_Button;
        private Dashboard dashboard1;
        private Channel channel1;
        private Staff staff1;
    }
}

