namespace ParkEase
{
    partial class UserParkingHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
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
            this.guna2Panel1.TabIndex = 34;
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
            this.guna2Panel2.TabIndex = 35;
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
            this.txtSearchAdmin.PlaceholderText = "Search by plate or slot...";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(378, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "My Parking History";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeColumns = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.Location = new System.Drawing.Point(384, 197);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 28;
            this.dgvHistory.Size = new System.Drawing.Size(1227, 593);
            this.dgvHistory.TabIndex = 36;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistory.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvHistory.ThemeStyle.ReadOnly = true;
            this.dgvHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistory.ThemeStyle.RowsStyle.Height = 28;
            this.dgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
            // 
            // UserParkingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserParkingHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Parking History";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistory;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAdmin;
    }
}