using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class frmUserAvailableSlots : Form
    {
        DataAccess da = new DataAccess();
        int loggedInUserId;

        public frmUserAvailableSlots()
        {
            InitializeComponent();
            loggedInUserId = Session.UserId;
            this.Load += new EventHandler(frmUserAvailableSlots_Load);
            this.dgvAvailableSlots.MouseDown += new MouseEventHandler(dgvAvailableSlots_MouseDown);
            this.dgvParkedVehicles.MouseDown += new MouseEventHandler(dgvParkedVehicles_MouseDown);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmUserAvailableSlots_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "User";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadMyVehicles();
            LoadAvailableSlotsDropdown();
            LoadAvailableSlotsTable();
            LoadParkedVehicles();
        }

        // load vehicles into dropdown
        private void LoadMyVehicles()
        {
            try
            {
                string sql = $@"SELECT vehicle_id, plate_number + ' (' + vehicle_type + ')' AS Display 
                               FROM vehicles WHERE user_id = {loggedInUserId}";
                DataTable dt = da.ExecuteQueryTable(sql);

                cmbMyVehicles.DataSource = dt;
                cmbMyVehicles.DisplayMember = "Display";
                cmbMyVehicles.ValueMember = "vehicle_id";
                cmbMyVehicles.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        // load available slots dropdown
        private void LoadAvailableSlotsDropdown()
        {
            try
            {
                string sql = "SELECT slot_id, slot_number AS Display " +
                             "FROM parking_slots WHERE status='Available' ORDER BY slot_number";
                DataTable dt = da.ExecuteQueryTable(sql);

                cmbAvailableSlots.DataSource = dt;
                cmbAvailableSlots.DisplayMember = "Display";
                cmbAvailableSlots.ValueMember = "slot_id";
                cmbAvailableSlots.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slots: " + ex.Message);
            }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadAvailableSlotsTable(txtSearchAdmin.Text.Trim());
        }

        private void LoadAvailableSlotsTable(string searchTerm = "")
        {
            try
            {
                string searchClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    searchClause = " AND (slot_number LIKE '%" + searchTerm + "%'" +
                                   " OR vehicle_type LIKE '%" + searchTerm + "%')";
                }

                // CHANGED: Removed 'vehicle_type AS [Vehicle Type]' from the SELECT statement
                string sql = "SELECT slot_number AS [Slot Number], status AS Status " +
                             "FROM parking_slots WHERE status='Available'" + searchClause + " ORDER BY slot_number";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvAvailableSlots.DataSource = dt;

                StyleDataGridView(dgvAvailableSlots);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available slots table: " + ex.Message);
            }
        }

        // load currently parked vehicles
        private void LoadParkedVehicles()
        {
            try
            {
                string sql = $@"SELECT 
                                pr.record_id AS ID,
                                v.plate_number AS [Plate Number],
                                s.slot_number AS [Slot],
                                pr.entry_time AS [Entry Time]
                             FROM parking_records pr
                             INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
                             INNER JOIN parking_slots s ON pr.slot_id = s.slot_id
                             WHERE v.user_id = {loggedInUserId} 
                             AND pr.exit_time IS NULL
                             ORDER BY pr.entry_time DESC";
                DataTable dt = da.ExecuteQueryTable(sql);
                dgvParkedVehicles.DataSource = dt;

                StyleDataGridView(dgvParkedVehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parked vehicles: " + ex.Message);
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 35;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Thistle;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowTemplate.Height = 35;
            dgv.ClearSelection();
        }

        private void btnParkHere_Click(object sender, EventArgs e)
        {
            if (cmbMyVehicles.SelectedIndex == -1 || cmbMyVehicles.SelectedValue == null)
            {
                MessageBox.Show("Please select your vehicle first.", "No Vehicle Selected");
                return;
            }
            if (cmbAvailableSlots.SelectedIndex == -1 || cmbAvailableSlots.SelectedValue == null)
            {
                MessageBox.Show("Please select an available slot.", "No Slot Selected");
                return;
            }

            try
            {
                int vehicleId = Convert.ToInt32(cmbMyVehicles.SelectedValue);
                int slotId = Convert.ToInt32(cmbAvailableSlots.SelectedValue);

                //check if already parked
                string checkSql = $"SELECT COUNT(*) FROM parking_records WHERE vehicle_id = {vehicleId} AND exit_time IS NULL";
                DataTable dtCheck = da.ExecuteQueryTable(checkSql);
                if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This vehicle is already parked! Exit it first.", "Already Parked");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Confirm parking this vehicle?",
                    "Confirm Parking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                string insertSql = $@"INSERT INTO parking_records 
                    (vehicle_id, slot_id, entry_time, exit_time, fee, is_paid) 
                    VALUES ({vehicleId}, {slotId}, GETDATE(), NULL, NULL, 0)";
                int insertResult = da.ExecuteDMLQuery(insertSql);

                if (insertResult > 0)
                {
                    // mark slot as booked
                    string updateSql = $"UPDATE parking_slots SET status='Booked' WHERE slot_id = {slotId}";
                    da.ExecuteDMLQuery(updateSql);

                    MessageBox.Show("Vehicle parked successfully! Have a great day!", "Success");

                    LoadAvailableSlotsDropdown();
                    LoadAvailableSlotsTable();
                    LoadParkedVehicles();

                    cmbMyVehicles.SelectedIndex = -1;
                    cmbAvailableSlots.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvParkedVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvParkedVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a currently parked vehicle to checkout.", "Select Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvParkedVehicles.SelectedRows[0];
            int recordId = Convert.ToInt32(row.Cells["ID"].Value);
            string slotNumber = row.Cells["Slot"].Value.ToString();

            try
            {
                // get entry time
                string getEntrySql = "SELECT entry_time FROM parking_records WHERE record_id = " + recordId;
                DataTable dt = da.ExecuteQueryTable(getEntrySql);

                if (dt.Rows.Count > 0)
                {
                    DateTime entryTime = Convert.ToDateTime(dt.Rows[0]["entry_time"]);
                    DateTime exitTime = DateTime.Now;

                    TimeSpan timeStayed = exitTime - entryTime;

                    // round up to nearest hour
                    double totalHours = Math.Ceiling(timeStayed.TotalHours);
                    if (totalHours == 0) totalHours = 1; // minimum 1 hour

                    double hourlyRate = 50.0;
                    double totalCost = totalHours * hourlyRate;

                    DialogResult payConfirm = MessageBox.Show(
                        $"--- PARKING BILL SUMMARY ---\n\n" +
                        $"Slot: {slotNumber}\n" +
                        $"Entry Time: {entryTime.ToString("g")}\n" +
                        $"Exit Time: {exitTime.ToString("g")}\n" +
                        $"Total Time: {totalHours} hour(s)\n\n" +
                        $"Total Amount Due: ৳{totalCost}\n\n" +
                        "Proceed to the payment screen to pay this bill?",
                        "Checkout Summary",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (payConfirm == DialogResult.Yes)
                    {
                        frmUserPayment paymentForm = new frmUserPayment(recordId);
                        paymentForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Checkout cancelled. Your vehicle is still parked.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating payment: " + ex.Message);
            }
        }

        private void cmbMyVehicles_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbAvailableSlots_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvAvailableSlots_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvAvailableSlots_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvAvailableSlots.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvAvailableSlots.ClearSelection();
            }
        }

        private void dgvParkedVehicles_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvParkedVehicles.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvParkedVehicles.ClearSelection();
            }
        }

        // SIDEBAR NAVIGATION
        private void btnUserDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserDashboard form = new frmUserDashboard();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUserMyVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserVehicles form = new frmUserVehicles();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUserAvailableSlots_Click(object sender, EventArgs e) { }

        private void btnUserParkingHistory_Click(object sender, EventArgs e)
        {
            try
            {
                UserParkingHistory form = new UserParkingHistory();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUserPayment_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserPayment form = new frmUserPayment();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserSettings form = new frmUserSettings();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLogOutUser_Click(object sender, EventArgs e)
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

        private void lblWelcomeUser_Click(object sender, EventArgs e) { }
    }
}