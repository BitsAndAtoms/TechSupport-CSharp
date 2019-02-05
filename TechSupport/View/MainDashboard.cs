﻿using System;
using System.Windows.Forms;
using TechSupport.Controller;


namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
       
        private readonly IncidentController incidentController;

        /// <summary>
        /// constructor for searchIncidentDialog class
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        
        /// <summary>
        /// gracefully exits the application in case of cancel from top of GUI
        /// </summary>
        private void exitForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {Application.Exit(); }
        }

        /// <summary>
        /// set user name display in loadIncident Tab
        /// </summary>
        public void setUserNameDisplay(String userName)
        {
            this.loadIncidentUserControl1.setUserNameDisplay(userName);
        }
       
        /// <summary>
        /// remeber to update tabs as the selection is changed between different operations
        ///  such as db manipulation, add, search etc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DashboardTabControl.SelectedTab == DashboardTabControl.TabPages["displayOpenIncidents"])
            {this.displayOpenIncidentsUserControl1.updateListOfIncidents();}
            else if (DashboardTabControl.SelectedTab == DashboardTabControl.TabPages["loadIncident"])
            {this.loadIncidentUserControl1.RefreshDataGrid();}
        }

  
    }
}
