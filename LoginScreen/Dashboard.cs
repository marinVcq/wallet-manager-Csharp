using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;
using System.Xml.Linq;
using Microsoft.Identity.Client;

namespace ExpensesManager
{
    public partial class Dashboard : Form
    {
        private int currentUserId;
        string? connectionString = ConfigurationManager.GetConnectionString();
        private PlotModel? expensePlotModel;
        private PlotModel? expenseTypePieModel;

        /// <summary>
        /// Conctructor - The userId is set to param to retrieve his expenses
        /// </summary>
        /// <param name="userId"></param>
        public Dashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            InitializeExpensePlotModel();
            InitializeExpenseTypePieModel();
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
        /// Initialize the plot for graph line 
        /// </summary>
        private void InitializeExpensePlotModel()
        {
            expensePlotModel = new PlotModel
            {
                Title = "Current Expenses Graph",
                TitleColor = OxyColor.FromRgb(25, 25, 112)
            };

            // Add X-axis (time axis)
            expensePlotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "dd/MM/yyyy",
                Title = "Date",
                IntervalType = OxyPlot.Axes.DateTimeIntervalType.Days,
                IntervalLength = 200,
            });

            // Add Y-axis (amount axis)
            expensePlotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Amount",
                Minimum = 0
            });

            // Add a LineSeries for the expenses
            var expensesSeries = new OxyPlot.Series.LineSeries
            {
                Title = "Expenses",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                Color = OxyColors.Blue,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Blue,
                StrokeThickness = 8,
                LineStyle = LineStyle.Solid,
                LineJoin = LineJoin.Round
            };

            // Add the series to the PlotModel
            expensePlotModel.Series.Add(expensesSeries);

            // Add a LineSeries for the total amount
            var totalAmountSeries = new OxyPlot.Series.LineSeries
            {
                Title = "Total Amount",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                Color = OxyColors.Red,
                MarkerFill = OxyColors.Red,
                StrokeThickness = 8,
                LineStyle = LineStyle.Solid,
                LineJoin = LineJoin.Round
            };

            // Add the total amount series to the PlotModel
            expensePlotModel.Series.Add(totalAmountSeries);

            // Set the PlotView to display the expensePlotModel
            plotView1.Model = expensePlotModel;
        }

        /// <summary>
        /// Initialize Pie Chart
        /// </summary>
        private void InitializeExpenseTypePieModel()
        {
            expenseTypePieModel = new PlotModel
            {
                Title = "Expenses by Type",
                TitleColor = OxyColor.FromRgb(255, 255, 255),
                DefaultColors = OxyPalettes.HueDistinct(8).Colors
            };

            // Add a PieSeries
            var pieSeries = new OxyPlot.Series.PieSeries
            {
                StrokeThickness = 0.0,
                InsideLabelPosition = 1.2,
                AngleSpan = 360,
                StartAngle = 0,
                Diameter = 0.67
            };

            pieSeries.TextColor = OxyColors.MidnightBlue;
            pieSeries.InsideLabelColor = OxyColors.MidnightBlue;
            pieSeries.FontSize = 14;

            // Add the series to the PlotModel
            expenseTypePieModel.Series.Add(pieSeries);

            // Set the PlotView to display the expenseTypePieModel
            plotView2.Model = expenseTypePieModel;
        }

        /// <summary>
        /// Update the plot
        /// </summary>
        /// <param name="dataTable"></param>
        private void UpdateExpensePlot(DataTable dataTable)
        {
            if (expensePlotModel == null)
            {
                return;
            }

            var expensesSeries = (OxyPlot.Series.LineSeries)expensePlotModel.Series[0];
            expensesSeries.Points.Clear();

            var totalAmountSeries = (OxyPlot.Series.LineSeries)expensePlotModel.Series[1];
            totalAmountSeries.Points.Clear();

            double totalAmount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime expenseDate = (DateTime)row["ExpenseDate"];
                decimal amount = (decimal)row["Amount"];

                expensesSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(expenseDate), Convert.ToDouble(amount)));

                // Accumulate total amount
                totalAmount += Convert.ToDouble(amount);

                // Add total amount point to the series
                totalAmountSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(expenseDate), totalAmount));
            }

            // Force the PlotModel to update
            expensePlotModel.InvalidatePlot(true);
        }

        /// <summary>
        /// Update pie chart
        /// </summary>
        /// <param name="dataTable"></param>
        private void UpdateExpenseTypePieChart(DataTable dataTable)
        {
            if (expenseTypePieModel == null)
            {
                return;
            }

            var pieSeries = (OxyPlot.Series.PieSeries)expenseTypePieModel.Series[0];
            pieSeries.Slices.Clear();

            var expenseTypeGroups = dataTable.AsEnumerable().GroupBy(row => row.Field<string>("ExpenseType"));

            foreach (var group in expenseTypeGroups)
            {
                decimal totalAmount = group.Sum(row => row.Field<decimal>("Amount"));
                pieSeries.Slices.Add(new PieSlice(group.Key, Convert.ToDouble(totalAmount)));
            }

            // Force the PlotModel to update
            expenseTypePieModel.InvalidatePlot(true);
        }

        /// <summary>
        /// Core function of the dashboard: LoadExpenses Method Bind user's expenses from database and generate datagridView
        /// </summary>
        private void LoadExpenses()
        {
            try
            {
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

                    string? filterValue = comboBoxFilter.SelectedItem?.ToString();

                    string query = "SELECT ExpenseID, ExpenseType, Label, Amount, ExpenseDate, RegisterDate FROM Expenses WHERE UserID = @UserID ORDER BY ExpenseDate";

                    if (!string.IsNullOrEmpty(filterValue) && filterValue != "All")
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

                        // Update the OxyPlot data series with expense data
                        UpdateExpensePlot(dataTable);
                        UpdateExpenseTypePieChart(dataTable);

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
                if (expenseType != "Select type...")
                {
                    Console.WriteLine("Valid date: " + expenseDate.ToString("dd/MM/yyyy"));
                    InsertExpense(expenseType, label, amount, expenseDate);
                    // Reset fields 
                    txtDate.Text = "";
                    txtAmount.Text = "";
                    txtLabel.Text = "";
                    comboBoxType.Text = "Select type...";
                    LoadExpenses();
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

        /// <summary>
        /// Useful: update records each time new filter is set 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        /// <summary>
        /// Cell Formating for column button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cell painting for cell button (to handle the background color issue) - REFACT NEEDED 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Handle cell click on cell button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Useful: Reset filter on "All" at each tab change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFilter.Text = "All";

        }
    }
}
