namespace CarRentalLegaspi
{
    public partial class AdminForm : Form
    {
        // Sample in-memory user list — replace with DB later
        private List<(string Username, string Role)> userList = new()
        {
            ("admin",    "Admin"),
            ("clerk01",  "Clerk"),
            ("customer", "Customer")
        };

        public AdminForm()
        {
            InitializeComponent();
            LoadDashboard();
            LoadUsers();
            LoadSettings();
        }

        // ─── DASHBOARD ───────────────────────────────────────────────

        private void LoadDashboard()
        {
            // Dummy data — wire up to DB later
            textBox1.Text = "12";    // Total Cars
            textBox2.Text = "5";     // Total Rentals
            textBox3.Text = "8";     // Available Cars
            textBox4.Text = "₱24,500"; // Total Revenue

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("R-001", "Juan Dela Cruz", "Toyota Vios", "₱4,500", "Completed");
            dataGridView1.Rows.Add("R-002", "Maria Santos", "Toyota Fortuner", "₱12,000", "Active");
            dataGridView1.Rows.Add("R-003", "Pedro Reyes", "Honda City", "₱3,600", "Pending");
        }

        // ─── USER MANAGEMENT ─────────────────────────────────────────

        private void LoadUsers()
        {
            dataGridView3.Rows.Clear();
            foreach (var u in userList)
            {
                int row = dataGridView3.Rows.Add(u.Username, u.Role);
                dataGridView3.Rows[row].Cells["Column8"].Value = "🗑 Delete";
            }
        }

        private void button2_Click(object sender, EventArgs e) // Add User
        {
            string username = textBox5.Text.Trim();
            string password = textBox6.Text.Trim();
            string role = comboBox1.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            userList.Add((username, role));
            LoadUsers();
            ClearUserFields();
            MessageBox.Show($"User '{username}' added successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) // Clear
        {
            ClearUserFields();
        }

        private void ClearUserFields()
        {
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["Column8"].Index && e.RowIndex >= 0)
            {
                string username = dataGridView3.Rows[e.RowIndex].Cells["Column6"].Value?.ToString() ?? "";

                var result = MessageBox.Show($"Delete user '{username}'?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    userList.RemoveAt(e.RowIndex);
                    LoadUsers();
                }
            }
        }

        // ─── SETTINGS ────────────────────────────────────────────────

        private void LoadSettings()
        {
            label16.Text = "Car Rental System";
            textBox7.Text = "09XX XXX XXXX";
            textBox8.Text = "Unit/Floor, Building, Street, City";
        }

        private void button3_Click(object sender, EventArgs e) // Save
        {
            MessageBox.Show(
                $"Settings saved!\n\nSystem Name: {label16.Text}\n" +
                $"Contact: {textBox7.Text}\nAddress: {textBox8.Text}",
                "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e) // Reset
        {
            LoadSettings();
        }

        // ─── LOGOUT ──────────────────────────────────────────────────

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}