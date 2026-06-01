using Microsoft.EntityFrameworkCore;

namespace CarRentalLegaspi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;  // Para sa Enter key
        }

        // ITO NA ANG BAGONG TAMANG PANGALAN: btnLogin_Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdAdmin.Checked && !rdCustomer.Checked && !rdClerk.Checked)
            {
                MessageBox.Show("Please select a role.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new AppDbContext();

                string expectedRole = rdAdmin.Checked ? "Admin"
                                     : rdClerk.Checked ? "Clerk"
                                     : "Customer";

                var user = db.Users.FirstOrDefault(u =>
                    u.Username == username &&
                    u.Password == password &&
                    u.Role == expectedRole);

                if (user == null) { ShowError(); return; }

                if (user.Role == "Admin") OpenForm(new AdminForm());
                else if (user.Role == "Clerk") OpenForm(new ClerkForm());
                else OpenForm(new CustomerForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ENTER KEY FEATURE
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, e);  // Tawagin ang bagong function
            }
        }

        private void OpenForm(Form form) { form.Show(); Hide(); }

        private void ShowError()
        {
            MessageBox.Show("Invalid username, password, or role.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear(); txtPassword.Focus();
        }

        private void lnklCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
        }
    }
}