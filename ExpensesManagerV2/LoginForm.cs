using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpensesManagerV2
{
    public partial class LoginForm : Form
    {
        private int currentUserId = -1;
        string? connectionString = ConfigurationManager.GetConnectionString();

        /// <summary>
        /// Constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Close login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Trigger password and username validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == string.Empty)
            {
                labelError.Text = "Please enter username.";
            }
            else if (password == string.Empty)
            {
                labelError.Text = "Please enter a password.";
            }
            else
            {
                int userId = AuthenticateUser(username, password);

                if (userId != -1)
                {
                    // Authentication successful
                    currentUserId = userId;

                    // Open the main form (the dashboard)
                    MainForm mainForm = new MainForm(currentUserId);
                    mainForm.Show();

                    this.Hide();  // Hide the login form
                }
                else
                {
                    labelError.Text = "incorrect ID or password.";
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxUsername.Focus();
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening connection: {ex.Message}");
                }
            }
            return -1;
        }
    }
}
