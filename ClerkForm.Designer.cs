namespace CarRentalLegaspi
{
    partial class ClerkForm
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
            panel1 = new Panel();
            btnLogOut = new Button();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSearch = new Button();
            txtboxSearch = new TextBox();
            label4 = new Label();
            dgvManageRentals = new DataGridView();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            dgvCarInv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnUpd = new Button();
            btnAdd = new Button();
            cmBoxTypeCar = new ComboBox();
            cmBoxStatus = new ComboBox();
            txtBoxRatePDay = new TextBox();
            txtBoxPlateNo = new TextBox();
            txtCarName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            panel4 = new Panel();
            panel6 = new Panel();
            label13 = new Label();
            textBox4 = new TextBox();
            dgvReports = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            btnGenerate = new Button();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageRentals).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarInv).BeginInit();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 46);
            panel1.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(916, 8);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(60, 26);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(838, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "👤Clerk";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(977, 485);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtboxSearch);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dgvManageRentals);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(969, 457);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Rentals";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(740, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 27);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtboxSearch
            // 
            txtboxSearch.BackColor = Color.White;
            txtboxSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(0, 27);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.PlaceholderText = "Search by customer name...";
            txtboxSearch.Size = new Size(734, 27);
            txtboxSearch.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(-4, 3);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 12;
            label4.Text = "🔍 Search Rentals";
            // 
            // dgvManageRentals
            // 
            dgvManageRentals.BackgroundColor = Color.WhiteSmoke;
            dgvManageRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageRentals.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewComboBoxColumn1 });
            dgvManageRentals.Location = new Point(0, 60);
            dgvManageRentals.Name = "dgvManageRentals";
            dgvManageRentals.Size = new Size(973, 383);
            dgvManageRentals.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(969, 457);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Car Inventory";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvCarInv);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-7, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 457);
            panel2.TabIndex = 0;
            // 
            // dgvCarInv
            // 
            dgvCarInv.BackgroundColor = Color.WhiteSmoke;
            dgvCarInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarInv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvCarInv.Location = new Point(26, 240);
            dgvCarInv.Name = "dgvCarInv";
            dgvCarInv.Size = new Size(926, 202);
            dgvCarInv.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Car Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Type";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Plate No.";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Rate/Day";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnUpd);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(cmBoxTypeCar);
            panel3.Controls.Add(cmBoxStatus);
            panel3.Controls.Add(txtBoxRatePDay);
            panel3.Controls.Add(txtBoxPlateNo);
            panel3.Controls.Add(txtCarName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(26, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(925, 170);
            panel3.TabIndex = 0;
            // 
            // btnUpd
            // 
            btnUpd.BackColor = Color.RoyalBlue;
            btnUpd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpd.ForeColor = Color.White;
            btnUpd.Location = new Point(519, 113);
            btnUpd.Name = "btnUpd";
            btnUpd.Size = new Size(78, 27);
            btnUpd.TabIndex = 14;
            btnUpd.Text = "📋 Update";
            btnUpd.UseVisualStyleBackColor = false;
            btnUpd.Click += btnUpd_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(435, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 27);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmBoxTypeCar
            // 
            cmBoxTypeCar.BackColor = Color.White;
            cmBoxTypeCar.FormattingEnabled = true;
            cmBoxTypeCar.Location = new Point(215, 61);
            cmBoxTypeCar.Name = "cmBoxTypeCar";
            cmBoxTypeCar.Size = new Size(158, 23);
            cmBoxTypeCar.TabIndex = 12;
            // 
            // cmBoxStatus
            // 
            cmBoxStatus.BackColor = Color.White;
            cmBoxStatus.FormattingEnabled = true;
            cmBoxStatus.Location = new Point(215, 117);
            cmBoxStatus.Name = "cmBoxStatus";
            cmBoxStatus.Size = new Size(160, 23);
            cmBoxStatus.TabIndex = 11;
            // 
            // txtBoxRatePDay
            // 
            txtBoxRatePDay.BackColor = Color.White;
            txtBoxRatePDay.Location = new Point(30, 117);
            txtBoxRatePDay.Name = "txtBoxRatePDay";
            txtBoxRatePDay.Size = new Size(160, 23);
            txtBoxRatePDay.TabIndex = 9;
            // 
            // txtBoxPlateNo
            // 
            txtBoxPlateNo.BackColor = Color.White;
            txtBoxPlateNo.Location = new Point(437, 61);
            txtBoxPlateNo.Name = "txtBoxPlateNo";
            txtBoxPlateNo.Size = new Size(160, 23);
            txtBoxPlateNo.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.BackColor = Color.White;
            txtCarName.Location = new Point(29, 60);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(160, 23);
            txtCarName.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(215, 98);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 5;
            label9.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(215, 42);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 4;
            label8.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(30, 98);
            label7.Name = "label7";
            label7.Size = new Size(103, 17);
            label7.TabIndex = 3;
            label7.Text = "Rate Per Day (₱)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(437, 42);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 2;
            label6.Text = "Plate no.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(30, 42);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 1;
            label5.Text = "Car Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(18, 11);
            label2.Name = "label2";
            label2.Size = new Size(170, 19);
            label2.TabIndex = 0;
            label2.Text = "+ Add / Update Car";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(969, 457);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(970, 458);
            panel4.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label13);
            panel6.Controls.Add(textBox4);
            panel6.Controls.Add(dgvReports);
            panel6.Location = new Point(18, 188);
            panel6.Name = "panel6";
            panel6.Size = new Size(927, 254);
            panel6.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.WhiteSmoke;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(16, 204);
            label13.Name = "label13";
            label13.Size = new Size(42, 21);
            label13.TabIndex = 2;
            label13.Text = "Total";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.Location = new Point(0, 173);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(927, 81);
            textBox4.TabIndex = 1;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.WhiteSmoke;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10 });
            dgvReports.Location = new Point(0, 0);
            dgvReports.Name = "dgvReports";
            dgvReports.Size = new Size(927, 175);
            dgvReports.TabIndex = 0;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Rental ID";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Customer";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Car";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.HeaderText = "Total";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Status";
            Column10.Name = "Column10";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(btnGenerate);
            panel5.Controls.Add(dtpTo);
            panel5.Controls.Add(dtpFrom);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(18, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(927, 121);
            panel5.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.WhiteSmoke;
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(444, 58);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(105, 36);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "📊Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(231, 66);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(189, 23);
            dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(16, 66);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(189, 23);
            dtpFrom.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(231, 48);
            label12.Name = "label12";
            label12.Size = new Size(22, 17);
            label12.TabIndex = 2;
            label12.Text = "To";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(16, 48);
            label11.Name = "label11";
            label11.Size = new Size(38, 17);
            label11.TabIndex = 1;
            label11.Text = "From";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(14, 10);
            label10.Name = "label10";
            label10.Size = new Size(105, 19);
            label10.TabIndex = 0;
            label10.Text = "Data Range";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Rental";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 155;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Customer";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 155;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn3.Frozen = true;
            dataGridViewTextBoxColumn3.HeaderText = "Car";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 155;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn4.Frozen = true;
            dataGridViewTextBoxColumn4.HeaderText = "Days";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 155;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewComboBoxColumn1.HeaderText = "Status";
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ClerkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 542);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ClerkForm";
            Text = "ManagerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageRentals).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarInv).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button2;
        private TextBox txtboxSearch;
        private Label label4;
        private DataGridView dgvManageRentals;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtBoxRatePDay;
        private TextBox txtBoxPlateNo;
        private TextBox txtCarName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button btnUpd;
        private Button button1;
        private ComboBox cmBoxTypeCar;
        private ComboBox cmBoxStatus;
        private DataGridView dgvCarInv;
        private Panel panel4;
        private Panel panel5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnGenerate;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Panel panel6;
        private DataGridView dgvReports;
        private TextBox textBox4;
        private Label label13;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnLogOut;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewComboBoxColumn1;
    }
}
