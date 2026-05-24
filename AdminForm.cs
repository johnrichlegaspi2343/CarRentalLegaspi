namespace CarRentalLegaspi
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadDashboard(); LoadUsers(); LoadSettings(); WireEvents();
        }

        private void WireEvents()
        {
            button1.Click += button1_Click;   // Clear fields
            button2.Click += button2_Click;   // Add User
            button3.Click += button3_Click;   // Save Settings
            button4.Click += button4_Click;   // Reset Settings
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
        }

        // ── DASHBOARD ────────────────────────────────────────────
        private void LoadDashboard()
        {
            try
            {
                using var db = new AppDbContext();
                textBox1.Text = db.Cars.Count().ToString();
                textBox2.Text = db.Rentals.Count().ToString();
                textBox3.Text = db.Cars.Count(c => c.Status == "Available").ToString();
                decimal rev = db.Rentals
                                 .Where(r => r.Status == "Completed")
                                 .Sum(r => (decimal?)r.Total) ?? 0;
                textBox4.Text = $"₱{rev:N2}";

                dataGridView1.Rows.Clear();
                foreach (var r in db.Rentals.ToList())
                    dataGridView1.Rows.Add($"R-{r.Id:000}", r.Customer,
                        r.Car, $"₱{r.Total:N2}", r.Status);
            }
            catch (Exception ex)
            { MessageBox.Show($"Dashboard error: {ex.Message}"); }
        }

        // ── USER MANAGEMENT ──────────────────────────────────────
        private void LoadUsers()
        {
            try
            {
                using var db = new AppDbContext();
                dataGridView3.Rows.Clear();
                foreach (var u in db.Users.ToList())
                {
                    int row = dataGridView3.Rows.Add(u.Username, u.Role);
                    dataGridView3.Rows[row].Cells["Column8"].Value = "Delete";
                    dataGridView3.Rows[row].Tag = u.Id;  // store DB Id
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"User load error: {ex.Message}"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text.Trim();
            string password = textBox6.Text.Trim();
            string role = comboBox1.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(role))
            { MessageBox.Show("Please fill in all fields."); return; }

            try
            {
                using var db = new AppDbContext();
                if (db.Users.Any(u => u.Username == username))
                { MessageBox.Show("Username already exists."); return; }

                db.Users.Add(new User
                { Username = username, Password = password, Role = role });
                db.SaveChanges();
                LoadUsers(); ClearUserFields();
                MessageBox.Show($"User '{username}' added.");
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void button1_Click(object s, EventArgs e) => ClearUserFields();

        private void ClearUserFields()
        { textBox5.Clear(); textBox6.Clear(); comboBox1.SelectedIndex = -1; }

        private void dataGridView3_CellContentClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dataGridView3.Columns["Column8"].Index
                || e.RowIndex < 0) return;

            string uname = dataGridView3.Rows[e.RowIndex]
                               .Cells["Column6"].Value?.ToString() ?? "";
            if (MessageBox.Show($"Delete '{uname}'?", "Confirm",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                int id = (int)(dataGridView3.Rows[e.RowIndex].Tag ?? 0);
                using var db = new AppDbContext();
                var user = db.Users.Find(id);
                if (user != null) { db.Users.Remove(user); db.SaveChanges(); }
                LoadUsers();
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}"); }
        }

        // ── SETTINGS ─────────────────────────────────────────────
        private void LoadSettings()
        {
            label16.Text = "Car Rental System";
            textBox7.Text = "09XX XXX XXXX";
            textBox8.Text = "Unit/Floor, Building, Street, City";
        }
        private void button3_Click(object s, EventArgs e) =>
            MessageBox.Show($"Saved!\nName: {label16.Text}\nContact: {textBox7.Text}\nAddress: {textBox8.Text}");
        private void button4_Click(object s, EventArgs e) => LoadSettings();

        protected override void OnFormClosing(FormClosingEventArgs e)
        { base.OnFormClosing(e); Application.Exit(); }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Hide(); new LoginForm().Show(); }
        }
    }
}