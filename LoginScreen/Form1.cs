using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        private int currentUserId = -1;
        private const string ConnectionString = "Data Source=LAPTOP-JDHKJSTJ\\SQLEXPRESS;Initial Catalog=walletManager;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Exit Button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Login btn
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
                
                if (userId != -1){
                    // Authentication successful
                    currentUserId = userId;

                    // Open the main form or any other form in your application
                    Form2 mainForm = new Form2(currentUserId);
                    mainForm.Show();

                    this.Hide();  // Hide the login form
                }
                else
                {
                    lblError.Text = "incorrect id or password.";
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        // Check credentials method
        private int AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Note: In a real application, use hashed passwords

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