using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;
namespace ExpensesManagerV2.User_Controls
{


    public partial class GraphicsUserControl : UserControl
    {
        private PlotModel? lineModel; // Declare the PlotModel for the line chart
        private PlotModel? pieModel;

        private int currentUserID;
        string? connectionString = ConfigurationManager.GetConnectionString();

        public class Expense
        {
            public DateTime Date { get; set; }
            public string? ExpenseType { get; set; }
            public double Amount { get; set; }
        }

        public class PieSliceData
        {
            public string ExpenseType { get; set; }
            public double Amount { get; set; }
            public OxyColor Color { get; set; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public GraphicsUserControl(int currentUserID)
        {
            InitializeComponent();
            this.currentUserID = currentUserID;
            // Fetch and display the expense graph
            DisplayExpenseGraph();
        }
        /// <summary>
        /// Get a list of expense from database
        /// </summary>
        /// <returns></returns>
        private List<Expense> FetchExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            try
            {
                // Replace "your_connection_string_here" with your actual connection string
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

                    string selectQuery = "SELECT ExpenseDate, ExpenseType, Amount FROM Expenses WHERE UserId = @UserId ORDER BY ExpenseDate";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", currentUserID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Expense expense = new Expense
                                {
                                    Date = reader.GetDateTime(0),
                                    ExpenseType = reader.GetString(1),
                                    Amount = (double)reader.GetDecimal(2)
                                };

                                expenses.Add(expense);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log, show a message to the user)
                MessageBox.Show($"Error fetching expenses from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return expenses;
        }
        /// <summary>
        /// Display the Graph series
        /// </summary>
        private void DisplayExpenseGraph()
        {
            List<Expense> expenses = FetchExpenses();

            // Create a LineSeries to represent the graph
            lineModel = new PlotModel
            {
                Title = "Expense Line Chart",
                TitleColor = OxyColor.FromRgb(28, 52, 116),
                PlotAreaBackground = OxyColors.White
            };

            lineModel.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Date" });
            lineModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Amount" });

            var lineSeries = new LineSeries
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

            // Create a PieSeries to represent the pie chart
            pieModel = new PlotModel
            {
                Title = "Expense by type",
                TitleColor = OxyColor.FromRgb(28, 52, 116),
                PlotAreaBackground = OxyColors.White
            };

            var pieSeries = new OxyPlot.Series.PieSeries
            {
                StrokeThickness = 0.0,
                InsideLabelPosition = 0,
                AngleSpan = 360,
                StartAngle = 0,
                Diameter = 1
            };

            pieSeries.TextColor = OxyColors.MidnightBlue;
            pieSeries.InsideLabelColor = OxyColors.Transparent;
            pieSeries.OutsideLabelFormat = "";
            pieSeries.TickHorizontalLength = 0.00;
            pieSeries.TickRadialLength = 0.00;
            pieSeries.FontSize = 14;

            // Group expenses by ExpenseType
            var expensesGroupedByType = expenses.GroupBy(e => e.ExpenseType);
            List<PieSliceData> pieSliceDataList = new List<PieSliceData>();
            // Define a dictionary to map expense types to colors
            Dictionary<string, OxyColor> colorMapping = new Dictionary<string, OxyColor>
            {
                { "Dining", OxyColor.FromRgb(255, 0, 0) },
                { "Entertainment", OxyColor.FromRgb(0, 255, 0) },
                { "Travel", OxyColor.FromRgb(0, 0, 255) },
                { "Utilities", OxyColor.FromRgb(255, 255, 0) },
                { "Health", OxyColor.FromRgb(128, 0, 128) },
                { "Shopping", OxyColor.FromRgb(128, 128, 0) },  

                // Add more mappings as needed
            };


            foreach (var expenseGroup in expensesGroupedByType)
            {
                if (expenseGroup.Key != null)
                {
                    // Sum the amounts for each expense type
                    double totalAmount = expenseGroup.Sum(e => e.Amount);

                    // Round the total amount to a specified number of decimal places (e.g., 2)
                    double roundedTotalAmount = Math.Round(totalAmount, 2);

                    // Check if the expense type exists in the color mapping dictionary
                    if (colorMapping.ContainsKey(expenseGroup.Key))
                    {
                        // Retrieve color from the dictionary based on the expense type
                        OxyColor sliceColor = colorMapping[expenseGroup.Key];

                        // Add data point to the PieSeries
                        pieSeries.Slices.Add(new PieSlice(expenseGroup.Key, roundedTotalAmount)
                        {
                            Fill = sliceColor,
                        });

                    }
                    else
                    {
                        pieSeries.Slices.Add(new PieSlice(expenseGroup.Key, roundedTotalAmount));
                    }
                }
            }

            // Add data points to the LineSeries
            foreach (Expense expense in expenses)
            {
                double roundedAmount = Math.Round(expense.Amount, 2);
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(expense.Date), roundedAmount));
            }

            // Add the LineSeries to the line chart model
            lineModel.Series.Add(lineSeries);

            // Add the PieSeries to the pie chart model
            pieModel.Series.Add(pieSeries);

            // Set the models to the PlotViews
            plotView1.Model = lineModel;
            plotView2.Model = pieModel;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
