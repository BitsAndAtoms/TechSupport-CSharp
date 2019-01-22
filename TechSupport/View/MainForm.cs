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
    /// <summary>
    /// MainForm class creates the mainForm after login
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// intializes the main form 
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// method to change and set the username upon login
        /// </summary>
        /// <param name="userName">The username that was used to login</param>
        public void setUserNameDisplay(String userName)
        {
            this.loginUsername.Text = userName;
        }


        /// <summary>
        /// logout page redirects user to main
        /// </summary>
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// gracefully exits the application in case of cancel from top of GUI
        /// </summary>
        private void exitForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Upon load of the form populate the data table with current incidents list
        /// </summary>
        /// <param name="sender"> sender is the event object</param>
        /// <param name="e"> e is the even arg</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        /// <summary>
        /// populated the data grid with the list of incidents
        /// </summary>
        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetCustomerIncidents();
        }

        /// <summary>
        /// add incident button's action
        /// </summary>
        /// <param name="sender">sender is the event object</param>
        /// <param name="e"> e is the even arg</param>
        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            Form AddIncidentDialog = new AddIncidentDialog();
            DialogResult result = AddIncidentDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid();
            }

        }

        /// <summary>
        /// search button action
        /// </summary>
        /// <param name="sender">sender is the event object</param>
        /// <param name="e"> e is the even arg</param>
        private void searchIncidentButton_click(object sender, EventArgs e)
        {
            Form SearchIncidentDialog = new SearchIncidentDialog();
            DialogResult result =SearchIncidentDialog.ShowDialog();
        }
    }
}
