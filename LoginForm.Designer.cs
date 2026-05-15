namespace CarRentalLegaspi
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            rdAdmin = new RadioButton();
            rdCustomer = new RadioButton();
            rdManager = new RadioButton();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 39);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(133, 60);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 1;
            label2.Text = "Please login to your account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 139);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 262);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(32, 161);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(429, 48);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(27, 283);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(429, 48);
            txtPassword.TabIndex = 5;
            // 
            // rdAdmin
            // 
            rdAdmin.AutoSize = true;
            rdAdmin.Font = new Font("Segoe UI", 11F);
            rdAdmin.Location = new Point(27, 354);
            rdAdmin.Name = "rdAdmin";
            rdAdmin.Size = new Size(71, 24);
            rdAdmin.TabIndex = 6;
            rdAdmin.TabStop = true;
            rdAdmin.Text = "Admin";
            rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdCustomer
            // 
            rdCustomer.AutoSize = true;
            rdCustomer.Font = new Font("Segoe UI", 11F);
            rdCustomer.Location = new Point(178, 354);
            rdCustomer.Name = "rdCustomer";
            rdCustomer.Size = new Size(90, 24);
            rdCustomer.TabIndex = 7;
            rdCustomer.TabStop = true;
            rdCustomer.Text = "Customer";
            rdCustomer.UseVisualStyleBackColor = true;
            // 
            // rdManager
            // 
            rdManager.AutoSize = true;
            rdManager.Font = new Font("Segoe UI", 11F);
            rdManager.Location = new Point(336, 354);
            rdManager.Name = "rdManager";
            rdManager.Size = new Size(125, 24);
            rdManager.TabIndex = 8;
            rdManager.TabStop = true;
            rdManager.Text = "Clerk/Manager";
            rdManager.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(149, 452);
            button1.Name = "button1";
            button1.Size = new Size(155, 46);
            button1.TabIndex = 9;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "D:\\johnrich files\\Integra Prog\\loginIMG.png";
            pictureBox1.Location = new Point(481, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 588);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(rdManager);
            Controls.Add(rdCustomer);
            Controls.Add(rdAdmin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private RadioButton rdAdmin;
        private RadioButton rdCustomer;
        private RadioButton rdManager;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
