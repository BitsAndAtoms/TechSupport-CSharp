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
        /// search button to acquire incident record based on customer ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_click(object sender, EventArgs e)
        {
            try
            {
                var customerID = Convert.ToInt32(this.searchCustomerIDField.Value);
                this.RefreshDataGrid(customerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!\n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// populate dataGrid table for search dialog based on customerID
        /// </summary>
        /// <param name="customerID"></param>
        private void RefreshDataGrid(int customerID)
        {
            this.searchDataGridView.DataSource = null;
            this.searchDataGridView.DataSource = this.incidentController.Search(customerID); ;
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
        /// reset search tab value to 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetSearchTabButton_click(object sender, EventArgs e)
        {
            this.searchCustomerIDField.Value = 1;
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
