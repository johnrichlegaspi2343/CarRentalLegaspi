using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarRentalLegaspi
{
    public partial class CustomerForm : Form
    {
        double totalCost = 0;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // ✅ Load available cars only from database
            using var db = new AppDbContext();
            var availableCars = db.Cars.Where(c => c.Status == "Available").ToList();
            foreach (var car in availableCars)
            {
                cmbCar.Items.Add($"{car.CarName} - {car.Type}");
            }

            // Payment Methods
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("GCash");

            nudCars.Minimum = 1;
            nudCars.Value = 1;
            txtTotalCost.Text = "TOTAL COST: ₱0.00";
            noDays.Text = "0";

            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
        }

        // ─── TAB 1: CUSTOMER DETAILS ─────────────────────────────────

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show(
                    "Please complete all customer details before proceeding.",
                    "Incomplete Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidContact(txtContact.Text))
            {
                MessageBox.Show(
                    "Contact number must be 11 digits (e.g. 09123456789).",
                    "Invalid Contact",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            tabControl1.TabPages[1].Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtFirstName.Focus();
        }

        // ─── TAB 2: RENTAL DETAILS ───────────────────────────────────

        // ✅ Kuhanin rate from DB instead of hardcoded
        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCar.SelectedIndex == -1) return;

            string selectedCar = cmbCar.Text.Split('-')[0].Trim();

            using var db = new AppDbContext();
            var car = db.Cars.FirstOrDefault(c => c.CarName == selectedCar);
            if (car != null)
                txtRate.Text = car.RatePerDay.ToString();

            CalculateDaysAndCost();
        }

        private void CalculateDays()
        {
            if (dtpReturn.Value.Date > dtpRental.Value.Date)
            {
                TimeSpan difference = dtpReturn.Value.Date - dtpRental.Value.Date;
                int days = difference.Days;
                noDays.Text = days.ToString();
            }
            else if (dtpReturn.Value.Date == dtpRental.Value.Date)
            {
                noDays.Text = "1";
            }
            else
            {
                noDays.Text = "0";
            }
        }

        private void CalculateTotalCost()
        {
            if (string.IsNullOrWhiteSpace(txtRate.Text) || noDays.Text == "0")
            {
                txtTotalCost.Text = "TOTAL COST: ₱0.00";
                return;
            }

            try
            {
                double rate = Convert.ToDouble(txtRate.Text);
                int cars = Convert.ToInt32(nudCars.Value);
                int days = Convert.ToInt32(noDays.Text);

                totalCost = rate * cars * days;
                txtTotalCost.Text = "TOTAL COST: ₱" + totalCost.ToString("N2");
            }
            catch (Exception)
            {
                txtTotalCost.Text = "TOTAL COST: ₱0.00";
            }
        }

        private void CalculateDaysAndCost()
        {
            CalculateDays();
            CalculateTotalCost();
        }

        private void dtpRental_ValueChanged(object sender, EventArgs e)
        {
            CalculateDaysAndCost();
        }

        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {
            CalculateDaysAndCost();
        }

        private void nudCars_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (cmbCar.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a car.",
                    "No Car Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpReturn.Value.Date <= dtpRental.Value.Date)
            {
                MessageBox.Show(
                    "Return date must be after the rental date.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRate.Text))
            {
                MessageBox.Show(
                    "Rate could not be determined. Please reselect a car.",
                    "Rate Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            CalculateDays();

            if (Convert.ToInt32(noDays.Text) <= 0)
            {
                MessageBox.Show(
                    "Please ensure rental days are valid (Return date must be after Rental date).",
                    "Invalid Days",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            CalculateTotalCost();

            if (totalCost <= 0)
            {
                MessageBox.Show(
                    "Please ensure all rental details are valid.",
                    "Invalid Calculation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            tabControl1.TabPages[2].Enabled = true;
            tabControl1.SelectedIndex = 2;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        // ─── TAB 3: PAYMENT ──────────────────────────────────────────

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "No Payment Method",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text))
            {
                MessageBox.Show(
                    "Please enter the amount paid.",
                    "No Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtAmountPaid.Text, out double amountPaid))
            {
                MessageBox.Show(
                    "Please enter a valid numeric amount.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (amountPaid <= 0)
            {
                MessageBox.Show(
                    "Amount paid must be greater than zero.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (amountPaid < totalCost)
            {
                MessageBox.Show(
                    $"Insufficient payment.\n\nTotal Cost: ₱{totalCost:N2}\nAmount Paid: ₱{amountPaid:N2}\nShort by: ₱{(totalCost - amountPaid):N2}",
                    "Insufficient Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            double change = amountPaid - totalCost;
            int days = Convert.ToInt32(noDays.Text);

            try
            {
                using var db = new AppDbContext();

                db.Rentals.Add(new Rental
                {
                    Customer = txtFirstName.Text + " " + txtLastName.Text,
                    Car = cmbCar.Text,
                    Days = (dtpReturn.Value.Date - dtpRental.Value.Date).Days,
                    Total = (decimal)totalCost,
                    Status = "ACTIVE",
                });

                // ✅ I-update ang car status sa "Rented"
                string selectedCar = cmbCar.Text.Split('-')[0].Trim();
                var car = db.Cars.FirstOrDefault(c => c.CarName == selectedCar);
                if (car != null)
                {
                    car.Status = "Rented";
                }

                db.SaveChanges();

                MessageBox.Show($"'{cmbCar.Text}' is successfully rented. Thank you");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }

            MessageBox.Show(
                "✅ Payment Successful!\n\n" +
                $"Customer: {txtFirstName.Text} {txtLastName.Text}\n" +
                $"Car: {cmbCar.Text}\n" +
                $"Rental Date: {dtpRental.Value:MM/dd/yyyy}\n" +
                $"Return Date: {dtpReturn.Value:MM/dd/yyyy}\n" +
                $"No. of Cars: {nudCars.Value}\n" +
                $"No. of Days: {days}\n\n" +
                $"Payment Method: {cmbPaymentMethod.Text}\n" +
                $"Total Cost:   ₱{totalCost:N2}\n" +
                $"Amount Paid:  ₱{amountPaid:N2}\n" +
                $"Change:       ₱{change:N2}",
                "Payment Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearAll();
        }

        private void btnBackRental_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to cancel this transaction?",
                "Cancel Transaction",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Transaction cancelled.", "Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Logged out successfully.", "Logout",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        // ─── HELPERS ─────────────────────────────────────────────────

        private bool IsValidContact(string contact)
        {
            contact = contact.Trim();
            if (contact.Length != 11) return false;
            foreach (char c in contact)
                if (!char.IsDigit(c)) return false;
            return true;
        }

        private void ClearAll()
        {
            // Tab 1
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            // Tab 2 — ✅ Reload available cars
            cmbCar.Items.Clear();
            using var db = new AppDbContext();
            var availableCars = db.Cars.Where(c => c.Status == "Available").ToList();
            foreach (var car in availableCars)
            {
                cmbCar.Items.Add($"{car.CarName} - {car.Type}");
            }

            cmbCar.SelectedIndex = -1;
            nudCars.Value = 1;
            noDays.Text = "0";
            txtRate.Clear();
            txtTotalCost.Text = "TOTAL COST: ₱0.00";

            // Tab 3
            cmbPaymentMethod.SelectedIndex = -1;
            txtAmountPaid.Clear();

            totalCost = 0;

            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
            tabControl1.SelectedIndex = 0;
        }
    }
}