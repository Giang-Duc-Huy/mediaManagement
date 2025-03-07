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
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
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
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(118, 20);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 0;
            label1.Text = "Channel Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1368, 72);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(47, 47, 47);
            panel2.Controls.Add(Logout_Button);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Dashboard_Button);
            panel2.Controls.Add(Staff_Button);
            panel2.Controls.Add(Channel_Button);
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 644);
            panel2.TabIndex = 3;
            // 
            // Logout_Button
            // 
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Logout_Button.FlatAppearance.BorderSize = 2;
            Logout_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = SystemColors.ButtonHighlight;
            Logout_Button.Image = (Image)resources.GetObject("Logout_Button.Image");
            Logout_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Logout_Button.Location = new Point(3, 403);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(223, 58);
            Logout_Button.TabIndex = 5;
            Logout_Button.Text = "Log out";
            Logout_Button.UseVisualStyleBackColor = true;
            Logout_Button.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(220, 220, 219);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 58);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(34, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 54);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(34, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 127);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.Cursor = Cursors.Hand;
            Dashboard_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Dashboard_Button.FlatAppearance.BorderSize = 2;
            Dashboard_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard_Button.ForeColor = SystemColors.ButtonHighlight;
            Dashboard_Button.Image = (Image)resources.GetObject("Dashboard_Button.Image");
            Dashboard_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_Button.Location = new Point(3, 339);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Size = new Size(223, 58);
            Dashboard_Button.TabIndex = 2;
            Dashboard_Button.Text = "Dashboard";
            Dashboard_Button.UseVisualStyleBackColor = true;
            Dashboard_Button.Click += Dashboard_Button_Click;
            // 
            // Staff_Button
            // 
            Staff_Button.Cursor = Cursors.Hand;
            Staff_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Staff_Button.FlatAppearance.BorderSize = 2;
            Staff_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Staff_Button.FlatStyle = FlatStyle.Flat;
            Staff_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Staff_Button.ForeColor = SystemColors.ButtonHighlight;
            Staff_Button.Image = (Image)resources.GetObject("Staff_Button.Image");
            Staff_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Staff_Button.Location = new Point(3, 275);
            Staff_Button.Name = "Staff_Button";
            Staff_Button.Size = new Size(223, 58);
            Staff_Button.TabIndex = 1;
            Staff_Button.Text = "Staff";
            Staff_Button.UseVisualStyleBackColor = true;
            Staff_Button.Click += Staff_Button_Click;
            // 
            // Channel_Button
            // 
            Channel_Button.BackColor = Color.FromArgb(47, 47, 47);
            Channel_Button.Cursor = Cursors.Hand;
            Channel_Button.FlatAppearance.BorderColor = Color.FromArgb(47, 47, 47);
            Channel_Button.FlatAppearance.BorderSize = 2;
            Channel_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Channel_Button.FlatStyle = FlatStyle.Flat;
            Channel_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Channel_Button.ForeColor = Color.White;
            Channel_Button.Image = (Image)resources.GetObject("Channel_Button.Image");
            Channel_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Channel_Button.Location = new Point(2, 211);
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
            pictureBox3.Location = new Point(232, 69);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(962, 644);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(32, 32, 32);
            dashboard1.Location = new Point(231, 69);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(962, 644);
            dashboard1.TabIndex = 5;
            // 
            // channel1
            // 
            channel1.BackColor = Color.FromArgb(32, 32, 32);
            channel1.Location = new Point(231, 69);
            channel1.Name = "channel1";
            channel1.Size = new Size(962, 644);
            channel1.TabIndex = 6;
            // 
            // staff1
            // 
            staff1.BackColor = Color.FromArgb(32, 32, 32);
            staff1.ForeColor = Color.Black;
            staff1.Location = new Point(232, 69);
            staff1.Name = "staff1";
            staff1.Size = new Size(962, 644);
            staff1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1187, 711);
            Controls.Add(staff1);
            Controls.Add(channel1);
            Controls.Add(dashboard1);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button Logout_Button;
        private PictureBox pictureBox3;
        private Button Channel_Button;
        private Dashboard dashboard1;
        private Channel channel1;
        private Staff staff1;
    }
}

