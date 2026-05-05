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
    public partial class frmAdminDashboard : Form
    {
        DataAccess da = new DataAccess();

        public frmAdminDashboard()
        {
            InitializeComponent();
            this.dgvRecentRecords.MouseDown += new MouseEventHandler(dgvRecentRecords_MouseDown);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "Admin";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            LoadDashboardData(); // load stats
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnAdminManageSlots_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdminManageSlots form = new frmAdminManageSlots(); // open manage slots form
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                frmSignIn login = new frmSignIn(); // opens login form
                login.Show();
                this.Close(); // close dashboard
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                // count total slots
                string sqlTotal = "SELECT COUNT(*) AS Total FROM parking_slots";
                DataTable dtTotal = da.ExecuteQueryTable(sqlTotal); // query total slots
                lblTotalSlotsValue.Text = dtTotal.Rows[0]["Total"].ToString();

                // available
                string sqlAvail = "SELECT COUNT(*) AS Avail FROM parking_slots WHERE status='Available'";
                DataTable dtAvail = da.ExecuteQueryTable(sqlAvail);
                lblAvailableSlotsValue.Text = dtAvail.Rows[0]["Avail"].ToString();

                // booked
                string sqlUsed = "SELECT COUNT(*) AS Used FROM parking_slots WHERE status='Booked'";
                DataTable dtUsed = da.ExecuteQueryTable(sqlUsed);
                lblUsedSlotsValue.Text = dtUsed.Rows[0]["Used"].ToString();

                // sum earnings
                string sqlEarn = "SELECT ISNULL(SUM(fee), 0) AS TotalFee FROM parking_records WHERE is_paid=1";
                DataTable dtEarn = da.ExecuteQueryTable(sqlEarn); // query total earnings
                lblTotalEarningsValue.Text = "Tk " + dtEarn.Rows[0]["TotalFee"].ToString();

                LoadRecentRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadRecentRecords(txtSearchAdmin.Text.Trim()); // live search on typing
        }

        private void LoadRecentRecords(string searchTerm = "")
        {
            try
            {
                string searchClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    searchClause = " AND (v.plate_number LIKE '%" + searchTerm + "%' " +
                                   "      OR u.username LIKE '%" + searchTerm + "%' " +
                                   "      OR s.slot_number LIKE '%" + searchTerm + "%') ";
                }

                string sqlRecords = @"SELECT TOP 20 v.plate_number AS Plate, 
                      u.username AS Owner,
                      s.slot_number AS Slot, 
                      p.entry_time AS EntryTime, 
                      p.exit_time AS ExitTime, 
                      p.fee AS Fee
                      FROM parking_records p
                      INNER JOIN vehicles v ON p.vehicle_id = v.vehicle_id
                      INNER JOIN users u ON v.user_id = u.user_id
                      INNER JOIN parking_slots s ON p.slot_id = s.slot_id
                      WHERE p.exit_time IS NULL " + searchClause +
                      " ORDER BY p.record_id DESC";

                DataTable dtRecords = da.ExecuteQueryTable(sqlRecords); // query recent records
                dgvRecentRecords.DataSource = dtRecords; // bind to grid

                dgvRecentRecords.EnableHeadersVisualStyles = false;
                dgvRecentRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dgvRecentRecords.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                dgvRecentRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvRecentRecords.RowsDefaultCellStyle.BackColor = Color.White;
                dgvRecentRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvRecentRecords.DefaultCellStyle.SelectionBackColor = Color.Thistle;
                dgvRecentRecords.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvRecentRecords.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent records: " + ex.Message);
            }
        }

        private void lblTotalSlots_Click(object sender, EventArgs e) { }

        private void btnAdminDashboard_Click_1(object sender, EventArgs e)
        {
            btnAdminDashboard_Click(sender, e);
        }

        private void btnAdminManageSlots_Click_1(object sender, EventArgs e)
        {
            btnAdminManageSlots_Click(sender, e);
        }

        private void btnAdminVehicles_Click_1(object sender, EventArgs e)
        {
            btnAdminVehicles_Click(sender, e);
        }

        private void btnAdminParkingRecords_Click_1(object sender, EventArgs e)
        {
            btnAdminParkingRecords_Click(sender, e);
        }

        private void btnAdminUsers_Click_1(object sender, EventArgs e)
        {
            btnAdminUsers_Click(sender, e);
        }

        private void btnAdminSettings_Click_1(object sender, EventArgs e)
        {
            btnAdminSettings_Click(sender, e);
        }

        private void btnLogOutAdmin_Click_1(object sender, EventArgs e)
        {
            btnLogOutAdmin_Click(sender, e);
        }

        private void dgvRecentRecords_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvRecentRecords.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvRecentRecords.ClearSelection();
            }
        }

        private void lblWelcomeAdmin_Click(object sender, EventArgs e) { }
    }
}