using ExpensesManagerV2.User_Controls;
using System.Configuration;
using System.Windows.Forms;

namespace ExpensesManagerV2
{
    public partial class MainForm : Form
    {

        // User Controls pages
        private HomeUserControl homePageControl;
        private DashboardUserControl dashboardPageControl;
        private GraphicsUserControl graphicsPageControl;
        private SettingsUserControl settingsPageControl;

        // Useful variables
        private int currentUserId;
        string? connectionString = ConfigurationManager.GetConnectionString();

        private Button selectedNavLink;
        private bool isMenuWrapped = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm(int userId)
        {
            InitializeComponent();

            currentUserId = userId;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Attach the common event handler to all navigation buttons
            homeLink.Click += NavigationButton_Click;
            dashboardLink.Click += NavigationButton_Click;
            settingsLink.Click += NavigationButton_Click;
            graphicsLink.MouseClick += NavigationButton_Click;

            // Initialize the selected button to the default button
            selectedNavLink = homeLink;

            // Initialize navbar title
            UpdateNavbarTitle(selectedNavLink.Text.ToString()); // Set the initial title

            homePageControl = new HomeUserControl();
            dashboardPageControl = new DashboardUserControl(userId);
            graphicsPageControl = new GraphicsUserControl(userId);
            settingsPageControl = new SettingsUserControl();

            // Set the default page (e.g., Home) when the form starts
            ShowPage(homePageControl);
        }
        /// <summary>
        /// Show the current user control form regarding the selected button
        /// </summary>
        /// <param name="page"></param>
        private void ShowPage(UserControl page)
        {
            // Clear the main panel and add the selected page
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Handle user's navlink click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                selectedNavLink = button;
                UpdateNavbarTitle(selectedNavLink.Text.ToString());
                int newY = button.Location.Y;
                AnimatePanel(newY);

                // Show/hide pages based on the button clicked
                switch (selectedNavLink.Name)
                {
                    case "homeLink":
                        ShowPage(homePageControl);
                        break;
                    case "dashboardLink":
                        ShowPage(dashboardPageControl);
                        break;
                    case "graphicsLink":
                        ShowPage(graphicsPageControl);
                        break;
                    case "settingsLink":
                        ShowPage(settingsPageControl);
                        break;
                }
            }
        }
        /// <summary>
        /// Update navbar title depends on selected navlink
        /// </summary>
        /// <param name="title"></param>
        private void UpdateNavbarTitle(string title)
        {
            // Update the text of your title panel
            navbarTitle.Text = title;
        }
        /// <summary>
        /// Update slider Y position depends on selected navLink
        /// </summary>
        /// <param name="newY"></param>
        private void AnimatePanel(int newY)
        {
            // You can use more advanced animation techniques if needed
            // Here, we're just directly updating the Y position of the panel
            slidePanel.Location = new System.Drawing.Point(slidePanel.Location.X, newY);
        }
        /// <summary>
        /// handle burger button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void burgerBtn_Click(object sender, EventArgs e)
        {
            isMenuWrapped = !isMenuWrapped;

            if (isMenuWrapped)
            {
                // Slide the menu to the left, leaving only button images
                menuPanel.Width = 100; // Set your desired width

                foreach (Control control in menuPanel.Controls)
                {
                    if (control is Button button)
                    {
                        control.Tag = control.Text;
                        control.Text = string.Empty;
                    }
                }
            }
            else
            {
                // Restore the menu to its original width
                menuPanel.Width = 330; // Set your original width
                foreach (Control control in menuPanel.Controls)
                {
                    if (control is Button button)
                    {
                        control.Text = control.Tag.ToString();
                    }
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}