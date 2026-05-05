namespace ParkEase
{
    partial class frmUserSettings
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
            this.btnLogOutUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserParkingHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserMyVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserAvailableSlots = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.picboxAdmin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picboxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInfoLastSaved = new System.Windows.Forms.Label();
            this.lblInfoStatus = new System.Windows.Forms.Label();
            this.lblInfoRole = new System.Windows.Forms.Label();
            this.lblInfoPhone = new System.Windows.Forms.Label();
            this.lblInfoEmail = new System.Windows.Forms.Label();
            this.lblInfoDisplayName = new System.Windows.Forms.Label();
            this.lblInfoUsername = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnLogOutUser);
            this.guna2Panel1.Controls.Add(this.btnUserSettings);
            this.guna2Panel1.Controls.Add(this.btnUserPayment);
            this.guna2Panel1.Controls.Add(this.btnUserParkingHistory);
            this.guna2Panel1.Controls.Add(this.btnUserMyVehicles);
            this.guna2Panel1.Controls.Add(this.btnUserAvailableSlots);
            this.guna2Panel1.Controls.Add(this.btnUserDashboard);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(345, 744);
            this.guna2Panel1.TabIndex = 38;
            // 
            // btnLogOutUser
            // 
            this.btnLogOutUser.BorderRadius = 5;
            this.btnLogOutUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOutUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOutUser.FillColor = System.Drawing.Color.Indigo;
            this.btnLogOutUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOutUser.ForeColor = System.Drawing.Color.White;
            this.btnLogOutUser.Image = global::Login.Properties.Resources.icon_logout;
            this.btnLogOutUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOutUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOutUser.Location = new System.Drawing.Point(11, 668);
            this.btnLogOutUser.Name = "btnLogOutUser";
            this.btnLogOutUser.Size = new System.Drawing.Size(322, 64);
            this.btnLogOutUser.TabIndex = 7;
            this.btnLogOutUser.Text = "Log Out";
            this.btnLogOutUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOutUser.Click += new System.EventHandler(this.btnLogOutUser_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BorderRadius = 5;
            this.btnUserSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserSettings.FillColor = System.Drawing.Color.Indigo;
            this.btnUserSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Image = global::Login.Properties.Resources.icon_settings;
            this.btnUserSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserSettings.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserSettings.Location = new System.Drawing.Point(11, 368);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(322, 64);
            this.btnUserSettings.TabIndex = 6;
            this.btnUserSettings.Text = "Settings";
            this.btnUserSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUserPayment
            // 
            this.btnUserPayment.BorderRadius = 5;
            this.btnUserPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserPayment.FillColor = System.Drawing.Color.Indigo;
            this.btnUserPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserPayment.ForeColor = System.Drawing.Color.White;
            this.btnUserPayment.Image = global::Login.Properties.Resources.icon_payment;
            this.btnUserPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserPayment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserPayment.Location = new System.Drawing.Point(11, 298);
            this.btnUserPayment.Name = "btnUserPayment";
            this.btnUserPayment.Size = new System.Drawing.Size(322, 64);
            this.btnUserPayment.TabIndex = 5;
            this.btnUserPayment.Text = "Payment";
            this.btnUserPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserPayment.Click += new System.EventHandler(this.btnUserPayment_Click);
            // 
            // btnUserParkingHistory
            // 
            this.btnUserParkingHistory.BorderRadius = 5;
            this.btnUserParkingHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserParkingHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserParkingHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserParkingHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserParkingHistory.FillColor = System.Drawing.Color.Indigo;
            this.btnUserParkingHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserParkingHistory.ForeColor = System.Drawing.Color.White;
            this.btnUserParkingHistory.Image = global::Login.Properties.Resources.icon_history;
            this.btnUserParkingHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserParkingHistory.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserParkingHistory.Location = new System.Drawing.Point(11, 228);
            this.btnUserParkingHistory.Name = "btnUserParkingHistory";
            this.btnUserParkingHistory.Size = new System.Drawing.Size(322, 64);
            this.btnUserParkingHistory.TabIndex = 4;
            this.btnUserParkingHistory.Text = "Parking History";
            this.btnUserParkingHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserParkingHistory.Click += new System.EventHandler(this.btnUserParkingHistory_Click);
            // 
            // btnUserMyVehicles
            // 
            this.btnUserMyVehicles.BorderRadius = 5;
            this.btnUserMyVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserMyVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserMyVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserMyVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserMyVehicles.FillColor = System.Drawing.Color.Indigo;
            this.btnUserMyVehicles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserMyVehicles.ForeColor = System.Drawing.Color.White;
            this.btnUserMyVehicles.Image = global::Login.Properties.Resources.icon_vehicle;
            this.btnUserMyVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserMyVehicles.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserMyVehicles.Location = new System.Drawing.Point(12, 88);
            this.btnUserMyVehicles.Name = "btnUserMyVehicles";
            this.btnUserMyVehicles.Size = new System.Drawing.Size(322, 64);
            this.btnUserMyVehicles.TabIndex = 3;
            this.btnUserMyVehicles.Text = "My Vehicles";
            this.btnUserMyVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserMyVehicles.Click += new System.EventHandler(this.btnUserMyVehicles_Click);
            // 
            // btnUserAvailableSlots
            // 
            this.btnUserAvailableSlots.BorderRadius = 5;
            this.btnUserAvailableSlots.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserAvailableSlots.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserAvailableSlots.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserAvailableSlots.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserAvailableSlots.FillColor = System.Drawing.Color.Indigo;
            this.btnUserAvailableSlots.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserAvailableSlots.ForeColor = System.Drawing.Color.White;
            this.btnUserAvailableSlots.Image = global::Login.Properties.Resources.icon_slots;
            this.btnUserAvailableSlots.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserAvailableSlots.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserAvailableSlots.Location = new System.Drawing.Point(12, 158);
            this.btnUserAvailableSlots.Name = "btnUserAvailableSlots";
            this.btnUserAvailableSlots.Size = new System.Drawing.Size(322, 64);
            this.btnUserAvailableSlots.TabIndex = 2;
            this.btnUserAvailableSlots.Text = "Available Slots";
            this.btnUserAvailableSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserAvailableSlots.Click += new System.EventHandler(this.btnUserAvailableSlots_Click);
            // 
            // btnUserDashboard
            // 
            this.btnUserDashboard.BorderRadius = 5;
            this.btnUserDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserDashboard.FillColor = System.Drawing.Color.Indigo;
            this.btnUserDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserDashboard.ForeColor = System.Drawing.Color.White;
            this.btnUserDashboard.Image = global::Login.Properties.Resources.icon_dashboard;
            this.btnUserDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserDashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserDashboard.Location = new System.Drawing.Point(12, 18);
            this.btnUserDashboard.Name = "btnUserDashboard";
            this.btnUserDashboard.Size = new System.Drawing.Size(322, 64);
            this.btnUserDashboard.TabIndex = 1;
            this.btnUserDashboard.Text = "Dashboard";
            this.btnUserDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserDashboard.Click += new System.EventHandler(this.btnUserDashboard_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lblCurrentTime);
            this.guna2Panel2.Controls.Add(this.lblWelcomeAdmin);
            this.guna2Panel2.Controls.Add(this.picboxAdmin);
            this.guna2Panel2.Controls.Add(this.picboxLogo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel2.TabIndex = 39;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 50);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(70, 32);
            this.lblCurrentTime.TabIndex = 15;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(58, 17);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(65, 32);
            this.lblWelcomeAdmin.TabIndex = 14;
            this.lblWelcomeAdmin.Text = "User";
            // 
            // picboxAdmin
            // 
            this.picboxAdmin.Image = global::Login.Properties.Resources.icon_user;
            this.picboxAdmin.ImageRotate = 0F;
            this.picboxAdmin.Location = new System.Drawing.Point(12, 12);
            this.picboxAdmin.Name = "picboxAdmin";
            this.picboxAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picboxAdmin.Size = new System.Drawing.Size(40, 40);
            this.picboxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAdmin.TabIndex = 13;
            this.picboxAdmin.TabStop = false;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::Login.Properties.Resources.logo;
            this.picboxLogo.ImageRotate = 0F;
            this.picboxLogo.Location = new System.Drawing.Point(1489, 12);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(177, 76);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 8;
            this.picboxLogo.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.txtEmail);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.txtPhone);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.txtNewPassword);
            this.guna2Panel3.Controls.Add(this.txtCurrentPassword);
            this.guna2Panel3.Controls.Add(this.btnSave);
            this.guna2Panel3.Controls.Add(this.txtFullName);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(422, 118);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(443, 696);
            this.guna2Panel3.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.LightGray;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtEmail.Location = new System.Drawing.Point(43, 226);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(346, 51);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 5;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.LightGray;
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtPhone.Location = new System.Drawing.Point(43, 327);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(346, 51);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderRadius = 5;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.LightGray;
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtNewPassword.Location = new System.Drawing.Point(41, 529);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(346, 51);
            this.txtNewPassword.TabIndex = 20;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderRadius = 5;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FillColor = System.Drawing.Color.LightGray;
            this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtCurrentPassword.Location = new System.Drawing.Point(41, 428);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.PlaceholderText = "";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.Size = new System.Drawing.Size(346, 51);
            this.txtCurrentPassword.TabIndex = 19;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Indigo;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Login.Properties.Resources.icon_save;
            this.btnSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(37, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(350, 45);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 5;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FillColor = System.Drawing.Color.LightGray;
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFullName.Location = new System.Drawing.Point(41, 125);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(346, 51);
            this.txtFullName.TabIndex = 12;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Details";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.Controls.Add(this.lblInfoLastSaved);
            this.guna2Panel4.Controls.Add(this.lblInfoStatus);
            this.guna2Panel4.Controls.Add(this.lblInfoRole);
            this.guna2Panel4.Controls.Add(this.lblInfoPhone);
            this.guna2Panel4.Controls.Add(this.lblInfoEmail);
            this.guna2Panel4.Controls.Add(this.lblInfoDisplayName);
            this.guna2Panel4.Controls.Add(this.lblInfoUsername);
            this.guna2Panel4.Controls.Add(this.label14);
            this.guna2Panel4.Controls.Add(this.label13);
            this.guna2Panel4.Controls.Add(this.label11);
            this.guna2Panel4.Controls.Add(this.label10);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.Controls.Add(this.label12);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(922, 118);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(698, 696);
            this.guna2Panel4.TabIndex = 41;
            // 
            // lblInfoLastSaved
            // 
            this.lblInfoLastSaved.AutoSize = true;
            this.lblInfoLastSaved.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLastSaved.ForeColor = System.Drawing.Color.Black;
            this.lblInfoLastSaved.Location = new System.Drawing.Point(304, 520);
            this.lblInfoLastSaved.Name = "lblInfoLastSaved";
            this.lblInfoLastSaved.Size = new System.Drawing.Size(23, 28);
            this.lblInfoLastSaved.TabIndex = 48;
            this.lblInfoLastSaved.Text = "0";
            this.lblInfoLastSaved.Click += new System.EventHandler(this.lblInfoLastSaved_Click);
            // 
            // lblInfoStatus
            // 
            this.lblInfoStatus.AutoSize = true;
            this.lblInfoStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoStatus.ForeColor = System.Drawing.Color.Black;
            this.lblInfoStatus.Location = new System.Drawing.Point(304, 454);
            this.lblInfoStatus.Name = "lblInfoStatus";
            this.lblInfoStatus.Size = new System.Drawing.Size(23, 28);
            this.lblInfoStatus.TabIndex = 47;
            this.lblInfoStatus.Text = "0";
            this.lblInfoStatus.Click += new System.EventHandler(this.lblInfoStatus_Click);
            // 
            // lblInfoRole
            // 
            this.lblInfoRole.AutoSize = true;
            this.lblInfoRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoRole.ForeColor = System.Drawing.Color.Black;
            this.lblInfoRole.Location = new System.Drawing.Point(304, 388);
            this.lblInfoRole.Name = "lblInfoRole";
            this.lblInfoRole.Size = new System.Drawing.Size(23, 28);
            this.lblInfoRole.TabIndex = 46;
            this.lblInfoRole.Text = "0";
            this.lblInfoRole.Click += new System.EventHandler(this.lblInfoRole_Click);
            // 
            // lblInfoPhone
            // 
            this.lblInfoPhone.AutoSize = true;
            this.lblInfoPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPhone.ForeColor = System.Drawing.Color.Black;
            this.lblInfoPhone.Location = new System.Drawing.Point(304, 322);
            this.lblInfoPhone.Name = "lblInfoPhone";
            this.lblInfoPhone.Size = new System.Drawing.Size(23, 28);
            this.lblInfoPhone.TabIndex = 45;
            this.lblInfoPhone.Text = "0";
            this.lblInfoPhone.Click += new System.EventHandler(this.lblInfoPhone_Click);
            // 
            // lblInfoEmail
            // 
            this.lblInfoEmail.AutoSize = true;
            this.lblInfoEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmail.ForeColor = System.Drawing.Color.Black;
            this.lblInfoEmail.Location = new System.Drawing.Point(304, 256);
            this.lblInfoEmail.Name = "lblInfoEmail";
            this.lblInfoEmail.Size = new System.Drawing.Size(23, 28);
            this.lblInfoEmail.TabIndex = 44;
            this.lblInfoEmail.Text = "0";
            this.lblInfoEmail.Click += new System.EventHandler(this.lblInfoEmail_Click);
            // 
            // lblInfoDisplayName
            // 
            this.lblInfoDisplayName.AutoSize = true;
            this.lblInfoDisplayName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDisplayName.ForeColor = System.Drawing.Color.Black;
            this.lblInfoDisplayName.Location = new System.Drawing.Point(304, 190);
            this.lblInfoDisplayName.Name = "lblInfoDisplayName";
            this.lblInfoDisplayName.Size = new System.Drawing.Size(23, 28);
            this.lblInfoDisplayName.TabIndex = 43;
            this.lblInfoDisplayName.Text = "0";
            this.lblInfoDisplayName.Click += new System.EventHandler(this.lblInfoDisplayName_Click);
            // 
            // lblInfoUsername
            // 
            this.lblInfoUsername.AutoSize = true;
            this.lblInfoUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoUsername.ForeColor = System.Drawing.Color.Black;
            this.lblInfoUsername.Location = new System.Drawing.Point(304, 124);
            this.lblInfoUsername.Name = "lblInfoUsername";
            this.lblInfoUsername.Size = new System.Drawing.Size(23, 28);
            this.lblInfoUsername.TabIndex = 42;
            this.lblInfoUsername.Text = "0";
            this.lblInfoUsername.Click += new System.EventHandler(this.lblInfoUsername_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(38, 519);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Last Saved";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(38, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 30);
            this.label13.TabIndex = 19;
            this.label13.Text = "Account Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(38, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "Account Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(38, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(38, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Display Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(36, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(292, 38);
            this.label12.TabIndex = 0;
            this.label12.Text = "Account Information";
            // 
            // frmUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Settings";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogOutUser;
        private Guna.UI2.WinForms.Guna2Button btnUserSettings;
        private Guna.UI2.WinForms.Guna2Button btnUserPayment;
        private Guna.UI2.WinForms.Guna2Button btnUserParkingHistory;
        private Guna.UI2.WinForms.Guna2Button btnUserMyVehicles;
        private Guna.UI2.WinForms.Guna2Button btnUserAvailableSlots;
        private Guna.UI2.WinForms.Guna2Button btnUserDashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox picboxLogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfoLastSaved;
        private System.Windows.Forms.Label lblInfoStatus;
        private System.Windows.Forms.Label lblInfoRole;
        private System.Windows.Forms.Label lblInfoPhone;
        private System.Windows.Forms.Label lblInfoEmail;
        private System.Windows.Forms.Label lblInfoDisplayName;
        private System.Windows.Forms.Label lblInfoUsername;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAdmin;
    }
}