using System;
using System.Linq;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class LoadIncidentUserControl : UserControl
    {

        private readonly IncidentController incidentController;

        public LoadIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// set user name display in loadIncident Tab
        /// </summary>
        public void setUserNameDisplay(String userName)
        {
            this.loginUsername.Text = userName;
        }

        /// <summary>
        /// refresh the data grid
        /// </summary>
        public void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetCustomerIncidents().Select(o => new {
                    customerID = o.CustomerID,
                    incidentTitle = o.Title,
                    IncidentDescription = o.Description
                })
               .ToList();
        }
        
        /// <summary>
        /// logout page redirects user to main
        /// </summary>
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
        }

    }
}
