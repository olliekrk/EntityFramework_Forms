namespace EntityFrameworkForms
{
    partial class AddCategoryDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.backTile = new MetroFramework.Controls.MetroTile();
            this.submitTile = new MetroFramework.Controls.MetroTile();
            this.categoryNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.categoryNameLabel.Location = new System.Drawing.Point(14, 13);
            this.categoryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(174, 25);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "Enter category name:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.backTile);
            this.metroPanel1.Controls.Add(this.submitTile);
            this.metroPanel1.Controls.Add(this.categoryNameTextBox);
            this.metroPanel1.Controls.Add(this.descriptionTextBox);
            this.metroPanel1.Controls.Add(this.descriptionLabel);
            this.metroPanel1.Controls.Add(this.categoryNameLabel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(15, 60);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(270, 336);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // backTile
            // 
            this.backTile.ActiveControl = null;
            this.backTile.Location = new System.Drawing.Point(141, 278);
            this.backTile.Margin = new System.Windows.Forms.Padding(2);
            this.backTile.Name = "backTile";
            this.backTile.Size = new System.Drawing.Size(113, 43);
            this.backTile.Style = MetroFramework.MetroColorStyle.Red;
            this.backTile.TabIndex = 3;
            this.backTile.Text = "Go back";
            this.backTile.UseSelectable = true;
            this.backTile.Click += new System.EventHandler(this.backTile_Click);
            // 
            // submitTile
            // 
            this.submitTile.ActiveControl = null;
            this.submitTile.Location = new System.Drawing.Point(14, 278);
            this.submitTile.Margin = new System.Windows.Forms.Padding(2);
            this.submitTile.Name = "submitTile";
            this.submitTile.Size = new System.Drawing.Size(113, 43);
            this.submitTile.TabIndex = 2;
            this.submitTile.Text = "Add category";
            this.submitTile.UseSelectable = true;
            this.submitTile.Click += new System.EventHandler(this.submitTile_Click);
            // 
            // categoryNameTextBox
            // 
            // 
            // 
            // 
            this.categoryNameTextBox.CustomButton.Image = null;
            this.categoryNameTextBox.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.categoryNameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.categoryNameTextBox.CustomButton.Name = "";
            this.categoryNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.categoryNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categoryNameTextBox.CustomButton.TabIndex = 1;
            this.categoryNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categoryNameTextBox.CustomButton.UseSelectable = true;
            this.categoryNameTextBox.CustomButton.Visible = false;
            this.categoryNameTextBox.Lines = new string[] {
        "New category\'s name"};
            this.categoryNameTextBox.Location = new System.Drawing.Point(14, 50);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryNameTextBox.MaxLength = 32767;
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.PasswordChar = '\0';
            this.categoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categoryNameTextBox.SelectedText = "";
            this.categoryNameTextBox.SelectionLength = 0;
            this.categoryNameTextBox.SelectionStart = 0;
            this.categoryNameTextBox.ShortcutsEnabled = true;
            this.categoryNameTextBox.Size = new System.Drawing.Size(240, 30);
            this.categoryNameTextBox.TabIndex = 0;
            this.categoryNameTextBox.Text = "New category\'s name";
            this.categoryNameTextBox.UseSelectable = true;
            this.categoryNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.descriptionTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[] {
        "..."};
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 152);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(240, 109);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "...";
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.descriptionLabel.Location = new System.Drawing.Point(14, 113);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(143, 25);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Enter description:";
            // 
            // AddCategoryDialogForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 412);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCategoryDialogForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Add new category";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel categoryNameLabel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroTile submitTile;
        private MetroFramework.Controls.MetroTextBox categoryNameTextBox;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTile backTile;
    }
}