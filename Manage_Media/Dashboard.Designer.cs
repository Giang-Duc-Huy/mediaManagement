namespace Manage_Media
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            dayComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            categoryFilterComboBox = new ComboBox();
            searchTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            circularProgressBar2 = new CircularProgressBar();
            panel7 = new Panel();
            circularProgressBar1 = new CircularProgressBar();
            label5 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(19, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 155);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(197, 107);
            label2.Name = "label2";
            label2.Size = new Size(38, 46);
            label2.TabIndex = 2;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 74);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 0;
            label1.Text = "All Channels";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label4);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(19, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 153);
            panel3.TabIndex = 3;
            panel3.Click += panel3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(197, 107);
            label3.Name = "label3";
            label3.Size = new Size(38, 46);
            label3.TabIndex = 2;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(13, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 74);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 19);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 0;
            label4.Text = "All Staff";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dayComboBox);
            panel1.Controls.Add(monthComboBox);
            panel1.Controls.Add(yearComboBox);
            panel1.Controls.Add(categoryFilterComboBox);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(16, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 360);
            panel1.TabIndex = 0;
            // 
            // dayComboBox
            // 
            dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dayComboBox.Font = new Font("Segoe UI", 11F);
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Location = new Point(322, 73);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(93, 38);
            dayComboBox.TabIndex = 7;
            // 
            // monthComboBox
            // 
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.Font = new Font("Segoe UI", 11F);
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(421, 73);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(103, 38);
            monthComboBox.TabIndex = 6;
            // 
            // yearComboBox
            // 
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.Font = new Font("Segoe UI", 11F);
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(530, 72);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(107, 38);
            yearComboBox.TabIndex = 5;
            // 
            // categoryFilterComboBox
            // 
            categoryFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryFilterComboBox.Font = new Font("Segoe UI", 11F);
            categoryFilterComboBox.FormattingEnabled = true;
            categoryFilterComboBox.Location = new Point(21, 72);
            categoryFilterComboBox.Name = "categoryFilterComboBox";
            categoryFilterComboBox.Size = new Size(295, 38);
            categoryFilterComboBox.TabIndex = 4;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(21, 19);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Nhập từ khóa...";
            searchTextBox.Size = new Size(618, 39);
            searchTextBox.TabIndex = 2;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(618, 225);
            dataGridView1.TabIndex = 1;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(16, 18);
            label7.Name = "label7";
            label7.Padding = new Padding(6, 5, 0, 0);
            label7.Size = new Size(152, 50);
            label7.TabIndex = 2;
            label7.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(panel2);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(16, 439);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(310, 190);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(panel3);
            panel6.Location = new Point(362, 439);
            panel6.Name = "panel6";
            panel6.Size = new Size(310, 190);
            panel6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(circularProgressBar2);
            panel4.Cursor = Cursors.Hand;
            panel4.ForeColor = Color.BlueViolet;
            panel4.Location = new Point(705, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 212);
            panel4.TabIndex = 4;
            // 
            // circularProgressBar2
            // 
            circularProgressBar2.Location = new Point(18, 18);
            circularProgressBar2.Name = "circularProgressBar2";
            circularProgressBar2.Progress = 0;
            circularProgressBar2.Size = new Size(202, 181);
            circularProgressBar2.TabIndex = 1;
            circularProgressBar2.Text = "circularProgressBar2";
            circularProgressBar2.Click += circularProgressBar2_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(circularProgressBar1);
            panel7.Cursor = Cursors.Hand;
            panel7.ForeColor = Color.BlueViolet;
            panel7.Location = new Point(705, 52);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 212);
            panel7.TabIndex = 5;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            circularProgressBar1.Location = new Point(18, 12);
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.Progress = 90;
            circularProgressBar1.Size = new Size(202, 181);
            circularProgressBar1.TabIndex = 0;
            circularProgressBar1.Text = "circularProgressBar1";
            circularProgressBar1.Click += circularProgressBar1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkOrange;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(761, 281);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 1;
            label5.Text = "Upcoming";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkOrange;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.GhostWhite;
            label6.Location = new Point(770, 582);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 2;
            label6.Text = "Released";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkOrange;
            panel8.Location = new Point(705, 260);
            panel8.Name = "panel8";
            panel8.Size = new Size(238, 67);
            panel8.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkOrange;
            panel9.Location = new Point(705, 566);
            panel9.Name = "panel9";
            panel9.Size = new Size(238, 67);
            panel9.TabIndex = 7;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Name = "Dashboard";
            Size = new Size(962, 644);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel1;
        private Label label7;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel7;
        private CircularProgressBar circularProgressBar2;
        private CircularProgressBar circularProgressBar1;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Panel panel8;
        private TextBox searchTextBox;
        private Panel panel9;
        private ComboBox dayComboBox;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private ComboBox categoryFilterComboBox;
        private Button filterButton;
    }
}