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
    public partial class UserParkingHistory : Form
    {
        DataAccess da = new DataAccess();

        public UserParkingHistory()
        {
            InitializeComponent();

            this.Load += new EventHandler(UserParkingHistory_Load);

            if (this.dgvHistory != null)
            {
                this.dgvHistory.MouseDown += new MouseEventHandler(dgvHistory_MouseDown);
            }

            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void UserParkingHistory_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "User";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadHistoryTable();
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadHistoryTable(txtSearchAdmin.Text.Trim()); // live search history
        }

        private void LoadHistoryTable(string searchTerm = "")
        {
            try
            {
                string searchClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    searchClause = " AND (v.plate_number LIKE '%" + searchTerm + "%' " +
                                   "      OR s.slot_number LIKE '%" + searchTerm + "%') ";
                }

                string sql = $@"SELECT 
                                v.plate_number AS [Plate Number],
                                s.slot_number AS [Slot],
                                pr.entry_time AS [Entry Time],
                                ISNULL(FORMAT(pr.exit_time, 'M/d/yyyy h:mm tt'), 'Still Parked') AS [Exit Time],
                                ISNULL(CONVERT(varchar, pr.fee), '0.00') AS [Fee (৳)],
                                CASE WHEN pr.is_paid = 1 THEN 'Paid' ELSE 'Pending' END AS [Status]
                             FROM parking_records pr
                             INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
                             INNER JOIN parking_slots s ON pr.slot_id = s.slot_id
                             WHERE v.user_id = {Session.UserId} " + searchClause +
                             " ORDER BY pr.entry_time DESC";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvHistory.DataSource = dt;

                StyleDataGridView(dgvHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message);
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 35;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Thistle;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);

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

        private void dgvHistory_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvHistory.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvHistory.ClearSelection();
            }
        }

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
        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}