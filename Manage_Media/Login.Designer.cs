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
            label1 = new Label();
            Login_TxtBox = new TextBox();
            Check_Pass = new CheckBox();
            Password_TxtBox = new TextBox();
            Login_Button = new Button();
            Exit_Button = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(241, 97, 37);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";

            // 
            // Login_TxtBox
            // 
            resources.ApplyResources(Login_TxtBox, "Login_TxtBox");
            Login_TxtBox.BackColor = Color.FromArgb(238, 113, 46);
            Login_TxtBox.Cursor = Cursors.IBeam;
            Login_TxtBox.ForeColor = Color.White;
            Login_TxtBox.Name = "Login_TxtBox";
            // 
            // Check_Pass
            // 
            resources.ApplyResources(Check_Pass, "Check_Pass");
            Check_Pass.BackColor = Color.FromArgb(235, 139, 62);
            Check_Pass.ForeColor = SystemColors.WindowFrame;
            Check_Pass.Name = "Check_Pass";
            Check_Pass.UseVisualStyleBackColor = false;
          
            // 
            // Password_TxtBox
            // 
            resources.ApplyResources(Password_TxtBox, "Password_TxtBox");
            Password_TxtBox.BackColor = Color.FromArgb(236, 128, 57);
            Password_TxtBox.Cursor = Cursors.IBeam;
            Password_TxtBox.ForeColor = SystemColors.InactiveBorder;
            Password_TxtBox.Name = "Password_TxtBox";
            // 
            // Login_Button
            // 
            Login_Button.BackColor = Color.Azure;
            resources.ApplyResources(Login_Button, "Login_Button");
            Login_Button.ForeColor = SystemColors.GrayText;
            Login_Button.Name = "Login_Button";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.Azure;
            resources.ApplyResources(Exit_Button, "Exit_Button");
            Exit_Button.ForeColor = SystemColors.GrayText;
            Exit_Button.Name = "Exit_Button";
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(236, 128, 57);
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(238, 113, 46);
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Check_Pass);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Exit_Button);
            Controls.Add(label1);
            Controls.Add(Login_Button);
            Controls.Add(Login_TxtBox);
            Controls.Add(Password_TxtBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            FormClosing += Form1_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox Login_TxtBox;
        private TextBox Password_TxtBox;
        private Button Login_Button;
        private Button Exit_Button;
        private PictureBox pictureBox1;
        private CheckBox Check_Pass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
