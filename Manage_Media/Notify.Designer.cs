namespace Manage_Media
{
    partial class Notify
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            notify_Lb = new Label();
            panel2 = new Panel();
            Exit = new Button();
            button1 = new Button();
            X = new Button();
            message_Lb = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 196);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 61);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(notify_Lb);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(79, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 61);
            panel5.TabIndex = 4;
            // 
            // notify_Lb
            // 
            notify_Lb.AutoSize = true;
            notify_Lb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notify_Lb.Location = new Point(13, 16);
            notify_Lb.Name = "notify_Lb";
            notify_Lb.Size = new Size(65, 28);
            notify_Lb.TabIndex = 0;
            notify_Lb.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Exit);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 76);
            panel2.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.BackColor = Color.OrangeRed;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Exit.ForeColor = SystemColors.ButtonHighlight;
            Exit.Location = new Point(194, 20);
            Exit.Name = "Exit";
            Exit.Size = new Size(122, 38);
            Exit.TabIndex = 2;
            Exit.Text = "Cancel";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(328, 20);
            button1.Margin = new Padding(9, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // X
            // 
            X.BackColor = Color.Tomato;
            X.Cursor = Cursors.Hand;
            X.FlatStyle = FlatStyle.Popup;
            X.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.ForeColor = Color.White;
            X.Location = new Point(413, 12);
            X.Name = "X";
            X.Size = new Size(73, 43);
            X.TabIndex = 1;
            X.Text = "X";
            X.UseVisualStyleBackColor = false;
            X.Click += X_Click;
            // 
            // message_Lb
            // 
            message_Lb.AutoSize = true;
            message_Lb.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_Lb.Location = new Point(87, 12);
            message_Lb.Name = "message_Lb";
            message_Lb.Size = new Size(76, 30);
            message_Lb.TabIndex = 2;
            message_Lb.Text = "label1";
            // 
            // panel3
            // 
            panel3.Controls.Add(message_Lb);
            panel3.Location = new Point(93, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 53);
            panel3.TabIndex = 3;
            // 
            // Notify
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(500, 274);
            Controls.Add(panel3);
            Controls.Add(X);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notify";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notify";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button X;
        private Label notify_Lb;
        private Label message_Lb;
        private Panel panel5;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button Exit;
        private Button button1;
    }
}