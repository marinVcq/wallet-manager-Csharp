using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace LoginScreen
{
    public partial class Form2 : Form
    {
        private int currentUserId;
        private const string ConnectionString = "Data Source=LAPTOP-JDHKJSTJ\\SQLEXPRESS;Initial Catalog=walletManager;Integrated Security=True";

        public Form2(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Form 2 Loader  (Dashboard loader)
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }
        // Load UserExpense in datagrid view 
        private void LoadExpenses()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string? filterValue = comboBoxFilter.SelectedItem?.ToString();

                    string query = "SELECT ExpenseType, Label, Amount, ExpenseDate, RegisterDate FROM Expenses WHERE UserID = @UserID";

                    if (!string.IsNullOrEmpty(filterValue))
                    {
                        query += " AND ExpenseType = @ExpenseType";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentUserId);

                        if (!string.IsNullOrEmpty(filterValue))
                        {
                            command.Parameters.AddWithValue("@ExpenseType", filterValue);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        // Set AutoSizeMode to Fill for all columns
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            // Customize the header cell style
                            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                            columnHeaderStyle.BackColor = Color.Navy;
                            columnHeaderStyle.ForeColor = Color.White;
                            columnHeaderStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                            // Modify column headers (optional)
                            dataGridView1.Columns["ExpenseType"].HeaderText = "Expense Type";
                            dataGridView1.Columns["Label"].HeaderText = "Label";
                            dataGridView1.Columns["Amount"].HeaderText = "Amount";
                            dataGridView1.Columns["ExpenseDate"].HeaderText = "Expense Date";
                            dataGridView1.Columns["RegisterDate"].HeaderText = "Register Date";

                            column.HeaderCell.Style = columnHeaderStyle;

                            // Disable Sort 
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Add Expense in database
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string dateFormat = "dd/MM/yyyy";
            string expenseType = comboBoxType.Text;
            string expenseDateInput = txtDate.Text;
            string label = txtLabel.Text;
            decimal amount;

            // Check Amount
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check Date
            else if (DateTime.TryParseExact(expenseDateInput, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expenseDate))
            {
                Console.WriteLine("Valid date: " + expenseDate.ToString("dd/MM/yyyy"));
                InsertExpense(expenseType, label, amount, expenseDate);
                LoadExpenses();

            }
            else
            {
                // The input is not a valid date in the specified format
                MessageBox.Show("Please enter a valid date in the format DD/MM/YYYY.");
                return;
            }
        }

        // Insert in db method
        private void InsertExpense(string expenseType, string label, decimal amount, DateTime expenseDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Expenses (UserID, ExpenseType, Label, Amount, ExpenseDate, RegisterDate) VALUES (@UserID, @ExpenseType, @Label, @Amount, @ExpenseDate, @RegisterDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentUserId);
                        command.Parameters.AddWithValue("@ExpenseType", expenseType);
                        command.Parameters.AddWithValue("@Label", label);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                        command.Parameters.AddWithValue("@RegisterDate", DateTime.Now);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Expense added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // User set a filter
        private void comboBoxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadExpenses();
        }
    }
}
