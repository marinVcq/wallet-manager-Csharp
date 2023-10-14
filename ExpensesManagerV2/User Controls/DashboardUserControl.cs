using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Microsoft.VisualBasic.Logging;

namespace ExpensesManagerV2.User_Controls
{
    public partial class DashboardUserControl : UserControl
    {
        private int currentUserID;
        string? connectionString = ConfigurationManager.GetConnectionString();

        /// <summary>
        /// Constructor
        /// </summary>
        public DashboardUserControl(int currentUserID)
        {
            InitializeComponent();
            this.currentUserID = currentUserID;
            DisplayUserExpenses(currentUserID);
        }
        /// <summary>
        /// Method to display row by row user's expenses
        /// </summary>
        /// <param name="userID"></param>
        private void DisplayUserExpenses(int userID)
        {
            string filterValue = comboBoxFilter.Text;
            // Fetch expenses from the database
            DataTable expensesTable = FetchExpensesFromDatabase(userID, filterValue);

            // Clear existing columns before adding new ones
            dataGridViewExpenses.Columns.Clear();

            // Set the DataTable as the DataSource for the DataGridView
            dataGridViewExpenses.DataSource = expensesTable;

            // Set AutoSizeMode to Fill for all columns
            foreach (DataGridViewColumn column in dataGridViewExpenses.Columns)
            {
                switch (column.Name)
                {
                    case "ExpenseID":
                        column.Width = 50; // Set your desired width for the "ID" column
                        break;
                    case "ExpenseType":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "Label":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "Amount":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "ExpenseDate":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "RegisterDate":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "ActionButton":
                        // Your existing button column settings...
                        break;
                }

                // Set column headers
                dataGridViewExpenses.Columns["ExpenseID"].HeaderText = "ID";
                dataGridViewExpenses.Columns["ExpenseType"].HeaderText = "Expense Type";
                dataGridViewExpenses.Columns["Label"].HeaderText = "Label";
                dataGridViewExpenses.Columns["Amount"].HeaderText = "Amount";
                dataGridViewExpenses.Columns["ExpenseDate"].HeaderText = "Expense Date";
                dataGridViewExpenses.Columns["RegisterDate"].HeaderText = "Register Date";

                // Disable Sort 
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn
            {
                Name = "ActionButton",
                HeaderText = "",
                Image = Properties.Resources.DeleteIcon1, // Replace with your icon
                Width = 30, // Set your desired width
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                }
            };

            dataGridViewExpenses.Columns.Add(buttonColumn);

            // Set row height
            dataGridViewExpenses.RowTemplate.Height = 60;

            // Set the data source after adding columns
            dataGridViewExpenses.DataSource = expensesTable;

            // Auto-size columns based on content
            dataGridViewExpenses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Remove row header cell
            dataGridViewExpenses.RowHeadersVisible = false;
        }
        /// <summary>
        /// Cell formating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell is in the button column
            if (dataGridViewExpenses.Columns[e.ColumnIndex].Name == "ActionButton" && e.RowIndex >= 0)
            {
                // Replace "YourButtonIcon" with your actual icon
                Image buttonIcon = Properties.Resources.DeleteIcon1;

                // Set the size you desire for the button icon
                int iconSize = 25; // Set your desired icon size

                // Resize the icon
                Image resizedIcon = new Bitmap(buttonIcon, new Size(iconSize, iconSize));

                e.Value = resizedIcon;
            }
        }
        /// <summary>
        /// Ask user if he want to modify or delete a record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DELETE A RECORD
            if (dataGridViewExpenses.Columns[e.ColumnIndex].Name == "ActionButton")
            {
                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure to delete this Expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the expense from the database
                    int expenseIdToDelete = (int)dataGridViewExpenses.Rows[e.RowIndex].Cells["ExpenseID"].Value;
                    DeleteExpense(expenseIdToDelete);

                    // Refresh the DataGridView
                    DisplayUserExpenses(currentUserID);
                }
            }
        }
        /// <summary>
        /// Update database after row edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewExpenses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the edited cell is in the data-bound column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the edited value
                object editedValue = dataGridViewExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Get the corresponding data source item
                DataRowView rowView = (DataRowView)dataGridViewExpenses.Rows[e.RowIndex].DataBoundItem;
                DataRow row = rowView.Row;

                // Get the column name dynamically based on the edited cell
                string columnName = dataGridViewExpenses.Columns[e.ColumnIndex].Name;

                // Update the corresponding value in the DataRow
                row[columnName] = editedValue;

                // Update the database with the modified value
                UpdateDatabase(row);
            }
        }
        /// <summary>
        /// Update database Backend function
        /// </summary>
        /// <param name="row"></param>
        private void UpdateDatabase(DataRow row)
        {
            try
            {
                // Assume you have a SqlConnection already defined
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening connection: {ex.Message}");
                    }

                    // Get values from the DataRow
                    int expenseID = (int)row["ExpenseID"];
                    string? expenseType = row["ExpenseType"].ToString();
                    string? label = row["Label"].ToString();
                    decimal amount = (decimal)row["Amount"];
                    DateTime expenseDate = (DateTime)row["ExpenseDate"];
                    DateTime registerDate = (DateTime)row["RegisterDate"];

                    // Create a SqlCommand for the update query
                    string updateQuery = "UPDATE Expenses SET ExpenseType = @ExpenseType, Label = @Label, Amount = @Amount, " +
                                         "ExpenseDate = @ExpenseDate, RegisterDate = @RegisterDate WHERE ExpenseID = @ExpenseID";

                    // Display a confirmation message
                    DialogResult result = MessageBox.Show("Are you sure you want to modify this record?", "Confirmation",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Proceed with the update
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Add parameters to the command
                            command.Parameters.AddWithValue("@ExpenseType", expenseType);
                            command.Parameters.AddWithValue("@Label", label);
                            command.Parameters.AddWithValue("@Amount", amount);
                            command.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                            command.Parameters.AddWithValue("@RegisterDate", registerDate);
                            command.Parameters.AddWithValue("@ExpenseID", expenseID);

                            // Execute the update query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Database updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log, show a message to the user)
                MessageBox.Show($"Error updating database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Delete expense record from database
        /// </summary>
        /// <param name="expenseId"></param>
        private void DeleteExpense(int expenseId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Expenses WHERE ExpenseID = @ExpenseID AND UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpenseID", expenseId);
                        command.Parameters.AddWithValue("@UserID", currentUserID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Generate dataTable with user's expenses
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        private DataTable FetchExpensesFromDatabase(int userID, string selectedExpenseType)
        {
            try
            {
                DataTable expensesTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand for the select query
                    string selectQuery = "SELECT ExpenseID, ExpenseType, Label, Amount, ExpenseDate, RegisterDate FROM Expenses WHERE UserID = @UserID";

                    // If a specific expense type is selected, add a filter condition to the query
                    if (selectedExpenseType != "All")
                    {
                        selectQuery += " AND ExpenseType = @SelectedExpenseType";
                    }

                    //MessageBox.Show($"Debug: SQL Query: {selectQuery}");


                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        // Add parameter for the selected expense type
                        if (selectedExpenseType != "All")
                        {
                            command.Parameters.AddWithValue("@SelectedExpenseType", selectedExpenseType);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(expensesTable);
                        }
                    }
                }
                
                //MessageBox.Show($"Debug: Fetched {expensesTable.Rows.Count} records.");

                return expensesTable;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log, show a message to the user)
                MessageBox.Show($"Error fetching expenses from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// Load the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashboardUserControl_Load(object sender, EventArgs e)
        {
            DisplayUserExpenses(currentUserID);
        }
        /// <summary>
        /// Add Expense
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (expenseType != "Select type...")
                {
                    Console.WriteLine("Valid date: " + expenseDate.ToString("dd/MM/yyyy"));
                    InsertExpense(expenseType, label, amount, expenseDate);
                    // Reset fields 
                    txtDate.Text = "";
                    txtAmount.Text = "";
                    txtLabel.Text = "";
                    comboBoxType.Text = "Select type...";
                    DisplayUserExpenses(currentUserID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid expense type", "Invalid type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            else
            {
                // The input is not a valid date in the specified format
                MessageBox.Show("Please enter a valid date in the format DD/MM/YYYY.");
                return;
            }
        }
        /// <summary>
        /// Insert expense record in database
        /// </summary>
        /// <param name="expenseType"></param>
        /// <param name="label"></param>
        /// <param name="amount"></param>
        /// <param name="expenseDate"></param>
        private void InsertExpense(string expenseType, string label, decimal amount, DateTime expenseDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Expenses (UserID, ExpenseType, Label, Amount, ExpenseDate, RegisterDate) VALUES (@UserID, @ExpenseType, @Label, @Amount, @ExpenseDate, @RegisterDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentUserID);
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
        /// <summary>
        /// User set filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayUserExpenses(currentUserID);
        }
    }
}
