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
            dgvManageRentals.DataError += DataGridView_DataError;
            dgvManageRentals.DataError += DataGridView_DataError;
            dgvReports.DataError += DataGridView_DataError;
        }

        private void WireEvents()
        {
            btnAdd.Click += btnAdd_Click;   // Add Car
            btnSearch.Click += btnSearch_Click;   // Search
            btnUpd.Click += btnUpd_Click;   // Update Car
            btnGenerate.Click += btnGenerate_Click;   // Generate Report
            btnLogOut.Click += btnLogOut_Click;
            dgvCarInv.CellClick += dataGridView1_CellClick;
        }

        // ── DATAGRIDVIEW CONFIGURATION ────────────────────────────────────────
        private void ConfigureDataGridViews()
        {
            // I-configure ang dataGridView1 (Car Inventory) - gawing TextBox ang Status column
            if (dgvManageRentals.Columns["Status"] != null &&
                (dgvManageRentals.Columns["Status"] is DataGridViewCheckBoxColumn ||
                 dgvManageRentals.Columns["Status"] is DataGridViewComboBoxColumn))
            {
                int index = dgvManageRentals.Columns["Status"].Index;
                string headerText = dgvManageRentals.Columns["Status"].HeaderText;
                int width = dgvManageRentals.Columns["Status"].Width;

                dgvManageRentals.Columns.RemoveAt(index);
                dgvManageRentals.Columns.Insert(index, new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    HeaderText = headerText,
                    Width = width,
                    ReadOnly = true
                });
            }

            // I-configure ang dataGridView2 (Rentals) - gawing TextBox ang Status column
            if (dgvManageRentals.Columns["Status"] != null &&
                (dgvManageRentals.Columns["Status"] is DataGridViewCheckBoxColumn ||
                 dgvManageRentals.Columns["Status"] is DataGridViewComboBoxColumn))
            {
                int index = dgvManageRentals.Columns["Status"].Index;
                string headerText = dgvManageRentals.Columns["Status"].HeaderText;
                int width = dgvManageRentals.Columns["Status"].Width;

                dgvManageRentals.Columns.RemoveAt(index);
                dgvManageRentals.Columns.Insert(index, new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    HeaderText = headerText,
                    Width = width,
                    ReadOnly = true
                });
            }

            // I-configure ang dataGridView3 (Reports) - gawing TextBox ang Status column
            if (dgvReports.Columns["Status"] != null &&
                (dgvReports.Columns["Status"] is DataGridViewCheckBoxColumn ||
                 dgvReports.Columns["Status"] is DataGridViewComboBoxColumn))
            {
                int index = dgvReports.Columns["Status"].Index;
                string headerText = dgvReports.Columns["Status"].HeaderText;
                int width = dgvReports.Columns["Status"].Width;

                dgvReports.Columns.RemoveAt(index);
                dgvReports.Columns.Insert(index, new DataGridViewTextBoxColumn
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
                dgvManageRentals.Rows.Clear();

                var q = db.Rentals.AsQueryable();
                if (!string.IsNullOrEmpty(filter))
                    q = q.Where(r => r.Customer.Contains(filter));

                foreach (var r in q.ToList())
                {
                    // Siguraduhin na ang status ay string
                    string status = string.IsNullOrEmpty(r.Status) ? "Active" : r.Status;

                    dgvManageRentals.Rows.Add(
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

        private void btnSearch_Click(object s, EventArgs e) =>
            LoadRentals(txtboxSearch.Text.Trim());

        // ── CAR INVENTORY ─────────────────────────────────────────
        private void LoadCars()
        {
            try
            {
                using var db = new AppDbContext();
                dgvManageRentals.Rows.Clear();

                foreach (var c in db.Cars.ToList())
                {
                    // Siguraduhin na ang status ay string
                    string status = string.IsNullOrEmpty(c.Status) ? "Available" : c.Status;

                    dgvManageRentals.Rows.Add(
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
            cmBoxTypeCar.Items.AddRange(new object[]
                { "Sedan", "SUV", "Van", "Pickup Truck" });
            cmBoxStatus.Items.AddRange(new object[]
                { "Available", "Rented", "Under Maintenance" });
        }

        private void btnAdd_Click(object sender, EventArgs e) // Add Car
        {
            if (string.IsNullOrEmpty(txtCarName.Text) ||
                string.IsNullOrEmpty(txtBoxPlateNo.Text) ||
                string.IsNullOrEmpty(txtBoxRatePDay.Text) ||
                string.IsNullOrEmpty(cmBoxTypeCar.Text))
            {
                MessageBox.Show("Please fill in all car fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBoxRatePDay.Text, out decimal rate))
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
                    CarName = txtCarName.Text.Trim(),
                    Type = cmBoxTypeCar.Text,
                    PlateNum = txtBoxPlateNo.Text.Trim(),
                    RatePerDay = rate,
                    Status = string.IsNullOrEmpty(cmBoxStatus.Text) ? "Available" : cmBoxStatus.Text
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

        private void btnUpd_Click(object sender, EventArgs e) // Update Car
        {
            if (dgvCarInv.CurrentRow == null || dgvCarInv.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a car row first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBoxRatePDay.Text, out decimal rate))
            {
                MessageBox.Show("Rate must be a valid number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the car ID from the database based on plate number or name
                using var db = new AppDbContext();
                string carName = txtCarName.Text.Trim();
                var car = db.Cars.FirstOrDefault(c => c.CarName == carName);

                if (car == null)
                {
                    MessageBox.Show("Car not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                car.CarName = txtCarName.Text.Trim();
                car.Type = cmBoxTypeCar.Text;
                car.PlateNum = txtBoxPlateNo.Text.Trim();
                car.RatePerDay = rate;
                car.Status = string.IsNullOrEmpty(cmBoxStatus.Text) ? "Available" : cmBoxStatus.Text;

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
            txtCarName.Clear();
            txtBoxPlateNo.Clear();
            txtBoxRatePDay.Clear();
            cmBoxTypeCar.SelectedIndex = -1;
            cmBoxStatus.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                if (dgvCarInv.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtCarName.Text = dgvCarInv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmBoxTypeCar.Text = dgvCarInv.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    txtBoxPlateNo.Text = dgvCarInv.Rows[e.RowIndex].Cells[2].Value?.ToString();

                    // Remove the ₱ sign and format the rate
                    string rateText = dgvCarInv.Rows[e.RowIndex].Cells[3].Value?.ToString();
                    if (rateText != null && rateText.StartsWith("₱"))
                        rateText = rateText.Substring(1);
                    txtBoxRatePDay.Text = rateText;

                    cmBoxStatus.Text = dgvCarInv.Rows[e.RowIndex].Cells[4].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting car: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── REPORTS ───────────────────────────────────────────────
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("'From' date must be before 'To' date.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new AppDbContext();
                dgvReports.Rows.Clear();
                decimal total = 0;

                var records = db.Rentals.ToList();

                foreach (var r in records)
                {
                    string status = string.IsNullOrEmpty(r.Status) ? "Completed" : r.Status;

                    dgvReports.Rows.Add(
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