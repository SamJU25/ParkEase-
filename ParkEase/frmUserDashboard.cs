using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class frmUserDashboard : Form
    {
        DataAccess da = new DataAccess();

        public frmUserDashboard()
        {
            InitializeComponent();
            this.dgvParkingHistory.MouseDown += new MouseEventHandler(dgvParkingHistory_MouseDown);
            this.Load += new EventHandler(frmUserDashboard_Load);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "User";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadSummaryCards();
            LoadParkingHistoryTable();
        }

        private void btnUserDashboard_Click(object sender, EventArgs e)
        {
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

        private void btnUserAvailableSlots_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserAvailableSlots form = new frmUserAvailableSlots();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

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
                Session.UserId = 0;
                Session.Username = "";
                Session.Role = "";

                frmSignIn login = new frmSignIn();
                login.Show();
                this.Close();
            }
        }

        private void LoadSummaryCards()
        {
            try
            {
                int userId = Session.UserId;

                // count active parkings
                string countSql = $@"
            SELECT COUNT(*) AS ActiveCount
            FROM parking_records pr
            INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
            WHERE v.user_id = {userId} AND pr.exit_time IS NULL";
                DataTable dtCount = da.ExecuteQueryTable(countSql);
                int activeCount = Convert.ToInt32(dtCount.Rows[0]["ActiveCount"]);

                // get latest parked vehicle
                string activeSql = $@"
            SELECT TOP 1 v.plate_number, pr.entry_time 
            FROM parking_records pr
            INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
            WHERE v.user_id = {userId} AND pr.exit_time IS NULL
            ORDER BY pr.entry_time DESC";

                DataTable dtActive = da.ExecuteQueryTable(activeSql);

                if (dtActive.Rows.Count > 0)
                {
                    string latestPlate = dtActive.Rows[0]["plate_number"].ToString();

                    if (activeCount > 1)
                    {
                        lblVehicleInfoValue.Text = latestPlate + " (" + activeCount + " total)";
                        lblParkingStatusValue.Text = "Yes (" + activeCount + " active)";
                    }
                    else
                    {
                        lblVehicleInfoValue.Text = latestPlate;
                        lblParkingStatusValue.Text = "Yes";
                    }

                    DateTime entry = Convert.ToDateTime(dtActive.Rows[0]["entry_time"]);
                    lblStartingTimeUser.Text = entry.ToString("hh:mm tt");
                    lblEndingTimeUser.Text = "Present";
                }
                else
                {
                    // no active parking
                    string anyVehicleSql = $"SELECT TOP 1 plate_number FROM vehicles WHERE user_id = {userId} ORDER BY vehicle_id DESC";
                    DataTable dtAny = da.ExecuteQueryTable(anyVehicleSql);
                    if (dtAny.Rows.Count > 0)
                        lblVehicleInfoValue.Text = dtAny.Rows[0]["plate_number"].ToString();
                    else
                        lblVehicleInfoValue.Text = "None";

                    lblParkingStatusValue.Text = "No";
                    lblStartingTimeUser.Text = "--:--";
                    lblEndingTimeUser.Text = "--:--";
                }

                // total spending
                string spendSql = $@"
            SELECT ISNULL(SUM(fee), 0) AS TotalSpent 
            FROM parking_records pr
            INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
            WHERE v.user_id = {userId} AND pr.is_paid = 1";

                DataTable dtSpend = da.ExecuteQueryTable(spendSql);
                decimal totalSpent = Convert.ToDecimal(dtSpend.Rows[0]["TotalSpent"]);
                lblTotalSpendingValue.Text = "Tk " + totalSpent.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard metrics: " + ex.Message);
            }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadParkingHistoryTable(txtSearchAdmin.Text.Trim());
        }

        private void LoadParkingHistoryTable(string searchTerm = "")
        {
            try
            {
                int userId = Session.UserId;

                string searchClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    searchClause = " AND (v.plate_number LIKE '%" + searchTerm + "%' " +
                                   "      OR s.slot_number LIKE '%" + searchTerm + "%') ";
                }

                string historySql = $@"
                    SELECT 
                        v.plate_number AS [Vehicle],
                        s.slot_number AS [Slot],
                        pr.entry_time AS [Entry Time],
                        ISNULL(CONVERT(varchar, pr.exit_time, 100), 'Currently Parked') AS [Exit Time],
                        ISNULL(CONVERT(varchar, pr.fee), '0.00') AS [Fee (Tk)],
                        CASE WHEN pr.exit_time IS NULL THEN 'Active' ELSE 'Completed' END AS [Status]
                    FROM parking_records pr
                    INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
                    INNER JOIN parking_slots s ON pr.slot_id = s.slot_id
                    WHERE v.user_id = {userId} " + searchClause + @"
                    ORDER BY pr.entry_time DESC";

                DataTable dtHistory = da.ExecuteQueryTable(historySql);
                dgvParkingHistory.DataSource = dtHistory;

                StyleDataGridView(dgvParkingHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parking history: " + ex.Message);
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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

        private void lblVehicleInfoUser_Click(object sender, EventArgs e) { }
        private void lblParkingStatusUser_Click(object sender, EventArgs e) { }
        private void lblStartingTimeUser_Click(object sender, EventArgs e) { }
        private void lblEndingTimeUser_Click(object sender, EventArgs e) { }
        private void lblTotalSpendingValue_Click(object sender, EventArgs e) { }
        private void dgvParkingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvParkingHistory_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvParkingHistory.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvParkingHistory.ClearSelection();
            }
        }

        private void btnUserDashboard_Click_1(object sender, EventArgs e)
        {
            btnUserDashboard_Click(sender, e);
        }

        private void btnUserMyVehicles_Click_1(object sender, EventArgs e)
        {
            btnUserMyVehicles_Click(sender, e);
        }

        private void btnUserAvailableSlots_Click_1(object sender, EventArgs e)
        {
            btnUserAvailableSlots_Click(sender, e);
        }

        private void btnUserParkingHistory_Click_1(object sender, EventArgs e)
        {
            btnUserParkingHistory_Click(sender, e);
        }

        private void btnUserPayment_Click_1(object sender, EventArgs e)
        {
            btnUserPayment_Click(sender, e);
        }

        private void btnUserSettings_Click_1(object sender, EventArgs e)
        {
            btnUserSettings_Click(sender, e);
        }

        private void btnLogOutUser_Click_1(object sender, EventArgs e)
        {
            btnLogOutUser_Click(sender, e);
        }

        private void lblWelcomeUser_Click(object sender, EventArgs e) { }
    }
}