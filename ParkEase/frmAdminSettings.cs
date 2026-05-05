using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class frmAdminSettings : Form
    {
        DataAccess da = new DataAccess();
        string actualCurrentPassword = "";

        public frmAdminSettings()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAdminSettings_Load);
        }

        private void frmAdminSettings_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "Admin";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            if (cmbStatusAdmin.Items.Count == 0)
            {
                cmbStatusAdmin.Items.Add("Active");
                cmbStatusAdmin.Items.Add("Inactive");
            }

            LoadAccountInformation();
        }

        private void LoadAccountInformation()
        {
            try
            {
                string sql = "SELECT * FROM users WHERE user_id = " + Session.UserId;
                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    string username = dt.Rows[0]["username"].ToString();
                    string role = dt.Rows[0]["role"].ToString();
                    string status = dt.Rows[0]["status"].ToString();
                    actualCurrentPassword = dt.Rows[0]["password"].ToString();

                    string fullName = dt.Columns.Contains("full_name") ? dt.Rows[0]["full_name"].ToString() : "";
                    string email = dt.Columns.Contains("email") ? dt.Rows[0]["email"].ToString() : "";
                    // uses 'phone' column not 'phone_number'
                    string phone = dt.Columns.Contains("phone") ? dt.Rows[0]["phone"].ToString() : "";

                    // right side display labels
                    lblDisplayUsernameAdmin.Text = username;
                    lblDisplayNameAdmin.Text = string.IsNullOrEmpty(fullName) ? "Not Set" : fullName;
                    lblDsplayEmailAdmin.Text = string.IsNullOrEmpty(email) ? "Not Set" : email;
                    lblDisplayPhoneNumberAdmin.Text = string.IsNullOrEmpty(phone) ? "Not Set" : phone;
                    lblDisplayRoleAdmin.Text = role;
                    lblDisplayStatusAdmin.Text = status;
                    lblDisplayLastLoginAdmin.Text = DateTime.Now.ToString("MMM dd, yyyy");

                    // left side edit form
                    txtUsernameAdmin.Text = username;
                    txtFullNameAdmin.Text = fullName;
                    txtEmailAddressAdmin.Text = email;
                    txtPhoneNumberAdmin.Text = phone;
                    cmbStatusAdmin.Text = status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading account info: " + ex.Message);
            }
        }

        // email format check
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return true;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // phone format check
        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return true;
            string pattern = @"^[\d\s\-\+\(\)]{10,15}$";
            return Regex.IsMatch(phone, pattern);
        }

        private void btnAdminDetailsSave_Click(object sender, EventArgs e)
        {
            // gets user input
            string newUsername = txtUsernameAdmin.Text.Trim();
            string newFullName = txtFullNameAdmin.Text.Trim();
            string newEmail = txtEmailAddressAdmin.Text.Trim();
            string newPhone = txtPhoneNumberAdmin.Text.Trim();
            string currentPassword = txtPasswordAdmin.Text.Trim();
            string newPassword = txtNewPasswordAdmin.Text.Trim();
            string newStatus = cmbStatusAdmin.Text.Trim();

            if (newUsername == "" || newStatus == "")
            {
                MessageBox.Show("Username and Status cannot be empty.");
                return;
            }

            if (newUsername.Length > 30)
            {
                MessageBox.Show("Username cannot exceed 30 characters.");
                return;
            }

            if (newFullName.Length > 100)
            {
                MessageBox.Show("Full name cannot exceed 100 characters.");
                return;
            }

            if (!IsValidEmail(newEmail)) // regex validation
            {
                MessageBox.Show("Please enter a valid email address (or leave it empty).", "Invalid Email");
                return;
            }

            if (!IsValidPhone(newPhone))
            {
                MessageBox.Show("Please enter a valid phone number (10-15 digits).", "Invalid Phone");
                return;
            }

            try
            {
                // check duplicate username
                string dupSql = "SELECT * FROM users WHERE username='" + newUsername + "' AND user_id <> " + Session.UserId;
                DataTable dtDup = da.ExecuteQueryTable(dupSql); // queries db
                if (dtDup.Rows.Count > 0)
                {
                    MessageBox.Show("Another user is already using this username.");
                    return;
                }

                string updateSql = "";

                // password change
                if (newPassword != "")
                {
                    if (currentPassword == "")
                    {
                        MessageBox.Show("Please enter your Current Password to change it.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (currentPassword != actualCurrentPassword)
                    {
                        MessageBox.Show("Current password is incorrect!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (newPassword.Length > 5)
                    {
                        MessageBox.Show("New password cannot exceed 5 characters.");
                        return;
                    }

                    if (newPassword == currentPassword)
                    {
                        MessageBox.Show("New password must be different from current password.");
                        return;
                    }

                    updateSql = "UPDATE users SET " +
                                "username='" + newUsername + "', " +
                                "password='" + newPassword + "', " +
                                "full_name='" + newFullName + "', " +
                                "email='" + newEmail + "', " +
                                "phone='" + newPhone + "', " +
                                "status='" + newStatus + "' " +
                                "WHERE user_id=" + Session.UserId;
                }
                // just profile update, no password
                else
                {
                    updateSql = "UPDATE users SET " +
                                "username='" + newUsername + "', " +
                                "full_name='" + newFullName + "', " +
                                "email='" + newEmail + "', " +
                                "phone='" + newPhone + "', " +
                                "status='" + newStatus + "' " +
                                "WHERE user_id=" + Session.UserId;
                }

                if (da.ExecuteDMLQuery(updateSql) > 0) // run update query
                {
                    MessageBox.Show("Account details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Session.Username = newUsername;
                    txtPasswordAdmin.Clear();
                    txtNewPasswordAdmin.Clear();
                    LoadAccountInformation();
                }
                else
                {
                    MessageBox.Show("Failed to update account details.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving details: " + ex.Message);
            }
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            try { frmAdminDashboard form = new frmAdminDashboard(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAdminManageSlots_Click(object sender, EventArgs e)
        {
            try { frmAdminManageSlots form = new frmAdminManageSlots(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAdminVehicles_Click(object sender, EventArgs e)
        {
            try { frmAdminVehicles form = new frmAdminVehicles(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAdminParkingRecords_Click(object sender, EventArgs e)
        {
            try { frmAdminParkingRecords form = new frmAdminParkingRecords(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            try { frmAdminUsers form = new frmAdminUsers(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAdminSettings_Click(object sender, EventArgs e)
        {
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
                Session.UserId = 0;
                Session.Username = "";
                Session.Role = "";

                frmSignIn login = new frmSignIn();
                login.Show();
                this.Close();
            }
        }

        private void lblWelcomeAdmin_Click(object sender, EventArgs e) { }
        private void txtUsernameAdmin_TextChanged(object sender, EventArgs e) { }
        private void txtPasswordAdmin_TextChanged(object sender, EventArgs e) { }
        private void txtNewPasswordAdmin_TextChanged(object sender, EventArgs e) { }
        private void cmbStatusAdmin_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDisplayUsernameAdmin_Click(object sender, EventArgs e) { }
        private void lblDisplayStatusAdmin_Click(object sender, EventArgs e) { }
        private void lblDisplayLastLoginAdmin_Click(object sender, EventArgs e) { }
        private void lblDisplayRoleAdmin_Click(object sender, EventArgs e) { }
        private void txtFullNameAdmin_TextChanged(object sender, EventArgs e) { }
        private void txtEmailAddressAdmin_TextChanged(object sender, EventArgs e) { }
        private void txtPhoneNumberAdmin_TextChanged(object sender, EventArgs e) { }
        private void lblDisplayNameAdmin_Click(object sender, EventArgs e) { }
        private void lblDsplayEmailAdmin_Click(object sender, EventArgs e) { }
        private void lblDisplayPhoneNumberAdmin_Click(object sender, EventArgs e) { }
    }
}