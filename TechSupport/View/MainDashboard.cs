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
using TechSupport.Model;

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
            {
                Application.Exit();
            }
        }

       

        /// <summary>
        /// set user name display in loadIncident Tab
        /// </summary>
        public void setUserNameDisplay(String userName)
        {
            this.loadIncidentUserControl1.setUserNameDisplay(userName);
        }
        private void loadIncidentUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void DashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DashboardTabControl.SelectedTab == DashboardTabControl.TabPages["displayOpenIncidents"])
            {

                this.displayOpenIncidentsUserControl1.updateListOfIncidents();

            }
            else if (DashboardTabControl.SelectedTab == DashboardTabControl.TabPages["loadIncident"])
            {
                this.loadIncidentUserControl1.RefreshDataGrid();
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelIncident_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void displayOpenIncidentsUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
