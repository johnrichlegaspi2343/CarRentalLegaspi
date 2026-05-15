namespace CarRentalSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (rdCustomer.Checked)
            {
                // Basic validation (replace with DB check later)
                if (username == "customer" && password == "1234")
                {
                    CustomerForm customer = new CustomerForm();
                    customer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdAdmin.Checked)
            {
                // Open AdminForm here later
            }
            else if (rdManager.Checked)
            {
                // Open ClerkForm here later
                MessageBox.Show("Clerk panel coming soon.");
            }
        }
    }
}
