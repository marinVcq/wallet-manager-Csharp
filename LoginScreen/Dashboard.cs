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
using System.Data.Common;
using System.Windows.Forms.DataVisualization.Charting;

namespace LoginScreen
{
    public partial class Dashboard : Form
    {
        private int currentUserId;
        private const string ConnectionString = "Data Source=LAPTOP-JDHKJSTJ\\SQLEXPRESS;Initial Catalog=walletManager;Integrated Security=True";

        /// <summary>
        /// Conctructor - The userId is set to param for retrieve his expenses
        /// </summary>
        /// <param name="userId"></param>
        public Dashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        /// <summary>
        /// Form Loader - Yet load the datagridView with Expense Overview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }
        
        /// <summary>
        /// LoadExpenses Method Bind user's expenses from database and generate datagridView
        /// </summary>
        private void LoadExpenses()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string? filterValue = comboBoxFilter.SelectedItem?.ToString();

                    string query = "SELECT ExpenseID, ExpenseType, Label, Amount, ExpenseDate, RegisterDate FROM Expenses WHERE UserID = @UserID";

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

                        // Clear existing columns before adding new ones
                        dataGridView1.Columns.Clear();

                        dataGridView1.DataSource = dataTable;

                        // Set AutoSizeMode to Fill for all columns
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            // Set column headers
                            dataGridView1.Columns["ExpenseID"].HeaderText = "ID";
                            dataGridView1.Columns["ExpenseType"].HeaderText = "Expense Type";
                            dataGridView1.Columns["Label"].HeaderText = "Label";
                            dataGridView1.Columns["Amount"].HeaderText = "Amount";
                            dataGridView1.Columns["ExpenseDate"].HeaderText = "Expense Date";
                            dataGridView1.Columns["RegisterDate"].HeaderText = "Register Date";

                            // Set width for the ID column
                            if (column.Name == "ExpenseID")
                            {
                                column.Width = 50; // Adjust the width as needed
                            }

                            // Disable Sort 
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        // Add buttons only to Modify and Delete columns
                        DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
                        modifyButtonColumn.Name = "Modify";
                        modifyButtonColumn.HeaderText = string.Empty;
                        modifyButtonColumn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(modifyButtonColumn);

                        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                        deleteButtonColumn.Name = "Delete";
                        deleteButtonColumn.HeaderText = string.Empty;
                        deleteButtonColumn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(deleteButtonColumn);


                        // Set the data source after adding columns
                        dataGridView1.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add Expense record to database at user's click
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                // Check if it's the Modify column
                if (dataGridView.Columns[e.ColumnIndex].Name == "Modify")
                {
                    e.Value = "Modify";
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                    e.FormattingApplied = true;
                }
                // Check if it's the Delete column
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    e.Value = "Delete";
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                // Check if it's the Modify column
                if (dataGridView.Columns[e.ColumnIndex].Name == "Modify")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Draw a green rectangle as the background
                    using (Brush brush = new SolidBrush(Color.Green))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 3, e.CellBounds.Height - 3);
                    }

                    // Draw the button text
                    using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                    {
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        e.Graphics.DrawString("Modify", e.CellStyle.Font, brush, e.CellBounds, sf);
                    }

                    e.Handled = true;
                }
                // Check if it's the Delete column
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Draw a red rectangle as the background
                    using (Brush brush = new SolidBrush(Color.Red))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 3, e.CellBounds.Height - 3);
                    }

                    // Draw the button text
                    using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                    {
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        e.Graphics.DrawString("Delete", e.CellStyle.Font, brush, e.CellBounds, sf);
                    }

                    e.Handled = true;
                }
            }
        }

        // Cell click 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                // DELETE A RECORD
                if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Ask for confirmation
                    DialogResult result = MessageBox.Show("Are you sure to delete this Expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Delete the expense from the database
                        int expenseIdToDelete = (int)dataGridView.Rows[e.RowIndex].Cells["ExpenseID"].Value;
                        DeleteExpense(expenseIdToDelete);

                        // Refresh the DataGridView
                        LoadExpenses();
                    }
                }

                // MODIFY A RECORD
                if (dataGridView.Columns[e.ColumnIndex].Name == "Modify")
                {
                    // Retrieve expense details from the selected row
                    int expenseIdToModify = (int)dataGridView.Rows[e.RowIndex].Cells["ExpenseID"].Value;

                    // Check if the cell values are not null before accessing them
                    string? expenseType = dataGridView.Rows[e.RowIndex].Cells["ExpenseType"].Value?.ToString();
                    string? label = dataGridView.Rows[e.RowIndex].Cells["Label"].Value?.ToString();
                    decimal amount = dataGridView.Rows[e.RowIndex].Cells["Amount"].Value as decimal? ?? 0;
                    DateTime expenseDate = dataGridView.Rows[e.RowIndex].Cells["ExpenseDate"].Value as DateTime? ?? DateTime.MinValue;

                    // Create an instance of ModifyExpenseForm and pass the data
                    ModifyExpense modifyForm = new ModifyExpense(expenseIdToModify, expenseType, label, amount, expenseDate);

                    // Show the form
                    if (modifyForm.ShowDialog() == DialogResult.OK)
                    {
                        // Reload expenses after modification
                        LoadExpenses();
                    }
                }
            }
        }

        // Delete expense
        private void DeleteExpense(int expenseId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Expenses WHERE ExpenseID = @ExpenseID AND UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpenseID", expenseId);
                        command.Parameters.AddWithValue("@UserID", currentUserId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
