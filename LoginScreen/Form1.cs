using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {

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
                if (CheckCredentials(username, password))
                {
                    new Form2().Show();
                    this.Hide();
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
        private bool CheckCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}