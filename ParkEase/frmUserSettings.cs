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
    public partial class frmUserSettings : Form
    {
        DataAccess da = new DataAccess();
        string actualCurrentPassword = "";

        public frmUserSettings()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmUserSettings_Load);
        }

        private void frmUserSettings_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "User";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            LoadUserData();

            // remind user to fill contact info
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()) && string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Please fill your account info to let us contact you.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadUserData()
        {
            try
            {
                string sql = $"SELECT * FROM users WHERE user_id = {Session.UserId}";
                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    lblInfoUsername.Text = dt.Rows[0]["username"].ToString();
                    lblInfoRole.Text = dt.Rows[0]["role"].ToString();
                    actualCurrentPassword = dt.Rows[0]["password"].ToString();

                    if (dt.Columns.Contains("status"))
                    {
                        string statusValue = dt.Rows[0]["status"].ToString();
                        lblInfoStatus.Text = (statusValue == "1") ? "Active" : "Inactive";
                    }

                    string fullName = dt.Columns.Contains("full_name") ? dt.Rows[0]["full_name"].ToString() : "";
                    string email = dt.Columns.Contains("email") ? dt.Rows[0]["email"].ToString() : "";
                    string phone = dt.Columns.Contains("phone") ? dt.Rows[0]["phone"].ToString() : "";

                    lblInfoDisplayName.Text = string.IsNullOrEmpty(fullName) ? "Not Set" : fullName;
                    lblInfoEmail.Text = string.IsNullOrEmpty(email) ? "Not Set" : email;
                    lblInfoPhone.Text = string.IsNullOrEmpty(phone) ? "Not Set" : phone;

                    txtFullName.Text = fullName;
                    txtEmail.Text = email;
                    txtPhone.Text = phone;

                    txtCurrentPassword.Text = "";
                    txtNewPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName = txtFullName.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string newPhone = txtPhone.Text.Trim();
            string enteredCurrentPass = txtCurrentPassword.Text;
            string newPass = txtNewPassword.Text;

            // need at least email or phone
            if (string.IsNullOrEmpty(newEmail) && string.IsNullOrEmpty(newPhone))
            {
                MessageBox.Show("At least one contact method (Email or Phone) is mandatory.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(newPass))
                {
                    if (enteredCurrentPass != actualCurrentPassword)
                    {
                        MessageBox.Show("Incorrect Current Password.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                List<string> updates = new List<string>();
                updates.Add($"full_name = '{newName}'");
                updates.Add($"email = '{newEmail}'");
                updates.Add($"phone = '{newPhone}'");

                if (!string.IsNullOrEmpty(newPass))
                {
                    updates.Add($"password = '{newPass}'");
                }

                string updateSql = $"UPDATE users SET {string.Join(", ", updates)} WHERE user_id = {Session.UserId}";
                int rowsAffected = da.ExecuteDMLQuery(updateSql);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblInfoLastSaved.Text = DateTime.Now.ToString("g");
                    LoadUserData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnUserDashboard_Click(object sender, EventArgs e) { frmUserDashboard f = new frmUserDashboard(); f.Show(); this.Hide(); }
        private void btnUserMyVehicles_Click(object sender, EventArgs e) { frmUserVehicles f = new frmUserVehicles(); f.Show(); this.Hide(); }
        private void btnUserAvailableSlots_Click(object sender, EventArgs e) { frmUserAvailableSlots f = new frmUserAvailableSlots(); f.Show(); this.Hide(); }
        private void btnUserParkingHistory_Click(object sender, EventArgs e) { UserParkingHistory f = new UserParkingHistory(); f.Show(); this.Hide(); }
        private void btnUserPayment_Click(object sender, EventArgs e) { frmUserPayment f = new frmUserPayment(); f.Show(); this.Hide(); }
        private void btnUserSettings_Click(object sender, EventArgs e) { }
        private void btnLogOutUser_Click(object sender, EventArgs e) { if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) { frmSignIn f = new frmSignIn(); f.Show(); this.Close(); } }

        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtPhone_TextChanged(object sender, EventArgs e) { }
        private void txtNewPassword_TextChanged(object sender, EventArgs e) { }
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e) { }
        private void txtFullName_TextChanged(object sender, EventArgs e) { }
        private void lblWelcomeUser_Click(object sender, EventArgs e) { }
        private void lblInfoUsername_Click(object sender, EventArgs e) { }
        private void lblInfoDisplayName_Click(object sender, EventArgs e) { }
        private void lblInfoEmail_Click(object sender, EventArgs e) { }
        private void lblInfoPhone_Click(object sender, EventArgs e) { }
        private void lblInfoRole_Click(object sender, EventArgs e) { }
        private void lblInfoStatus_Click(object sender, EventArgs e) { }
        private void lblInfoLastSaved_Click(object sender, EventArgs e) { }
    }
}