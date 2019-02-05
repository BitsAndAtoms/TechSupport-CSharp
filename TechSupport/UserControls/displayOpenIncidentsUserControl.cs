using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class displayOpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        /// <summary>
        /// constructor for display openIncidents user control form
        /// </summary>
        public displayOpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// readies list of incidents to display
        /// </summary>
        public void updateListOfIncidents() {
            List<Incident> incidentList = null;
            openIncidents.Items.Clear();
            try
            {
                
                incidentList = this.incidentController.GetCustomerDBIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;

                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        openIncidents.Items.Add(incident.productCode);
                        openIncidents.Items[i].SubItems.Add(incident.dateOpened);
                        openIncidents.Items[i].SubItems.Add(incident.customerName);
                        openIncidents.Items[i].SubItems.Add(incident.technicianName);
                        openIncidents.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("All incidents are resolved");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
             
            }
        }



    }
}
