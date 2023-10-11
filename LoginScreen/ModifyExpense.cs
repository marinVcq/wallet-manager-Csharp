using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class ModifyExpense : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-JDHKJSTJ\\SQLEXPRESS;Initial Catalog=walletManager;Integrated Security=True";

        // Fields to store expense details
        private int expenseId;
        private string? originalExpenseType;
        private string? originalLabel;
        private decimal originalAmount;
        private DateTime originalExpenseDate;

        public ModifyExpense(int expenseId, string? expenseType, string? label, decimal amount, DateTime expenseDate)
        {
            InitializeComponent();

            // Initialize fields with the original expense details
            this.expenseId = expenseId;
            originalExpenseType = expenseType;
            originalLabel = label;
            originalAmount = amount;
            originalExpenseDate = expenseDate;

            // Populate controls with the original expense details
            comboBoxType.Text = expenseType ?? string.Empty;
            txtLabel.Text = label ?? string.Empty;
            txtAmount.Text = amount.ToString();
            txtDate.Text = expenseDate.ToString();
        }

        private void ModifyExpense_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Modify Expense at Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModify_Click(object sender, EventArgs e)
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
                // Update the expense in the database
                UpdateExpenseInDatabase(expenseId, expenseType, label, amount, expenseDate);
                
                // Set DialogResult to OK to indicate a successful modification
                DialogResult = DialogResult.OK;

                // Close the form
                Close();

            }
            else
            {
                // The input is not a valid date in the specified format
                MessageBox.Show("Something goes wrong when you try to modify your expense");
                return;
            }
        }

        /// <summary>
        /// Update Expense in database
        /// </summary>
        /// <param name="expenseId"></param>
        /// <param name="expenseType"></param>
        /// <param name="label"></param>
        /// <param name="amount"></param>
        /// <param name="expenseDate"></param>
        private void UpdateExpenseInDatabase(int expenseId, string expenseType, string label, decimal amount, DateTime expenseDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Expenses SET ExpenseType = @ExpenseType, Label = @Label, Amount = @Amount, ExpenseDate = @ExpenseDate WHERE ExpenseID = @ExpenseID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpenseType", expenseType);
                        command.Parameters.AddWithValue("@Label", label);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                        command.Parameters.AddWithValue("@ExpenseID", expenseId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Close the modify form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
