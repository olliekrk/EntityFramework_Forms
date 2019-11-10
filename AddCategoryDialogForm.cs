using MetroFramework;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkForms
{
    public delegate void saveChangesDelegate();

    public partial class AddCategoryDialogForm : MetroFramework.Forms.MetroForm
    {
        public saveChangesDelegate SaveChanges;
        internal ProdContext ctx { get; set; }

        public AddCategoryDialogForm()
        {
            InitializeComponent();
        }

        private void submitTile_Click(object sender, EventArgs e)
        {
            Category categoryToAdd = new Category
            {
                Name = this.categoryNameTextBox.Text.Trim(),
                Description = this.descriptionTextBox.Text.Trim(),
            };

            var categoryExists = ctx.Categories.Any(c => c.Name == categoryToAdd.Name);
            if (!categoryExists)
            {
                ctx.Categories.Add(categoryToAdd);
                ctx.SaveChanges();
                this.SaveChanges?.Invoke();
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Category already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backTile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
