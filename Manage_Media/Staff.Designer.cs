namespace Manage_Media
{
    partial class Staff
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel9 = new Panel();
            genderComboBox = new ComboBox();
            label6 = new Label();
            panel8 = new Panel();
            address_Txt = new TextBox();
            label5 = new Label();
            clear_Btn = new Button();
            panel7 = new Panel();
            phone_Txt = new TextBox();
            label4 = new Label();
            add_Btn = new Button();
            panel6 = new Panel();
            name_Txt = new TextBox();
            label3 = new Label();
            update_Btn = new Button();
            panel5 = new Panel();
            staffID_Txt = new TextBox();
            label2 = new Label();
            delete_Btn = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            btnUploadImage = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(clear_Btn);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(add_Btn);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(update_Btn);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(delete_Btn);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(13, 42);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 220);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(label6);
            panel9.Controls.Add(genderComboBox);
            panel9.Location = new Point(317, 22);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(191, 26);
            panel9.TabIndex = 9;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            genderComboBox.Location = new Point(82, 0);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(109, 28);
            genderComboBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(2, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 0;
            label6.Text = "Gender:";
            // 
            // panel8
            // 
            panel8.Controls.Add(address_Txt);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(12, 144);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(293, 26);
            panel8.TabIndex = 6;
            // 
            // address_Txt
            // 
            address_Txt.BorderStyle = BorderStyle.FixedSingle;
            address_Txt.Location = new Point(70, 1);
            address_Txt.Margin = new Padding(2);
            address_Txt.Name = "address_Txt";
            address_Txt.PlaceholderText = "Ho Chi Minh";
            address_Txt.Size = new Size(223, 27);
            address_Txt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 5);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 0;
            label5.Text = "Address:";
            // 
            // clear_Btn
            // 
            clear_Btn.BackColor = Color.DarkOrange;
            clear_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            clear_Btn.FlatStyle = FlatStyle.Flat;
            clear_Btn.Location = new Point(418, 108);
            clear_Btn.Margin = new Padding(2);
            clear_Btn.Name = "clear_Btn";
            clear_Btn.Size = new Size(90, 30);
            clear_Btn.TabIndex = 8;
            clear_Btn.Text = "Clear";
            clear_Btn.UseVisualStyleBackColor = false;
            clear_Btn.Click += clear_Btn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(phone_Txt);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(12, 103);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(293, 26);
            panel7.TabIndex = 5;
            // 
            // phone_Txt
            // 
            phone_Txt.BorderStyle = BorderStyle.FixedSingle;
            phone_Txt.Location = new Point(70, 1);
            phone_Txt.Margin = new Padding(2);
            phone_Txt.Name = "phone_Txt";
            phone_Txt.PlaceholderText = "0123456789";
            phone_Txt.Size = new Size(223, 27);
            phone_Txt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 0;
            label4.Text = "Phone:";
            // 
            // add_Btn
            // 
            add_Btn.BackColor = Color.DarkOrange;
            add_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            add_Btn.FlatStyle = FlatStyle.Flat;
            add_Btn.Location = new Point(317, 63);
            add_Btn.Margin = new Padding(2);
            add_Btn.Name = "add_Btn";
            add_Btn.Size = new Size(90, 30);
            add_Btn.TabIndex = 9;
            add_Btn.Text = "Add";
            add_Btn.UseVisualStyleBackColor = false;
            add_Btn.Click += add_Btn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(name_Txt);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(12, 62);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(293, 26);
            panel6.TabIndex = 4;
            // 
            // name_Txt
            // 
            name_Txt.BorderStyle = BorderStyle.FixedSingle;
            name_Txt.Location = new Point(70, 1);
            name_Txt.Margin = new Padding(2);
            name_Txt.Name = "name_Txt";
            name_Txt.PlaceholderText = "Nguyen Van A";
            name_Txt.Size = new Size(223, 27);
            name_Txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // update_Btn
            // 
            update_Btn.BackColor = Color.DarkOrange;
            update_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            update_Btn.FlatStyle = FlatStyle.Flat;
            update_Btn.Location = new Point(418, 63);
            update_Btn.Margin = new Padding(2);
            update_Btn.Name = "update_Btn";
            update_Btn.Size = new Size(90, 30);
            update_Btn.TabIndex = 10;
            update_Btn.Text = "Update";
            update_Btn.UseVisualStyleBackColor = false;
            update_Btn.Click += update_Btn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(staffID_Txt);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(12, 22);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 26);
            panel5.TabIndex = 3;
            // 
            // staffID_Txt
            // 
            staffID_Txt.BorderStyle = BorderStyle.FixedSingle;
            staffID_Txt.Location = new Point(70, 1);
            staffID_Txt.Margin = new Padding(2);
            staffID_Txt.Name = "staffID_Txt";
            staffID_Txt.PlaceholderText = "ABC1234";
            staffID_Txt.Size = new Size(223, 27);
            staffID_Txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 0;
            label2.Text = "Staff ID:";
            // 
            // delete_Btn
            // 
            delete_Btn.BackColor = Color.DarkOrange;
            delete_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            delete_Btn.FlatStyle = FlatStyle.Flat;
            delete_Btn.Location = new Point(317, 108);
            delete_Btn.Margin = new Padding(2);
            delete_Btn.Name = "delete_Btn";
            delete_Btn.Size = new Size(90, 30);
            delete_Btn.TabIndex = 7;
            delete_Btn.Text = "Delete";
            delete_Btn.UseVisualStyleBackColor = false;
            delete_Btn.Click += delete_Btn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnUploadImage);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(549, 42);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 220);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.DarkOrange;
            btnUploadImage.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Location = new Point(10, 180);
            btnUploadImage.Margin = new Padding(2);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(180, 30);
            btnUploadImage.TabIndex = 0;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dataGridView1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(13, 274);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 260);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(14, 18);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(708, 229);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(22, 7, 0, 0);
            label1.Size = new Size(122, 37);
            label1.TabIndex = 2;
            label1.Text = "All Staff";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Aquamarine;
            Margin = new Padding(2);
            Name = "Staff";
            Size = new Size(770, 545);
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel5;
        private Panel panel4;
        private Label label1;
        private TextBox staffID_Txt;
        private Panel panel8;
        private TextBox address_Txt;
        private Label label5;
        private Panel panel7;
        private TextBox phone_Txt;
        private Label label4;
        private Panel panel6;
        private TextBox name_Txt;
        private Label label3;
        private Button clear_Btn;
        private Button delete_Btn;
        private Button update_Btn;
        private Button add_Btn;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btnUploadImage;
        private OpenFileDialog openFileDialog1;
        private Panel panel9;
        private ComboBox genderComboBox;
        private Label label6;
    }
}