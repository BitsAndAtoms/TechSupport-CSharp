using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController;
        // intializes the main form with the username value
        public MainForm(String userName)
        {
            this.InitializeComponent();
            this.loginUsername.Text = userName;
            this.incidentController = new IncidentController();
        }

        // logout page redirects user to main
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.Show();
        }

        // gracefully exits the application in case of cancel from top of GUI
        private void exitForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginUsername_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetCustomerIncidents();
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            Form AddIncidentDialog = new AddIncidentDialog();
            DialogResult result = AddIncidentDialog.ShowDialog();
        }

        private void searchIncidentButton_click(object sender, EventArgs e)
        {
            Form SearchIncidentDialog = new SearchIncidentDialog();
            DialogResult result = SearchIncidentDialog.ShowDialog();
        }
    }
}
