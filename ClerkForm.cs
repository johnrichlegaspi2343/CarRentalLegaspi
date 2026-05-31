namespace CarRentalLegaspi
{
    public partial class ClerkForm : Form
    {
        public ClerkForm()
        {
            InitializeComponent();

            // I-configure ang DataGridViews bago mag-load ng data
            ConfigureDataGridViews();

            LoadRentals();
            LoadCars();
            LoadCarComboBoxes();
            WireEvents();

            // I-handle ang DataError events
            dataGridView1.DataError += DataGridView_DataError;
            dataGridView2.DataError += DataGridView_DataError;
            dataGridView3.DataError += DataGridView_DataError;
        }

        private void WireEvents()
        {
            button1.Click += button1_Click;   // Add Car
            button2.Click += button2_Click;   // Search
            button3.Click += button3_Click;   // Update Car
            button4.Click += button4_Click;   // Generate Report
            btnLogOut.Click += btnLogOut_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // ── DATAGRIDVIEW CONFIGURATION ────────────────────────────────────────
        private void ConfigureDataGridViews()
        {
            // I-configure ang dataGridView1 (Car Inventory) - gawing TextBox ang Status column
            if (dataGridView1.Columns["Status"] != null &&
                (dataGridView1.Columns["Status"] is DataGridViewCheckBoxColumn ||
                 dataGridView1.Columns["Status"] is DataGridViewComboBoxColumn))
            {
                int index = dataGridView1.Columns["Status"].Index;
                string headerText = dataGridView1.Columns["Status"].HeaderText;
                int width = dataGridView1.Columns["Status"].Width;

                dataGridView1.Columns.RemoveAt(index);
                dataGridView1.Columns.Insert(index, new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    HeaderText = headerText,
                    Width = width,
                    ReadOnly = true
                });
            }

            // I-configure ang dataGridView2 (Rentals) - gawing TextBox ang Status column
            if (dataGridView2.Columns["Status"] != null &&
                (dataGridView2.Columns["Status"] is DataGridViewCheckBoxColumn ||
                 dataGridView2.Columns["Status"] is DataGridViewComboBoxColumn))
            {
                int index = dataGridView2.Columns["Status"].Index;
                string headerText = dataGridView2.Columns["Status"].HeaderText;
                int width = dataGridView2.Columns["Status"].Width;

                dataGridView2.Columns.RemoveAt(index);
                dataGridView2.Columns.Insert(index, new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    HeaderText = headerText,
                    Width = width,
                    ReadOnly = true
                });
            }

            // I-configure ang dataGridView3 (Reports) - gawing TextBox ang Status column
            if (dataGridView3.Columns["Status"] != null &&
                (dataGridView3.Columns["Status"] is DataGridViewCheckBoxColumn ||
                 dataGridView3.Columns["Status"] is DataGridViewComboBoxColumn))
            {
                int index = dataGridView3.Columns["Status"].Index;
                string headerText = dataGridView3.Columns["Status"].HeaderText;
                int width = dataGridView3.Columns["Status"].Width;

                dataGridView3.Columns.RemoveAt(index);
                dataGridView3.Columns.Insert(index, new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    HeaderText = headerText,
                    Width = width,
                    ReadOnly = true
                });
            }
        }

        // I-handle ang DataGridView errors
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Cancel the error para hindi mag-popup ang error dialog
            e.Cancel = true;
        }

        // ── MANAGE RENTALS ────────────────────────────────────────
        private void LoadRentals(string filter = "")
        {
            try
            {
                using var db = new AppDbContext();
                dataGridView2.Rows.Clear();

                var q = db.Rentals.AsQueryable();
                if (!string.IsNullOrEmpty(filter))
                    q = q.Where(r => r.Customer.Contains(filter));

                foreach (var r in q.ToList())
                {
                    // Siguraduhin na ang status ay string
                    string status = string.IsNullOrEmpty(r.Status) ? "Active" : r.Status;

                    dataGridView2.Rows.Add(
                        $"R-{r.Id:000}",
                        r.Customer,
                        r.Car,
                        r.Days,
                        $"₱{r.Total:N2}",
                        status,
                        "Edit"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rentals: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object s, EventArgs e) =>
            LoadRentals(textBox2.Text.Trim());

        // ── CAR INVENTORY ─────────────────────────────────────────
        private void LoadCars()
        {
            try
            {
                using var db = new AppDbContext();
                dataGridView1.Rows.Clear();

                foreach (var c in db.Cars.ToList())
                {
                    // Siguraduhin na ang status ay string
                    string status = string.IsNullOrEmpty(c.Status) ? "Available" : c.Status;

                    dataGridView1.Rows.Add(
                        c.CarName,
                        c.Type,
                        c.PlateNum,
                        $"₱{c.RatePerDay:N2}",
                        status
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cars: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarComboBoxes()
        {
            comboBox2.Items.AddRange(new object[]
                { "Sedan", "SUV", "Van", "Pickup Truck" });
            comboBox1.Items.AddRange(new object[]
                { "Available", "Rented", "Under Maintenance" });
        }

        private void button1_Click(object sender, EventArgs e) // Add Car
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill in all car fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox5.Text, out decimal rate))
            {
                MessageBox.Show("Rate must be a valid number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new AppDbContext();
                db.Cars.Add(new Car
                {
                    CarName = textBox1.Text.Trim(),
                    Type = comboBox2.Text,
                    PlateNum = textBox3.Text.Trim(),
                    RatePerDay = rate,
                    Status = string.IsNullOrEmpty(comboBox1.Text) ? "Available" : comboBox1.Text
                });
                db.SaveChanges();
                LoadCars();
                ClearCarFields();
                MessageBox.Show("Car added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding car: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Update Car
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a car row first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox5.Text, out decimal rate))
            {
                MessageBox.Show("Rate must be a valid number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the car ID from the database based on plate number or name
                using var db = new AppDbContext();
                string carName = textBox1.Text.Trim();
                var car = db.Cars.FirstOrDefault(c => c.CarName == carName);

                if (car == null)
                {
                    MessageBox.Show("Car not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                car.CarName = textBox1.Text.Trim();
                car.Type = comboBox2.Text;
                car.PlateNum = textBox3.Text.Trim();
                car.RatePerDay = rate;
                car.Status = string.IsNullOrEmpty(comboBox1.Text) ? "Available" : comboBox1.Text;

                db.SaveChanges();
                LoadCars();
                ClearCarFields();
                MessageBox.Show("Car updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating car: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCarFields()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();

                    // Remove the ₱ sign and format the rate
                    string rateText = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                    if (rateText != null && rateText.StartsWith("₱"))
                        rateText = rateText.Substring(1);
                    textBox5.Text = rateText;

                    comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting car: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── REPORTS ───────────────────────────────────────────────
        private void button4_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("'From' date must be before 'To' date.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new AppDbContext();
                dataGridView3.Rows.Clear();
                decimal total = 0;

                var records = db.Rentals.ToList();

                foreach (var r in records)
                {
                    string status = string.IsNullOrEmpty(r.Status) ? "Completed" : r.Status;

                    dataGridView3.Rows.Add(
                        $"R-{r.Id:000}",
                        r.Customer,
                        r.Car,
                        $"₱{r.Total:N2}",
                        status
                    );
                    total += r.Total;
                }

                textBox4.Text = $"Transactions: {records.Count}";
                label13.Text = $"Total Revenue: ₱{total:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}