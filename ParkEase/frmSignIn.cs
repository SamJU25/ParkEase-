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
    public partial class frmSignIn : Form
    {
        DataAccess da = new DataAccess();

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            cmbSignInUserAdmin.SelectedIndex = 0;
        }

        private void frmSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // kills entire app
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // gets user input
            string username = txtSignInUsername.Text.Trim();
            string password = txtSignInPassword.Text.Trim();
            string role = cmbSignInUserAdmin.Text.Trim();

            // validation: prevents empty input
            if (username == "")
            {
                MessageBox.Show("Please enter your username.");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Please enter your password.");
                return;
            }
            if (role == "")
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                // checks database for match
                string sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "' AND role='" + role + "'";
                DataTable dt = da.ExecuteQueryTable(sql); // run query

                if (dt.Rows.Count > 0) // if match found
                {
                    // store login info in session
                    Session.UserId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                    Session.Username = username;
                    Session.Role = role;

                    MessageBox.Show("Welcome, " + username + "!");

                    if (role == "Admin")
                    {
                        // opens admin dashboard
                        frmAdminDashboard adminForm = new frmAdminDashboard();
                        adminForm.Show();
                        this.Hide(); // hides sign in form
                    }
                    else if (role == "User")
                    {
                        // opens user dashboard
                        frmUserDashboard userForm = new frmUserDashboard();
                        userForm.Show();
                        this.Hide(); // hides sign in form
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.");
                    txtSignInPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void lblDontHaveAnAccount_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Looks like you need an account. Head over to Sign Up?",
                "Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Hide();
                frmSignUp registerForm = new frmSignUp(); // opens sign up form
                registerForm.Show();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}