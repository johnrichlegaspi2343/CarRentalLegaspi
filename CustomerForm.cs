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
            // Cars
            cmbCar.Items.Add("Toyota Vios - Sedan");
            cmbCar.Items.Add("Honda City - Sedan");
            cmbCar.Items.Add("Mitsubishi Montero - SUV");
            cmbCar.Items.Add("Toyota Fortuner - SUV");
            cmbCar.Items.Add("Toyota Hiace - Van");
            cmbCar.Items.Add("Ford Ranger - Pickup Truck");

            // Payment Methods
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("GCash");

            nudCars.Minimum = 1;
            nudCars.Value = 1;

            txtTotalCost.Text = "TOTAL COST: ₱0.00";

            // Initialize noDays Label
            noDays.Text = "0";

            // Lock tabs — user must go through steps
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

            // Basic email format check
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Basic contact number check (must be numeric, 11 digits)
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

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCar.Text)
            {
                case "Toyota Vios - Sedan": txtRate.Text = "1500"; break;
                case "Honda City - Sedan": txtRate.Text = "1800"; break;
                case "Mitsubishi Montero - SUV": txtRate.Text = "3500"; break;
                case "Toyota Fortuner - SUV": txtRate.Text = "4000"; break;
                case "Toyota Hiace - Van": txtRate.Text = "4500"; break;
                case "Ford Ranger - Pickup Truck": txtRate.Text = "3800"; break;
                default: txtRate.Text = ""; break;
            }
            // Recalculate when car selection changes
            CalculateDaysAndCost();
        }

        // METHOD: Calculate days between rental and return dates
        private void CalculateDays()
        {
            if (dtpReturn.Value.Date > dtpRental.Value.Date)
            {
                TimeSpan difference = dtpReturn.Value.Date - dtpRental.Value.Date;
                int days = difference.Days;
                noDays.Text = days.ToString(); // Display in Label
            }
            else if (dtpReturn.Value.Date == dtpRental.Value.Date)
            {
                noDays.Text = "1"; // Minimum 1 day rental
            }
            else
            {
                noDays.Text = "0";
            }
        }

        // METHOD: Calculate total cost based on days, rate, and number of cars
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
                int days = Convert.ToInt32(noDays.Text); // Get days from Label

                totalCost = rate * cars * days;
                txtTotalCost.Text = "TOTAL COST: ₱" + totalCost.ToString("N2");
            }
            catch (Exception)
            {
                txtTotalCost.Text = "TOTAL COST: ₱0.00";
            }
        }

        // METHOD: Combined calculation for both days and cost
        private void CalculateDaysAndCost()
        {
            CalculateDays();
            CalculateTotalCost();
        }

        // Event handler for Rental Date change
        private void dtpRental_ValueChanged(object sender, EventArgs e)
        {
            CalculateDaysAndCost();
        }

        // Event handler for Return Date change
        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {
            CalculateDaysAndCost();
        }

        // Event handler for Number of Cars change
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

            // Make sure days are calculated
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

            // Ensure total cost is updated
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

            // Tab 2
            cmbCar.SelectedIndex = -1;
            nudCars.Value = 1;
            noDays.Text = "0"; // Reset Label
            txtRate.Clear();
            txtTotalCost.Text = "TOTAL COST: ₱0.00";

            // Tab 3
            cmbPaymentMethod.SelectedIndex = -1;
            txtAmountPaid.Clear();

            totalCost = 0;

            // Lock tabs again and go back to start
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
            tabControl1.SelectedIndex = 0;
        }
    }
}