using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;

namespace EntityFrameworkForms
{
    public partial class AuthorizationForm : MetroFramework.Forms.MetroForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void logInTile_Click(object sender, EventArgs e)
        {
            var customerName = companyNameTextBox.Text.Trim();
            var customerPassword = passwordTextBox.Text;
            using (var ctx = new ProdContext())
            {
                var customerToAuthorize = ctx.Customers.Where(c => c.CompanyName == customerName);
                if (customerToAuthorize.Count() > 0 && customerToAuthorize.First().Password == customerPassword)
                {
                    this.Hide();
                    new DashboardForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    showInvalidCredentialsMessageBox("Invalid company name or password.");
                }
            }
        }

        private void registerTile_Click(object sender, EventArgs e)
        {
            var customerToRegister = new Customer()
            {
                CompanyName = companyNameTextBox.Text.Trim(),
                Password = passwordTextBox.Text
            };
            using (var ctx = new ProdContext())
            {
                var nameAvailable = ctx.Customers.Where(c => c.CompanyName == customerToRegister.CompanyName).Count() == 0;

                if (nameAvailable)
                {
                    ctx.Customers.Add(customerToRegister);
                    ctx.SaveChanges();

                    this.Hide();
                    new DashboardForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    showInvalidCredentialsMessageBox("Company name is already taken.");
                }
            }
        }

        private void showInvalidCredentialsMessageBox(string message)
        {
            passwordTextBox.Clear();

            MetroMessageBox.Show(
                this,
                message,
                "Failure!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop
                );
        }
    }
}
