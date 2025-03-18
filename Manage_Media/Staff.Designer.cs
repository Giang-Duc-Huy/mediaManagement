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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(clear_Btn);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(add_Btn);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(update_Btn);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(delete_Btn);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(18, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 234);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.ForeColor = Color.Violet;
            flowLayoutPanel1.Location = new Point(396, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(239, 82);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel8
            // 
            panel8.Controls.Add(address_Txt);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(15, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(366, 33);
            panel8.TabIndex = 6;
            // 
            // address_Txt
            // 
            address_Txt.BorderStyle = BorderStyle.FixedSingle;
            address_Txt.Location = new Point(88, 1);
            address_Txt.Name = "address_Txt";
            address_Txt.PlaceholderText = "Ho Chi Minh";
            address_Txt.Size = new Size(278, 31);
            address_Txt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(8, 6);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 0;
            label5.Text = "Address:";
            // 
            // clear_Btn
            // 
            clear_Btn.BackColor = Color.DarkOrange;
            clear_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            clear_Btn.FlatStyle = FlatStyle.Flat;
            clear_Btn.Location = new Point(523, 176);
            clear_Btn.Name = "clear_Btn";
            clear_Btn.Size = new Size(112, 38);
            clear_Btn.TabIndex = 8;
            clear_Btn.Text = "Clear";
            clear_Btn.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(phone_Txt);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(15, 129);
            panel7.Name = "panel7";
            panel7.Size = new Size(366, 33);
            panel7.TabIndex = 5;
            // 
            // phone_Txt
            // 
            phone_Txt.BorderStyle = BorderStyle.FixedSingle;
            phone_Txt.Location = new Point(88, 1);
            phone_Txt.Name = "phone_Txt";
            phone_Txt.PlaceholderText = "0123456789";
            phone_Txt.Size = new Size(278, 31);
            phone_Txt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 6);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 0;
            label4.Text = "Phone:";
            // 
            // add_Btn
            // 
            add_Btn.BackColor = Color.DarkOrange;
            add_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            add_Btn.FlatStyle = FlatStyle.Flat;
            add_Btn.Location = new Point(396, 125);
            add_Btn.Name = "add_Btn";
            add_Btn.Size = new Size(112, 38);
            add_Btn.TabIndex = 9;
            add_Btn.Text = "Add";
            add_Btn.UseVisualStyleBackColor = false;
            add_Btn.Click += add_Btn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(name_Txt);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(15, 77);
            panel6.Name = "panel6";
            panel6.Size = new Size(366, 33);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // name_Txt
            // 
            name_Txt.BorderStyle = BorderStyle.FixedSingle;
            name_Txt.Location = new Point(88, 1);
            name_Txt.Name = "name_Txt";
            name_Txt.PlaceholderText = "Nguyen Van A";
            name_Txt.Size = new Size(278, 31);
            name_Txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 6);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // update_Btn
            // 
            update_Btn.BackColor = Color.DarkOrange;
            update_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            update_Btn.FlatStyle = FlatStyle.Flat;
            update_Btn.Location = new Point(523, 125);
            update_Btn.Name = "update_Btn";
            update_Btn.Size = new Size(112, 38);
            update_Btn.TabIndex = 10;
            update_Btn.Text = "Update";
            update_Btn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(staffID_Txt);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(15, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(366, 33);
            panel5.TabIndex = 3;
            // 
            // staffID_Txt
            // 
            staffID_Txt.BorderStyle = BorderStyle.FixedSingle;
            staffID_Txt.Location = new Point(88, 1);
            staffID_Txt.Name = "staffID_Txt";
            staffID_Txt.PlaceholderText = "ABC1234";
            staffID_Txt.Size = new Size(278, 31);
            staffID_Txt.TabIndex = 1;
            staffID_Txt.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 6);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 0;
            label2.Text = "Staff ID:";
            label2.Click += label2_Click;
            // 
            // delete_Btn
            // 
            delete_Btn.BackColor = Color.DarkOrange;
            delete_Btn.FlatAppearance.BorderColor = Color.SaddleBrown;
            delete_Btn.FlatStyle = FlatStyle.Flat;
            delete_Btn.Location = new Point(396, 176);
            delete_Btn.Name = "delete_Btn";
            delete_Btn.Size = new Size(112, 38);
            delete_Btn.TabIndex = 7;
            delete_Btn.Text = "Delete";
            delete_Btn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(686, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 234);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dataGridView1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(18, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 325);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(885, 286);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Padding = new Padding(28, 9, 0, 0);
            label1.Size = new Size(152, 46);
            label1.TabIndex = 2;
            label1.Text = "All Staff";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Aquamarine;
            Name = "Staff";
            Size = new Size(962, 644);
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
