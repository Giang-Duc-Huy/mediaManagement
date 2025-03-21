namespace Manage_Media
{
    partial class Channel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            duration_Txt = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            schedule_Dtp = new DateTimePicker();
            label7 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel8 = new Panel();
            category_Cbb = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            producer_Txt = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            name_Txt = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            channelID_Txt = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(14, 274);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 228);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 17);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(708, 198);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(14, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 4, 0, 0);
            label1.Size = new Size(122, 40);
            label1.TabIndex = 1;
            label1.Text = "All Channels";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(14, 42);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 221);
            panel3.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(duration_Txt);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(328, 66);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(206, 34);
            panel7.TabIndex = 2;
            // 
            // duration_Txt
            // 
            duration_Txt.BorderStyle = BorderStyle.FixedSingle;
            duration_Txt.Cursor = Cursors.IBeam;
            duration_Txt.Font = new Font("Segoe UI", 10F);
            duration_Txt.Location = new Point(80, 3);
            duration_Txt.Margin = new Padding(2, 2, 2, 2);
            duration_Txt.Name = "duration_Txt";
            duration_Txt.PlaceholderText = "2";
            duration_Txt.Size = new Size(120, 30);
            duration_Txt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(5, 7);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 0;
            label5.Text = "Duration:";
            // 
            // panel9
            // 
            panel9.Controls.Add(schedule_Dtp);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(18, 163);
            panel9.Margin = new Padding(2, 2, 2, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(290, 34);
            panel9.TabIndex = 8;
            // 
            // schedule_Dtp
            // 
            schedule_Dtp.Location = new Point(89, 6);
            schedule_Dtp.Margin = new Padding(2, 2, 2, 2);
            schedule_Dtp.Name = "schedule_Dtp";
            schedule_Dtp.Size = new Size(200, 27);
            schedule_Dtp.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(16, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 0;
            label7.Text = "Shedule:";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderColor = Color.SaddleBrown;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(445, 170);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 7;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.SaddleBrown;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(445, 122);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.SaddleBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(328, 169);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.SaddleBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(328, 122);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(category_Cbb);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(328, 19);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(206, 34);
            panel8.TabIndex = 3;
            // 
            // category_Cbb
            // 
            category_Cbb.DisplayMember = "l";
            category_Cbb.FormattingEnabled = true;
            category_Cbb.Location = new Point(80, 4);
            category_Cbb.Margin = new Padding(2, 2, 2, 2);
            category_Cbb.Name = "category_Cbb";
            category_Cbb.Size = new Size(120, 28);
            category_Cbb.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(2, 8);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 2;
            label6.Text = "Category:";
            // 
            // panel6
            // 
            panel6.Controls.Add(producer_Txt);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(18, 115);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(290, 34);
            panel6.TabIndex = 2;
            // 
            // producer_Txt
            // 
            producer_Txt.BorderStyle = BorderStyle.FixedSingle;
            producer_Txt.Cursor = Cursors.IBeam;
            producer_Txt.Font = new Font("Segoe UI", 10F);
            producer_Txt.Location = new Point(89, 3);
            producer_Txt.Margin = new Padding(2, 2, 2, 2);
            producer_Txt.Name = "producer_Txt";
            producer_Txt.PlaceholderText = "Nguyen Van A";
            producer_Txt.Size = new Size(200, 30);
            producer_Txt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(11, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Producer:";
            // 
            // panel5
            // 
            panel5.Controls.Add(name_Txt);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(18, 66);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(290, 34);
            panel5.TabIndex = 2;
            // 
            // name_Txt
            // 
            name_Txt.BorderStyle = BorderStyle.FixedSingle;
            name_Txt.Cursor = Cursors.IBeam;
            name_Txt.Font = new Font("Segoe UI", 10F);
            name_Txt.Location = new Point(89, 3);
            name_Txt.Margin = new Padding(2, 2, 2, 2);
            name_Txt.Name = "name_Txt";
            name_Txt.PlaceholderText = "Natra Nao Hai";
            name_Txt.Size = new Size(200, 30);
            name_Txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(34, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // panel4
            // 
            panel4.Controls.Add(channelID_Txt);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(18, 19);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 34);
            panel4.TabIndex = 0;
            // 
            // channelID_Txt
            // 
            channelID_Txt.BorderStyle = BorderStyle.FixedSingle;
            channelID_Txt.Cursor = Cursors.IBeam;
            channelID_Txt.Font = new Font("Segoe UI", 10F);
            channelID_Txt.Location = new Point(89, 3);
            channelID_Txt.Margin = new Padding(2, 2, 2, 2);
            channelID_Txt.Name = "channelID_Txt";
            channelID_Txt.PlaceholderText = "ABC1234";
            channelID_Txt.Size = new Size(200, 30);
            channelID_Txt.TabIndex = 1;
            channelID_Txt.TextChanged += channelID_Txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(2, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Channel ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(577, 42);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 221);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Channel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Channel";
            Size = new Size(770, 515);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private TextBox name_Txt;
        private Label label3;
        private Panel panel4;
        private TextBox channelID_Txt;
        private Label label2;
        private Panel panel8;
        private ComboBox category_Cbb;
        private Label label6;
        private Panel panel7;
        private TextBox duration_Txt;
        private Label label5;
        private Panel panel6;
        private TextBox producer_Txt;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker schedule_Dtp;
        private PictureBox pictureBox1;
        private Panel panel9;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
