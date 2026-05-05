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
    public partial class frmAdminVehicles : Form
    {
        DataAccess da = new DataAccess();

        public frmAdminVehicles()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAdminVehicles_Load);
            this.dgvAdminVehicles.MouseDown += new MouseEventHandler(dgvAdminVehicles_MouseDown);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmAdminVehicles_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "Admin";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadTotalVehicles();
            LoadAllVehicles();
        }

        private void LoadTotalVehicles()
        {
            try
            {
                string sql = "SELECT COUNT(*) AS Total FROM vehicles";
                DataTable dt = da.ExecuteQueryTable(sql); // query total vehicles
                lblTotalVehicleNumber.Text = dt.Rows[0]["Total"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total: " + ex.Message);
            }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadAllVehicles(txtSearchAdmin.Text.Trim()); // live search vehicles
        }

        private void LoadAllVehicles(string searchTerm = "")
        {
            try
            {
                string whereClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    whereClause = " WHERE v.plate_number LIKE '%" + searchTerm + "%'" +
                                  " OR u.username LIKE '%" + searchTerm + "%'" +
                                  " OR v.vehicle_type LIKE '%" + searchTerm + "%'";
                }

                string sql = @"
                    SELECT 
                        v.vehicle_id AS [ID],
                        v.plate_number AS [Plate Number],
                        v.vehicle_type AS [Type],
                        u.username AS [Owner],
                        CASE 
                            WHEN EXISTS (
                                SELECT 1 FROM parking_records pr 
                                WHERE pr.vehicle_id = v.vehicle_id AND pr.exit_time IS NULL
                            ) 
                            THEN 'Active' 
                            ELSE 'Inactive' 
                        END AS [Status]
                    FROM vehicles v
                    INNER JOIN users u ON v.user_id = u.user_id"
                    + whereClause +
                    " ORDER BY v.vehicle_id";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvAdminVehicles.DataSource = dt;

                lblTotalVehicleNumber.Text = dt.Rows.Count.ToString();

                dgvAdminVehicles.EnableHeadersVisualStyles = false;
                dgvAdminVehicles.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dgvAdminVehicles.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                dgvAdminVehicles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvAdminVehicles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvAdminVehicles.ColumnHeadersHeight = 35;

                dgvAdminVehicles.RowsDefaultCellStyle.BackColor = Color.White;
                dgvAdminVehicles.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvAdminVehicles.DefaultCellStyle.SelectionBackColor = Color.Thistle;
                dgvAdminVehicles.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvAdminVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAdminVehicles.RowHeadersVisible = false;
                dgvAdminVehicles.AllowUserToAddRows = false;
                dgvAdminVehicles.AllowUserToDeleteRows = false;
                dgvAdminVehicles.ReadOnly = true;
                dgvAdminVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAdminVehicles.MultiSelect = false;
                dgvAdminVehicles.RowTemplate.Height = 35;
                dgvAdminVehicles.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        private void lblTotalVehicleNumber_Click(object sender, EventArgs e) { }
        private void dgvAdminVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvAdminVehicles_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvAdminVehicles.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvAdminVehicles.ClearSelection();
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

        private void lblWelcomeAdmin_Click(object sender, EventArgs e) { }
    }
}