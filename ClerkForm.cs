namespace CarRentalLegaspi
{
    public partial class ClerkForm : Form
    {
        // Sample rental data — replace with DB later
        private List<string[]> rentals = new()
        {
            new[] { "R-001", "Juan Dela Cruz",  "Toyota Vios",      "3", "₱4,500",  "Completed" },
            new[] { "R-002", "Maria Santos",    "Toyota Fortuner",  "3", "₱12,000", "Active"    },
            new[] { "R-003", "Pedro Reyes",     "Honda City",       "2", "₱3,600",  "Pending"   }
        };

        // Sample car inventory — replace with DB later
        private List<string[]> cars = new()
        {
            new[] { "Toyota Vios",      "Sedan",        "ABC-1234", "1500", "Available" },
            new[] { "Honda City",       "Sedan",        "DEF-5678", "1800", "Available" },
            new[] { "Toyota Fortuner",  "SUV",          "GHI-9012", "4000", "Rented"    },
            new[] { "Toyota Hiace",     "Van",          "JKL-3456", "4500", "Available" },
            new[] { "Ford Ranger",      "Pickup Truck", "MNO-7890", "3800", "Available" }
        };

        public ClerkForm()
        {
            InitializeComponent();
            LoadRentals();
            LoadCars();
            LoadCarComboBoxes();
        }

        // ─── MANAGE RENTALS ──────────────────────────────────────────

        private void LoadRentals(string filter = "")
        {
            dataGridView2.Rows.Clear();
            foreach (var r in rentals)
            {
                if (string.IsNullOrEmpty(filter) ||
                    r[1].Contains(filter, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView2.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], "✏ Edit");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Search
        {
            LoadRentals(textBox2.Text.Trim());
        }

        // ─── CAR INVENTORY ───────────────────────────────────────────

        private void LoadCars()
        {
            dataGridView1.Rows.Clear();
            foreach (var c in cars)
                dataGridView1.Rows.Add(c[0], c[1], c[2], c[3], c[4]);
        }

        private void LoadCarComboBoxes()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "Sedan", "SUV", "Van", "Pickup Truck" });

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Available", "Rented", "Under Maintenance" });
        }

        private void button1_Click(object sender, EventArgs e) // Add Car
        {
            string name = textBox1.Text.Trim();
            string plate = textBox3.Text.Trim();
            string rate = textBox5.Text.Trim();
            string type = comboBox2.Text;
            string status = comboBox1.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(plate) ||
                string.IsNullOrEmpty(rate) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please fill in all car fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cars.Add(new[] { name, type, plate, rate, status == "" ? "Available" : status });
            LoadCars();
            ClearCarFields();
            MessageBox.Show("Car added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e) // Update Car
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a car to update.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dataGridView1.CurrentRow.Index;
            cars[idx] = new[]
            {
                textBox1.Text.Trim(),
                comboBox2.Text,
                textBox3.Text.Trim(),
                textBox5.Text.Trim(),
                comboBox1.Text == "" ? "Available" : comboBox1.Text
            };
            LoadCars();
            ClearCarFields();
            MessageBox.Show("Car updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearCarFields()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate fields when a car row is clicked
            if (e.RowIndex >= 0 && e.RowIndex < cars.Count)
            {
                var c = cars[e.RowIndex];
                textBox1.Text = c[0];
                comboBox2.Text = c[1];
                textBox3.Text = c[2];
                textBox5.Text = c[3];
                comboBox1.Text = c[4];
            }
        }

        // ─── REPORTS ─────────────────────────────────────────────────

        private void button4_Click(object sender, EventArgs e) // Generate Report
        {
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;

            if (from > to)
            {
                MessageBox.Show("'From' date must be before 'To' date.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show all rentals in report grid (filter by date when connected to DB)
            dataGridView3.Rows.Clear();
            double total = 0;

            foreach (var r in rentals)
            {
                dataGridView3.Rows.Add(r[0], r[1], r[2], r[4], r[5]);
                string raw = r[4].Replace("₱", "").Replace(",", "");
                if (double.TryParse(raw, out double amt)) total += amt;
            }

            textBox4.Text = $"Report from {from:MM/dd/yyyy} to {to:MM/dd/yyyy}   |   " +
                            $"Transactions: {rentals.Count}";
            label13.Text = $"Total Revenue: ₱{total:N2}";
        }

        // ─── WINDOW CLOSE ────────────────────────────────────────────

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}