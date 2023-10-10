using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {

        private const string ConnectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password;";

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

            // Check if user exist here
            if (CheckCredentials(username, password))
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                // This is an error
                lblError.Text = "incorrect id or password.";
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        // Check credentials method
        private bool CheckCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString)
            {
                connection.Open();
            }

        }
    }
}