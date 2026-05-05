namespace ParkEase
{
    partial class frmAdminManageSlots
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
            this.txtSearchAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.picboxAdmin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picboxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogOutAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminParkingRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminManageSlots = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlotNumberAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSlotVehicleTypeAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSlotStatusAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSlotSaveAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSlotDeleteAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSlotAddAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSlots = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlots)).BeginInit();
            this.SuspendLayout();
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
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(58, 11);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(65, 32);
            this.lblWelcomeAdmin.TabIndex = 10;
            this.lblWelcomeAdmin.Text = "User";
            this.lblWelcomeAdmin.Click += new System.EventHandler(this.lblWelcomeAdmin_Click);
            // 
            // picboxAdmin
            // 
            this.picboxAdmin.Image = global::Login.Properties.Resources.icon_user;
            this.picboxAdmin.ImageRotate = 0F;
            this.picboxAdmin.Location = new System.Drawing.Point(12, 6);
            this.picboxAdmin.Name = "picboxAdmin";
            this.picboxAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picboxAdmin.Size = new System.Drawing.Size(40, 40);
            this.picboxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAdmin.TabIndex = 9;
            this.picboxAdmin.TabStop = false;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::Login.Properties.Resources.logo;
            this.picboxLogo.ImageRotate = 0F;
            this.picboxLogo.Location = new System.Drawing.Point(1489, 11);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(177, 76);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 8;
            this.picboxLogo.TabStop = false;
            // 
            // btnLogOutAdmin
            // 
            this.btnLogOutAdmin.BorderRadius = 5;
            this.btnLogOutAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOutAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOutAdmin.FillColor = System.Drawing.Color.Indigo;
            this.btnLogOutAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOutAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLogOutAdmin.Image = global::Login.Properties.Resources.icon_logout;
            this.btnLogOutAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOutAdmin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOutAdmin.Location = new System.Drawing.Point(11, 668);
            this.btnLogOutAdmin.Name = "btnLogOutAdmin";
            this.btnLogOutAdmin.Size = new System.Drawing.Size(322, 64);
            this.btnLogOutAdmin.TabIndex = 7;
            this.btnLogOutAdmin.Text = "Log Out";
            this.btnLogOutAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOutAdmin.Click += new System.EventHandler(this.btnLogOutAdmin_Click);
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.BorderRadius = 5;
            this.btnAdminSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminSettings.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminSettings.ForeColor = System.Drawing.Color.White;
            this.btnAdminSettings.Image = global::Login.Properties.Resources.icon_settings;
            this.btnAdminSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminSettings.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminSettings.Location = new System.Drawing.Point(11, 368);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(322, 64);
            this.btnAdminSettings.TabIndex = 6;
            this.btnAdminSettings.Text = "Settings";
            this.btnAdminSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminSettings.Click += new System.EventHandler(this.btnAdminSettings_Click);
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.BorderRadius = 5;
            this.btnAdminUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminUsers.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminUsers.ForeColor = System.Drawing.Color.White;
            this.btnAdminUsers.Image = global::Login.Properties.Resources.icon_users;
            this.btnAdminUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminUsers.Location = new System.Drawing.Point(11, 298);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(322, 64);
            this.btnAdminUsers.TabIndex = 5;
            this.btnAdminUsers.Text = "Users";
            this.btnAdminUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminUsers.Click += new System.EventHandler(this.btnAdminUsers_Click);
            // 
            // btnAdminParkingRecords
            // 
            this.btnAdminParkingRecords.BorderRadius = 5;
            this.btnAdminParkingRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminParkingRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminParkingRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminParkingRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminParkingRecords.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminParkingRecords.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminParkingRecords.ForeColor = System.Drawing.Color.White;
            this.btnAdminParkingRecords.Image = global::Login.Properties.Resources.icon_records;
            this.btnAdminParkingRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminParkingRecords.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminParkingRecords.Location = new System.Drawing.Point(11, 228);
            this.btnAdminParkingRecords.Name = "btnAdminParkingRecords";
            this.btnAdminParkingRecords.Size = new System.Drawing.Size(322, 64);
            this.btnAdminParkingRecords.TabIndex = 4;
            this.btnAdminParkingRecords.Text = "Parking Records";
            this.btnAdminParkingRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminParkingRecords.Click += new System.EventHandler(this.btnAdminParkingRecords_Click);
            // 
            // btnAdminVehicles
            // 
            this.btnAdminVehicles.BorderRadius = 5;
            this.btnAdminVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminVehicles.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminVehicles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminVehicles.ForeColor = System.Drawing.Color.White;
            this.btnAdminVehicles.Image = global::Login.Properties.Resources.icon_vehicle;
            this.btnAdminVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminVehicles.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminVehicles.Location = new System.Drawing.Point(12, 158);
            this.btnAdminVehicles.Name = "btnAdminVehicles";
            this.btnAdminVehicles.Size = new System.Drawing.Size(322, 64);
            this.btnAdminVehicles.TabIndex = 3;
            this.btnAdminVehicles.Text = "Vehicles";
            this.btnAdminVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminVehicles.Click += new System.EventHandler(this.btnAdminVehicles_Click);
            // 
            // btnAdminManageSlots
            // 
            this.btnAdminManageSlots.BorderRadius = 5;
            this.btnAdminManageSlots.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminManageSlots.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminManageSlots.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminManageSlots.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminManageSlots.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminManageSlots.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminManageSlots.ForeColor = System.Drawing.Color.White;
            this.btnAdminManageSlots.Image = global::Login.Properties.Resources.icon_slots;
            this.btnAdminManageSlots.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminManageSlots.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminManageSlots.Location = new System.Drawing.Point(12, 88);
            this.btnAdminManageSlots.Name = "btnAdminManageSlots";
            this.btnAdminManageSlots.Size = new System.Drawing.Size(322, 64);
            this.btnAdminManageSlots.TabIndex = 2;
            this.btnAdminManageSlots.Text = "Manage Slots";
            this.btnAdminManageSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminManageSlots.Click += new System.EventHandler(this.btnAdminManageSlots_Click);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BorderRadius = 5;
            this.btnAdminDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminDashboard.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminDashboard.ForeColor = System.Drawing.Color.White;
            this.btnAdminDashboard.Image = global::Login.Properties.Resources.icon_dashboard;
            this.btnAdminDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminDashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminDashboard.Location = new System.Drawing.Point(12, 18);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(322, 64);
            this.btnAdminDashboard.TabIndex = 1;
            this.btnAdminDashboard.Text = "Dashboard";
            this.btnAdminDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnLogOutAdmin);
            this.guna2Panel1.Controls.Add(this.btnAdminSettings);
            this.guna2Panel1.Controls.Add(this.btnAdminUsers);
            this.guna2Panel1.Controls.Add(this.btnAdminParkingRecords);
            this.guna2Panel1.Controls.Add(this.btnAdminVehicles);
            this.guna2Panel1.Controls.Add(this.btnAdminManageSlots);
            this.guna2Panel1.Controls.Add(this.btnAdminDashboard);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(345, 744);
            this.guna2Panel1.TabIndex = 13;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lblCurrentTime);
            this.guna2Panel2.Controls.Add(this.txtSearchAdmin);
            this.guna2Panel2.Controls.Add(this.lblWelcomeAdmin);
            this.guna2Panel2.Controls.Add(this.picboxAdmin);
            this.guna2Panel2.Controls.Add(this.picboxLogo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel2.TabIndex = 14;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 44);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(70, 32);
            this.lblCurrentTime.TabIndex = 12;
            this.lblCurrentTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slot Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slot Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // txtSlotNumberAdmin
            // 
            this.txtSlotNumberAdmin.BorderRadius = 5;
            this.txtSlotNumberAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlotNumberAdmin.DefaultText = "";
            this.txtSlotNumberAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSlotNumberAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSlotNumberAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSlotNumberAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSlotNumberAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtSlotNumberAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSlotNumberAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSlotNumberAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtSlotNumberAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSlotNumberAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtSlotNumberAdmin.Location = new System.Drawing.Point(41, 180);
            this.txtSlotNumberAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSlotNumberAdmin.Name = "txtSlotNumberAdmin";
            this.txtSlotNumberAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSlotNumberAdmin.PlaceholderText = "e.g.  S-01";
            this.txtSlotNumberAdmin.SelectedText = "";
            this.txtSlotNumberAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtSlotNumberAdmin.TabIndex = 12;
            this.txtSlotNumberAdmin.TextChanged += new System.EventHandler(this.txtSlotNumberAdmin_TextChanged);
            // 
            // cmbSlotVehicleTypeAdmin
            // 
            this.cmbSlotVehicleTypeAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cmbSlotVehicleTypeAdmin.BorderRadius = 5;
            this.cmbSlotVehicleTypeAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSlotVehicleTypeAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlotVehicleTypeAdmin.FillColor = System.Drawing.Color.LightGray;
            this.cmbSlotVehicleTypeAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSlotVehicleTypeAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSlotVehicleTypeAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSlotVehicleTypeAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSlotVehicleTypeAdmin.ItemHeight = 30;
            this.cmbSlotVehicleTypeAdmin.Items.AddRange(new object[] {
            "Car",
            "Motorcycle"});
            this.cmbSlotVehicleTypeAdmin.Location = new System.Drawing.Point(41, 297);
            this.cmbSlotVehicleTypeAdmin.Name = "cmbSlotVehicleTypeAdmin";
            this.cmbSlotVehicleTypeAdmin.Size = new System.Drawing.Size(350, 36);
            this.cmbSlotVehicleTypeAdmin.TabIndex = 13;
            this.cmbSlotVehicleTypeAdmin.SelectedIndexChanged += new System.EventHandler(this.cmbSlotVehicleTypeAdmin_SelectedIndexChanged);
            // 
            // cmbSlotStatusAdmin
            // 
            this.cmbSlotStatusAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cmbSlotStatusAdmin.BorderRadius = 5;
            this.cmbSlotStatusAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSlotStatusAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlotStatusAdmin.FillColor = System.Drawing.Color.LightGray;
            this.cmbSlotStatusAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSlotStatusAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSlotStatusAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSlotStatusAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSlotStatusAdmin.ItemHeight = 30;
            this.cmbSlotStatusAdmin.Items.AddRange(new object[] {
            "Available",
            "Maintenance",
            "Booked"});
            this.cmbSlotStatusAdmin.Location = new System.Drawing.Point(41, 396);
            this.cmbSlotStatusAdmin.Name = "cmbSlotStatusAdmin";
            this.cmbSlotStatusAdmin.Size = new System.Drawing.Size(350, 36);
            this.cmbSlotStatusAdmin.TabIndex = 14;
            this.cmbSlotStatusAdmin.SelectedIndexChanged += new System.EventHandler(this.cmbSlotStatusAdmin_SelectedIndexChanged);
            // 
            // btnSlotSaveAdmin
            // 
            this.btnSlotSaveAdmin.BorderRadius = 7;
            this.btnSlotSaveAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSlotSaveAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSlotSaveAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSlotSaveAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSlotSaveAdmin.FillColor = System.Drawing.Color.Indigo;
            this.btnSlotSaveAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSlotSaveAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSlotSaveAdmin.Image = global::Login.Properties.Resources.icon_save;
            this.btnSlotSaveAdmin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSlotSaveAdmin.Location = new System.Drawing.Point(41, 558);
            this.btnSlotSaveAdmin.Name = "btnSlotSaveAdmin";
            this.btnSlotSaveAdmin.Size = new System.Drawing.Size(180, 45);
            this.btnSlotSaveAdmin.TabIndex = 15;
            this.btnSlotSaveAdmin.Text = "Save";
            this.btnSlotSaveAdmin.Click += new System.EventHandler(this.btnSlotSaveAdmin_Click);
            // 
            // btnSlotDeleteAdmin
            // 
            this.btnSlotDeleteAdmin.BorderRadius = 7;
            this.btnSlotDeleteAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSlotDeleteAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSlotDeleteAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSlotDeleteAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSlotDeleteAdmin.FillColor = System.Drawing.Color.Indigo;
            this.btnSlotDeleteAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSlotDeleteAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSlotDeleteAdmin.Image = global::Login.Properties.Resources.icon_delete;
            this.btnSlotDeleteAdmin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSlotDeleteAdmin.Location = new System.Drawing.Point(227, 558);
            this.btnSlotDeleteAdmin.Name = "btnSlotDeleteAdmin";
            this.btnSlotDeleteAdmin.Size = new System.Drawing.Size(180, 45);
            this.btnSlotDeleteAdmin.TabIndex = 17;
            this.btnSlotDeleteAdmin.Text = "Delete";
            this.btnSlotDeleteAdmin.Click += new System.EventHandler(this.btnSlotDeleteAdmin_Click);
            // 
            // btnSlotAddAdmin
            // 
            this.btnSlotAddAdmin.BorderRadius = 7;
            this.btnSlotAddAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSlotAddAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSlotAddAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSlotAddAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSlotAddAdmin.FillColor = System.Drawing.Color.Indigo;
            this.btnSlotAddAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSlotAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSlotAddAdmin.Image = global::Login.Properties.Resources.icon_add;
            this.btnSlotAddAdmin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSlotAddAdmin.Location = new System.Drawing.Point(43, 507);
            this.btnSlotAddAdmin.Name = "btnSlotAddAdmin";
            this.btnSlotAddAdmin.Size = new System.Drawing.Size(364, 45);
            this.btnSlotAddAdmin.TabIndex = 18;
            this.btnSlotAddAdmin.Text = "Add";
            this.btnSlotAddAdmin.Click += new System.EventHandler(this.btnSlotAddAdmin_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.btnSlotAddAdmin);
            this.guna2Panel3.Controls.Add(this.btnSlotDeleteAdmin);
            this.guna2Panel3.Controls.Add(this.btnSlotSaveAdmin);
            this.guna2Panel3.Controls.Add(this.cmbSlotStatusAdmin);
            this.guna2Panel3.Controls.Add(this.cmbSlotVehicleTypeAdmin);
            this.guna2Panel3.Controls.Add(this.txtSlotNumberAdmin);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(389, 129);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(443, 642);
            this.guna2Panel3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(888, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 38);
            this.label5.TabIndex = 18;
            this.label5.Text = "All Parking Slots";
            // 
            // dgvSlots
            // 
            this.dgvSlots.AllowUserToAddRows = false;
            this.dgvSlots.AllowUserToDeleteRows = false;
            this.dgvSlots.AllowUserToResizeColumns = false;
            this.dgvSlots.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvSlots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSlots.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSlots.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSlots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSlots.Location = new System.Drawing.Point(884, 188);
            this.dgvSlots.MultiSelect = false;
            this.dgvSlots.Name = "dgvSlots";
            this.dgvSlots.ReadOnly = true;
            this.dgvSlots.RowHeadersVisible = false;
            this.dgvSlots.RowHeadersWidth = 62;
            this.dgvSlots.RowTemplate.Height = 28;
            this.dgvSlots.Size = new System.Drawing.Size(755, 583);
            this.dgvSlots.TabIndex = 19;
            this.dgvSlots.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSlots.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSlots.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSlots.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSlots.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSlots.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSlots.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSlots.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSlots.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSlots.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSlots.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSlots.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSlots.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSlots.ThemeStyle.ReadOnly = true;
            this.dgvSlots.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSlots.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSlots.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSlots.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSlots.ThemeStyle.RowsStyle.Height = 28;
            this.dgvSlots.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSlots.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSlots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlots_CellClick);
            // 
            // frmAdminManageSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.dgvSlots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminManageSlots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Manage Slots";
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAdmin;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAdmin;
        private Guna.UI2.WinForms.Guna2PictureBox picboxLogo;
        private Guna.UI2.WinForms.Guna2Button btnLogOutAdmin;
        private Guna.UI2.WinForms.Guna2Button btnAdminSettings;
        private Guna.UI2.WinForms.Guna2Button btnAdminUsers;
        private Guna.UI2.WinForms.Guna2Button btnAdminParkingRecords;
        private Guna.UI2.WinForms.Guna2Button btnAdminVehicles;
        private Guna.UI2.WinForms.Guna2Button btnAdminManageSlots;
        private Guna.UI2.WinForms.Guna2Button btnAdminDashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSlotNumberAdmin;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSlotVehicleTypeAdmin;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSlotStatusAdmin;
        private Guna.UI2.WinForms.Guna2Button btnSlotSaveAdmin;
        private Guna.UI2.WinForms.Guna2Button btnSlotDeleteAdmin;
        private Guna.UI2.WinForms.Guna2Button btnSlotAddAdmin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSlots;
        private System.Windows.Forms.Label lblCurrentTime;
    }
}