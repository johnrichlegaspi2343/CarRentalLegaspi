using CarRentalLegaspi;

namespace CarRentalLegaspi
{
    public partial class LoginForm : Form
    {
        // Hardcoded users — replace with DB later
        private readonly Dictionary<string, string> users = new()
        {
            { "admin",    "admin123" },
            { "clerk01",  "clerk123" },
            { "customer", "1234"     }
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdCustomer.Checked)
            {
                if (users.TryGetValue(username, out var pass) && pass == password
                    && username == "customer")
                {
                    OpenForm(new CustomerForm());
                }
                else
                {
                    ShowError();
                }
            }
            else if (rdAdmin.Checked)
            {
                if (username == "admin" && users.TryGetValue(username, out var pass)
                    && pass == password)
                {
                    OpenForm(new AdminForm());
                }
                else
                {
                    ShowError();
                }
            }
            else if (rdManager.Checked)
            {
                if (username == "clerk01" && users.TryGetValue(username, out var pass)
                    && pass == password)
                {
                    OpenForm(new ClerkForm());
                }
                else
                {
                    ShowError();
                }
            }
            else
            {
                MessageBox.Show("Please select a role.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void ShowError()
        {
            MessageBox.Show("Invalid username or password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
            txtPassword.Focus();
        }
    }
}