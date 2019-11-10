using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework;

namespace EntityFrameworkForms
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        ProdContext context = new ProdContext();

        private bool customersSaveMode;
        private Customer customerToModify;
        private Category selectedCategory;


        public DashboardForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new ProdContext();
            context.Categories.Load();
            context.Products.Load();
            context.Customers.Load();
            context.Orders.Load();
            this.categoryBindingSource.DataSource = context.Categories.Local.ToBindingList();
            this.productsBindingSource.DataSource = context.Products.Local.ToBindingList();
            this.customerBindingSource.DataSource = context.Customers.Local.ToBindingList();
            this.orderBindingSource.DataSource = context.Orders.Local.ToBindingList();
            customersClear();
            repaintChart();
        }

        // PRODUCTS TAB

        private void categoriesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = (Category)this.categoriesGridView.Rows[e.RowIndex]?.DataBoundItem;

            //this.productsBindingSource.DataSource = context
            //    .Products
            //    .Local
            //    .ToBindingList()
            //    .Where(p => p.CategoryId == selectedCategory.CategoryId);

            //this.productsBindingSource.DataSource = (from p in context.Products
            //                                         where p.CategoryId == selectedCategory.CategoryId
            //                                         select p);
        }

        private void productsGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Product productToAdd = (Product)productsGridView.Rows[e.RowIndex]?.DataBoundItem;
            if (productToAdd != null && selectedCategory != null)
            {
                productToAdd.CategoryId = selectedCategory.CategoryId;
                context.Products.Add(productToAdd);
                context.SaveChanges();
                productsGridView.Refresh();
            }       
        }

        // ORDERS TAB

        private void validateOrderInput(object sender, EventArgs e)
        {
            this.orderButton.Enabled = isOrderValid();
        }

        private bool isOrderValid()
        {
            return this.customerCombo.SelectedValue != null && this.productCombo.SelectedValue != null && this.quantityInput.Value > 0;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (isOrderValid())
            {
                Order ord = new Order();
                ord.CustomerName = (String)this.customerCombo.SelectedValue;
                ord.Quantity = (int)this.quantityInput.Value;
                ord.ProductID = (int)this.productCombo.SelectedValue;

                context.Orders.Add(ord);
                context.SaveChanges();
                showSuccessMessageBox("New order added.");
            }
            else
            {
                this.orderButton.Enabled = false;
            }
        }

        private void categoryCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.categoryCombo.SelectedValue != null)
            {
                int catId = (int)this.categoryCombo.SelectedValue;
                this.productCombo.DataSource = (from p in context.Products where p.CategoryId == catId select p).ToList();
            }
            else
            {
                this.productCombo.DataSource = new BindingList<Product>();
            }
            this.productCombo.SelectedIndex = -1;
        }

        private void productCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.productCombo.SelectedValue != null)
            {
                int ProductID = (int)this.productCombo.SelectedValue;
                Product p = (Product)this.context.Products.Find(ProductID);

                this.quantityInput.Maximum = p.UnitsInStock;
            }

        }

        private void customerCombo_DropDown(object sender, EventArgs e)
        {
            this.customerCombo.DataSource = context.Customers.Local.ToBindingList();
        }

        // CUSTOMERS TAB
        private void customerInput_TextChanged(object sender, EventArgs e)
        {
            customersValidateSaveButton();
        }

        private void customersSaveButton_Click(object sender, EventArgs e)
        {
            var companyNameArg = customerCompanyName.Text.Trim();
            var descriptionArg = customerDescription.Text.Trim();
            var passwordArg = customerPassword.Text;

            try
            {
                if (customersSaveMode)
                {
                    customerToModify = new Customer
                    {
                        CompanyName = companyNameArg,
                        Description = descriptionArg,
                        Password = passwordArg,
                    };
                    if (context.Customers.Any(c => c.CompanyName == companyNameArg))
                    {
                        showErrorMessageBox("Company name is already taken.");
                    }
                    else
                    {
                        context.Customers.Add(customerToModify);
                        showSuccessMessageBox("Customer added.");
                    }
                }
                else
                {
                    customerToModify.CompanyName = companyNameArg;
                    customerToModify.Description = descriptionArg;
                    customerToModify.Password = passwordArg;
                    context.Entry(customerToModify).State = EntityState.Modified;
                    showSuccessMessageBox("Customer updated.");
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                showErrorMessageBox();
                Console.WriteLine("Exception while saving customer: " + ex.Message);
            }

            customersGridView.Refresh();
            customersClear();
        }

        private void customersClearButton_Click(object sender, EventArgs e)
        {
            customersClear();
        }

        private void customersDeleteButton_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure to delete this customer?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                context.Customers.Remove(customerToModify);
                context.SaveChanges();
                customersGridView.Refresh();
                customersClear();
                showSuccessMessageBox("Customer deleted successfully.");
            }
        }

        private void customersGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            customerToModify = (Customer)customersGridView.Rows[row].DataBoundItem;

            //customerToModify = context.Customers
            //    .Where(x => x.CompanyName == customer.CompanyName)
            //    .FirstOrDefault();

            customerCompanyName.Text = customerToModify.CompanyName;
            customerDescription.Text = customerToModify.Description;
            customersSwitchSaveButton(false);
        }

        private void customersSwitchSaveButton(bool saveMode)
        {
            customersSaveMode = saveMode;
            if (saveMode)
            {
                customersSaveButton.Text = "Save";
            }
            else
            {
                customersSaveButton.Text = "Update";
            }
            customersValidateSaveButton();
        }

        private void customersClear()
        {
            customerCompanyName.Text = customerDescription.Text = customerPassword.Text = "";
            customersSwitchSaveButton(true);
        }

        private void customersValidateSaveButton()
        {
            customersSaveButton.Enabled =
                customerCompanyName.Text.Trim().Length > 0
                && customerDescription.Text.Trim().Length > 0
                && customerPassword.Text.Length > 0;
        }

        // GENERAL 

        public void SaveEverythingAndReload()
        {
            context.SaveChanges();
            showSuccessMessageBox();

            categoriesGridView.Refresh();
            productsGridView.Refresh();
            ordersGridView.Refresh();
            customersGridView.Refresh();

            repaintChart();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            SaveEverythingAndReload();
        }

        private void showSuccessMessageBox(string additionalMessage = "")
        {
            MetroMessageBox.Show(this,
                "Changes saved succesfully. " + additionalMessage,
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void showErrorMessageBox(string additionalMessage = "")
        {
            MetroMessageBox.Show(this,
                "An error has occured. " + additionalMessage,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        // STATISTICS CHART

        private void repaintChart()
        {
            var dataXY = from o in context.Orders
                         group o by o.Customer into oc
                         select new
                         {
                             xCustomer = oc.Key,
                             yOrders = oc.Count()
                         };

            Series chartSeries = this.statisticsCustomersOrdersChart.Series[0];
            chartSeries.Points.Clear();

            foreach (var xy in dataXY)
            {
                chartSeries.Points.AddXY(xy.xCustomer.CompanyName, xy.yOrders);
            }
        }

        // OPEN ADD CATEGORY FORM

        private void openCategoryFormButton_Click(object sender, EventArgs e)
        {
            new AddCategoryDialogForm
            {
                SaveChanges = this.SaveEverythingAndReload,
                ctx = this.context
            }
            .ShowDialog();
        }
    }
}