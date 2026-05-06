using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class frmAdminUsers : Form
    {
        DataAccess da = new DataAccess();
        int selectedUserId = 0;
        bool isAddMode = false;

        public frmAdminUsers()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAdminUsers_Load);
            txtSearchAdmin.TextChanged += new EventHandler(txtSearchAdmin_TextChanged);
        }

        private void frmAdminUsers_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "Admin";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            if (cmbRoleAdmin.Items.Count == 0)
            {
                cmbRoleAdmin.Items.Add("Admin");
                cmbRoleAdmin.Items.Add("User");
            }

            cmbRoleAdmin.SelectedIndex = -1;
            LoadUsers();
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(txtSearchAdmin.Text.Trim()); // live search users
        }

        private void LoadUsers(string searchTerm = "")
        {
            try
            {
                string whereClause = "";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    whereClause = " WHERE u.username LIKE '%" + searchTerm + "%'" +
                                  " OR u.role LIKE '%" + searchTerm + "%'";
                }

                string sql = @"
                    SELECT 
                        u.user_id,
                        u.username AS Username, 
                        u.role AS Role,
                        (SELECT COUNT(*) FROM vehicles v WHERE v.user_id = u.user_id) AS Vehicles
                    FROM users u"
                    + whereClause +
                    " ORDER BY u.user_id";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvUsers.DataSource = dt;

                if (dgvUsers.Columns.Contains("user_id"))
                {
                    dgvUsers.Columns["user_id"].Visible = false;
                }

                dgvUsers.EnableHeadersVisualStyles = false;
                dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvUsers.ColumnHeadersHeight = 35;

                dgvUsers.RowsDefaultCellStyle.BackColor = Color.White;
                dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvUsers.DefaultCellStyle.SelectionBackColor = Color.Thistle;
                dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsers.RowHeadersVisible = false;
                dgvUsers.AllowUserToResizeRows = false;
                dgvUsers.RowTemplate.Height = 35;
                dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnUserAddAdmin_Click(object sender, EventArgs e)
        {
            ClearInputs();
            isAddMode = true;
            txtUsernameAdmin.Focus();
            MessageBox.Show("Enter new user details, then click Save.", "Add Mode");
        }

        private void btnUserSaveAdmin_Click(object sender, EventArgs e)
        {
            // gets user input
            string username = txtUsernameAdmin.Text.Trim();
            string password = txtPasswordAdmin.Text.Trim();
            string role = cmbRoleAdmin.Text.Trim();

            if (username == "" || role == "")
            {
                MessageBox.Show("Please fill out username and role.");
                return;
            }
            if (username.Length > 30)
            {
                MessageBox.Show("Username cannot exceed 30 characters.");
                return;
            }

            try
            {
                if (isAddMode || selectedUserId == 0) // if add mode
                {
                    // add new user
                    if (password == "")
                    {
                        MessageBox.Show("Password is required for new users.");
                        return;
                    }
                    if (password.Length > 5)
                    {
                        MessageBox.Show("Password cannot exceed 5 characters.");
                        return;
                    }

                    // check duplicate
                    string checkSql = "SELECT * FROM users WHERE username='" + username + "'";
                    DataTable dt = da.ExecuteQueryTable(checkSql); // check duplicate username
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("This username already exists.");
                        return; // stop execution
                    }

                    string insertSql = "INSERT INTO users (username, password, role) VALUES ('" + username + "', '" + password + "', '" + role + "')";
                    if (da.ExecuteDMLQuery(insertSql) > 0) // run insert query
                    {
                        MessageBox.Show("User added successfully!");
                    }
                }
                else // if edit mode
                {
                    // edit existing user

                    // cant change an admin's role
                    string currentRoleSql = "SELECT role FROM users WHERE user_id=" + selectedUserId;
                    DataTable dtCurrent = da.ExecuteQueryTable(currentRoleSql);
                    string currentRole = dtCurrent.Rows[0]["role"].ToString();

                    if (currentRole == "Admin" && role != "Admin")
                    {
                        MessageBox.Show("Cannot change the role of an Admin account.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // check duplicate username (excluding self)
                    string checkSql = "SELECT * FROM users WHERE username='" + username + "' AND user_id <> " + selectedUserId;
                    DataTable dt = da.ExecuteQueryTable(checkSql);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Another user with this username already exists.");
                        return;
                    }

                    // keep password if left empty
                    string updateSql;
                    if (password == "")
                    {
                        updateSql = "UPDATE users SET username='" + username + "', role='" + role + "' WHERE user_id=" + selectedUserId;
                    }
                    else
                    {
                        if (password.Length > 5)
                        {
                            MessageBox.Show("Password cannot exceed 5 characters.");
                            return;
                        }
                        updateSql = "UPDATE users SET username='" + username + "', password='" + password + "', role='" + role + "' WHERE user_id=" + selectedUserId;
                    }

                    if (da.ExecuteDMLQuery(updateSql) > 0) // run update query
                    {
                        MessageBox.Show("User updated successfully!");
                    }
                }

                ClearInputs();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message);
            }
        }

        private void btnUserDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) // validation: select first
            {
                MessageBox.Show("Please select a user from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?\n\nThis will also delete their vehicles and parking history!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                // cant delete an admin
                string roleCheckSql = "SELECT role FROM users WHERE user_id=" + selectedUserId;
                DataTable dtRole = da.ExecuteQueryTable(roleCheckSql);
                string userRole = dtRole.Rows[0]["role"].ToString();

                if (userRole == "Admin")
                {
                    MessageBox.Show("Admin accounts cannot be deleted.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // cant delete if they have active parking
                string activeSql = @"SELECT COUNT(*) FROM parking_records pr 
                                    INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id 
                                    WHERE v.user_id = " + selectedUserId + " AND pr.exit_time IS NULL";
                DataTable dtActive = da.ExecuteQueryTable(activeSql); // check active parking
                if (Convert.ToInt32(dtActive.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Cannot delete this user. They have a vehicle currently parked!", "Action Denied");
                    return;
                }

                // delete records then vehicles then user
                string deleteRecordsSql = @"DELETE FROM parking_records 
                                           WHERE vehicle_id IN (SELECT vehicle_id FROM vehicles WHERE user_id = " + selectedUserId + ")";
                da.ExecuteDMLQuery(deleteRecordsSql);

                string deleteVehiclesSql = "DELETE FROM vehicles WHERE user_id = " + selectedUserId;
                da.ExecuteDMLQuery(deleteVehiclesSql);

                string deleteUserSql = "DELETE FROM users WHERE user_id = " + selectedUserId;
                if (da.ExecuteDMLQuery(deleteUserSql) > 0) // run delete query
                {
                    MessageBox.Show("User deleted successfully!");
                    ClearInputs();
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["user_id"].Value);
                txtUsernameAdmin.Text = row.Cells["Username"].Value.ToString();

                // password stays empty for security
                txtPasswordAdmin.Clear();

                string userRole = row.Cells["Role"].Value.ToString();
                for (int i = 0; i < cmbRoleAdmin.Items.Count; i++)
                {
                    if (cmbRoleAdmin.Items[i].ToString() == userRole)
                    {
                        cmbRoleAdmin.SelectedIndex = i;
                        break;
                    }
                }

                isAddMode = false;
            }
        }

        private void dgvUsers_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvUsers.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtUsernameAdmin.Clear();
            txtPasswordAdmin.Clear();
            cmbRoleAdmin.SelectedIndex = -1;

            selectedUserId = 0;
            isAddMode = false;
            dgvUsers.ClearSelection();
        }

        private void txtUsernameAdmin_TextChanged(object sender, EventArgs e) { }
        private void txtPasswordAdmin_TextChanged(object sender, EventArgs e) { }
        private void cmbRoleAdmin_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

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