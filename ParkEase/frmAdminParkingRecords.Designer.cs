namespace ParkEase
{
    partial class frmAdminParkingRecords
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
            this.btnAdminDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchAdmin = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdminRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalEarnings = new System.Windows.Forms.Label();
            this.lblActiveParkings = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRecords)).BeginInit();
            this.guna2Panel3.SuspendLayout();
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
            this.txtSearchAdmin.PlaceholderText = "Search by plate or owner...";
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
            this.guna2Panel1.TabIndex = 17;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lblCurrentTime);
            this.guna2Panel2.Controls.Add(this.lblWelcomeAdmin);
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel2.Controls.Add(this.txtSearchAdmin);
            this.guna2Panel2.Controls.Add(this.picboxLogo);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel2.TabIndex = 18;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(840, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "All Parking Records";
            // 
            // dgvAdminRecords
            // 
            this.dgvAdminRecords.AllowUserToAddRows = false;
            this.dgvAdminRecords.AllowUserToDeleteRows = false;
            this.dgvAdminRecords.AllowUserToResizeColumns = false;
            this.dgvAdminRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAdminRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminRecords.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdminRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAdminRecords.Location = new System.Drawing.Point(400, 359);
            this.dgvAdminRecords.Name = "dgvAdminRecords";
            this.dgvAdminRecords.ReadOnly = true;
            this.dgvAdminRecords.RowHeadersVisible = false;
            this.dgvAdminRecords.RowHeadersWidth = 62;
            this.dgvAdminRecords.RowTemplate.Height = 28;
            this.dgvAdminRecords.Size = new System.Drawing.Size(1215, 429);
            this.dgvAdminRecords.TabIndex = 19;
            this.dgvAdminRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAdminRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAdminRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAdminRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAdminRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAdminRecords.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAdminRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAdminRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAdminRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAdminRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdminRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAdminRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdminRecords.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAdminRecords.ThemeStyle.ReadOnly = true;
            this.dgvAdminRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAdminRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAdminRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdminRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAdminRecords.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAdminRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAdminRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Active Now";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(29, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Earnings";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.lblTotalEarnings);
            this.guna2Panel3.Controls.Add(this.lblActiveParkings);
            this.guna2Panel3.Controls.Add(this.lblTotalRecords);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(669, 118);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(564, 170);
            this.guna2Panel3.TabIndex = 23;
            // 
            // lblTotalEarnings
            // 
            this.lblTotalEarnings.AutoSize = true;
            this.lblTotalEarnings.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEarnings.ForeColor = System.Drawing.Color.Black;
            this.lblTotalEarnings.Location = new System.Drawing.Point(261, 112);
            this.lblTotalEarnings.Name = "lblTotalEarnings";
            this.lblTotalEarnings.Size = new System.Drawing.Size(25, 30);
            this.lblTotalEarnings.TabIndex = 25;
            this.lblTotalEarnings.Text = "0";
            this.lblTotalEarnings.Click += new System.EventHandler(this.lblTotalEarnings_Click);
            // 
            // lblActiveParkings
            // 
            this.lblActiveParkings.AutoSize = true;
            this.lblActiveParkings.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveParkings.ForeColor = System.Drawing.Color.Black;
            this.lblActiveParkings.Location = new System.Drawing.Point(261, 65);
            this.lblActiveParkings.Name = "lblActiveParkings";
            this.lblActiveParkings.Size = new System.Drawing.Size(25, 30);
            this.lblActiveParkings.TabIndex = 24;
            this.lblActiveParkings.Text = "0";
            this.lblActiveParkings.Click += new System.EventHandler(this.lblActiveParkings_Click);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRecords.Location = new System.Drawing.Point(261, 18);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(25, 30);
            this.lblTotalRecords.TabIndex = 23;
            this.lblTotalRecords.Text = "0";
            this.lblTotalRecords.Click += new System.EventHandler(this.lblTotalRecords_Click);
            // 
            // frmAdminParkingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.dgvAdminRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminParkingRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Parking Records";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRecords)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdminDashboard;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAdmin;
        private Guna.UI2.WinForms.Guna2PictureBox picboxLogo;
        private Guna.UI2.WinForms.Guna2Button btnLogOutAdmin;
        private Guna.UI2.WinForms.Guna2Button btnAdminSettings;
        private Guna.UI2.WinForms.Guna2Button btnAdminUsers;
        private Guna.UI2.WinForms.Guna2Button btnAdminParkingRecords;
        private Guna.UI2.WinForms.Guna2Button btnAdminVehicles;
        private Guna.UI2.WinForms.Guna2Button btnAdminManageSlots;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAdminRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblActiveParkings;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblTotalEarnings;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}