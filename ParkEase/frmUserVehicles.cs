using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ParkEase
{
    public partial class frmUserVehicles : Form
    {
        DataAccess da = new DataAccess();
        int loggedInUserId;
        int selectedVehicleId = 0; // 0 means 'New Record', >0 means 'Editing Record'

        public frmUserVehicles()
        {
            InitializeComponent();
            loggedInUserId = Session.UserId;

            this.Load += new EventHandler(frmUserVehicles_Load);
            this.dgvMyVehicles.MouseDown += new MouseEventHandler(dgvMyVehicles_MouseDown);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmUserVehicles_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "User";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadSummaryCards();
            LoadMyVehicles();
        }

        private void LoadSummaryCards()
        {
            try
            {
                string sqlTotal = $"SELECT COUNT(*) AS Total FROM vehicles WHERE user_id = {loggedInUserId}";
                DataTable dtTotal = da.ExecuteQueryTable(sqlTotal);
                lblTotalVehiclesUser.Text = dtTotal.Rows[0]["Total"].ToString();
            }
            catch { /* Ignore empty counts */ }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadMyVehicles(txtSearchAdmin.Text.Trim());
        }

        private void LoadMyVehicles(string searchTerm = "")
        {
            try
            {
                string searchClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    searchClause = " AND (v.plate_number LIKE '%" + searchTerm + "%'" +
                                   " OR v.vehicle_type LIKE '%" + searchTerm + "%')";
                }

                string query = $@"
                    SELECT 
                        v.vehicle_id AS ID, 
                        v.plate_number AS [Plate Number], 
                        v.vehicle_type AS [Type]
                    FROM vehicles v
                    WHERE v.user_id = {loggedInUserId}" + searchClause;

                DataTable dt = da.ExecuteQueryTable(query);
                dgvMyVehicles.DataSource = dt;

                lblTotalVehiclesUser.Text = dt.Rows.Count.ToString();

                // Grid Styling
                dgvMyVehicles.EnableHeadersVisualStyles = false;
                dgvMyVehicles.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dgvMyVehicles.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                dgvMyVehicles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvMyVehicles.ColumnHeadersHeight = 35;

                dgvMyVehicles.RowsDefaultCellStyle.BackColor = Color.White;
                dgvMyVehicles.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvMyVehicles.DefaultCellStyle.SelectionBackColor = Color.Thistle;
                dgvMyVehicles.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvMyVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMyVehicles.RowHeadersVisible = false;
                dgvMyVehicles.AllowUserToResizeRows = false;
                dgvMyVehicles.RowTemplate.Height = 35;
                dgvMyVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMyVehicles.MultiSelect = false;
                dgvMyVehicles.ReadOnly = true;
                dgvMyVehicles.AllowUserToAddRows = false;

                dgvMyVehicles.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        // ADD BUTTON (Prepares form for a new entry)
        private void btnVehicleAddUser_Click(object sender, EventArgs e)
        {
            ClearInputs(); // Clears boxes and sets selectedVehicleId to 0
            txtPlateNumberUser.Focus();
        }

        // SAVE BUTTON (Handles both Insert & Update)
        private void btnVehicleEditUser_Click(object sender, EventArgs e)
        {
            // 1. Validate Input
            if (string.IsNullOrWhiteSpace(txtPlateNumberUser.Text) || cmbVehicleTypeUser.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a plate number and select a vehicle type.", "Missing Info");
                return;
            }

            string platePattern = @"^[A-Za-z]{3}-\d{4}$";
            if (!Regex.IsMatch(txtPlateNumberUser.Text, platePattern))
            {
                MessageBox.Show("Invalid Plate Format! Use like ABC-1234.", "Format Error");
                return;
            }

            string finalPlate = txtPlateNumberUser.Text.ToUpper();

            try
            {
                string query = "";

                // 2. Determine Action: INSERT (New) or UPDATE (Edit)
                if (selectedVehicleId == 0)
                {
                    // --- INSERT MODE ---
                    string checkSql = $"SELECT COUNT(*) FROM vehicles WHERE plate_number = '{finalPlate}'";
                    if (Convert.ToInt32(da.ExecuteQueryTable(checkSql).Rows[0][0]) > 0)
                    {
                        MessageBox.Show("This license plate is already registered!", "Duplicate");
                        return;
                    }

                    query = $"INSERT INTO vehicles (user_id, plate_number, vehicle_type) VALUES ({loggedInUserId}, '{finalPlate}', '{cmbVehicleTypeUser.Text}')";
                }
                else
                {
                    // --- UPDATE MODE ---
                    string checkSql = $"SELECT COUNT(*) FROM vehicles WHERE plate_number = '{finalPlate}' AND vehicle_id <> {selectedVehicleId}";
                    if (Convert.ToInt32(da.ExecuteQueryTable(checkSql).Rows[0][0]) > 0)
                    {
                        MessageBox.Show("Another vehicle has this plate already!");
                        return;
                    }

                    query = $"UPDATE vehicles SET plate_number = '{finalPlate}', vehicle_type = '{cmbVehicleTypeUser.Text}' WHERE vehicle_id = {selectedVehicleId}";
                }

                // 3. Execute query
                if (da.ExecuteDMLQuery(query) > 0)
                {
                    MessageBox.Show(selectedVehicleId == 0 ? "Vehicle added successfully!" : "Vehicle updated successfully!", "Success");
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // DELETE BUTTON

        private void btnVehicleDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedVehicleId == 0)
            {
                MessageBox.Show("Please click on a vehicle from the table first.");
                return;
            }

            // check if currently parked
            string checkActiveQuery = $"SELECT COUNT(*) FROM parking_records WHERE vehicle_id = {selectedVehicleId} AND exit_time IS NULL";
            if (Convert.ToInt32(da.ExecuteQueryTable(checkActiveQuery).Rows[0][0]) > 0)
            {
                MessageBox.Show("Cannot delete a currently parked vehicle!");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM vehicles WHERE vehicle_id = {selectedVehicleId}";
                    if (da.ExecuteDMLQuery(query) > 0)
                    {
                        MessageBox.Show("Vehicle deleted successfully!");
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vehicle: " + ex.Message);
                }
            }
        }

        private void dgvMyVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMyVehicles.Rows[e.RowIndex];
                selectedVehicleId = Convert.ToInt32(row.Cells["ID"].Value);
                txtPlateNumberUser.Text = row.Cells["Plate Number"].Value.ToString();
                cmbVehicleTypeUser.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtPlateNumberUser.Clear();
            cmbVehicleTypeUser.SelectedIndex = -1;
            selectedVehicleId = 0; // Reset back to "Add Mode"

            LoadSummaryCards();
            LoadMyVehicles();
        }

        private void dgvMyVehicles_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvMyVehicles.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearInputs(); // Clicking blank space clears selection
            }
        }

        private void btnUserDashboard_Click(object sender, EventArgs e) { new frmUserDashboard().Show(); this.Hide(); }
        private void btnUserMyVehicles_Click(object sender, EventArgs e) { /* Do nothing, already here */ }
        private void btnUserAvailableSlots_Click(object sender, EventArgs e) { new frmUserAvailableSlots().Show(); this.Hide(); }
        private void btnUserParkingHistory_Click(object sender, EventArgs e) { new UserParkingHistory().Show(); this.Hide(); }
        private void btnUserPayment_Click(object sender, EventArgs e) { new frmUserPayment().Show(); this.Hide(); }
        private void btnUserSettings_Click(object sender, EventArgs e) { new frmUserSettings().Show(); this.Hide(); }

        private void btnLogOutUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmSignIn().Show();
                this.Close();
            }
        }

        // Empty Designer placeholders to prevent crashes
        private void label7_Click(object sender, EventArgs e) { }
        private void lblTotalVehiclesUser_Click(object sender, EventArgs e) { }
        private void txtPlateNumberUser_TextChanged(object sender, EventArgs e) { }
        private void cmbVehicleTypeUser_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblWelcomeUser_Click(object sender, EventArgs e) { }
    }
}