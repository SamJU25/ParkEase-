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
    public partial class frmSignUp : Form
    {
        DataAccess da = new DataAccess();

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            cmbSignUpUserAdmin.SelectedIndex = 0;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // gets user input
            string username = txtSignUpUsername.Text.Trim();
            string password = txtSignUpPassword.Text.Trim();
            string role = cmbSignUpUserAdmin.Text.Trim();

            // validation: prevents empty input
            if (username == "")
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (role == "")
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            if (username.Length > 30) // length validation
            {
                MessageBox.Show("Username cannot be more than 30 characters.");
                return;
            }
            if (password.Length > 5)
            {
                MessageBox.Show("Password cannot be more than 5 characters.");
                return;
            }

            try
            {
                // check if username exists
                string checkSql = "SELECT * FROM users WHERE username='" + username + "'";
                DataTable dt = da.ExecuteQueryTable(checkSql); // queries db
                if (dt.Rows.Count > 0) // if duplicate found
                {
                    MessageBox.Show("This username is already taken.");
                    return; // stop execution
                }

                // insert new user
                string insertSql = "INSERT INTO users (username, password, role) VALUES ('" + username + "', '" + password + "', '" + role + "')";
                int result = da.ExecuteDMLQuery(insertSql); // run insert query

                if (result > 0) // if successful
                {
                    MessageBox.Show("Account created successfully!");
                    txtSignUpUsername.Clear();
                    txtSignUpPassword.Clear();
                    cmbSignUpUserAdmin.SelectedIndex = 0;

                    this.Hide();
                    frmSignIn loginForm = new frmSignIn(); // opens login form
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to create account.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSignIn loginForm = new frmSignIn();
            loginForm.Show();
            this.Hide();
        }
    }
}