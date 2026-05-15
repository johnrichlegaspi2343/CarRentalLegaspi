namespace CarRentalSystem
{
    partial class CustomerForm
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
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnNext = new Button();
            btnClear = new Button();
            panel2 = new Panel();
            txtAddress = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            btnReturn = new Button();
            btnCompute = new Button();
            panel3 = new Panel();
            dtpReturn = new DateTimePicker();
            dtpRental = new DateTimePicker();
            nudDays = new NumericUpDown();
            nudCars = new NumericUpDown();
            txtRate = new TextBox();
            cmbCar = new ComboBox();
            label15 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabPage3 = new TabPage();
            btnConfrim = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            panel4 = new Panel();
            txtTotalCost = new Label();
            txtAmountPaid = new TextBox();
            cmbPaymentMethod = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCars).BeginInit();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 52);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(807, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(60, 26);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(564, 13);
            label2.Name = "label2";
            label2.Size = new Size(222, 21);
            label2.TabIndex = 1;
            label2.Text = "👤Juan Dela Cruz  ·  Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "🚗 Car Rental System";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(873, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(btnNext);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(panel2);
            tabPage1.Font = new Font("Segoe UI", 11F);
            tabPage1.ForeColor = Color.White;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(865, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Details";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 128, 0);
            btnNext.Location = new Point(732, 380);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 34);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Location = new Point(618, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.ForeColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(40, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(789, 346);
            panel2.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Gray;
            txtAddress.Font = new Font("Segoe UI", 14F);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(21, 251);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(751, 76);
            txtAddress.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(21, 228);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 9;
            label8.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gray;
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(478, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 32);
            txtEmail.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.Gray;
            txtContact.Font = new Font("Segoe UI", 14F);
            txtContact.ForeColor = Color.White;
            txtContact.Location = new Point(21, 168);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(294, 32);
            txtContact.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(478, 145);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(21, 145);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 5;
            label6.Text = "Contact Number:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.Gray;
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(478, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(294, 32);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.Gray;
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(21, 88);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(294, 32);
            txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(21, 18);
            label3.Name = "label3";
            label3.Size = new Size(249, 30);
            label3.TabIndex = 0;
            label3.Text = "👤 Personal Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(478, 65);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 2;
            label5.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(21, 65);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 1;
            label4.Text = "First Name:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(btnReturn);
            tabPage2.Controls.Add(btnCompute);
            tabPage2.Controls.Add(panel3);
            tabPage2.Font = new Font("Segoe UI", 11F);
            tabPage2.ForeColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(865, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rental Details";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 128, 0);
            btnReturn.Location = new Point(597, 382);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(97, 34);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Back";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(255, 128, 0);
            btnCompute.Location = new Point(713, 382);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(114, 34);
            btnCompute.TabIndex = 13;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dtpReturn);
            panel3.Controls.Add(dtpRental);
            panel3.Controls.Add(nudDays);
            panel3.Controls.Add(nudCars);
            panel3.Controls.Add(txtRate);
            panel3.Controls.Add(cmbCar);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.ForeColor = Color.FromArgb(255, 128, 0);
            panel3.Location = new Point(38, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(789, 346);
            panel3.TabIndex = 4;
            // 
            // dtpReturn
            // 
            dtpReturn.CalendarFont = new Font("Segoe UI", 14F);
            dtpReturn.CalendarTitleBackColor = Color.FromArgb(255, 128, 0);
            dtpReturn.CalendarTitleForeColor = Color.Gray;
            dtpReturn.Location = new Point(322, 220);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(194, 27);
            dtpReturn.TabIndex = 16;
            dtpReturn.Value = new DateTime(2026, 1, 26, 0, 0, 0, 0);
            // 
            // dtpRental
            // 
            dtpRental.CalendarFont = new Font("Segoe UI", 14F);
            dtpRental.CalendarTitleBackColor = Color.FromArgb(255, 128, 0);
            dtpRental.CalendarTitleForeColor = Color.Gray;
            dtpRental.Location = new Point(23, 220);
            dtpRental.Name = "dtpRental";
            dtpRental.Size = new Size(194, 27);
            dtpRental.TabIndex = 15;
            // 
            // nudDays
            // 
            nudDays.BackColor = Color.Gray;
            nudDays.Font = new Font("Segoe UI", 14F);
            nudDays.ForeColor = Color.White;
            nudDays.Location = new Point(579, 135);
            nudDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDays.Name = "nudDays";
            nudDays.Size = new Size(194, 32);
            nudDays.TabIndex = 14;
            nudDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCars
            // 
            nudCars.BackColor = Color.Gray;
            nudCars.Font = new Font("Segoe UI", 14F);
            nudCars.ForeColor = Color.White;
            nudCars.Location = new Point(322, 135);
            nudCars.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCars.Name = "nudCars";
            nudCars.Size = new Size(194, 32);
            nudCars.TabIndex = 13;
            nudCars.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtRate
            // 
            txtRate.BackColor = Color.Gray;
            txtRate.Font = new Font("Segoe UI", 14F);
            txtRate.ForeColor = Color.White;
            txtRate.Location = new Point(579, 215);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(194, 32);
            txtRate.TabIndex = 12;
            // 
            // cmbCar
            // 
            cmbCar.BackColor = Color.Gray;
            cmbCar.Font = new Font("Segoe UI", 11F);
            cmbCar.ForeColor = Color.White;
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new Point(23, 134);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(194, 28);
            cmbCar.TabIndex = 11;
            cmbCar.SelectedIndexChanged += cmbCar_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(255, 128, 0);
            label15.Location = new Point(579, 192);
            label15.Name = "label15";
            label15.Size = new Size(118, 20);
            label15.TabIndex = 10;
            label15.Text = "Rate per Day (₱)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(322, 192);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 9;
            label9.Text = "Return Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(579, 112);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 6;
            label10.Text = "No. Of Days";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(23, 192);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 5;
            label11.Text = " Rental Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F);
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(21, 18);
            label12.Name = "label12";
            label12.Size = new Size(178, 30);
            label12.TabIndex = 0;
            label12.Text = "🚗 Rental Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(322, 112);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 2;
            label13.Text = "No. Of Cars";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(255, 128, 0);
            label14.Location = new Point(23, 112);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 1;
            label14.Text = "Select Car";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DimGray;
            tabPage3.Controls.Add(btnConfrim);
            tabPage3.Controls.Add(btnCancel);
            tabPage3.Controls.Add(btnBack);
            tabPage3.Controls.Add(panel4);
            tabPage3.Font = new Font("Segoe UI", 11F);
            tabPage3.ForeColor = Color.White;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(865, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Payment";
            // 
            // btnConfrim
            // 
            btnConfrim.BackColor = Color.FromArgb(255, 128, 0);
            btnConfrim.Location = new Point(690, 377);
            btnConfrim.Name = "btnConfrim";
            btnConfrim.Size = new Size(138, 34);
            btnConfrim.TabIndex = 17;
            btnConfrim.Text = "Confirm Payment";
            btnConfrim.UseVisualStyleBackColor = false;
            btnConfrim.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 0);
            btnCancel.Location = new Point(587, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 34);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 0);
            btnBack.Location = new Point(484, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 34);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBackRental_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtTotalCost);
            panel4.Controls.Add(txtAmountPaid);
            panel4.Controls.Add(cmbPaymentMethod);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label22);
            panel4.ForeColor = Color.FromArgb(255, 128, 0);
            panel4.Location = new Point(39, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(789, 346);
            panel4.TabIndex = 5;
            // 
            // txtTotalCost
            // 
            txtTotalCost.AutoSize = true;
            txtTotalCost.BorderStyle = BorderStyle.FixedSingle;
            txtTotalCost.Font = new Font("Segoe UI", 16F);
            txtTotalCost.Location = new Point(21, 238);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(141, 32);
            txtTotalCost.TabIndex = 15;
            txtTotalCost.Text = "TOTAL COST:";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.BackColor = Color.Gray;
            txtAmountPaid.Font = new Font("Segoe UI", 14F);
            txtAmountPaid.ForeColor = Color.White;
            txtAmountPaid.Location = new Point(470, 88);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(294, 32);
            txtAmountPaid.TabIndex = 12;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.BackColor = Color.Gray;
            cmbPaymentMethod.Font = new Font("Segoe UI", 14F);
            cmbPaymentMethod.ForeColor = Color.White;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(21, 87);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(294, 33);
            cmbPaymentMethod.TabIndex = 11;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F);
            label20.ForeColor = Color.FromArgb(255, 128, 0);
            label20.Location = new Point(21, 18);
            label20.Name = "label20";
            label20.Size = new Size(132, 30);
            label20.TabIndex = 0;
            label20.Text = "💳 Payment";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.FromArgb(255, 128, 0);
            label21.Location = new Point(470, 65);
            label21.Name = "label21";
            label21.Size = new Size(117, 20);
            label21.TabIndex = 2;
            label21.Text = "Amount Paid (₱)";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(255, 128, 0);
            label22.Location = new Point(21, 65);
            label22.Name = "label22";
            label22.Size = new Size(121, 20);
            label22.TabIndex = 1;
            label22.Text = "Payment Method";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 507);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCars).EndInit();
            tabPage3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label4;
        private Label label3;
        private Label label5;
        private Panel panel2;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnClear;
        private TextBox txtAddress;
        private Button btnNext;
        private Button btnReturn;
        private Button btnCompute;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cmbCar;
        private NumericUpDown nudCars;
        private TextBox txtRate;
        private DateTimePicker dtpRental;
        private NumericUpDown nudDays;
        private DateTimePicker dtpReturn;
        private Button btnConfrim;
        private Button btnCancel;
        private Button btnBack;
        private Panel panel4;
        private ComboBox cmbPaymentMethod;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtAmountPaid;
        private Button btnLogOut;
        private Panel panel5;
        private Label txtTotalCost;
    }
}