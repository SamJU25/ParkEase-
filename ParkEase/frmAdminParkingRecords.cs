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
    public partial class frmAdminParkingRecords : Form
    {
        DataAccess da = new DataAccess();

        public frmAdminParkingRecords()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAdminParkingRecords_Load);
            this.dgvAdminRecords.MouseDown += new MouseEventHandler(dgvAdminRecords_MouseDown);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmAdminParkingRecords_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "Admin";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadStats();
            LoadAllRecords();
        }

        private void LoadStats()
        {
            try
            {
                // total records
                string sqlTotal = "SELECT COUNT(*) AS Total FROM parking_records";
                DataTable dtTotal = da.ExecuteQueryTable(sqlTotal); // query total records
                lblTotalRecords.Text = dtTotal.Rows[0]["Total"].ToString();

                // active parkings
                string sqlActive = "SELECT COUNT(*) AS Active FROM parking_records WHERE exit_time IS NULL";
                DataTable dtActive = da.ExecuteQueryTable(sqlActive);
                lblActiveParkings.Text = dtActive.Rows[0]["Active"].ToString();

                // total earnings
                string sqlEarn = "SELECT ISNULL(SUM(fee), 0) AS TotalFee FROM parking_records WHERE is_paid = 1";
                DataTable dtEarn = da.ExecuteQueryTable(sqlEarn);
                decimal earnings = Convert.ToDecimal(dtEarn.Rows[0]["TotalFee"]);
                lblTotalEarnings.Text = "Tk " + earnings.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadAllRecords(txtSearchAdmin.Text.Trim()); // live search records
        }

        private void LoadAllRecords(string searchTerm = "")
        {
            try
            {
                string whereClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    whereClause = " WHERE v.plate_number LIKE '%" + searchTerm + "%'" +
                                  " OR u.username LIKE '%" + searchTerm + "%'";
                }

                string sql = @"
                    SELECT 
                        pr.record_id AS [ID],
                        v.plate_number AS [Plate],
                        u.username AS [Owner],
                        s.slot_number AS [Slot],
                        pr.entry_time AS [Entry Time],
                        ISNULL(CONVERT(varchar, pr.exit_time, 100), 'Currently Parked') AS [Exit Time],
                        ISNULL(CONVERT(varchar, pr.fee), '0.00') AS [Fee (Tk)],
                        CASE WHEN pr.exit_time IS NULL THEN 'Active' ELSE 'Completed' END AS [Status]
                    FROM parking_records pr
                    INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
                    INNER JOIN users u ON v.user_id = u.user_id
                    INNER JOIN parking_slots s ON pr.slot_id = s.slot_id"
                    + whereClause +
                    " ORDER BY pr.record_id DESC";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvAdminRecords.DataSource = dt;

                lblTotalRecords.Text = dt.Rows.Count.ToString();

                dgvAdminRecords.EnableHeadersVisualStyles = false;
                dgvAdminRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dgvAdminRecords.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                dgvAdminRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvAdminRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvAdminRecords.ColumnHeadersHeight = 35;

                dgvAdminRecords.RowsDefaultCellStyle.BackColor = Color.White;
                dgvAdminRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvAdminRecords.DefaultCellStyle.SelectionBackColor = Color.Thistle;
                dgvAdminRecords.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvAdminRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAdminRecords.RowHeadersVisible = false;
                dgvAdminRecords.AllowUserToAddRows = false;
                dgvAdminRecords.AllowUserToDeleteRows = false;
                dgvAdminRecords.ReadOnly = true;
                dgvAdminRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAdminRecords.MultiSelect = false;
                dgvAdminRecords.RowTemplate.Height = 35;
                dgvAdminRecords.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        private void lblTotalRecords_Click(object sender, EventArgs e) { }
        private void lblActiveParkings_Click(object sender, EventArgs e) { }
        private void lblTotalEarnings_Click(object sender, EventArgs e) { }
        private void dgvAdminRecords_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvAdminRecords_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvAdminRecords.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvAdminRecords.ClearSelection();
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
            try
            {
                frmAdminManageSlots form = new frmAdminManageSlots();
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

        private void lblWelcomeAdmin_Click(object sender, EventArgs e) { }
    }
}