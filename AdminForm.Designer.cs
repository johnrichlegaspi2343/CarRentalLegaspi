namespace CarRentalLegaspi
{
    partial class AdminForm
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
            btnLogOut = new Button();
            label3 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            dgvUserManagement = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            panel5 = new Panel();
            btnAddUser = new Button();
            btnClear = new Button();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabPage3 = new TabPage();
            panel6 = new Panel();
            panel7 = new Panel();
            textBox8 = new TextBox();
            panel8 = new Panel();
            label16 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            textBox7 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).BeginInit();
            panel5.SuspendLayout();
            tabPage3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 46);
            panel1.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(901, 9);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(60, 26);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(807, 13);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "👤 Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 0;
            label1.Text = "🚗Car Rental System";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(976, 478);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(968, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 461);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 41);
            panel3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(6, 11);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 8;
            label7.Text = "☰ All Rentals";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(0, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 12;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(968, 166);
            dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Rental ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Customer";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Car";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Total";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.Font = new Font("Segoe UI", 18F);
            textBox4.ForeColor = Color.FromArgb(255, 128, 0);
            textBox4.Location = new Point(775, 49);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(116, 48);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.ForeColor = Color.FromArgb(255, 128, 0);
            textBox3.Location = new Point(531, 49);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(105, 48);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(269, 49);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(105, 48);
            textBox2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(782, 100);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 4;
            label6.Text = "Total Revenue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(531, 100);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 3;
            label5.Text = "Available Cars";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(271, 100);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 2;
            label4.Text = " Total Rentals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(59, 100);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Total Cars";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(44, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(105, 48);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(968, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgvUserManagement);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(968, 461);
            panel4.TabIndex = 0;
            // 
            // dgvUserManagement
            // 
            dgvUserManagement.BackgroundColor = Color.WhiteSmoke;
            dgvUserManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserManagement.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            dgvUserManagement.Location = new Point(45, 175);
            dgvUserManagement.Name = "dgvUserManagement";
            dgvUserManagement.Size = new Size(867, 186);
            dgvUserManagement.TabIndex = 1;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Username";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Role";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Action";
            Column8.Name = "Column8";
            Column8.Resizable = DataGridViewTriState.True;
            Column8.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(btnAddUser);
            panel5.Controls.Add(btnClear);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(45, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(867, 124);
            panel5.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(627, 93);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(89, 24);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(566, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(55, 24);
            btnClear.TabIndex = 7;
            btnClear.Text = "X Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Clerk", "Customer" });
            comboBox1.Location = new Point(566, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Location = new Point(274, 64);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(150, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(44, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 23);
            textBox5.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(566, 46);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 3;
            label11.Text = "Role";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(274, 46);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 2;
            label10.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 46);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 1;
            label9.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(42, 19);
            label8.Name = "label8";
            label8.Size = new Size(117, 18);
            label8.TabIndex = 0;
            label8.Text = "+ Add New User";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(968, 450);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(8, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(968, 461);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(textBox8);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(btnSave);
            panel7.Controls.Add(btnReset);
            panel7.Controls.Add(textBox7);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label15);
            panel7.Location = new Point(45, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(867, 239);
            panel7.TabIndex = 0;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(42, 134);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(786, 50);
            textBox8.TabIndex = 10;
            textBox8.Text = "Unit/Floor, Building, Street, City";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label16);
            panel8.Location = new Point(44, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(160, 24);
            panel8.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 5);
            label16.Name = "label16";
            label16.Size = new Size(102, 15);
            label16.TabIndex = 10;
            label16.Text = "Car Rental System";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(739, 199);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 24);
            btnSave.TabIndex = 8;
            btnSave.Text = "✔️ Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(678, 199);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(55, 24);
            btnReset.TabIndex = 7;
            btnReset.Text = "X Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.Location = new Point(498, 64);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 23);
            textBox7.TabIndex = 5;
            textBox7.Text = "09XX XXX XXXX";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 116);
            label12.Name = "label12";
            label12.Size = new Size(100, 15);
            label12.TabIndex = 3;
            label12.Text = "Business Address ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(501, 46);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 2;
            label13.Text = "Admin Contact";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 46);
            label14.Name = "label14";
            label14.Size = new Size(80, 15);
            label14.TabIndex = 1;
            label14.Text = "System Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(255, 128, 10);
            label15.Location = new Point(42, 19);
            label15.Name = "label15";
            label15.Size = new Size(213, 25);
            label15.TabIndex = 0;
            label15.Text = "⚙️ System Settings";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 537);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAddUser;
        private Button btnClear;
        private DataGridView dgvUserManagement;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
        private Panel panel6;
        private Panel panel7;
        private Button btnSave;
        private Button btnReset;
        private TextBox textBox7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel8;
        private Label label16;
        private TextBox textBox8;
        private Button btnLogOut;
    }
}