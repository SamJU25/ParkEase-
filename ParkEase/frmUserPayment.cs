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
    public partial class frmUserPayment : Form
    {
        DataAccess da = new DataAccess();

        int currentRecordId = 0;
        double finalCalculatedFee = 0;
        string slotToFree = "";

        // no record id passed (from sidebar)
        public frmUserPayment()
        {
            InitializeComponent();
            currentRecordId = 0;
            this.Load += new EventHandler(frmUserPayment_Load);
        }

        // record id passed (from checkout)
        public frmUserPayment(int recordId)
        {
            InitializeComponent();
            currentRecordId = recordId;
            this.Load += new EventHandler(frmUserPayment_Load);
        }

        private void frmUserPayment_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = !string.IsNullOrEmpty(Session.Username) ? Session.Username : "User";
            lblCurrentTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // payment method options
            cmbSelectPayment.Items.Clear();
            cmbSelectPayment.Items.Add("Select Method...");
            cmbSelectPayment.Items.Add("Cash");
            cmbSelectPayment.Items.Add("bKash");
            cmbSelectPayment.Items.Add("Nagad");
            cmbSelectPayment.Items.Add("Card");
            cmbSelectPayment.SelectedIndex = 0;

            cmbSelectPayment.SelectedIndexChanged += cmbSelectPayment_SelectedIndexChanged;

            // hide all payment panels
            pnlCash.Visible = false;
            pnlMobile.Visible = false;
            pnlCard.Visible = false;

            // text limits
            txtMobile.MaxLength = 11;
            txtOTP.MaxLength = 6;
            txtCardNumber.MaxLength = 16;
            txtExpiry.MaxLength = 5;
            txtCVV.MaxLength = 3;

            // numbers only
            txtMobile.KeyPress += AllowOnlyNumbers_KeyPress;
            txtOTP.KeyPress += AllowOnlyNumbers_KeyPress;
            txtCardNumber.KeyPress += AllowOnlyNumbers_KeyPress;
            txtCVV.KeyPress += AllowOnlyNumbers_KeyPress;

            if (currentRecordId == 0)
            {
                cmbSelectVehicle.Visible = true;
                LoadUnpaidVehiclesIntoDropdown();
            }
            else
            {
                cmbSelectVehicle.Visible = false;
                CalculateAndDisplayBill();
            }
        }

        private void LoadUnpaidVehiclesIntoDropdown()
        {
            try
            {
                string sql = $@"SELECT pr.record_id, v.plate_number + ' - Slot ' + s.slot_number AS Display 
                                FROM parking_records pr
                                INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
                                INNER JOIN parking_slots s ON pr.slot_id = s.slot_id
                                WHERE v.user_id = {Session.UserId} AND pr.exit_time IS NULL";

                DataTable dt = da.ExecuteQueryTable(sql);

                cmbSelectVehicle.DataSource = dt;
                cmbSelectVehicle.DisplayMember = "Display";
                cmbSelectVehicle.ValueMember = "record_id";
                cmbSelectVehicle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading unpaid vehicles: " + ex.Message);
            }
        }

        private void cmbSelectVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectVehicle.SelectedIndex != -1 && cmbSelectVehicle.SelectedValue != null)
            {
                if (int.TryParse(cmbSelectVehicle.SelectedValue.ToString(), out int selectedId))
                {
                    currentRecordId = selectedId;
                    CalculateAndDisplayBill();
                }
            }
        }

        private void CalculateAndDisplayBill()
        {
            try
            {
                string sql = $@"SELECT pr.entry_time, v.plate_number, s.slot_number 
                                FROM parking_records pr
                                INNER JOIN vehicles v ON pr.vehicle_id = v.vehicle_id
                                INNER JOIN parking_slots s ON pr.slot_id = s.slot_id
                                WHERE pr.record_id = {currentRecordId}";

                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    DateTime entryTime = Convert.ToDateTime(dt.Rows[0]["entry_time"]);
                    DateTime exitTime = DateTime.Now;

                    slotToFree = dt.Rows[0]["slot_number"].ToString();

                    TimeSpan timeStayed = exitTime - entryTime;
                    double totalHours = Math.Ceiling(timeStayed.TotalHours);
                    if (totalHours == 0) totalHours = 1;

                    double hourlyRate = 50.0;
                    finalCalculatedFee = totalHours * hourlyRate;

                    lblPlateNumber.Text = dt.Rows[0]["plate_number"].ToString();
                    lblSlotNumber.Text = slotToFree;
                    lblEntryTime.Text = entryTime.ToString("g");
                    lblExitTime.Text = exitTime.ToString("g");

                    // total hours including days
                    int trueHours = (int)timeStayed.TotalHours;
                    lblDuration.Text = $"{trueHours}h {timeStayed.Minutes}m";

                    lblBilledHours.Text = $"{totalHours} Hour(s) = ৳{finalCalculatedFee}";
                    lblAmountPayValue.Text = $"৳{finalCalculatedFee}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating bill: " + ex.Message);
            }
        }

        // block letters in textbox
        private void AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // auto-slash for expiry MM/YY
        private void txtExpiry_TextChanged(object sender, EventArgs e)
        {
            txtExpiry.TextChanged -= txtExpiry_TextChanged;

            if (txtExpiry.Text.Length == 2 && !txtExpiry.Text.Contains("/"))
            {
                txtExpiry.Text += "/";
                txtExpiry.SelectionStart = txtExpiry.Text.Length;
            }

            txtExpiry.TextChanged += txtExpiry_TextChanged;
        }

        // show/hide payment panels
        private void cmbSelectPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbSelectPayment.Text;

            pnlCash.Visible = false;
            pnlMobile.Visible = false;
            pnlCard.Visible = false;

            if (selected == "Cash")
            {
                pnlCash.Visible = true;
            }
            else if (selected == "bKash" || selected == "Nagad")
            {
                pnlMobile.Visible = true;
            }
            else if (selected == "Card")
            {
                pnlCard.Visible = true;
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (currentRecordId == 0) // validation: select first
            {
                MessageBox.Show("Please select a vehicle to pay for first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paymentMethod = cmbSelectPayment.SelectedItem.ToString();

            // process payment based on method
            if (paymentMethod == "bKash" || paymentMethod == "Nagad")
            {
                MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // card validation
            if (paymentMethod == "Card")
            {
                if (txtCardNumber.Text.Length < 16 || txtExpiry.Text.Length < 5 || txtCVV.Text.Length < 3)
                {
                    MessageBox.Show("Please fill out all Credit Card details completely.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                // update record as paid
                string updateRecordSql = "UPDATE parking_records SET exit_time = CURRENT_TIMESTAMP, fee = " + finalCalculatedFee + ", is_paid = 1 WHERE record_id = " + currentRecordId;
                
                // update slot as available
                string updateSlotSql = "UPDATE parking_slots SET status = 'Available' WHERE slot_number = '" + slotToFree + "'";

                if (da.ExecuteDMLQuery(updateRecordSql) > 0) // run update query
                {
                    da.ExecuteDMLQuery(updateSlotSql); // run slot update
                    MessageBox.Show("Payment Successful! Thank you for using ParkEase.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmUserAvailableSlots availableSlots = new frmUserAvailableSlots(); // opens available slots
                    availableSlots.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment Error: " + ex.Message);
            }
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            frmUserDashboard form = new frmUserDashboard();
            form.Show();
            this.Close();
        }

        private void btnUserDashboard_Click(object sender, EventArgs e)
        {
            try { frmUserDashboard form = new frmUserDashboard(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUserMyVehicles_Click(object sender, EventArgs e)
        {
            try { frmUserVehicles form = new frmUserVehicles(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUserAvailableSlots_Click(object sender, EventArgs e)
        {
            try { frmUserAvailableSlots form = new frmUserAvailableSlots(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUserParkingHistory_Click(object sender, EventArgs e)
        {
            try { UserParkingHistory form = new UserParkingHistory(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUserPayment_Click(object sender, EventArgs e) { }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            try { frmUserSettings form = new frmUserSettings(); form.Show(); this.Hide(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnLogOutUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmSignIn login = new frmSignIn(); login.Show(); this.Close();
            }
        }

        private void lblWelcomeUser_Click(object sender, EventArgs e) { }
        private void lblPlateNumber_Click(object sender, EventArgs e) { }
        private void lblSlotNumber_Click(object sender, EventArgs e) { }
        private void lblEntryTime_Click(object sender, EventArgs e) { }
        private void lblExitTime_Click(object sender, EventArgs e) { }
        private void lblDuration_Click(object sender, EventArgs e) { }
        private void lblBilledHours_Click(object sender, EventArgs e) { }
        private void lblAmountPayValue_Click(object sender, EventArgs e) { }
        private void pnlCash_Paint(object sender, PaintEventArgs e) { }
        private void pnlMobile_Paint(object sender, PaintEventArgs e) { }
        private void txtMobile_TextChanged(object sender, EventArgs e) { }
        private void txtOTP_TextChanged(object sender, EventArgs e) { }
        private void pnlCard_Paint(object sender, PaintEventArgs e) { }
        private void txtCardNumber_TextChanged(object sender, EventArgs e) { }
        private void txtCVV_TextChanged(object sender, EventArgs e) { }
    }
}