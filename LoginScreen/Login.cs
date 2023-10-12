using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpensesManager
{
    public partial class Login : Form
    {
        private int currentUserId = -1;
        string? connectionString = ConfigurationManager.GetConnectionString();

        /// <summary>
        /// Constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close Login Form when user click on the top right corner cross button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Trigger password and username validation check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == string.Empty)
            {
                lblError.Text = "Please enter username.";
            }
            else if (password == string.Empty)
            {
                lblError.Text = "Please enter a password.";
            }
            else
            {
                int userId = AuthenticateUser(username, password);

                if (userId != -1)
                {
                    // Authentication successful
                    currentUserId = userId;

                    // Open the main form (the dashboard)
                    Dashboard mainForm = new Dashboard(currentUserId);
                    mainForm.Show();

                    this.Hide();  // Hide the login form
                }
                else
                {
                    lblError.Text = "incorrect ID or password.";
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        /// <summary>
        /// Check if username exist in database and if password is correct
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Return -1 if its failed or userID if its done
        /// </returns>
        private int AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Continue with database operations
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening connection: {ex.Message}");
                }

                string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Note: In a real application, we have to use hashed passwords

                    // ExecuteScalar returns the first column of the first row in the result set
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // User authenticated successfully; return the UserID
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Authentication failed
                        return -1;
                    }
                }
            }
        }
    }
}