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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(16, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 285);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(885, 248);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Padding = new Padding(6, 5, 0, 0);
            label1.Size = new Size(152, 50);
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
            panel3.Location = new Point(16, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 276);
            panel3.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(duration_Txt);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(556, 82);
            panel7.Name = "panel7";
            panel7.Size = new Size(346, 43);
            panel7.TabIndex = 2;
            // 
            // duration_Txt
            // 
            duration_Txt.BorderStyle = BorderStyle.FixedSingle;
            duration_Txt.Cursor = Cursors.IBeam;
            duration_Txt.Font = new Font("Segoe UI", 10F);
            duration_Txt.Location = new Point(100, 4);
            duration_Txt.Name = "duration_Txt";
            duration_Txt.PlaceholderText = "2";
            duration_Txt.Size = new Size(243, 34);
            duration_Txt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 0;
            label5.Text = "Duration:";
            // 
            // panel9
            // 
            panel9.Controls.Add(schedule_Dtp);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(23, 204);
            panel9.Name = "panel9";
            panel9.Size = new Size(497, 43);
            panel9.TabIndex = 8;
            // 
            // schedule_Dtp
            // 
            schedule_Dtp.Location = new Point(111, 7);
            schedule_Dtp.Name = "schedule_Dtp";
            schedule_Dtp.Size = new Size(383, 31);
            schedule_Dtp.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(20, 12);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
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
            button4.Location = new Point(770, 216);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
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
            button3.Location = new Point(770, 153);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
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
            button2.Location = new Point(595, 213);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
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
            button1.Location = new Point(595, 153);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(category_Cbb);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(556, 24);
            panel8.Name = "panel8";
            panel8.Size = new Size(346, 43);
            panel8.TabIndex = 3;
            // 
            // category_Cbb
            // 
            category_Cbb.DisplayMember = "l";
            category_Cbb.FormattingEnabled = true;
            category_Cbb.Location = new Point(100, 5);
            category_Cbb.Name = "category_Cbb";
            category_Cbb.Size = new Size(243, 33);
            category_Cbb.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 2;
            label6.Text = "Category:";
            // 
            // panel6
            // 
            panel6.Controls.Add(producer_Txt);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(23, 144);
            panel6.Name = "panel6";
            panel6.Size = new Size(497, 43);
            panel6.TabIndex = 2;
            // 
            // producer_Txt
            // 
            producer_Txt.BorderStyle = BorderStyle.FixedSingle;
            producer_Txt.Cursor = Cursors.IBeam;
            producer_Txt.Font = new Font("Segoe UI", 10F);
            producer_Txt.Location = new Point(111, 4);
            producer_Txt.Name = "producer_Txt";
            producer_Txt.PlaceholderText = "Nguyen Van A";
            producer_Txt.Size = new Size(383, 34);
            producer_Txt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(14, 9);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 0;
            label4.Text = "Producer:";
            // 
            // panel5
            // 
            panel5.Controls.Add(name_Txt);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(23, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(497, 43);
            panel5.TabIndex = 2;
            // 
            // name_Txt
            // 
            name_Txt.BorderStyle = BorderStyle.FixedSingle;
            name_Txt.Cursor = Cursors.IBeam;
            name_Txt.Font = new Font("Segoe UI", 10F);
            name_Txt.Location = new Point(111, 4);
            name_Txt.Name = "name_Txt";
            name_Txt.PlaceholderText = "Natra Nao Hai";
            name_Txt.Size = new Size(383, 34);
            name_Txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(42, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // panel4
            // 
            panel4.Controls.Add(channelID_Txt);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(23, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(497, 43);
            panel4.TabIndex = 0;
            // 
            // channelID_Txt
            // 
            channelID_Txt.BorderStyle = BorderStyle.FixedSingle;
            channelID_Txt.Cursor = Cursors.IBeam;
            channelID_Txt.Font = new Font("Segoe UI", 10F);
            channelID_Txt.Location = new Point(111, 4);
            channelID_Txt.Name = "channelID_Txt";
            channelID_Txt.PlaceholderText = "ABC1234";
            channelID_Txt.Size = new Size(383, 34);
            channelID_Txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 0;
            label2.Text = "Channel ID:";
            // 
            // Channel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Channel";
            Size = new Size(962, 644);
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
        private Panel panel9;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
