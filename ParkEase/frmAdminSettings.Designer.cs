namespace ParkEase
{
    partial class frmAdminSettings
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
            this.btnAdminDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.picboxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogOutAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminParkingRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminManageSlots = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFullNameAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhoneNumberAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailAddressAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPasswordAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdminDetailsSave = new Guna.UI2.WinForms.Guna2Button();
            this.cmbStatusAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtUsernameAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDisplayPhoneNumberAdmin = new System.Windows.Forms.Label();
            this.lblDsplayEmailAdmin = new System.Windows.Forms.Label();
            this.lblDisplayNameAdmin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDisplayLastLoginAdmin = new System.Windows.Forms.Label();
            this.lblDisplayStatusAdmin = new System.Windows.Forms.Label();
            this.lblDisplayRoleAdmin = new System.Windows.Forms.Label();
            this.lblDisplayUsernameAdmin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2Panel1.TabIndex = 21;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lblCurrentTime);
            this.guna2Panel2.Controls.Add(this.lblWelcomeAdmin);
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel2.Controls.Add(this.picboxLogo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel2.TabIndex = 22;
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
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Login.Properties.Resources.icon_user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.Controls.Add(this.txtFullNameAdmin);
            this.guna2Panel3.Controls.Add(this.label12);
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Controls.Add(this.txtPhoneNumberAdmin);
            this.guna2Panel3.Controls.Add(this.txtEmailAddressAdmin);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.txtNewPasswordAdmin);
            this.guna2Panel3.Controls.Add(this.txtPasswordAdmin);
            this.guna2Panel3.Controls.Add(this.btnAdminDetailsSave);
            this.guna2Panel3.Controls.Add(this.cmbStatusAdmin);
            this.guna2Panel3.Controls.Add(this.txtUsernameAdmin);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(383, 118);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(583, 696);
            this.guna2Panel3.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 28);
            this.label13.TabIndex = 27;
            this.label13.Text = "Full Name";
            // 
            // txtFullNameAdmin
            // 
            this.txtFullNameAdmin.BorderRadius = 5;
            this.txtFullNameAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullNameAdmin.DefaultText = "";
            this.txtFullNameAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullNameAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullNameAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullNameAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullNameAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtFullNameAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullNameAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullNameAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtFullNameAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullNameAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFullNameAdmin.Location = new System.Drawing.Point(189, 180);
            this.txtFullNameAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFullNameAdmin.Name = "txtFullNameAdmin";
            this.txtFullNameAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFullNameAdmin.PlaceholderText = "";
            this.txtFullNameAdmin.SelectedText = "";
            this.txtFullNameAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtFullNameAdmin.TabIndex = 26;
            this.txtFullNameAdmin.TextChanged += new System.EventHandler(this.txtFullNameAdmin_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 28);
            this.label12.TabIndex = 25;
            this.label12.Text = "Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 28);
            this.label11.TabIndex = 24;
            this.label11.Text = "Email Address";
            // 
            // txtPhoneNumberAdmin
            // 
            this.txtPhoneNumberAdmin.BorderRadius = 5;
            this.txtPhoneNumberAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumberAdmin.DefaultText = "";
            this.txtPhoneNumberAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumberAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumberAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumberAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumberAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtPhoneNumberAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumberAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhoneNumberAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumberAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumberAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtPhoneNumberAdmin.Location = new System.Drawing.Point(189, 312);
            this.txtPhoneNumberAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPhoneNumberAdmin.Name = "txtPhoneNumberAdmin";
            this.txtPhoneNumberAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNumberAdmin.PlaceholderText = "";
            this.txtPhoneNumberAdmin.SelectedText = "";
            this.txtPhoneNumberAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtPhoneNumberAdmin.TabIndex = 23;
            this.txtPhoneNumberAdmin.TextChanged += new System.EventHandler(this.txtPhoneNumberAdmin_TextChanged);
            // 
            // txtEmailAddressAdmin
            // 
            this.txtEmailAddressAdmin.BorderRadius = 5;
            this.txtEmailAddressAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddressAdmin.DefaultText = "";
            this.txtEmailAddressAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailAddressAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailAddressAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddressAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddressAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtEmailAddressAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddressAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailAddressAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtEmailAddressAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddressAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtEmailAddressAdmin.Location = new System.Drawing.Point(189, 246);
            this.txtEmailAddressAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmailAddressAdmin.Name = "txtEmailAddressAdmin";
            this.txtEmailAddressAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmailAddressAdmin.PlaceholderText = "";
            this.txtEmailAddressAdmin.SelectedText = "";
            this.txtEmailAddressAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtEmailAddressAdmin.TabIndex = 22;
            this.txtEmailAddressAdmin.TextChanged += new System.EventHandler(this.txtEmailAddressAdmin_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "New Password";
            // 
            // txtNewPasswordAdmin
            // 
            this.txtNewPasswordAdmin.BorderRadius = 5;
            this.txtNewPasswordAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPasswordAdmin.DefaultText = "";
            this.txtNewPasswordAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPasswordAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPasswordAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPasswordAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPasswordAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtNewPasswordAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPasswordAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPasswordAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtNewPasswordAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPasswordAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtNewPasswordAdmin.Location = new System.Drawing.Point(189, 444);
            this.txtNewPasswordAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNewPasswordAdmin.Name = "txtNewPasswordAdmin";
            this.txtNewPasswordAdmin.PasswordChar = '*';
            this.txtNewPasswordAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPasswordAdmin.PlaceholderText = "";
            this.txtNewPasswordAdmin.SelectedText = "";
            this.txtNewPasswordAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtNewPasswordAdmin.TabIndex = 20;
            this.txtNewPasswordAdmin.TextChanged += new System.EventHandler(this.txtNewPasswordAdmin_TextChanged);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.BorderRadius = 5;
            this.txtPasswordAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordAdmin.DefaultText = "";
            this.txtPasswordAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtPasswordAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPasswordAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtPasswordAdmin.Location = new System.Drawing.Point(189, 378);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPasswordAdmin.PlaceholderText = "";
            this.txtPasswordAdmin.SelectedText = "";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtPasswordAdmin.TabIndex = 19;
            this.txtPasswordAdmin.TextChanged += new System.EventHandler(this.txtPasswordAdmin_TextChanged);
            // 
            // btnAdminDetailsSave
            // 
            this.btnAdminDetailsSave.BorderRadius = 7;
            this.btnAdminDetailsSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminDetailsSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminDetailsSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminDetailsSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminDetailsSave.FillColor = System.Drawing.Color.Indigo;
            this.btnAdminDetailsSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdminDetailsSave.ForeColor = System.Drawing.Color.White;
            this.btnAdminDetailsSave.Image = global::Login.Properties.Resources.icon_save;
            this.btnAdminDetailsSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdminDetailsSave.Location = new System.Drawing.Point(102, 613);
            this.btnAdminDetailsSave.Name = "btnAdminDetailsSave";
            this.btnAdminDetailsSave.Size = new System.Drawing.Size(350, 45);
            this.btnAdminDetailsSave.TabIndex = 15;
            this.btnAdminDetailsSave.Text = "Save";
            this.btnAdminDetailsSave.Click += new System.EventHandler(this.btnAdminDetailsSave_Click);
            // 
            // cmbStatusAdmin
            // 
            this.cmbStatusAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatusAdmin.BorderRadius = 5;
            this.cmbStatusAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatusAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusAdmin.FillColor = System.Drawing.Color.LightGray;
            this.cmbStatusAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatusAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatusAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatusAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatusAdmin.ItemHeight = 30;
            this.cmbStatusAdmin.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatusAdmin.Location = new System.Drawing.Point(189, 510);
            this.cmbStatusAdmin.Name = "cmbStatusAdmin";
            this.cmbStatusAdmin.Size = new System.Drawing.Size(346, 36);
            this.cmbStatusAdmin.StartIndex = 0;
            this.cmbStatusAdmin.TabIndex = 14;
            this.cmbStatusAdmin.SelectedIndexChanged += new System.EventHandler(this.cmbStatusAdmin_SelectedIndexChanged);
            // 
            // txtUsernameAdmin
            // 
            this.txtUsernameAdmin.BorderRadius = 5;
            this.txtUsernameAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameAdmin.DefaultText = "";
            this.txtUsernameAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameAdmin.FillColor = System.Drawing.Color.LightGray;
            this.txtUsernameAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsernameAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtUsernameAdmin.Location = new System.Drawing.Point(189, 114);
            this.txtUsernameAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUsernameAdmin.Name = "txtUsernameAdmin";
            this.txtUsernameAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsernameAdmin.PlaceholderText = "";
            this.txtUsernameAdmin.SelectedText = "";
            this.txtUsernameAdmin.Size = new System.Drawing.Size(346, 51);
            this.txtUsernameAdmin.TabIndex = 12;
            this.txtUsernameAdmin.TextChanged += new System.EventHandler(this.txtUsernameAdmin_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
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
            this.guna2Panel4.Controls.Add(this.lblDisplayPhoneNumberAdmin);
            this.guna2Panel4.Controls.Add(this.lblDsplayEmailAdmin);
            this.guna2Panel4.Controls.Add(this.lblDisplayNameAdmin);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.Controls.Add(this.label17);
            this.guna2Panel4.Controls.Add(this.label16);
            this.guna2Panel4.Controls.Add(this.label15);
            this.guna2Panel4.Controls.Add(this.label14);
            this.guna2Panel4.Controls.Add(this.lblDisplayLastLoginAdmin);
            this.guna2Panel4.Controls.Add(this.lblDisplayStatusAdmin);
            this.guna2Panel4.Controls.Add(this.lblDisplayRoleAdmin);
            this.guna2Panel4.Controls.Add(this.lblDisplayUsernameAdmin);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(993, 118);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(649, 696);
            this.guna2Panel4.TabIndex = 24;
            // 
            // lblDisplayPhoneNumberAdmin
            // 
            this.lblDisplayPhoneNumberAdmin.AutoSize = true;
            this.lblDisplayPhoneNumberAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPhoneNumberAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayPhoneNumberAdmin.Location = new System.Drawing.Point(260, 280);
            this.lblDisplayPhoneNumberAdmin.Name = "lblDisplayPhoneNumberAdmin";
            this.lblDisplayPhoneNumberAdmin.Size = new System.Drawing.Size(25, 30);
            this.lblDisplayPhoneNumberAdmin.TabIndex = 38;
            this.lblDisplayPhoneNumberAdmin.Text = "0";
            this.lblDisplayPhoneNumberAdmin.Click += new System.EventHandler(this.lblDisplayPhoneNumberAdmin_Click);
            // 
            // lblDsplayEmailAdmin
            // 
            this.lblDsplayEmailAdmin.AutoSize = true;
            this.lblDsplayEmailAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDsplayEmailAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDsplayEmailAdmin.Location = new System.Drawing.Point(260, 229);
            this.lblDsplayEmailAdmin.Name = "lblDsplayEmailAdmin";
            this.lblDsplayEmailAdmin.Size = new System.Drawing.Size(25, 30);
            this.lblDsplayEmailAdmin.TabIndex = 37;
            this.lblDsplayEmailAdmin.Text = "0";
            this.lblDsplayEmailAdmin.Click += new System.EventHandler(this.lblDsplayEmailAdmin_Click);
            // 
            // lblDisplayNameAdmin
            // 
            this.lblDisplayNameAdmin.AutoSize = true;
            this.lblDisplayNameAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayNameAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayNameAdmin.Location = new System.Drawing.Point(260, 174);
            this.lblDisplayNameAdmin.Name = "lblDisplayNameAdmin";
            this.lblDisplayNameAdmin.Size = new System.Drawing.Size(25, 30);
            this.lblDisplayNameAdmin.TabIndex = 36;
            this.lblDisplayNameAdmin.Text = "0";
            this.lblDisplayNameAdmin.Click += new System.EventHandler(this.lblDisplayNameAdmin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(48, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 30);
            this.label8.TabIndex = 35;
            this.label8.Text = "Last Saved";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(52, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 30);
            this.label9.TabIndex = 34;
            this.label9.Text = "Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(52, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 30);
            this.label17.TabIndex = 33;
            this.label17.Text = "Role";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(45, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 30);
            this.label16.TabIndex = 32;
            this.label16.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(45, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 30);
            this.label15.TabIndex = 31;
            this.label15.Text = "Email Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(45, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 30);
            this.label14.TabIndex = 30;
            this.label14.Text = "Display Name";
            // 
            // lblDisplayLastLoginAdmin
            // 
            this.lblDisplayLastLoginAdmin.AutoSize = true;
            this.lblDisplayLastLoginAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayLastLoginAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayLastLoginAdmin.Location = new System.Drawing.Point(260, 444);
            this.lblDisplayLastLoginAdmin.Name = "lblDisplayLastLoginAdmin";
            this.lblDisplayLastLoginAdmin.Size = new System.Drawing.Size(25, 30);
            this.lblDisplayLastLoginAdmin.TabIndex = 29;
            this.lblDisplayLastLoginAdmin.Text = "0";
            this.lblDisplayLastLoginAdmin.Click += new System.EventHandler(this.lblDisplayLastLoginAdmin_Click);
            // 
            // lblDisplayStatusAdmin
            // 
            this.lblDisplayStatusAdmin.AutoSize = true;
            this.lblDisplayStatusAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayStatusAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayStatusAdmin.Location = new System.Drawing.Point(260, 384);
            this.lblDisplayStatusAdmin.Name = "lblDisplayStatusAdmin";
            this.lblDisplayStatusAdmin.Size = new System.Drawing.Size(25, 30);
            this.lblDisplayStatusAdmin.TabIndex = 28;
            this.lblDisplayStatusAdmin.Text = "0";
            this.lblDisplayStatusAdmin.Click += new System.EventHandler(this.lblDisplayStatusAdmin_Click);
            // 
            // lblDisplayRoleAdmin
            // 
            this.lblDisplayRoleAdmin.AutoSize = true;
            this.lblDisplayRoleAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayRoleAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayRoleAdmin.Location = new System.Drawing.Point(260, 333);
            this.lblDisplayRoleAdmin.Name = "lblDisplayRoleAdmin";
            this.lblDisplayRoleAdmin.Size = new System.Drawing.Size(76, 30);
            this.lblDisplayRoleAdmin.TabIndex = 27;
            this.lblDisplayRoleAdmin.Text = "Admin";
            this.lblDisplayRoleAdmin.Click += new System.EventHandler(this.lblDisplayRoleAdmin_Click);
            // 
            // lblDisplayUsernameAdmin
            // 
            this.lblDisplayUsernameAdmin.AutoSize = true;
            this.lblDisplayUsernameAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUsernameAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayUsernameAdmin.Location = new System.Drawing.Point(260, 114);
            this.lblDisplayUsernameAdmin.Name = "lblDisplayUsernameAdmin";
            this.lblDisplayUsernameAdmin.Size = new System.Drawing.Size(25, 30);
            this.lblDisplayUsernameAdmin.TabIndex = 26;
            this.lblDisplayUsernameAdmin.Text = "0";
            this.lblDisplayUsernameAdmin.Click += new System.EventHandler(this.lblDisplayUsernameAdmin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Userame";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(45, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 45);
            this.label5.TabIndex = 20;
            this.label5.Text = "Account Information";
            // 
            // frmAdminSettings
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
            this.Name = "frmAdminSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Settings";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAdminDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox picboxLogo;
        private Guna.UI2.WinForms.Guna2Button btnLogOutAdmin;
        private Guna.UI2.WinForms.Guna2Button btnAdminSettings;
        private Guna.UI2.WinForms.Guna2Button btnAdminUsers;
        private Guna.UI2.WinForms.Guna2Button btnAdminParkingRecords;
        private Guna.UI2.WinForms.Guna2Button btnAdminVehicles;
        private Guna.UI2.WinForms.Guna2Button btnAdminManageSlots;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordAdmin;
        private Guna.UI2.WinForms.Guna2Button btnAdminDetailsSave;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatusAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPasswordAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDisplayLastLoginAdmin;
        private System.Windows.Forms.Label lblDisplayStatusAdmin;
        private System.Windows.Forms.Label lblDisplayRoleAdmin;
        private System.Windows.Forms.Label lblDisplayUsernameAdmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumberAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailAddressAdmin;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtFullNameAdmin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDisplayPhoneNumberAdmin;
        private System.Windows.Forms.Label lblDsplayEmailAdmin;
        private System.Windows.Forms.Label lblDisplayNameAdmin;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}