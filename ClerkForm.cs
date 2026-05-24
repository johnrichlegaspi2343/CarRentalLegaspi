namespace CarRentalLegaspi
{
    public partial class ClerkForm : Form
    {
        public ClerkForm()
        {
            InitializeComponent();
            LoadRentals(); LoadCars(); LoadCarComboBoxes(); WireEvents();
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
                    dataGridView2.Rows.Add($"R-{r.Id:000}", r.Customer,
                        r.Car, r.Days, $"₱{r.Total:N2}", r.Status, "Edit");
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
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
                    dataGridView1.Rows.Add(c.CarName, c.Type, c.PlateNum,
                        $"₱{c.RatePerDay:N2}", c.Status);
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
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
            { MessageBox.Show("Fill in all car fields."); return; }

            if (!decimal.TryParse(textBox5.Text, out decimal rate))
            { MessageBox.Show("Rate must be a number."); return; }

            try
            {
                using var db = new AppDbContext();
                db.Cars.Add(new Car
                {
                    CarName = textBox1.Text.Trim(),
                    Type = comboBox2.Text,
                    PlateNum = textBox3.Text.Trim(),
                    RatePerDay = rate,
                    Status = string.IsNullOrEmpty(comboBox1.Text)
                                 ? "Available" : comboBox1.Text
                });
                db.SaveChanges();
                LoadCars(); ClearCarFields();
                MessageBox.Show("Car added!");
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void button3_Click(object sender, EventArgs e) // Update Car
        {
            if (dataGridView1.CurrentRow?.Tag == null)
            { MessageBox.Show("Select a car row first."); return; }
            if (!decimal.TryParse(textBox5.Text, out decimal rate))
            { MessageBox.Show("Rate must be a number."); return; }

            try
            {
                int id = (int)dataGridView1.CurrentRow.Tag;
                using var db = new AppDbContext();
                var car = db.Cars.Find(id);
                if (car == null) { MessageBox.Show("Car not found."); return; }
                car.CarName = textBox1.Text.Trim();
                car.Type = comboBox2.Text;
                car.PlateNum = textBox3.Text.Trim();
                car.RatePerDay = rate;
                car.Status = string.IsNullOrEmpty(comboBox1.Text)
                                 ? "Available" : comboBox1.Text;
                db.SaveChanges();
                LoadCars(); ClearCarFields();
                MessageBox.Show("Car updated!");
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void ClearCarFields()
        {
            textBox1.Clear(); textBox3.Clear(); textBox5.Clear();
            comboBox2.SelectedIndex = -1; comboBox1.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                using var db = new AppDbContext();
                var cars = db.Cars.ToList();
                if (e.RowIndex >= cars.Count) return;
                var c = cars[e.RowIndex];
                textBox1.Text = c.CarName;
                comboBox2.Text = c.Type;
                textBox3.Text = c.PlateNum;
                textBox5.Text = c.RatePerDay.ToString("F2");
                comboBox1.Text = c.Status;
                dataGridView1.Rows[e.RowIndex].Tag = c.Id;
            }
            catch { }
        }

        // ── REPORTS ───────────────────────────────────────────────
        private void button4_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            { MessageBox.Show("'From' must be before 'To'."); return; }
            try
            {
                using var db = new AppDbContext();
                dataGridView3.Rows.Clear();
                decimal total = 0;
                var records = db.Reports.Any()
                    ? db.Reports.Select(r => new { r.Id, r.Customer, r.Car, r.Total, r.Status }).ToList()
                    : db.Rentals.Select(r => new { r.Id, r.Customer, r.Car, r.Total, r.Status }).ToList();
                foreach (var r in records)
                {
                    dataGridView3.Rows.Add($"R-{r.Id:000}", r.Customer,
                        r.Car, $"₱{r.Total:N2}", r.Status);
                    total += r.Total;
                }
                textBox4.Text = $"Transactions: {records.Count}";
                label13.Text = $"Total Revenue: ₱{total:N2}";
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void btnLogOut_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Hide(); new LoginForm().Show(); }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        { base.OnFormClosing(e); Application.Exit(); }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {

        }
    }
}