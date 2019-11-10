namespace EntityFrameworkForms
{
    partial class AuthorizationForm
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.logInLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.companyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.logInTile = new MetroFramework.Controls.MetroTile();
            this.registerTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // logInLabel
            // 
            this.logInLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logInLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.logInLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.logInLabel.Location = new System.Drawing.Point(20, 60);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(260, 60);
            this.logInLabel.TabIndex = 0;
            this.logInLabel.Text = "Welcome!";
            this.logInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 150);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(113, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Company Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 223);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // companyNameTextBox
            // 
            // 
            // 
            // 
            this.companyNameTextBox.CustomButton.Image = null;
            this.companyNameTextBox.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.companyNameTextBox.CustomButton.Name = "";
            this.companyNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.companyNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.companyNameTextBox.CustomButton.TabIndex = 1;
            this.companyNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.companyNameTextBox.CustomButton.UseSelectable = true;
            this.companyNameTextBox.CustomButton.Visible = false;
            this.companyNameTextBox.Lines = new string[0];
            this.companyNameTextBox.Location = new System.Drawing.Point(17, 173);
            this.companyNameTextBox.MaxLength = 32767;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.PasswordChar = '\0';
            this.companyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.companyNameTextBox.SelectedText = "";
            this.companyNameTextBox.SelectionLength = 0;
            this.companyNameTextBox.SelectionStart = 0;
            this.companyNameTextBox.ShortcutsEnabled = true;
            this.companyNameTextBox.Size = new System.Drawing.Size(257, 23);
            this.companyNameTextBox.TabIndex = 0;
            this.companyNameTextBox.UseSelectable = true;
            this.companyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.companyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(20, 246);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(257, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // logInTile
            // 
            this.logInTile.ActiveControl = null;
            this.logInTile.ForeColor = System.Drawing.Color.Black;
            this.logInTile.Location = new System.Drawing.Point(20, 329);
            this.logInTile.Name = "logInTile";
            this.logInTile.Size = new System.Drawing.Size(125, 48);
            this.logInTile.TabIndex = 2;
            this.logInTile.Text = "Log In";
            this.logInTile.UseSelectable = true;
            this.logInTile.Click += new System.EventHandler(this.logInTile_Click);
            // 
            // registerTile
            // 
            this.registerTile.ActiveControl = null;
            this.registerTile.Location = new System.Drawing.Point(149, 329);
            this.registerTile.Name = "registerTile";
            this.registerTile.Size = new System.Drawing.Size(125, 48);
            this.registerTile.TabIndex = 3;
            this.registerTile.Text = "Register";
            this.registerTile.UseSelectable = true;
            this.registerTile.Click += new System.EventHandler(this.registerTile_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.registerTile);
            this.Controls.Add(this.logInTile);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logInLabel);
            this.Name = "AuthorizationForm";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel logInLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox companyNameTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroTile logInTile;
        private MetroFramework.Controls.MetroTile registerTile;
    }
}
