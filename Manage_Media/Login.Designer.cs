namespace Manage_Media
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            Login_TxtBox = new TextBox();
            panel2 = new Panel();
            Check_Pass = new CheckBox();
            Password_TxtBox = new TextBox();
            label4 = new Label();
            Login_Button = new Button();
            Exit_Button = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // Login_TxtBox
            // 
            resources.ApplyResources(Login_TxtBox, "Login_TxtBox");
            Login_TxtBox.BorderStyle = BorderStyle.FixedSingle;
            Login_TxtBox.Cursor = Cursors.IBeam;
            Login_TxtBox.Name = "Login_TxtBox";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(Check_Pass);
            panel2.Controls.Add(Password_TxtBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Login_TxtBox);
            panel2.Name = "panel2";
            // 
            // Check_Pass
            // 
            resources.ApplyResources(Check_Pass, "Check_Pass");
            Check_Pass.Name = "Check_Pass";
            Check_Pass.UseVisualStyleBackColor = true;
            Check_Pass.CheckedChanged += Check_Pass_CheckedChanged;
            // 
            // Password_TxtBox
            // 
            resources.ApplyResources(Password_TxtBox, "Password_TxtBox");
            Password_TxtBox.Cursor = Cursors.IBeam;
            Password_TxtBox.Name = "Password_TxtBox";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(Login_Button, "Login_Button");
            Login_Button.ForeColor = SystemColors.ButtonFace;
            Login_Button.Name = "Login_Button";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Exit_Button
            // 
            resources.ApplyResources(Exit_Button, "Exit_Button");
            Exit_Button.BackColor = Color.OrangeRed;
            Exit_Button.ForeColor = SystemColors.ButtonFace;
            Exit_Button.Name = "Exit_Button";
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(Exit_Button);
            Controls.Add(Login_Button);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            FormClosing += Form1_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox Login_TxtBox;
        private Panel panel2;
        private TextBox Password_TxtBox;
        private Label label4;
        private Button Login_Button;
        private Button Exit_Button;
        private PictureBox pictureBox1;
        private CheckBox Check_Pass;
    }
}
