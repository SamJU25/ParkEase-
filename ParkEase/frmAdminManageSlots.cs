using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class frmAdminManageSlots : Form
    {
        DataAccess da = new DataAccess();
        int selectedSlotId = 0;

        public frmAdminManageSlots()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAdminManageSlots_Load);
            this.dgvSlots.MouseDown += new MouseEventHandler(dgvSlots_MouseDown);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmAdminManageSlots_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "Admin";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // setup status dropdown
            cmbSlotStatusAdmin.Items.Clear();
            cmbSlotStatusAdmin.Items.Add("Available");
            cmbSlotStatusAdmin.Items.Add("Booked");
            cmbSlotStatusAdmin.Items.Add("Maintenance");
            cmbSlotStatusAdmin.SelectedIndex = 0;

            if (cmbSlotVehicleTypeAdmin.Items.Count == 0)
            {
                cmbSlotVehicleTypeAdmin.Items.Add("Car");
                cmbSlotVehicleTypeAdmin.Items.Add("Motorcycle");
                cmbSlotVehicleTypeAdmin.Items.Add("Van");
            }
            if (cmbSlotVehicleTypeAdmin.Items.Count > 0)
            {
                cmbSlotVehicleTypeAdmin.SelectedIndex = 0;
            }

            LoadSlots();
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadSlots(txtSearchAdmin.Text.Trim()); // live search slots
        }

        private void LoadSlots(string searchTerm = "")
        {
            try
            {
                string whereClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    whereClause = " WHERE slot_number LIKE '%" + searchTerm + "%'" +
                                  " OR vehicle_type LIKE '%" + searchTerm + "%'";
                }

                string sql = "SELECT slot_id, slot_number AS [Slot Number], vehicle_type AS [Vehicle Type], status AS Status FROM parking_slots" + whereClause + " ORDER BY slot_id";
                DataTable dt = da.ExecuteQueryTable(sql);
                dgvSlots.DataSource = dt;

                if (dgvSlots.Columns.Contains("slot_id"))
                {
                    dgvSlots.Columns["slot_id"].Visible = false;
                }

                dgvSlots.EnableHeadersVisualStyles = false;
                dgvSlots.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dgvSlots.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                dgvSlots.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSlots.ColumnHeadersHeight = 35;

                dgvSlots.RowsDefaultCellStyle.BackColor = Color.White;
                dgvSlots.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvSlots.DefaultCellStyle.SelectionBackColor = Color.Thistle;
                dgvSlots.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSlots.RowHeadersVisible = false;
                dgvSlots.AllowUserToResizeRows = false;
                dgvSlots.RowTemplate.Height = 35;
                dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSlots.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slots: " + ex.Message);
            }
        }

        // validate slot format like A-01
        private bool IsValidSlotFormat(string slotNumber)
        {
            string pattern = @"^[A-Za-z]-\d{2}$";
            return Regex.IsMatch(slotNumber, pattern);
        }

        private void btnSlotAddAdmin_Click(object sender, EventArgs e)
        {
            ClearInputs();
            txtSlotNumberAdmin.Focus();
        }

        private void btnSlotSaveAdmin_Click(object sender, EventArgs e)
        {
            // gets user input
            string slotNumber = txtSlotNumberAdmin.Text.Trim().ToUpper();
            string vehicleType = cmbSlotVehicleTypeAdmin.Text.Trim();
            string status = cmbSlotStatusAdmin.Text.Trim();

            if (slotNumber == "" || vehicleType == "" || status == "")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            // check format
            if (!IsValidSlotFormat(slotNumber)) // regex validation
            {
                MessageBox.Show("Invalid slot number format. Use format like A-01, S-13.");
                return;
            }

            try
            {
                if (selectedSlotId == 0) // if add mode
                {
                    // adding new slot
                    string checkSql = "SELECT * FROM parking_slots WHERE slot_number='" + slotNumber + "'";
                    DataTable dt = da.ExecuteQueryTable(checkSql); // check duplicate slot
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("This slot number already exists.");
                        return; // stop execution
                    }

                    string insertSql = "INSERT INTO parking_slots (slot_number, vehicle_type, status) VALUES ('" + slotNumber + "', '" + vehicleType + "', '" + status + "')";
                    if (da.ExecuteDMLQuery(insertSql) > 0) // run insert query
                    {
                        MessageBox.Show("Slot added successfully!");
                    }
                }
                else // if edit mode
                {
                    // editing existing slot

                    // cant edit if car is parked
                    string checkParkedSql = "SELECT * FROM parking_records WHERE slot_id=" + selectedSlotId + " AND exit_time IS NULL";
                    DataTable dtParked = da.ExecuteQueryTable(checkParkedSql); // check active parking
                    if (dtParked.Rows.Count > 0)
                    {
                        MessageBox.Show("You cannot edit this slot because a vehicle is currently parked here! The vehicle must exit first.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // no duplicate slot numbers
                    string checkSql = "SELECT * FROM parking_slots WHERE slot_number='" + slotNumber + "' AND slot_id <> " + selectedSlotId;
                    DataTable dt = da.ExecuteQueryTable(checkSql);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Another slot is already using this number.");
                        return;
                    }

                    string updateSql = "UPDATE parking_slots SET slot_number='" + slotNumber + "', vehicle_type='" + vehicleType + "', status='" + status + "' WHERE slot_id=" + selectedSlotId;
                    if (da.ExecuteDMLQuery(updateSql) > 0)
                    {
                        MessageBox.Show("Slot updated successfully!");
                    }
                }

                ClearInputs();
                LoadSlots();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving slot: " + ex.Message);
            }
        }

        private void btnSlotDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (selectedSlotId == 0) // validation: select first
            {
                MessageBox.Show("Please select a slot from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this slot?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                // cant delete if car is parked here or slot is booked
                string checkSql = "SELECT * FROM parking_records WHERE slot_id=" + selectedSlotId + " AND exit_time IS NULL";
                DataTable dt = da.ExecuteQueryTable(checkSql); // check active parking

                string checkStatusSql = "SELECT * FROM parking_slots WHERE slot_id=" + selectedSlotId + " AND status='Booked'";
                DataTable dtStatus = da.ExecuteQueryTable(checkStatusSql); // check booked status

                if (dt.Rows.Count > 0 || dtStatus.Rows.Count > 0)
                {
                    MessageBox.Show("Cannot delete this slot. It is currently booked or a vehicle is parked here.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "DELETE FROM parking_slots WHERE slot_id=" + selectedSlotId;
                if (da.ExecuteDMLQuery(sql) > 0) // run delete query
                {
                    MessageBox.Show("Slot deleted successfully!");
                    ClearInputs();
                    LoadSlots();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting slot: " + ex.Message);
            }
        }

        private void dgvSlots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSlots.Rows[e.RowIndex];
                selectedSlotId = Convert.ToInt32(row.Cells["slot_id"].Value);
                txtSlotNumberAdmin.Text = row.Cells["Slot Number"].Value.ToString();
                cmbSlotVehicleTypeAdmin.Text = row.Cells["Vehicle Type"].Value.ToString();
                cmbSlotStatusAdmin.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtSlotNumberAdmin.Clear();
            if (cmbSlotVehicleTypeAdmin.Items.Count > 0) cmbSlotVehicleTypeAdmin.SelectedIndex = 0;
            if (cmbSlotStatusAdmin.Items.Count > 0) cmbSlotStatusAdmin.SelectedIndex = 0;

            selectedSlotId = 0;
            dgvSlots.ClearSelection();
        }

        private void txtSlotNumberAdmin_TextChanged(object sender, EventArgs e) { }
        private void cmbSlotVehicleTypeAdmin_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbSlotStatusAdmin_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvSlots_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvSlots_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvSlots.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearInputs();
            }
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminDashboard form = new frmAdminDashboard();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdminManageSlots_Click(object sender, EventArgs e)
        {
        }

        private void btnAdminVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminVehicles form = new frmAdminVehicles();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdminParkingRecords_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminParkingRecords form = new frmAdminParkingRecords();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminUsers form = new frmAdminUsers();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdminSettings_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminSettings form = new frmAdminSettings();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmSignIn login = new frmSignIn();
                login.Show();
                this.Close();
            }
        }

        private void lblWelcomeAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}