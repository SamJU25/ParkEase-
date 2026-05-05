namespace ParkEase
{
    partial class frmSignIn
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDontHaveAnAccount = new System.Windows.Forms.Label();
            this.lblSignInAs = new System.Windows.Forms.Label();
            this.cmbSignInUserAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.lblSignInPassword = new System.Windows.Forms.Label();
            this.txtSignInPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblSignInUsername = new System.Windows.Forms.Label();
            this.txtSignInUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.Controls.Add(this.lblDontHaveAnAccount);
            this.guna2Panel1.Controls.Add(this.lblSignInAs);
            this.guna2Panel1.Controls.Add(this.cmbSignInUserAdmin);
            this.guna2Panel1.Controls.Add(this.btnSignIn);
            this.guna2Panel1.Controls.Add(this.lblSignInPassword);
            this.guna2Panel1.Controls.Add(this.txtSignInPassword);
            this.guna2Panel1.Controls.Add(this.lblSignIn);
            this.guna2Panel1.Controls.Add(this.lblSignInUsername);
            this.guna2Panel1.Controls.Add(this.txtSignInUsername);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(105, 162);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(514, 579);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblDontHaveAnAccount
            // 
            this.lblDontHaveAnAccount.AutoSize = true;
            this.lblDontHaveAnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDontHaveAnAccount.Location = new System.Drawing.Point(162, 539);
            this.lblDontHaveAnAccount.Name = "lblDontHaveAnAccount";
            this.lblDontHaveAnAccount.Size = new System.Drawing.Size(177, 20);
            this.lblDontHaveAnAccount.TabIndex = 9;
            this.lblDontHaveAnAccount.Text = "Don\'t have an account?";
            this.lblDontHaveAnAccount.Click += new System.EventHandler(this.lblDontHaveAnAccount_Click);
            // 
            // lblSignInAs
            // 
            this.lblSignInAs.AutoSize = true;
            this.lblSignInAs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInAs.Location = new System.Drawing.Point(45, 102);
            this.lblSignInAs.Name = "lblSignInAs";
            this.lblSignInAs.Size = new System.Drawing.Size(106, 28);
            this.lblSignInAs.TabIndex = 7;
            this.lblSignInAs.Text = "Sign In As";
            // 
            // cmbSignInUserAdmin
            // 
            this.cmbSignInUserAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cmbSignInUserAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbSignInUserAdmin.BorderRadius = 5;
            this.cmbSignInUserAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSignInUserAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignInUserAdmin.FillColor = System.Drawing.Color.LightGray;
            this.cmbSignInUserAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSignInUserAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSignInUserAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSignInUserAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSignInUserAdmin.ItemHeight = 30;
            this.cmbSignInUserAdmin.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbSignInUserAdmin.Location = new System.Drawing.Point(50, 133);
            this.cmbSignInUserAdmin.Name = "cmbSignInUserAdmin";
            this.cmbSignInUserAdmin.Size = new System.Drawing.Size(423, 36);
            this.cmbSignInUserAdmin.StartIndex = 0;
            this.cmbSignInUserAdmin.TabIndex = 6;
            this.cmbSignInUserAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BorderRadius = 5;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.Indigo;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = global::Login.Properties.Resources.Image_Login_White;
            this.btnSignIn.Location = new System.Drawing.Point(166, 465);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(180, 45);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSignInPassword
            // 
            this.lblSignInPassword.AutoSize = true;
            this.lblSignInPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInPassword.Location = new System.Drawing.Point(50, 331);
            this.lblSignInPassword.Name = "lblSignInPassword";
            this.lblSignInPassword.Size = new System.Drawing.Size(101, 28);
            this.lblSignInPassword.TabIndex = 4;
            this.lblSignInPassword.Text = "Password";
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.BorderRadius = 5;
            this.txtSignInPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignInPassword.DefaultText = "";
            this.txtSignInPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSignInPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSignInPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignInPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignInPassword.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSignInPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignInPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInPassword.ForeColor = System.Drawing.Color.Black;
            this.txtSignInPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignInPassword.Location = new System.Drawing.Point(50, 364);
            this.txtSignInPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.PasswordChar = '*';
            this.txtSignInPassword.PlaceholderForeColor = System.Drawing.Color.SlateGray;
            this.txtSignInPassword.PlaceholderText = "Enter Your Password";
            this.txtSignInPassword.SelectedText = "";
            this.txtSignInPassword.Size = new System.Drawing.Size(423, 60);
            this.txtSignInPassword.TabIndex = 3;
            this.txtSignInPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(191, 17);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(124, 45);
            this.lblSignIn.TabIndex = 2;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblSignInUsername
            // 
            this.lblSignInUsername.AutoSize = true;
            this.lblSignInUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInUsername.Location = new System.Drawing.Point(50, 217);
            this.lblSignInUsername.Name = "lblSignInUsername";
            this.lblSignInUsername.Size = new System.Drawing.Size(106, 28);
            this.lblSignInUsername.TabIndex = 1;
            this.lblSignInUsername.Text = "Username";
            // 
            // txtSignInUsername
            // 
            this.txtSignInUsername.BorderRadius = 5;
            this.txtSignInUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignInUsername.DefaultText = "";
            this.txtSignInUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSignInUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSignInUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignInUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignInUsername.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSignInUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignInUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInUsername.ForeColor = System.Drawing.Color.Black;
            this.txtSignInUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignInUsername.Location = new System.Drawing.Point(50, 249);
            this.txtSignInUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignInUsername.Name = "txtSignInUsername";
            this.txtSignInUsername.PlaceholderForeColor = System.Drawing.Color.SlateGray;
            this.txtSignInUsername.PlaceholderText = "Enter Your Name";
            this.txtSignInUsername.SelectedText = "";
            this.txtSignInUsername.Size = new System.Drawing.Size(423, 53);
            this.txtSignInUsername.TabIndex = 0;
            this.txtSignInUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSignInUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Login.Properties.Resources.logo;
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.Location = new System.Drawing.Point(198, 70);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(326, 75);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(728, 844);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtSignInUsername;
        private System.Windows.Forms.Label lblSignInUsername;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblSignInPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtSignInPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSignInUserAdmin;
        private System.Windows.Forms.Label lblSignInAs;
        private System.Windows.Forms.Label lblDontHaveAnAccount;
    }
}

