using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRentalLegaspi
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtboxUnSU.Text) ||
                string.IsNullOrWhiteSpace(txtboxLastNameSU.Text) ||
                string.IsNullOrWhiteSpace(txtboxCreatePassSU.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new AppDbContext();

                var username = txtboxUnSU.Text + " " + txtboxLastNameSU.Text;
                var password = txtboxCreatePassSU.Text;
                var role = "Customer";

                if (db.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("An account with that name already exists. Please try a different name..");
                    return;
                }

                db.Users.Add(new User
                {
                    Username = username,
                    Password = password,
                    Role = role
                });

                db.SaveChanges();

                MessageBox.Show($"Thank you for signing up, '{username}'!");

                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}