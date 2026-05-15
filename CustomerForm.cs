using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalLegaspi
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            cmbCar.Items.Add("Toyota Vios - Sedan");
            cmbCar.Items.Add("Honda City - Sedan");
            cmbCar.Items.Add("Mitsubishi Montero - SUV");
            cmbCar.Items.Add("Toyota Fortuner - SUV");
            cmbCar.Items.Add("Toyota Hiace - Van");
            cmbCar.Items.Add("Ford Ranger - Pickup Truck");

            // Payment Methods
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("GCash");
            cmbPaymentMethod.Items.Add("Credit Card");

            nudCars.Minimum = 1;
            nudDays.Minimum = 1;

            txtTotalCost.Text = "TOTAL COST: ₱0.00";
        }

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCar.Text == "Toyota Vios - Sedan")
            {
                txtRate.Text = "1500";
            }
            else if (cmbCar.Text == "Honda City - Sedan")
            {
                txtRate.Text = "1800";
            }
            else if (cmbCar.Text == "Mitsubishi Montero - SUV")
            {
                txtRate.Text = "3500";
            }
            else if (cmbCar.Text == "Toyota Fortuner - SUV")
            {
                txtRate.Text = "4000";
            }
            else if (cmbCar.Text == "Toyota Hiace - Van")
            {
                txtRate.Text = "4500";
            }
            else if (cmbCar.Text == "Ford Ranger - Pickup Truck")
            {
                txtRate.Text = "3800";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" ||
               txtLastName.Text == "" ||
               txtContact.Text == "" ||
               txtEmail.Text == "" ||
               txtAddress.Text == "")
            {
                MessageBox.Show("Please complete customer details.");
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        double totalCost = 0;

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (cmbCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.");
                return;
            }

            double rate = Convert.ToDouble(txtRate.Text);

            int cars = Convert.ToInt32(nudCars.Value);
            int days = Convert.ToInt32(nudDays.Value);

            totalCost = rate * cars * days;

            txtTotalCost.Text = "TOTAL COST: ₱" + totalCost.ToString("N2");

            tabControl1.SelectedIndex = 2;
        }

        private void btnBackRental_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnBackPayment_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            if (txtAmountPaid.Text == "")
            {
                MessageBox.Show("Please enter amount paid.");
                return;
            }

            double amountPaid;

            if (!double.TryParse(txtAmountPaid.Text, out amountPaid))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            if (amountPaid < totalCost)
            {
                MessageBox.Show("Insufficient payment.");
                return;
            }

            double change = amountPaid - totalCost;

            MessageBox.Show(
                "Payment Successful!\n\n" +
                "Payment Method: " + cmbPaymentMethod.Text +
                "\nTotal Cost: ₱" + totalCost.ToString("N2") +
                "\nAmount Paid: ₱" + amountPaid.ToString("N2") +
                "\nChange: ₱" + change.ToString("N2"));

            ClearAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Cancelled.");

            ClearAll();
        }

        private void ClearAll()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            cmbCar.SelectedIndex = -1;

            nudCars.Value = 1;
            nudDays.Value = 1;

            txtRate.Clear();

            cmbPaymentMethod.SelectedIndex = -1;

            txtAmountPaid.Clear(); 

            txtTotalCost.Text = "TOTAL COST: ₱0.00";

            tabControl1.SelectedIndex = 0;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Logged out successfully.");

                // Close current form
                this.Hide();

                // Open Login Form
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
