namespace ParkEase
{
    partial class frmUserVehicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picboxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearchAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.picboxAdmin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUserDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserAvailableSlots = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserMyVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserParkingHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOutUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVehicleDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicleEditUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicleAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.cmbVehicleTypeUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPlateNumberUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalVehiclesUser = new System.Windows.Forms.Label();
            this.dgvMyVehicles = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyVehicles)).BeginInit();
            this.SuspendLayout();
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
            // txtSearchAdmin
            // 
            this.txtSearchAdmin.BorderRadius = 5;
            this.txtSearchAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAdmin.DefaultText = "";
            this.txtSearchAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAdmin.FillColor = System.Drawing.Color.Lavender;
            this.txtSearchAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtSearchAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAdmin.IconLeft = global::Login.Properties.Resources.icon_search;
            this.txtSearchAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtSearchAdmin.Location = new System.Drawing.Point(516, 16);
            this.txtSearchAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAdmin.Name = "txtSearchAdmin";
            this.txtSearchAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchAdmin.PlaceholderText = "Search your vehicles...";
            this.txtSearchAdmin.SelectedText = "";
            this.txtSearchAdmin.Size = new System.Drawing.Size(753, 60);
            this.txtSearchAdmin.TabIndex = 11;
            this.txtSearchAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lblCurrentTime);
            this.guna2Panel2.Controls.Add(this.lblWelcomeAdmin);
            this.guna2Panel2.Controls.Add(this.picboxAdmin);
            this.guna2Panel2.Controls.Add(this.txtSearchAdmin);
            this.guna2Panel2.Controls.Add(this.picboxLogo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel2.TabIndex = 31;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 54);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(70, 32);
            this.lblCurrentTime.TabIndex = 15;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(58, 21);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(65, 32);
            this.lblWelcomeAdmin.TabIndex = 14;
            this.lblWelcomeAdmin.Text = "User";
            // 
            // picboxAdmin
            // 
            this.picboxAdmin.Image = global::Login.Properties.Resources.icon_user;
            this.picboxAdmin.ImageRotate = 0F;
            this.picboxAdmin.Location = new System.Drawing.Point(12, 16);
            this.picboxAdmin.Name = "picboxAdmin";
            this.picboxAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picboxAdmin.Size = new System.Drawing.Size(40, 40);
            this.picboxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAdmin.TabIndex = 13;
            this.picboxAdmin.TabStop = false;
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
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
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
            this.guna2Panel1.TabIndex = 30;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.btnVehicleDeleteUser);
            this.guna2Panel3.Controls.Add(this.btnVehicleEditUser);
            this.guna2Panel3.Controls.Add(this.btnVehicleAddUser);
            this.guna2Panel3.Controls.Add(this.cmbVehicleTypeUser);
            this.guna2Panel3.Controls.Add(this.txtPlateNumberUser);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(388, 139);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(469, 669);
            this.guna2Panel3.TabIndex = 32;
            // 
            // btnVehicleDeleteUser
            // 
            this.btnVehicleDeleteUser.BorderRadius = 7;
            this.btnVehicleDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicleDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicleDeleteUser.FillColor = System.Drawing.Color.Indigo;
            this.btnVehicleDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVehicleDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnVehicleDeleteUser.Image = global::Login.Properties.Resources.icon_delete;
            this.btnVehicleDeleteUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnVehicleDeleteUser.Location = new System.Drawing.Point(42, 594);
            this.btnVehicleDeleteUser.Name = "btnVehicleDeleteUser";
            this.btnVehicleDeleteUser.Size = new System.Drawing.Size(380, 45);
            this.btnVehicleDeleteUser.TabIndex = 27;
            this.btnVehicleDeleteUser.Text = "Delete";
            this.btnVehicleDeleteUser.Click += new System.EventHandler(this.btnVehicleDeleteUser_Click);
            // 
            // btnVehicleEditUser
            // 
            this.btnVehicleEditUser.BorderRadius = 7;
            this.btnVehicleEditUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleEditUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleEditUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicleEditUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicleEditUser.FillColor = System.Drawing.Color.Indigo;
            this.btnVehicleEditUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVehicleEditUser.ForeColor = System.Drawing.Color.White;
            this.btnVehicleEditUser.Image = global::Login.Properties.Resources.icon_save;
            this.btnVehicleEditUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnVehicleEditUser.Location = new System.Drawing.Point(242, 529);
            this.btnVehicleEditUser.Name = "btnVehicleEditUser";
            this.btnVehicleEditUser.Size = new System.Drawing.Size(180, 45);
            this.btnVehicleEditUser.TabIndex = 26;
            this.btnVehicleEditUser.Text = "Save";
            this.btnVehicleEditUser.Click += new System.EventHandler(this.btnVehicleEditUser_Click);
            // 
            // btnVehicleAddUser
            // 
            this.btnVehicleAddUser.BorderRadius = 7;
            this.btnVehicleAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicleAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicleAddUser.FillColor = System.Drawing.Color.Indigo;
            this.btnVehicleAddUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVehicleAddUser.ForeColor = System.Drawing.Color.White;
            this.btnVehicleAddUser.Image = global::Login.Properties.Resources.icon_add;
            this.btnVehicleAddUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnVehicleAddUser.Location = new System.Drawing.Point(42, 529);
            this.btnVehicleAddUser.Name = "btnVehicleAddUser";
            this.btnVehicleAddUser.Size = new System.Drawing.Size(180, 45);
            this.btnVehicleAddUser.TabIndex = 25;
            this.btnVehicleAddUser.Text = "Add";
            this.btnVehicleAddUser.Click += new System.EventHandler(this.btnVehicleAddUser_Click);
            // 
            // cmbVehicleTypeUser
            // 
            this.cmbVehicleTypeUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbVehicleTypeUser.BorderRadius = 5;
            this.cmbVehicleTypeUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVehicleTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleTypeUser.FillColor = System.Drawing.Color.LightGray;
            this.cmbVehicleTypeUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVehicleTypeUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVehicleTypeUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVehicleTypeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbVehicleTypeUser.ItemHeight = 30;
            this.cmbVehicleTypeUser.Items.AddRange(new object[] {
            "Car",
            "Motorcycle"});
            this.cmbVehicleTypeUser.Location = new System.Drawing.Point(51, 268);
            this.cmbVehicleTypeUser.Name = "cmbVehicleTypeUser";
            this.cmbVehicleTypeUser.Size = new System.Drawing.Size(350, 36);
            this.cmbVehicleTypeUser.TabIndex = 23;
            this.cmbVehicleTypeUser.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleTypeUser_SelectedIndexChanged);
            // 
            // txtPlateNumberUser
            // 
            this.txtPlateNumberUser.BorderRadius = 5;
            this.txtPlateNumberUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumberUser.DefaultText = "";
            this.txtPlateNumberUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateNumberUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateNumberUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumberUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumberUser.FillColor = System.Drawing.Color.LightGray;
            this.txtPlateNumberUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNumberUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlateNumberUser.ForeColor = System.Drawing.Color.Black;
            this.txtPlateNumberUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNumberUser.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtPlateNumberUser.Location = new System.Drawing.Point(51, 148);
            this.txtPlateNumberUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlateNumberUser.Name = "txtPlateNumberUser";
            this.txtPlateNumberUser.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPlateNumberUser.PlaceholderText = "e.g., ABC-1234";
            this.txtPlateNumberUser.SelectedText = "";
            this.txtPlateNumberUser.Size = new System.Drawing.Size(346, 51);
            this.txtPlateNumberUser.TabIndex = 22;
            this.txtPlateNumberUser.TextChanged += new System.EventHandler(this.txtPlateNumberUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Plate Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vehicle Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(883, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total Vehicles :";
            // 
            // lblTotalVehiclesUser
            // 
            this.lblTotalVehiclesUser.AutoSize = true;
            this.lblTotalVehiclesUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVehiclesUser.ForeColor = System.Drawing.Color.Black;
            this.lblTotalVehiclesUser.Location = new System.Drawing.Point(1101, 163);
            this.lblTotalVehiclesUser.Name = "lblTotalVehiclesUser";
            this.lblTotalVehiclesUser.Size = new System.Drawing.Size(25, 30);
            this.lblTotalVehiclesUser.TabIndex = 29;
            this.lblTotalVehiclesUser.Text = "0";
            this.lblTotalVehiclesUser.Click += new System.EventHandler(this.lblTotalVehiclesUser_Click);
            // 
            // dgvMyVehicles
            // 
            this.dgvMyVehicles.AllowUserToAddRows = false;
            this.dgvMyVehicles.AllowUserToDeleteRows = false;
            this.dgvMyVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMyVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMyVehicles.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMyVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMyVehicles.Location = new System.Drawing.Point(889, 211);
            this.dgvMyVehicles.MultiSelect = false;
            this.dgvMyVehicles.Name = "dgvMyVehicles";
            this.dgvMyVehicles.ReadOnly = true;
            this.dgvMyVehicles.RowHeadersVisible = false;
            this.dgvMyVehicles.RowHeadersWidth = 62;
            this.dgvMyVehicles.RowTemplate.Height = 28;
            this.dgvMyVehicles.Size = new System.Drawing.Size(752, 597);
            this.dgvMyVehicles.TabIndex = 35;
            this.dgvMyVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyVehicles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMyVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMyVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMyVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMyVehicles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMyVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMyVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMyVehicles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMyVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMyVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMyVehicles.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMyVehicles.ThemeStyle.ReadOnly = true;
            this.dgvMyVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMyVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMyVehicles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMyVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMyVehicles.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMyVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMyVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMyVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyVehicles_CellClick);
            // 
            // frmUserVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.lblTotalVehiclesUser);
            this.Controls.Add(this.dgvMyVehicles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picboxLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAdmin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnUserDashboard;
        private Guna.UI2.WinForms.Guna2Button btnUserAvailableSlots;
        private Guna.UI2.WinForms.Guna2Button btnUserMyVehicles;
        private Guna.UI2.WinForms.Guna2Button btnUserParkingHistory;
        private Guna.UI2.WinForms.Guna2Button btnUserPayment;
        private Guna.UI2.WinForms.Guna2Button btnUserSettings;
        private Guna.UI2.WinForms.Guna2Button btnLogOutUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnVehicleDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnVehicleEditUser;
        private Guna.UI2.WinForms.Guna2Button btnVehicleAddUser;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVehicleTypeUser;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNumberUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalVehiclesUser;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMyVehicles;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAdmin;
    }
}