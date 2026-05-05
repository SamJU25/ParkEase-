namespace ParkEase
{
    partial class frmSignUp
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
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSignUpAs = new System.Windows.Forms.Label();
            this.cmbSignUpUserAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.txtSignUpPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblSignUpUsername = new System.Windows.Forms.Label();
            this.txtSignUpUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Login.Properties.Resources.logo;
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.Location = new System.Drawing.Point(194, 71);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(326, 75);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.lblSignUpAs);
            this.guna2Panel1.Controls.Add(this.cmbSignUpUserAdmin);
            this.guna2Panel1.Controls.Add(this.btnSignUp);
            this.guna2Panel1.Controls.Add(this.lblSignUpPassword);
            this.guna2Panel1.Controls.Add(this.txtSignUpPassword);
            this.guna2Panel1.Controls.Add(this.lblSignUp);
            this.guna2Panel1.Controls.Add(this.lblSignUpUsername);
            this.guna2Panel1.Controls.Add(this.txtSignUpUsername);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(101, 163);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(514, 579);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblSignUpAs
            // 
            this.lblSignUpAs.AutoSize = true;
            this.lblSignUpAs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpAs.Location = new System.Drawing.Point(45, 102);
            this.lblSignUpAs.Name = "lblSignUpAs";
            this.lblSignUpAs.Size = new System.Drawing.Size(114, 28);
            this.lblSignUpAs.TabIndex = 7;
            this.lblSignUpAs.Text = "Sign Up As";
            // 
            // cmbSignUpUserAdmin
            // 
            this.cmbSignUpUserAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cmbSignUpUserAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbSignUpUserAdmin.BorderRadius = 5;
            this.cmbSignUpUserAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSignUpUserAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignUpUserAdmin.FillColor = System.Drawing.Color.LightGray;
            this.cmbSignUpUserAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSignUpUserAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSignUpUserAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSignUpUserAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSignUpUserAdmin.ItemHeight = 30;
            this.cmbSignUpUserAdmin.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbSignUpUserAdmin.Location = new System.Drawing.Point(50, 133);
            this.cmbSignUpUserAdmin.Name = "cmbSignUpUserAdmin";
            this.cmbSignUpUserAdmin.Size = new System.Drawing.Size(423, 36);
            this.cmbSignUpUserAdmin.StartIndex = 0;
            this.cmbSignUpUserAdmin.TabIndex = 6;
            this.cmbSignUpUserAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BorderRadius = 5;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.Indigo;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(166, 465);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(180, 45);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpPassword.Location = new System.Drawing.Point(50, 331);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(101, 28);
            this.lblSignUpPassword.TabIndex = 4;
            this.lblSignUpPassword.Text = "Password";
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.BorderRadius = 5;
            this.txtSignUpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignUpPassword.DefaultText = "";
            this.txtSignUpPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSignUpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSignUpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignUpPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignUpPassword.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSignUpPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignUpPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpPassword.ForeColor = System.Drawing.Color.Black;
            this.txtSignUpPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignUpPassword.Location = new System.Drawing.Point(50, 364);
            this.txtSignUpPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.PasswordChar = '*';
            this.txtSignUpPassword.PlaceholderForeColor = System.Drawing.Color.SlateGray;
            this.txtSignUpPassword.PlaceholderText = "Enter Your Password";
            this.txtSignUpPassword.SelectedText = "";
            this.txtSignUpPassword.Size = new System.Drawing.Size(423, 60);
            this.txtSignUpPassword.TabIndex = 3;
            this.txtSignUpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(194, 27);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(138, 45);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.Text = "Sign Up";
            // 
            // lblSignUpUsername
            // 
            this.lblSignUpUsername.AutoSize = true;
            this.lblSignUpUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpUsername.Location = new System.Drawing.Point(50, 217);
            this.lblSignUpUsername.Name = "lblSignUpUsername";
            this.lblSignUpUsername.Size = new System.Drawing.Size(106, 28);
            this.lblSignUpUsername.TabIndex = 1;
            this.lblSignUpUsername.Text = "Username";
            // 
            // txtSignUpUsername
            // 
            this.txtSignUpUsername.BorderRadius = 5;
            this.txtSignUpUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignUpUsername.DefaultText = "";
            this.txtSignUpUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSignUpUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSignUpUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignUpUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignUpUsername.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSignUpUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignUpUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpUsername.ForeColor = System.Drawing.Color.Black;
            this.txtSignUpUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignUpUsername.Location = new System.Drawing.Point(50, 249);
            this.txtSignUpUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpUsername.Name = "txtSignUpUsername";
            this.txtSignUpUsername.PlaceholderForeColor = System.Drawing.Color.SlateGray;
            this.txtSignUpUsername.PlaceholderText = "Enter Your Name";
            this.txtSignUpUsername.SelectedText = "";
            this.txtSignUpUsername.Size = new System.Drawing.Size(423, 53);
            this.txtSignUpUsername.TabIndex = 0;
            this.txtSignUpUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 5;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Indigo;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(166, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 45);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(728, 844);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblSignUpAs;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSignUpUserAdmin;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private System.Windows.Forms.Label lblSignUpPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtSignUpPassword;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblSignUpUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtSignUpUsername;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}