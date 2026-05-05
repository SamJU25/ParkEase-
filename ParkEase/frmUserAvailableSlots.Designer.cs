namespace ParkEase
{
    partial class frmUserAvailableSlots
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtSearchAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.picboxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAvailableSlots = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMyVehicles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnParkHere = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAvailableSlots = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParkedVehicles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkedVehicles)).BeginInit();
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
            this.guna2Panel1.TabIndex = 32;
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
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
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
            this.guna2Panel2.Controls.Add(this.txtSearchAdmin);
            this.guna2Panel2.Controls.Add(this.picboxLogo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel2.TabIndex = 33;
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
            this.txtSearchAdmin.PlaceholderText = "Search by slot number or type...";
            this.txtSearchAdmin.SelectedText = "";
            this.txtSearchAdmin.Size = new System.Drawing.Size(753, 60);
            this.txtSearchAdmin.TabIndex = 11;
            this.txtSearchAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.guna2Panel3.Controls.Add(this.btnParkHere);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.cmbAvailableSlots);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.cmbMyVehicles);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(399, 118);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1230, 159);
            this.guna2Panel3.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Available Slots";
            // 
            // cmbAvailableSlots
            // 
            this.cmbAvailableSlots.BackColor = System.Drawing.Color.Transparent;
            this.cmbAvailableSlots.BorderRadius = 5;
            this.cmbAvailableSlots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAvailableSlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableSlots.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAvailableSlots.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAvailableSlots.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAvailableSlots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAvailableSlots.ItemHeight = 30;
            this.cmbAvailableSlots.Location = new System.Drawing.Point(500, 70);
            this.cmbAvailableSlots.Name = "cmbAvailableSlots";
            this.cmbAvailableSlots.Size = new System.Drawing.Size(417, 36);
            this.cmbAvailableSlots.TabIndex = 2;
            this.cmbAvailableSlots.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableSlots_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Your Vehicle";
            // 
            // cmbMyVehicles
            // 
            this.cmbMyVehicles.BackColor = System.Drawing.Color.Transparent;
            this.cmbMyVehicles.BorderRadius = 5;
            this.cmbMyVehicles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMyVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyVehicles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMyVehicles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMyVehicles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMyVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMyVehicles.ItemHeight = 30;
            this.cmbMyVehicles.Location = new System.Drawing.Point(52, 70);
            this.cmbMyVehicles.Name = "cmbMyVehicles";
            this.cmbMyVehicles.Size = new System.Drawing.Size(417, 36);
            this.cmbMyVehicles.TabIndex = 0;
            this.cmbMyVehicles.SelectedIndexChanged += new System.EventHandler(this.cmbMyVehicles_SelectedIndexChanged);
            // 
            // btnParkHere
            // 
            this.btnParkHere.BorderRadius = 5;
            this.btnParkHere.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParkHere.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParkHere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParkHere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParkHere.FillColor = System.Drawing.Color.Indigo;
            this.btnParkHere.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkHere.ForeColor = System.Drawing.Color.White;
            this.btnParkHere.ImageSize = new System.Drawing.Size(40, 40);
            this.btnParkHere.Location = new System.Drawing.Point(984, 66);
            this.btnParkHere.Name = "btnParkHere";
            this.btnParkHere.Size = new System.Drawing.Size(184, 51);
            this.btnParkHere.TabIndex = 4;
            this.btnParkHere.Text = "Park Here";
            this.btnParkHere.Click += new System.EventHandler(this.btnParkHere_Click);
            // 
            // dgvAvailableSlots
            // 
            this.dgvAvailableSlots.AllowUserToAddRows = false;
            this.dgvAvailableSlots.AllowUserToDeleteRows = false;
            this.dgvAvailableSlots.AllowUserToResizeColumns = false;
            this.dgvAvailableSlots.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvAvailableSlots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableSlots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAvailableSlots.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableSlots.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAvailableSlots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableSlots.Location = new System.Drawing.Point(1115, 398);
            this.dgvAvailableSlots.Name = "dgvAvailableSlots";
            this.dgvAvailableSlots.ReadOnly = true;
            this.dgvAvailableSlots.RowHeadersVisible = false;
            this.dgvAvailableSlots.RowHeadersWidth = 62;
            this.dgvAvailableSlots.RowTemplate.Height = 28;
            this.dgvAvailableSlots.Size = new System.Drawing.Size(514, 406);
            this.dgvAvailableSlots.TabIndex = 35;
            this.dgvAvailableSlots.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailableSlots.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAvailableSlots.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAvailableSlots.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAvailableSlots.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAvailableSlots.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailableSlots.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableSlots.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAvailableSlots.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAvailableSlots.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvailableSlots.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAvailableSlots.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAvailableSlots.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAvailableSlots.ThemeStyle.ReadOnly = true;
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableSlots.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAvailableSlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableSlots_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(1147, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Available Slots";
            // 
            // dgvParkedVehicles
            // 
            this.dgvParkedVehicles.AllowUserToAddRows = false;
            this.dgvParkedVehicles.AllowUserToDeleteRows = false;
            this.dgvParkedVehicles.AllowUserToResizeColumns = false;
            this.dgvParkedVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvParkedVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParkedVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvParkedVehicles.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParkedVehicles.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvParkedVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParkedVehicles.Location = new System.Drawing.Point(399, 398);
            this.dgvParkedVehicles.Name = "dgvParkedVehicles";
            this.dgvParkedVehicles.ReadOnly = true;
            this.dgvParkedVehicles.RowHeadersVisible = false;
            this.dgvParkedVehicles.RowHeadersWidth = 62;
            this.dgvParkedVehicles.RowTemplate.Height = 28;
            this.dgvParkedVehicles.Size = new System.Drawing.Size(677, 406);
            this.dgvParkedVehicles.TabIndex = 36;
            this.dgvParkedVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParkedVehicles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvParkedVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvParkedVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvParkedVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvParkedVehicles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvParkedVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParkedVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvParkedVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvParkedVehicles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParkedVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvParkedVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParkedVehicles.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvParkedVehicles.ThemeStyle.ReadOnly = true;
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.Height = 28;
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParkedVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvParkedVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParkedVehicles_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(422, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Currently Parked";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 5;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.Indigo;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::Login.Properties.Resources.icon_pay;
            this.btnCheckout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckout.Location = new System.Drawing.Point(653, 328);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(246, 53);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Checkout and Pay";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // frmUserAvailableSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvParkedVehicles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAvailableSlots);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserAvailableSlots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Available Slots";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkedVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAdmin;
        private Guna.UI2.WinForms.Guna2PictureBox picboxLogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMyVehicles;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAvailableSlots;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvParkedVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnParkHere;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAvailableSlots;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAdmin;
    }
}