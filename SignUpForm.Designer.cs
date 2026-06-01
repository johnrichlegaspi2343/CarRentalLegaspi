namespace CarRentalLegaspi
{
    partial class SignUpForm
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
            pictureBox1 = new PictureBox();
            btnSignUp = new Button();
            txtboxUnSU = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtboxLastNameSU = new TextBox();
            txtboxCreatePassSU = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "D:\\johnrich files\\Integra Prog\\loginIMG.png";
            pictureBox1.Location = new Point(480, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(255, 128, 0);
            btnSignUp.ForeColor = SystemColors.ControlLightLight;
            btnSignUp.Location = new Point(145, 440);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(165, 46);
            btnSignUp.TabIndex = 20;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtboxUnSU
            // 
            txtboxUnSU.Font = new Font("Segoe UI", 16F);
            txtboxUnSU.Location = new Point(33, 200);
            txtboxUnSU.Multiline = true;
            txtboxUnSU.Name = "txtboxUnSU";
            txtboxUnSU.Size = new Size(404, 34);
            txtboxUnSU.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 327);
            label4.Name = "label4";
            label4.Size = new Size(140, 18);
            label4.TabIndex = 14;
            label4.Text = "Create Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(105, 68);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 12;
            label2.Text = "Create an account as Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(421, 39);
            label1.TabIndex = 11;
            label1.Text = "Get started on Car Rental";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 179);
            label6.Name = "label6";
            label6.Size = new Size(95, 18);
            label6.TabIndex = 23;
            label6.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 250);
            label7.Name = "label7";
            label7.Size = new Size(92, 18);
            label7.TabIndex = 24;
            label7.Text = "Last Name:";
            // 
            // txtboxLastNameSU
            // 
            txtboxLastNameSU.Font = new Font("Segoe UI", 16F);
            txtboxLastNameSU.Location = new Point(33, 271);
            txtboxLastNameSU.Multiline = true;
            txtboxLastNameSU.Name = "txtboxLastNameSU";
            txtboxLastNameSU.Size = new Size(404, 34);
            txtboxLastNameSU.TabIndex = 25;
            // 
            // txtboxCreatePassSU
            // 
            txtboxCreatePassSU.Font = new Font("Segoe UI", 16F);
            txtboxCreatePassSU.Location = new Point(33, 348);
            txtboxCreatePassSU.Multiline = true;
            txtboxCreatePassSU.Name = "txtboxCreatePassSU";
            txtboxCreatePassSU.PasswordChar = '*';
            txtboxCreatePassSU.Size = new Size(404, 34);
            txtboxCreatePassSU.TabIndex = 27;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 586);
            Controls.Add(txtboxCreatePassSU);
            Controls.Add(txtboxLastNameSU);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignUp);
            Controls.Add(txtboxUnSU);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSignUp;
        private TextBox txtboxUnSU;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private TextBox txtboxLastNameSU;
        private TextBox txtboxCreatePassSU;
    }
}