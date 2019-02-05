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

                List<Incident> incidentList = null;
                openIncidents.Items.Clear();
                try
                {
                    //instead of using the following line of code, which couples the 
                    //DAL with the view, we ask the controller to get the data for us 
                    //so that the view does not have to know where the data comes from
                    //(the line after the commented line)

                    //incidentList = incidentDB.GetincidentsDue();
                    incidentList = this.incidentController.GetCustomerDBIncidents();

                    if (incidentList.Count > 0)
                    {
                        Incident incident;

                        for (int i = 0; i < incidentList.Count; i++)
                        {
                            incident = incidentList[i];
                            openIncidents.Items.Add(incident.CustomerID.ToString());
                            openIncidents.Items[i].SubItems.Add(incident.Description);
                            openIncidents.Items[i].SubItems.Add(incident.technicianName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("All incidents are paid in full.",
                            "No Balance Due");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.Close();
                }

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
    }
}
