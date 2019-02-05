using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class displayOpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public displayOpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }


        public void updateListOfIncidents() {
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
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
             
            }
        }



        private void openIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
